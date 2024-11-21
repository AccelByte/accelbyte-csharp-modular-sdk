// Copyright (c) 2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    public abstract class StoreBasedTests : BaseServiceTests
    {
        public StoreBasedTests(bool useUserLogin) : base(useUserLogin) { }

        public void CheckAndClearStores(IAccelByteSdk sdk)
        {
            //Check whether draft store is already exists or not
            List<StoreInfo> stores = sdk.GetPlatformApi().Store.ListStoresOp
                .Execute(sdk.Namespace)
                .EnsureSuccess();
            if (stores.Count > 0)
            {
                foreach (var store in stores)
                {
                    if (store.Published! != true)
                    {
                        //draft store exists. delete it first.
                        sdk.GetPlatformApi().Store.DeleteStoreOp
                            .Execute(sdk.Namespace, store.StoreId!)
                            .EnsureSuccess();
                    }
                    else
                    {
                        //published store exists. delete it too
                        sdk.GetPlatformApi().Store.DeletePublishedStoreOp
                            .Execute(sdk.Namespace)
                            .EnsureSuccess();
                    }
                }
            }
        }
    }
}

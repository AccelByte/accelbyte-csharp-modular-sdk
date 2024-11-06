// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core.Net;
using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class PlatformTests : StoreBasedTests
    {
        public PlatformTests() : base(true) { }

        [Test]
        public void StoreTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            CheckAndClearStores(_Sdk);

            string store_id = String.Empty;

            #region Create a store
            StoreCreate createStore = new StoreCreate()
            {
                Title = "CSharp SDK Store Test",
                Description = "Description for CSharp Extend SDK store service integration test.",
                DefaultLanguage = "en",
                DefaultRegion = "US",
                SupportedLanguages = new List<string>() { "en", "id" },
                SupportedRegions = new List<string>() { "US", "ID" }
            };

            StoreInfo cStore = _Sdk.GetPlatformApi().Store.CreateStoreOp
                .Execute(createStore, _Sdk.Namespace)
                .Ok();
            #endregion
            Assert.AreEqual("CSharp SDK Store Test", cStore.Title);
            store_id = cStore.StoreId!;

            #region Get a store
            StoreInfo gStore = _Sdk.GetPlatformApi().Store.GetStoreOp
                .Execute(_Sdk.Namespace, store_id)
                .Ok();
            #endregion
            Assert.AreEqual("CSharp SDK Store Test", gStore.Title);


            #region Update a store
            StoreUpdate updateStore = new StoreUpdate()
            {
                Description = "Updated description."
            };
            StoreInfo cStoreUpdate = _Sdk.GetPlatformApi().Store.UpdateStoreOp
                .Execute(updateStore, _Sdk.Namespace, store_id)
                .Ok();
            #endregion
            Assert.AreEqual("Updated description.", cStoreUpdate.Description);

            #region Delete a store
            StoreInfo dStore = _Sdk.GetPlatformApi().Store.DeleteStoreOp
                .Execute(_Sdk.Namespace, store_id)
                .Ok();
            #endregion
            Assert.IsNotNull(dStore);
        }

        [Test]
        public void StoreExportImportTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            CheckAndClearStores(_Sdk);

            string store_id = String.Empty;

            StoreCreate createStore = new StoreCreate()
            {
                Title = "CSharp SDK Store Test",
                Description = "Description for CSharp Server SDK store service integration test.",
                DefaultLanguage = "en",
                DefaultRegion = "US",
                SupportedLanguages = new List<string>() { "en", "id" },
                SupportedRegions = new List<string>() { "US", "ID" }
            };

            DisableRetry();
            StoreInfo cStore = _Sdk.GetPlatformApi().Store.CreateStoreOp
                .Execute(createStore, _Sdk.Namespace)
                .Ok();
            Assert.AreEqual("CSharp SDK Store Test", cStore.Title);
            store_id = cStore.StoreId!;

            #region Export a store
            ExportStoreRequest xRequest = new ExportStoreRequest();
            Stream stream = _Sdk.GetPlatformApi().Store.ExportStore1Op
                .SetBody(xRequest)
                .Execute(_Sdk.Namespace, store_id)
                .Ok();
            #endregion
            if (stream == null)
            {
                Assert.Fail("response stream is null.");
                return;
            }

            MemoryUploadStream uploadStream = MemoryUploadStream.FromStream(stream, "temp.zip");

            DisableRetry();
            #region Import store
            ImportStoreResult result = _Sdk.GetPlatformApi().Store.ImportStore1Op
                .SetFile(uploadStream)
                .SetStoreId(store_id)
                .Execute(_Sdk.Namespace)
                .Ok();
            #endregion
            Assert.IsNotNull(result);

            //Delete draft store
            _ = _Sdk.GetPlatformApi().Store.DeleteStoreOp
                .Execute(_Sdk.Namespace, store_id)
                .Ok();
        }
    }
}

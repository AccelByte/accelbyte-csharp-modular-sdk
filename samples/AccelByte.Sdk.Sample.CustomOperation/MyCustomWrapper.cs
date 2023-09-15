// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Sample.CustomOperation
{
    public class MyCustomWrapper
    {
        private readonly IAccelByteSdk _sdk;

        public MyCustomWrapper(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public MyCustomResponseModel? CallMyCustomOperation(MyCustomOperation input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public MyCustomOperation.MyCustomOperationBuilder MyCustomOperationOp
        {
            get { return new MyCustomOperation.MyCustomOperationBuilder(_sdk); }
        }
    }
}

// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// mockFulfillIAPItem
    ///
    ///  [TEST FACILITY ONLY] Forbidden in live environment. Mock fulfill iap item without validate receipt.Other detail info:
    /// 
    ///   * Returns :
    /// </summary>
    public class MockFulfillIAPItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static MockFulfillIAPItemBuilder Builder { get => new MockFulfillIAPItemBuilder(); }

        public class MockFulfillIAPItemBuilder
            : OperationBuilder<MockFulfillIAPItemBuilder>
        {





            internal MockFulfillIAPItemBuilder() { }

            internal MockFulfillIAPItemBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public MockFulfillIAPItem Build(
                MockIAPReceipt body,
                string namespace_,
                string userId
            )
            {
                MockFulfillIAPItem op = new MockFulfillIAPItem(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<MockFulfillIAPItemBuilder>(this);
                return op;
            }

            public void Execute(
                MockIAPReceipt body,
                string namespace_,
                string userId
            )
            {
                MockFulfillIAPItem op = Build(
                    body,
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task ExecuteAsync(
                MockIAPReceipt body,
                string namespace_,
                string userId
            )
            {
                MockFulfillIAPItem op = Build(
                    body,
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private MockFulfillIAPItem(MockFulfillIAPItemBuilder builder,
            MockIAPReceipt body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public MockFulfillIAPItem(
            string namespace_,            
            string userId,            
            Model.MockIAPReceipt body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/iap/mock/receipt";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
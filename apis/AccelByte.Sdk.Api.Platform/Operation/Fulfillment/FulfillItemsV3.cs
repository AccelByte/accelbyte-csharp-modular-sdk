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
    /// fulfillItemsV3
    ///
    /// [Not supported yet in AGS Shared Cloud] Fulfill items by transactionId.
    /// Other detail info:
    ///               * Request body : storeId, region, language, and entitlementCollectionId can be ignored.
    ///               *  Returns : fulfillment v2 result, storeId field can be ignored.
    /// </summary>
    public class FulfillItemsV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static FulfillItemsV3Builder Builder { get => new FulfillItemsV3Builder(); }

        public class FulfillItemsV3Builder
            : OperationBuilder<FulfillItemsV3Builder>
        {





            internal FulfillItemsV3Builder() { }

            internal FulfillItemsV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public FulfillItemsV3 Build(
                FulfillmentV2Request body,
                string namespace_,
                string transactionId,
                string userId
            )
            {
                FulfillItemsV3 op = new FulfillItemsV3(this,
                    body,
                    namespace_,
                    transactionId,
                    userId
                );

                op.SetBaseFields<FulfillItemsV3Builder>(this);
                return op;
            }

            public FulfillItemsV3.Response Execute(
                FulfillmentV2Request body,
                string namespace_,
                string transactionId,
                string userId
            )
            {
                FulfillItemsV3 op = Build(
                    body,
                    namespace_,
                    transactionId,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<FulfillItemsV3.Response> ExecuteAsync(
                FulfillmentV2Request body,
                string namespace_,
                string transactionId,
                string userId
            )
            {
                FulfillItemsV3 op = Build(
                    body,
                    namespace_,
                    transactionId,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private FulfillItemsV3(FulfillItemsV3Builder builder,
            FulfillmentV2Request body,
            string namespace_,
            string transactionId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["transactionId"] = transactionId;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.FulfillmentV2Result>
        {

            public ErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Fulfillment::FulfillItemsV3";
        }

        #endregion

        public FulfillItemsV3(
            string namespace_,
            string transactionId,
            string userId,
            Model.FulfillmentV2Request body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["transactionId"] = transactionId;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/v3/admin/namespaces/{namespace}/users/{userId}/fulfillments/{transactionId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public FulfillItemsV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new FulfillItemsV3.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.FulfillmentV2Result>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }

            return response;
        }
    }

}
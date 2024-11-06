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
    /// preCheckFulfillItem
    ///
    /// Retrieve and check fulfillment items based on the provided request.
    /// Other detail info:
    /// 
    ///   * Returns : list of fulfillment items
    /// </summary>
    public class PreCheckFulfillItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PreCheckFulfillItemBuilder Builder { get => new PreCheckFulfillItemBuilder(); }

        public class PreCheckFulfillItemBuilder
            : OperationBuilder<PreCheckFulfillItemBuilder>
        {





            internal PreCheckFulfillItemBuilder() { }

            internal PreCheckFulfillItemBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PreCheckFulfillItem Build(
                PreCheckFulfillmentRequest body,
                string namespace_,
                string userId
            )
            {
                PreCheckFulfillItem op = new PreCheckFulfillItem(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<PreCheckFulfillItemBuilder>(this);
                return op;
            }

            public PreCheckFulfillItem.Response Execute(
                PreCheckFulfillmentRequest body,
                string namespace_,
                string userId
            )
            {
                PreCheckFulfillItem op = Build(
                    body,
                    namespace_,
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
            public async Task<PreCheckFulfillItem.Response> ExecuteAsync(
                PreCheckFulfillmentRequest body,
                string namespace_,
                string userId
            )
            {
                PreCheckFulfillItem op = Build(
                    body,
                    namespace_,
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

        private PreCheckFulfillItem(PreCheckFulfillItemBuilder builder,
            PreCheckFulfillmentRequest body,
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

        #region Response Part        
        public class Response : ApiResponse<List<Model.FulfillmentItem>>
        {

            public ErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Fulfillment::PreCheckFulfillItem";
        }

        #endregion

        public PreCheckFulfillItem(
            string namespace_,            
            string userId,            
            Model.PreCheckFulfillmentRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/fulfillment/preCheck";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public PreCheckFulfillItem.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PreCheckFulfillItem.Response()
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
                response.Data = JsonSerializer.Deserialize<List<Model.FulfillmentItem>>(payload, ResponseJsonOptions);
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
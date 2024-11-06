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
    /// publicFulfillGoogleIAPItem
    ///
    /// Verify google iap receipt and fulfill item.Other detail info:
    ///   * Returns :
    /// </summary>
    public class PublicFulfillGoogleIAPItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicFulfillGoogleIAPItemBuilder Builder { get => new PublicFulfillGoogleIAPItemBuilder(); }

        public class PublicFulfillGoogleIAPItemBuilder
            : OperationBuilder<PublicFulfillGoogleIAPItemBuilder>
        {





            internal PublicFulfillGoogleIAPItemBuilder() { }

            internal PublicFulfillGoogleIAPItemBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicFulfillGoogleIAPItem Build(
                GoogleIAPReceipt body,
                string namespace_,
                string userId
            )
            {
                PublicFulfillGoogleIAPItem op = new PublicFulfillGoogleIAPItem(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<PublicFulfillGoogleIAPItemBuilder>(this);
                return op;
            }

            public PublicFulfillGoogleIAPItem.Response Execute(
                GoogleIAPReceipt body,
                string namespace_,
                string userId
            )
            {
                PublicFulfillGoogleIAPItem op = Build(
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
            public async Task<PublicFulfillGoogleIAPItem.Response> ExecuteAsync(
                GoogleIAPReceipt body,
                string namespace_,
                string userId
            )
            {
                PublicFulfillGoogleIAPItem op = Build(
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

        private PublicFulfillGoogleIAPItem(PublicFulfillGoogleIAPItemBuilder builder,
            GoogleIAPReceipt body,
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
        public class Response : ApiResponse<Model.GoogleReceiptResolveResult>
        {

            public ErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error404 { get; set; } = null;

            public ErrorEntity? Error409 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::IAP::PublicFulfillGoogleIAPItem";
        }

        #endregion

        public PublicFulfillGoogleIAPItem(
            string namespace_,            
            string userId,            
            Model.GoogleIAPReceipt body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/iap/google/receipt";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicFulfillGoogleIAPItem.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicFulfillGoogleIAPItem.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.GoogleReceiptResolveResult>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }

            return response;
        }
    }

}
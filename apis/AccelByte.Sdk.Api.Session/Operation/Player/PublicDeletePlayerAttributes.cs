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

using AccelByte.Sdk.Api.Session.Model;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// publicDeletePlayerAttributes
    ///
    /// Reset player attributes.
    /// </summary>
    public class PublicDeletePlayerAttributes : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicDeletePlayerAttributesBuilder Builder { get => new PublicDeletePlayerAttributesBuilder(); }

        public class PublicDeletePlayerAttributesBuilder
            : OperationBuilder<PublicDeletePlayerAttributesBuilder>
        {





            internal PublicDeletePlayerAttributesBuilder() { }

            internal PublicDeletePlayerAttributesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicDeletePlayerAttributes Build(
                string namespace_
            )
            {
                PublicDeletePlayerAttributes op = new PublicDeletePlayerAttributes(this,
                    namespace_                    
                );

                op.SetBaseFields<PublicDeletePlayerAttributesBuilder>(this);
                return op;
            }

            public PublicDeletePlayerAttributes.Response Execute(
                string namespace_
            )
            {
                PublicDeletePlayerAttributes op = Build(
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<PublicDeletePlayerAttributes.Response> ExecuteAsync(
                string namespace_
            )
            {
                PublicDeletePlayerAttributes op = Build(
                    namespace_
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

        private PublicDeletePlayerAttributes(PublicDeletePlayerAttributesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Session::Player::PublicDeletePlayerAttributes";
        }

        #endregion

        public PublicDeletePlayerAttributes(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/users/me/attributes";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicDeletePlayerAttributes.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicDeletePlayerAttributes.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)
            
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
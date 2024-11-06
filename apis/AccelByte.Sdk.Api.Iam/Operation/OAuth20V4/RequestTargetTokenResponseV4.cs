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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// RequestTargetTokenResponseV4
    ///
    /// This endpoint is being used to generate target token.
    /// It requires basic header with ClientID and Secret, it should match the ClientID when call `/iam/v3/namespace/{namespace}/token/request`
    /// The code should be generated from `/iam/v3/namespace/{namespace}/token/request`.
    /// </summary>
    public class RequestTargetTokenResponseV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RequestTargetTokenResponseV4Builder Builder { get => new RequestTargetTokenResponseV4Builder(); }

        public class RequestTargetTokenResponseV4Builder
            : OperationBuilder<RequestTargetTokenResponseV4Builder>
        {



            public string? AdditionalData { get; set; }



            internal RequestTargetTokenResponseV4Builder() { }

            internal RequestTargetTokenResponseV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }




            public RequestTargetTokenResponseV4Builder SetAdditionalData(string _additionalData)
            {
                AdditionalData = _additionalData;
                return this;
            }



            public RequestTargetTokenResponseV4 Build(
                string code
            )
            {
                RequestTargetTokenResponseV4 op = new RequestTargetTokenResponseV4(this,
                    code                    
                );

                op.SetBaseFields<RequestTargetTokenResponseV4Builder>(this);
                return op;
            }

            public RequestTargetTokenResponseV4.Response Execute(
                string code
            )
            {
                RequestTargetTokenResponseV4 op = Build(
                    code
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<RequestTargetTokenResponseV4.Response> ExecuteAsync(
                string code
            )
            {
                RequestTargetTokenResponseV4 op = Build(
                    code
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

        private RequestTargetTokenResponseV4(RequestTargetTokenResponseV4Builder builder,
            string code
        )
        {
            
            
            if (builder.AdditionalData is not null) FormParams["additionalData"] = builder.AdditionalData;
            if (code is not null) FormParams["code"] = code;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.OauthmodelTokenResponseV3>
        {


            protected override string GetFullOperationId() => "Iam::OAuth20V4::RequestTargetTokenResponseV4";
        }

        #endregion

        public RequestTargetTokenResponseV4(
            string? additionalData,            
            string code            
        )
        {
            
            
            if (additionalData is not null) FormParams["additionalData"] = additionalData;
            if (code is not null) FormParams["code"] = code;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/oauth/token/exchange";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

        public override List<string> Produces => new() { "application/json" };
        
        public RequestTargetTokenResponseV4.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new RequestTargetTokenResponseV4.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.OauthmodelTokenResponseV3>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}
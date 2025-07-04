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
    /// getRevocationConfig
    ///
    /// Get revocation configuration.
    /// Other detail info:
    /// 
    ///   * Returns : Revocation config
    /// </summary>
    public class GetRevocationConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetRevocationConfigBuilder Builder { get => new GetRevocationConfigBuilder(); }

        public class GetRevocationConfigBuilder
            : OperationBuilder<GetRevocationConfigBuilder>
        {





            internal GetRevocationConfigBuilder() { }

            internal GetRevocationConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetRevocationConfig Build(
                string namespace_
            )
            {
                GetRevocationConfig op = new GetRevocationConfig(this,
                    namespace_                    
                );

                op.SetBaseFields<GetRevocationConfigBuilder>(this);
                return op;
            }

            public GetRevocationConfig.Response Execute(
                string namespace_
            )
            {
                GetRevocationConfig op = Build(
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
            public async Task<GetRevocationConfig.Response> ExecuteAsync(
                string namespace_
            )
            {
                GetRevocationConfig op = Build(
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

        private GetRevocationConfig(GetRevocationConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.RevocationConfigInfo>
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Revocation::GetRevocationConfig";
        }

        #endregion

        public GetRevocationConfig(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/revocation/config";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public GetRevocationConfig.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetRevocationConfig.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.RevocationConfigInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
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
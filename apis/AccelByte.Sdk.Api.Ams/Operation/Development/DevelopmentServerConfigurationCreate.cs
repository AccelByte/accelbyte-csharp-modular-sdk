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

using AccelByte.Sdk.Api.Ams.Model;

namespace AccelByte.Sdk.Api.Ams.Operation
{
    /// <summary>
    /// DevelopmentServerConfigurationCreate
    ///
    /// Configuration name can be up to 128 characters and must conform to ^[.a-zA-Z0-9_-]+$
    /// 
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:ARMADA:FLEET [CREATE]
    /// </summary>
    public class DevelopmentServerConfigurationCreate : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DevelopmentServerConfigurationCreateBuilder Builder { get => new DevelopmentServerConfigurationCreateBuilder(); }

        public class DevelopmentServerConfigurationCreateBuilder
            : OperationBuilder<DevelopmentServerConfigurationCreateBuilder>
        {





            internal DevelopmentServerConfigurationCreateBuilder() { }

            internal DevelopmentServerConfigurationCreateBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DevelopmentServerConfigurationCreate Build(
                ApiDevelopmentServerConfigurationCreateRequest body,
                string namespace_
            )
            {
                DevelopmentServerConfigurationCreate op = new DevelopmentServerConfigurationCreate(this,
                    body,                    
                    namespace_                    
                );

                op.SetBaseFields<DevelopmentServerConfigurationCreateBuilder>(this);
                return op;
            }

            public DevelopmentServerConfigurationCreate.Response Execute(
                ApiDevelopmentServerConfigurationCreateRequest body,
                string namespace_
            )
            {
                DevelopmentServerConfigurationCreate op = Build(
                    body,
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
            public async Task<DevelopmentServerConfigurationCreate.Response> ExecuteAsync(
                ApiDevelopmentServerConfigurationCreateRequest body,
                string namespace_
            )
            {
                DevelopmentServerConfigurationCreate op = Build(
                    body,
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

        private DevelopmentServerConfigurationCreate(DevelopmentServerConfigurationCreateBuilder builder,
            ApiDevelopmentServerConfigurationCreateRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ApiDevelopmentServerConfigurationCreateResponse>
        {

            public ResponseErrorResponse? Error400 { get; set; } = null;

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Ams::Development::DevelopmentServerConfigurationCreate";
        }

        #endregion

        public DevelopmentServerConfigurationCreate(
            string namespace_,            
            Model.ApiDevelopmentServerConfigurationCreateRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/admin/namespaces/{namespace}/development/server-configurations";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public DevelopmentServerConfigurationCreate.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DevelopmentServerConfigurationCreate.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ApiDevelopmentServerConfigurationCreateResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
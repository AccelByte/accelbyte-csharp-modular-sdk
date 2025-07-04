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

using AccelByte.Sdk.Api.Csm.Model;

namespace AccelByte.Sdk.Api.Csm.Operation
{
    /// <summary>
    /// GetAppReleaseV1
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:EXTEND:APP [READ]`
    /// 
    /// Gets the Latest Release Version info of this App
    /// </summary>
    public class GetAppReleaseV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetAppReleaseV1Builder Builder { get => new GetAppReleaseV1Builder(); }

        public class GetAppReleaseV1Builder
            : OperationBuilder<GetAppReleaseV1Builder>
        {





            internal GetAppReleaseV1Builder() { }

            internal GetAppReleaseV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetAppReleaseV1 Build(
                string app,
                string namespace_
            )
            {
                GetAppReleaseV1 op = new GetAppReleaseV1(this,
                    app,                    
                    namespace_                    
                );

                op.SetBaseFields<GetAppReleaseV1Builder>(this);
                return op;
            }

            public GetAppReleaseV1.Response Execute(
                string app,
                string namespace_
            )
            {
                GetAppReleaseV1 op = Build(
                    app,
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
            public async Task<GetAppReleaseV1.Response> ExecuteAsync(
                string app,
                string namespace_
            )
            {
                GetAppReleaseV1 op = Build(
                    app,
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

        private GetAppReleaseV1(GetAppReleaseV1Builder builder,
            string app,
            string namespace_
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.GeneratedGetAppReleaseV1Response>
        {

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error404 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Csm::App::GetAppReleaseV1";
        }

        #endregion

        public GetAppReleaseV1(
            string app,            
            string namespace_            
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/csm/v1/admin/namespaces/{namespace}/apps/{app}/release";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public GetAppReleaseV1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetAppReleaseV1.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.GeneratedGetAppReleaseV1Response>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
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
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
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
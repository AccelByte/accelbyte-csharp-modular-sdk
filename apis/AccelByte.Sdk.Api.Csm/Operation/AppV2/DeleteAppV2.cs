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
    /// DeleteAppV2
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:EXTEND:APP [DELETE]`
    /// 
    /// Delete extend app by given {app} name
    /// 
    /// This endpoint will delete app information, configuration, deployments and all related manifest from
    /// db, storage and cluster
    /// </summary>
    public class DeleteAppV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteAppV2Builder Builder { get => new DeleteAppV2Builder(); }

        public class DeleteAppV2Builder
            : OperationBuilder<DeleteAppV2Builder>
        {

            public string? Forced { get; set; }





            internal DeleteAppV2Builder() { }

            internal DeleteAppV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public DeleteAppV2Builder SetForced(string _forced)
            {
                Forced = _forced;
                return this;
            }





            public DeleteAppV2 Build(
                string app,
                string namespace_
            )
            {
                DeleteAppV2 op = new DeleteAppV2(this,
                    app,                    
                    namespace_                    
                );

                op.SetBaseFields<DeleteAppV2Builder>(this);
                return op;
            }

            public DeleteAppV2.Response Execute(
                string app,
                string namespace_
            )
            {
                DeleteAppV2 op = Build(
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
            public async Task<DeleteAppV2.Response> ExecuteAsync(
                string app,
                string namespace_
            )
            {
                DeleteAppV2 op = Build(
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

        private DeleteAppV2(DeleteAppV2Builder builder,
            string app,
            string namespace_
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;
            
            if (builder.Forced is not null) QueryParams["forced"] = builder.Forced;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ResponseErrorResponse? Error400 { get; set; } = null;

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error404 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Csm::AppV2::DeleteAppV2";
        }

        #endregion

        public DeleteAppV2(
            string app,            
            string namespace_,            
            string? forced            
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;
            
            if (forced is not null) QueryParams["forced"] = forced;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/csm/v2/admin/namespaces/{namespace}/apps/{app}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public DeleteAppV2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DeleteAppV2.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)
            
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
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
    /// GetListOfSecretsV2
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:EXTEND:SECRET [READ]`
    /// 
    /// Get list of environment secrets per app
    /// Available Deployment Status:
    /// `deployed` = app config is already deployed
    /// `undeployed` = app config is not deployed yet and need restart and deploy of the app to be deployed
    /// </summary>
    public class GetListOfSecretsV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetListOfSecretsV2Builder Builder { get => new GetListOfSecretsV2Builder(); }

        public class GetListOfSecretsV2Builder
            : OperationBuilder<GetListOfSecretsV2Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal GetListOfSecretsV2Builder() { }

            internal GetListOfSecretsV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetListOfSecretsV2Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetListOfSecretsV2Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetListOfSecretsV2 Build(
                string app,
                string namespace_
            )
            {
                GetListOfSecretsV2 op = new GetListOfSecretsV2(this,
                    app,                    
                    namespace_                    
                );

                op.SetBaseFields<GetListOfSecretsV2Builder>(this);
                return op;
            }

            public GetListOfSecretsV2.Response Execute(
                string app,
                string namespace_
            )
            {
                GetListOfSecretsV2 op = Build(
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
            public async Task<GetListOfSecretsV2.Response> ExecuteAsync(
                string app,
                string namespace_
            )
            {
                GetListOfSecretsV2 op = Build(
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

        private GetListOfSecretsV2(GetListOfSecretsV2Builder builder,
            string app,
            string namespace_
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ApimodelGetListOfConfigurationsV2Response>
        {

            public ResponseErrorResponse? Error400 { get; set; } = null;

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error404 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Csm::ConfigurationV2::GetListOfSecretsV2";
        }

        #endregion

        public GetListOfSecretsV2(
            string app,            
            string namespace_,            
            long? limit,            
            long? offset            
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/csm/v2/admin/namespaces/{namespace}/apps/{app}/secrets";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public GetListOfSecretsV2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetListOfSecretsV2.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ApimodelGetListOfConfigurationsV2Response>(payload, ResponseJsonOptions);
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
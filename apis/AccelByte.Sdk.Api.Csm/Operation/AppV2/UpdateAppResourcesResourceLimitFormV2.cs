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
    /// UpdateAppResourcesResourceLimitFormV2
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:EXTEND:APP [UPDATE]`
    /// 
    /// Update app resources provided on request body
    /// </summary>
    public class UpdateAppResourcesResourceLimitFormV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateAppResourcesResourceLimitFormV2Builder Builder { get => new UpdateAppResourcesResourceLimitFormV2Builder(); }

        public class UpdateAppResourcesResourceLimitFormV2Builder
            : OperationBuilder<UpdateAppResourcesResourceLimitFormV2Builder>
        {





            internal UpdateAppResourcesResourceLimitFormV2Builder() { }

            internal UpdateAppResourcesResourceLimitFormV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateAppResourcesResourceLimitFormV2 Build(
                ApimodelIncreaseLimitFormRequest body,
                string app,
                string namespace_
            )
            {
                UpdateAppResourcesResourceLimitFormV2 op = new UpdateAppResourcesResourceLimitFormV2(this,
                    body,
                    app,
                    namespace_
                );

                op.SetBaseFields<UpdateAppResourcesResourceLimitFormV2Builder>(this);
                return op;
            }

            public UpdateAppResourcesResourceLimitFormV2.Response Execute(
                ApimodelIncreaseLimitFormRequest body,
                string app,
                string namespace_
            )
            {
                UpdateAppResourcesResourceLimitFormV2 op = Build(
                    body,
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
            public async Task<UpdateAppResourcesResourceLimitFormV2.Response> ExecuteAsync(
                ApimodelIncreaseLimitFormRequest body,
                string app,
                string namespace_
            )
            {
                UpdateAppResourcesResourceLimitFormV2 op = Build(
                    body,
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

        private UpdateAppResourcesResourceLimitFormV2(UpdateAppResourcesResourceLimitFormV2Builder builder,
            ApimodelIncreaseLimitFormRequest body,
            string app,
            string namespace_
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


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


            protected override string GetFullOperationId() => "Csm::AppV2::UpdateAppResourcesResourceLimitFormV2";
        }

        #endregion

        public UpdateAppResourcesResourceLimitFormV2(
            string app,
            string namespace_,
            Model.ApimodelIncreaseLimitFormRequest body
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/csm/v2/admin/namespaces/{namespace}/apps/{app}/resources/form";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public UpdateAppResourcesResourceLimitFormV2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdateAppResourcesResourceLimitFormV2.Response()
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
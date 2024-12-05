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

using AccelByte.Sdk.Api.Dsmc.Model;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// GetServerSessionTimeout
    ///
    /// ```
    /// Required permission: NAMESPACE:{namespace}:DSM:CONFIG [READ]
    /// Required scope: social
    /// 
    /// This endpoint is intended to be called by dedicated server
    /// to get the session timeout that will be used for the DS.
    /// DS will use this session timeout to make sure it regularly make heartbeat
    /// call to the DSMC, before the session timeout.```
    /// </summary>
    public class GetServerSessionTimeout : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetServerSessionTimeoutBuilder Builder { get => new GetServerSessionTimeoutBuilder(); }

        public class GetServerSessionTimeoutBuilder
            : OperationBuilder<GetServerSessionTimeoutBuilder>
        {





            internal GetServerSessionTimeoutBuilder() { }

            internal GetServerSessionTimeoutBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetServerSessionTimeout Build(
                string namespace_,
                string podName
            )
            {
                GetServerSessionTimeout op = new GetServerSessionTimeout(this,
                    namespace_,
                    podName
                );

                op.SetBaseFields<GetServerSessionTimeoutBuilder>(this);
                return op;
            }

            public GetServerSessionTimeout.Response Execute(
                string namespace_,
                string podName
            )
            {
                GetServerSessionTimeout op = Build(
                    namespace_,
                    podName
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<GetServerSessionTimeout.Response> ExecuteAsync(
                string namespace_,
                string podName
            )
            {
                GetServerSessionTimeout op = Build(
                    namespace_,
                    podName
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

        private GetServerSessionTimeout(GetServerSessionTimeoutBuilder builder,
            string namespace_,
            string podName
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["podName"] = podName;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsServerDeploymentConfigSessionTimeoutResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Dsmc::Server::GetServerSessionTimeout";
        }

        #endregion

        public GetServerSessionTimeout(
            string namespace_,
            string podName
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["podName"] = podName;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/namespaces/{namespace}/servers/{podName}/config/sessiontimeout";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public GetServerSessionTimeout.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetServerSessionTimeout.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsServerDeploymentConfigSessionTimeoutResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
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
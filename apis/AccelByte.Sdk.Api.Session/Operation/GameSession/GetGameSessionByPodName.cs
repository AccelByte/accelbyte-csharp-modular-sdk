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
    /// getGameSessionByPodName
    ///
    /// Get game session detail by podname.
    /// Session service has several DSInformation status to track DS request to DS providers:
    /// - NEED_TO_REQUEST: number of active players hasn't reached session's minPlayers therefore DS has not yet requested.
    /// - REQUESTED: DS is being requested to DSMC.
    /// - PREPARING: DS needs to call manual set ready for the game session
    /// - AVAILABLE: DS is ready to use. The DSMC status for this DS is either READY/BUSY.
    /// - FAILED_TO_REQUEST: DSMC fails to spin up a DS for session.
    /// - DS_ERROR: DS provider fails to spin up the DS or the DS itself becomes unreachable
    /// - DS_CANCELLED: when DSMC is preparing the DS, DSMC will give a temporary DS. In this phase, if you delete the game session, the DS request will be canceled.
    /// - ENDED: when a game session (match) has finished and DS has done its job, it will terminate itself.
    /// - UNKNOWN: if any unknown DS status is detected.
    /// DSInformation has 2 fields for DS status: "status" and "statusV2". The "status" is there for backward-compatibility, therefore we encourage to just rely on "statusV2" for the more updated statuses.
    /// DS Source can be DSMC, AMS or custom. In DSMC, a DS request will be put in queue if they dont have available buffers, and DSMC will let the service knows when they finished spinning it up. While AMS doesn't have a concept of queue. Therefore some "DSInformation.statusV2" only applicable for DSMC.
    /// </summary>
    public class GetGameSessionByPodName : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetGameSessionByPodNameBuilder Builder { get => new GetGameSessionByPodNameBuilder(); }

        public class GetGameSessionByPodNameBuilder
            : OperationBuilder<GetGameSessionByPodNameBuilder>
        {





            internal GetGameSessionByPodNameBuilder() { }

            internal GetGameSessionByPodNameBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetGameSessionByPodName Build(
                string namespace_,
                string podName
            )
            {
                GetGameSessionByPodName op = new GetGameSessionByPodName(this,
                    namespace_,
                    podName
                );

                op.SetBaseFields<GetGameSessionByPodNameBuilder>(this);
                return op;
            }

            public GetGameSessionByPodName.Response Execute(
                string namespace_,
                string podName
            )
            {
                GetGameSessionByPodName op = Build(
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
            public async Task<GetGameSessionByPodName.Response> ExecuteAsync(
                string namespace_,
                string podName
            )
            {
                GetGameSessionByPodName op = Build(
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

            public GetGameSessionByPodName.Response<T1, T2> Execute<T1, T2>(
                string namespace_,
                string podName
            )
            {
                GetGameSessionByPodName op = Build(
                    namespace_,
                    podName
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<GetGameSessionByPodName.Response<T1, T2>> ExecuteAsync<T1, T2>(
                string namespace_,
                string podName
            )
            {
                GetGameSessionByPodName op = Build(
                    namespace_,
                    podName
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private GetGameSessionByPodName(GetGameSessionByPodNameBuilder builder,
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
        public class Response : ApiResponse<Model.ApimodelsGameSessionResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Session::GameSession::GetGameSessionByPodName";
        }

        public class Response<T1, T2> : ApiResponse<Model.ApimodelsGameSessionResponse<T1, T2>>
        {
            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Session::GameSession::GetGameSessionByPodName";
        }
        #endregion

        public GetGameSessionByPodName(
            string namespace_,
            string podName
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["podName"] = podName;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/gamesessions/servers/{podName}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public GetGameSessionByPodName.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetGameSessionByPodName.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ApimodelsGameSessionResponse>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
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

        public GetGameSessionByPodName.Response<T1, T2> ParseResponse<T1, T2>(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetGameSessionByPodName.Response<T1, T2>()
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
                response.Data = JsonSerializer.Deserialize<Model.ApimodelsGameSessionResponse<T1, T2>>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
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
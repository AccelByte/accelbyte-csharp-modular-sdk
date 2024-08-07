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

            public Model.ApimodelsGameSessionResponse? Execute(
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
            public async Task<Model.ApimodelsGameSessionResponse?> ExecuteAsync(
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

            public Model.ApimodelsGameSessionResponse<T1, T2>? Execute<T1, T2>(
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
            public async Task<Model.ApimodelsGameSessionResponse<T1, T2>?> ExecuteAsync<T1, T2>(
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

        public Model.ApimodelsGameSessionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsGameSessionResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsGameSessionResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ApimodelsGameSessionResponse<T1, T2>? ParseResponse<T1, T2>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsGameSessionResponse<T1, T2>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsGameSessionResponse<T1, T2>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}
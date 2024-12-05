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

using AccelByte.Sdk.Api.Dslogmanager.Model;

namespace AccelByte.Sdk.Api.Dslogmanager.Operation
{
    /// <summary>
    /// checkServerLogs
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSLM:LOG [READ]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint will check log file existence before download file.
    /// </summary>
    public class CheckServerLogs : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CheckServerLogsBuilder Builder { get => new CheckServerLogsBuilder(); }

        public class CheckServerLogsBuilder
            : OperationBuilder<CheckServerLogsBuilder>
        {





            internal CheckServerLogsBuilder() { }

            internal CheckServerLogsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CheckServerLogs Build(
                string namespace_,
                string podName
            )
            {
                CheckServerLogs op = new CheckServerLogs(this,
                    namespace_,
                    podName
                );

                op.SetBaseFields<CheckServerLogsBuilder>(this);
                return op;
            }

            public CheckServerLogs.Response Execute(
                string namespace_,
                string podName
            )
            {
                CheckServerLogs op = Build(
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
            public async Task<CheckServerLogs.Response> ExecuteAsync(
                string namespace_,
                string podName
            )
            {
                CheckServerLogs op = Build(
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

        private CheckServerLogs(CheckServerLogsBuilder builder,
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
        public class Response : ApiResponse<Model.ModelsLogFileStatus>
        {

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Dslogmanager::TerminatedServers::CheckServerLogs";
        }

        #endregion

        public CheckServerLogs(
            string namespace_,
            string podName
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["podName"] = podName;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dslogmanager/namespaces/{namespace}/servers/{podName}/logs/exists";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json", "text/x-log" };

        public CheckServerLogs.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new CheckServerLogs.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsLogFileStatus>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
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
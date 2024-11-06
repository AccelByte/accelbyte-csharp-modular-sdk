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
    /// batchDownloadServerLogs
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSLM:LOG [READ]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint will download dedicated server's log file (.zip).
    /// </summary>
    public class BatchDownloadServerLogs : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BatchDownloadServerLogsBuilder Builder { get => new BatchDownloadServerLogsBuilder(); }

        public class BatchDownloadServerLogsBuilder
            : OperationBuilder<BatchDownloadServerLogsBuilder>
        {





            internal BatchDownloadServerLogsBuilder() { }

            internal BatchDownloadServerLogsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public BatchDownloadServerLogs Build(
                ModelsBatchDownloadLogsRequest body
            )
            {
                BatchDownloadServerLogs op = new BatchDownloadServerLogs(this,
                    body                    
                );

                op.SetBaseFields<BatchDownloadServerLogsBuilder>(this);
                return op;
            }

            public BatchDownloadServerLogs.Response Execute(
                ModelsBatchDownloadLogsRequest body
            )
            {
                BatchDownloadServerLogs op = Build(
                    body
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<BatchDownloadServerLogs.Response> ExecuteAsync(
                ModelsBatchDownloadLogsRequest body
            )
            {
                BatchDownloadServerLogs op = Build(
                    body
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

        private BatchDownloadServerLogs(BatchDownloadServerLogsBuilder builder,
            ModelsBatchDownloadLogsRequest body
        )
        {
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Stream>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Dslogmanager::AllTerminatedServers::BatchDownloadServerLogs";
        }

        #endregion

        public BatchDownloadServerLogs(
            Model.ModelsBatchDownloadLogsRequest body            
        )
        {
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dslogmanager/servers/logs/download";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public BatchDownloadServerLogs.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new BatchDownloadServerLogs.Response()
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
                response.Data = payload;
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
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
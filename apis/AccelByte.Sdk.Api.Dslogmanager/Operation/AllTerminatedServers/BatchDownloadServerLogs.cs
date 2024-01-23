// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
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

            public Stream? Execute(
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
        }

        private BatchDownloadServerLogs(BatchDownloadServerLogsBuilder builder,
            ModelsBatchDownloadLogsRequest body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
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

        public Stream? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return payload;
            }
            else if (code == (HttpStatusCode)200)
            {
                return payload;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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

using AccelByte.Sdk.Api.Dsartifact.Model;

namespace AccelByte.Sdk.Api.Dsartifact.Operation
{
    /// <summary>
    /// getActiveQueue
    ///
    /// ```
    /// Required permission: ADMIN:DSAM:ARTIFACT:QUEUE [READ]
    /// 
    /// This endpoint is used to get an active queue process on a node
    /// ```
    /// </summary>
    public class GetActiveQueue : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetActiveQueueBuilder Builder { get => new GetActiveQueueBuilder(); }

        public class GetActiveQueueBuilder
            : OperationBuilder<GetActiveQueueBuilder>
        {





            internal GetActiveQueueBuilder() { }

            internal GetActiveQueueBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetActiveQueue Build(
                string nodeIP
            )
            {
                GetActiveQueue op = new GetActiveQueue(this,
                    nodeIP
                );

                op.SetBaseFields<GetActiveQueueBuilder>(this);
                return op;
            }

            public Model.ModelsQueue? Execute(
                string nodeIP
            )
            {
                GetActiveQueue op = Build(
                    nodeIP
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.ModelsQueue?> ExecuteAsync(
                string nodeIP
            )
            {
                GetActiveQueue op = Build(
                    nodeIP
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

        private GetActiveQueue(GetActiveQueueBuilder builder,
            string nodeIP
        )
        {

            if (nodeIP is not null) QueryParams["nodeIP"] = nodeIP;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetActiveQueue(
            string nodeIP
        )
        {

            if (nodeIP is not null) QueryParams["nodeIP"] = nodeIP;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsartifact/artifacts/queues/active";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json", "text/x-log" };

        public Model.ModelsQueue? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsQueue>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsQueue>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
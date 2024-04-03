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
    /// deleteActiveQueue
    ///
    /// ```
    /// Required permission: ADMIN:DSAM:ARTIFACT:QUEUE [DELETE]
    /// 
    /// This endpoint is used to delete active queue process on a node
    /// ```
    /// </summary>
    public class DeleteActiveQueue : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteActiveQueueBuilder Builder { get => new DeleteActiveQueueBuilder(); }

        public class DeleteActiveQueueBuilder
            : OperationBuilder<DeleteActiveQueueBuilder>
        {





            internal DeleteActiveQueueBuilder() { }

            internal DeleteActiveQueueBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteActiveQueue Build(
                string nodeIP
            )
            {
                DeleteActiveQueue op = new DeleteActiveQueue(this,
                    nodeIP
                );

                op.SetBaseFields<DeleteActiveQueueBuilder>(this);
                return op;
            }

            public void Execute(
                string nodeIP
            )
            {
                DeleteActiveQueue op = Build(
                    nodeIP
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task ExecuteAsync(
                string nodeIP
            )
            {
                DeleteActiveQueue op = Build(
                    nodeIP
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private DeleteActiveQueue(DeleteActiveQueueBuilder builder,
            string nodeIP
        )
        {

            if (nodeIP is not null) QueryParams["nodeIP"] = nodeIP;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteActiveQueue(
            string nodeIP
        )
        {

            if (nodeIP is not null) QueryParams["nodeIP"] = nodeIP;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsartifact/artifacts/queues/active";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json", "text/x-log" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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
    /// DeleteCreatingServerCountQueue
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [DELETE]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint deletes the deployment creating server count queue in a namespace in all registered region for the selected version
    /// </summary>
    public class DeleteCreatingServerCountQueue : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteCreatingServerCountQueueBuilder Builder { get => new DeleteCreatingServerCountQueueBuilder(); }

        public class DeleteCreatingServerCountQueueBuilder
            : OperationBuilder<DeleteCreatingServerCountQueueBuilder>
        {





            internal DeleteCreatingServerCountQueueBuilder() { }

            internal DeleteCreatingServerCountQueueBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteCreatingServerCountQueue Build(
                string deployment,
                string namespace_,
                string version
            )
            {
                DeleteCreatingServerCountQueue op = new DeleteCreatingServerCountQueue(this,
                    deployment,
                    namespace_,
                    version
                );

                op.SetBaseFields<DeleteCreatingServerCountQueueBuilder>(this);
                return op;
            }

            public void Execute(
                string deployment,
                string namespace_,
                string version
            )
            {
                DeleteCreatingServerCountQueue op = Build(
                    deployment,
                    namespace_,
                    version
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
                string deployment,
                string namespace_,
                string version
            )
            {
                DeleteCreatingServerCountQueue op = Build(
                    deployment,
                    namespace_,
                    version
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

        private DeleteCreatingServerCountQueue(DeleteCreatingServerCountQueueBuilder builder,
            string deployment,
            string namespace_,
            string version
        )
        {
            PathParams["deployment"] = deployment;
            PathParams["namespace"] = namespace_;
            PathParams["version"] = version;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteCreatingServerCountQueue(
            string deployment,
            string namespace_,
            string version
        )
        {
            PathParams["deployment"] = deployment;
            PathParams["namespace"] = namespace_;
            PathParams["version"] = version;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/versions/{version}/queues";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
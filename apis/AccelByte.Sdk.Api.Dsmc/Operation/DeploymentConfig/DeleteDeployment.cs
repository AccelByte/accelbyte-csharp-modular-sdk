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
    /// DeleteDeployment
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [DELETE]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint delete a dedicated server deployment in a namespace
    /// </summary>
    public class DeleteDeployment : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteDeploymentBuilder Builder { get => new DeleteDeploymentBuilder(); }

        public class DeleteDeploymentBuilder
            : OperationBuilder<DeleteDeploymentBuilder>
        {





            internal DeleteDeploymentBuilder() { }

            internal DeleteDeploymentBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteDeployment Build(
                string deployment,
                string namespace_
            )
            {
                DeleteDeployment op = new DeleteDeployment(this,
                    deployment,
                    namespace_
                );

                op.SetBaseFields<DeleteDeploymentBuilder>(this);
                return op;
            }

            public void Execute(
                string deployment,
                string namespace_
            )
            {
                DeleteDeployment op = Build(
                    deployment,
                    namespace_
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
                string namespace_
            )
            {
                DeleteDeployment op = Build(
                    deployment,
                    namespace_
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

        private DeleteDeployment(DeleteDeploymentBuilder builder,
            string deployment,
            string namespace_
        )
        {
            PathParams["deployment"] = deployment;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteDeployment(
            string deployment,
            string namespace_
        )
        {
            PathParams["deployment"] = deployment;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

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
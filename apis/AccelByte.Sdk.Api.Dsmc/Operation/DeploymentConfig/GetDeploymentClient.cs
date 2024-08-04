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
    /// GetDeploymentClient
    ///
    /// Required permission: NAMESPACE:{namespace}:DSM:CONFIG [READ]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint get a dedicated server deployment in a namespace
    /// </summary>
    public class GetDeploymentClient : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetDeploymentClientBuilder Builder { get => new GetDeploymentClientBuilder(); }

        public class GetDeploymentClientBuilder
            : OperationBuilder<GetDeploymentClientBuilder>
        {





            internal GetDeploymentClientBuilder() { }

            internal GetDeploymentClientBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetDeploymentClient Build(
                string deployment,
                string namespace_
            )
            {
                GetDeploymentClient op = new GetDeploymentClient(this,
                    deployment,
                    namespace_
                );

                op.SetBaseFields<GetDeploymentClientBuilder>(this);
                return op;
            }

            public Model.ModelsDeploymentWithOverride? Execute(
                string deployment,
                string namespace_
            )
            {
                GetDeploymentClient op = Build(
                    deployment,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.ModelsDeploymentWithOverride?> ExecuteAsync(
                string deployment,
                string namespace_
            )
            {
                GetDeploymentClient op = Build(
                    deployment,
                    namespace_
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

        private GetDeploymentClient(GetDeploymentClientBuilder builder,
            string deployment,
            string namespace_
        )
        {
            PathParams["deployment"] = deployment;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetDeploymentClient(
            string deployment,
            string namespace_
        )
        {
            PathParams["deployment"] = deployment;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/namespaces/{namespace}/configs/deployments/{deployment}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsDeploymentWithOverride? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsDeploymentWithOverride>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsDeploymentWithOverride>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
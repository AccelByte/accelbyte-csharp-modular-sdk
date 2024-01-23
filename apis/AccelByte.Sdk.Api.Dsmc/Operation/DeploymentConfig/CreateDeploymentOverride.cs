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

using AccelByte.Sdk.Api.Dsmc.Model;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// CreateDeploymentOverride
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [CREATE]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint create a dedicated servers deployment override in a namespace.
    /// </summary>
    public class CreateDeploymentOverride : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateDeploymentOverrideBuilder Builder { get => new CreateDeploymentOverrideBuilder(); }

        public class CreateDeploymentOverrideBuilder
            : OperationBuilder<CreateDeploymentOverrideBuilder>
        {





            internal CreateDeploymentOverrideBuilder() { }

            internal CreateDeploymentOverrideBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateDeploymentOverride Build(
                ModelsCreateDeploymentOverrideRequest body,
                string deployment,
                string namespace_,
                string version
            )
            {
                CreateDeploymentOverride op = new CreateDeploymentOverride(this,
                    body,
                    deployment,
                    namespace_,
                    version
                );

                op.SetBaseFields<CreateDeploymentOverrideBuilder>(this);
                return op;
            }

            public Model.ModelsDeploymentWithOverride? Execute(
                ModelsCreateDeploymentOverrideRequest body,
                string deployment,
                string namespace_,
                string version
            )
            {
                CreateDeploymentOverride op = Build(
                    body,
                    deployment,
                    namespace_,
                    version
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

        private CreateDeploymentOverride(CreateDeploymentOverrideBuilder builder,
            ModelsCreateDeploymentOverrideRequest body,
            string deployment,
            string namespace_,
            string version
        )
        {
            PathParams["deployment"] = deployment;
            PathParams["namespace"] = namespace_;
            PathParams["version"] = version;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateDeploymentOverride(
            string deployment,
            string namespace_,
            string version,
            Model.ModelsCreateDeploymentOverrideRequest body
        )
        {
            PathParams["deployment"] = deployment;
            PathParams["namespace"] = namespace_;
            PathParams["version"] = version;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/version/{version}";

        public override HttpMethod Method => HttpMethod.Post;

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
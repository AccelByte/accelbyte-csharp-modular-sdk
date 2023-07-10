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
    /// CreateDeployment
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [CREATE]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint create a dedicated servers deployment in a namespace.
    /// </summary>
    public class CreateDeployment : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateDeploymentBuilder Builder { get => new CreateDeploymentBuilder(); }

        public class CreateDeploymentBuilder
            : OperationBuilder<CreateDeploymentBuilder>
        {





            internal CreateDeploymentBuilder() { }

            internal CreateDeploymentBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateDeployment Build(
                ModelsCreateDeploymentRequest body,
                string deployment,
                string namespace_
            )
            {
                CreateDeployment op = new CreateDeployment(this,
                    body,
                    deployment,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsDeploymentWithOverride? Execute(
                ModelsCreateDeploymentRequest body,
                string deployment,
                string namespace_
            )
            {
                CreateDeployment op = Build(
                    body,
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
        }

        private CreateDeployment(CreateDeploymentBuilder builder,
            ModelsCreateDeploymentRequest body,
            string deployment,
            string namespace_
        )
        {
            PathParams["deployment"] = deployment;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateDeployment(
            string deployment,
            string namespace_,
            Model.ModelsCreateDeploymentRequest body
        )
        {
            PathParams["deployment"] = deployment;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}";

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
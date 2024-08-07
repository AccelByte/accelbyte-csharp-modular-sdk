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
    /// CreatePodConfigClient
    ///
    /// Required permission: NAMESPACE:{namespace}:DSM:CONFIG [CREATE]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint create a dedicated servers pod config in a namespace.
    /// </summary>
    public class CreatePodConfigClient : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreatePodConfigClientBuilder Builder { get => new CreatePodConfigClientBuilder(); }

        public class CreatePodConfigClientBuilder
            : OperationBuilder<CreatePodConfigClientBuilder>
        {





            internal CreatePodConfigClientBuilder() { }

            internal CreatePodConfigClientBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreatePodConfigClient Build(
                ModelsCreatePodConfigRequest body,
                string name,
                string namespace_
            )
            {
                CreatePodConfigClient op = new CreatePodConfigClient(this,
                    body,
                    name,
                    namespace_
                );

                op.SetBaseFields<CreatePodConfigClientBuilder>(this);
                return op;
            }

            public Model.ModelsPodConfigRecord? Execute(
                ModelsCreatePodConfigRequest body,
                string name,
                string namespace_
            )
            {
                CreatePodConfigClient op = Build(
                    body,
                    name,
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
            public async Task<Model.ModelsPodConfigRecord?> ExecuteAsync(
                ModelsCreatePodConfigRequest body,
                string name,
                string namespace_
            )
            {
                CreatePodConfigClient op = Build(
                    body,
                    name,
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

        private CreatePodConfigClient(CreatePodConfigClientBuilder builder,
            ModelsCreatePodConfigRequest body,
            string name,
            string namespace_
        )
        {
            PathParams["name"] = name;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreatePodConfigClient(
            string name,
            string namespace_,
            Model.ModelsCreatePodConfigRequest body
        )
        {
            PathParams["name"] = name;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/namespaces/{namespace}/configs/pods/{name}";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsPodConfigRecord? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPodConfigRecord>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPodConfigRecord>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
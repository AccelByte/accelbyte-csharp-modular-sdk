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
    /// UpdatePodConfig
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [UPDATE]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint update a dedicated servers pod config in a namespace.
    /// </summary>
    public class UpdatePodConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdatePodConfigBuilder Builder { get => new UpdatePodConfigBuilder(); }

        public class UpdatePodConfigBuilder
            : OperationBuilder<UpdatePodConfigBuilder>
        {





            internal UpdatePodConfigBuilder() { }

            internal UpdatePodConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdatePodConfig Build(
                ModelsUpdatePodConfigRequest body,
                string name,
                string namespace_
            )
            {
                UpdatePodConfig op = new UpdatePodConfig(this,
                    body,
                    name,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsPodConfigRecord? Execute(
                ModelsUpdatePodConfigRequest body,
                string name,
                string namespace_
            )
            {
                UpdatePodConfig op = Build(
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
        }

        private UpdatePodConfig(UpdatePodConfigBuilder builder,
            ModelsUpdatePodConfigRequest body,
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

        public UpdatePodConfig(
            string name,
            string namespace_,
            Model.ModelsUpdatePodConfigRequest body
        )
        {
            PathParams["name"] = name;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/configs/pods/{name}";

        public override HttpMethod Method => HttpMethod.Patch;

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
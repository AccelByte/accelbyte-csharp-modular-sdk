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
    /// AddPort
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [CREATE]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint create a dedicated servers port config in a namespace.
    /// </summary>
    public class AddPort : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AddPortBuilder Builder { get => new AddPortBuilder(); }

        public class AddPortBuilder
            : OperationBuilder<AddPortBuilder>
        {





            internal AddPortBuilder() { }

            internal AddPortBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AddPort Build(
                ModelsCreatePortRequest body,
                string name,
                string namespace_
            )
            {
                AddPort op = new AddPort(this,
                    body,
                    name,
                    namespace_
                );

                op.SetBaseFields<AddPortBuilder>(this);
                return op;
            }

            public Model.ModelsDSMConfigRecord? Execute(
                ModelsCreatePortRequest body,
                string name,
                string namespace_
            )
            {
                AddPort op = Build(
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

        private AddPort(AddPortBuilder builder,
            ModelsCreatePortRequest body,
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

        public AddPort(
            string name,
            string namespace_,
            Model.ModelsCreatePortRequest body
        )
        {
            PathParams["name"] = name;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/configs/ports/{name}";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsDSMConfigRecord? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsDSMConfigRecord>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsDSMConfigRecord>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
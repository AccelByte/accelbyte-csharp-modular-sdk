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

using AccelByte.Sdk.Api.Lobby.Model;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// adminCreateThirdPartyConfig
    ///
    /// Create third party config in a namespace.
    /// </summary>
    public class AdminCreateThirdPartyConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCreateThirdPartyConfigBuilder Builder { get => new AdminCreateThirdPartyConfigBuilder(); }

        public class AdminCreateThirdPartyConfigBuilder
            : OperationBuilder<AdminCreateThirdPartyConfigBuilder>
        {





            internal AdminCreateThirdPartyConfigBuilder() { }

            internal AdminCreateThirdPartyConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminCreateThirdPartyConfig Build(
                ModelsCreateConfigRequest body,
                string namespace_
            )
            {
                AdminCreateThirdPartyConfig op = new AdminCreateThirdPartyConfig(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<AdminCreateThirdPartyConfigBuilder>(this);
                return op;
            }

            public Model.ModelsCreateConfigResponse? Execute(
                ModelsCreateConfigRequest body,
                string namespace_
            )
            {
                AdminCreateThirdPartyConfig op = Build(
                    body,
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
            public async Task<Model.ModelsCreateConfigResponse?> ExecuteAsync(
                ModelsCreateConfigRequest body,
                string namespace_
            )
            {
                AdminCreateThirdPartyConfig op = Build(
                    body,
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

        private AdminCreateThirdPartyConfig(AdminCreateThirdPartyConfigBuilder builder,
            ModelsCreateConfigRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminCreateThirdPartyConfig(
            string namespace_,
            Model.ModelsCreateConfigRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/thirdparty/namespaces/{namespace}/config/steam";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsCreateConfigResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateConfigResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateConfigResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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
    /// adminGetConfigV1
    ///
    /// Get lobby config of a namespace.
    /// default MaxDSWaitTime is 120 (second)
    /// </summary>
    public class AdminGetConfigV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetConfigV1Builder Builder { get => new AdminGetConfigV1Builder(); }

        public class AdminGetConfigV1Builder
            : OperationBuilder<AdminGetConfigV1Builder>
        {





            internal AdminGetConfigV1Builder() { }

            internal AdminGetConfigV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetConfigV1 Build(
                string namespace_
            )
            {
                AdminGetConfigV1 op = new AdminGetConfigV1(this,
                    namespace_
                );

                op.SetBaseFields<AdminGetConfigV1Builder>(this);
                return op;
            }

            public Model.ModelsConfigReq? Execute(
                string namespace_
            )
            {
                AdminGetConfigV1 op = Build(
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
            public async Task<Model.ModelsConfigReq?> ExecuteAsync(
                string namespace_
            )
            {
                AdminGetConfigV1 op = Build(
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

        private AdminGetConfigV1(AdminGetConfigV1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetConfigV1(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/config/namespaces/{namespace}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsConfigReq? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsConfigReq>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsConfigReq>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
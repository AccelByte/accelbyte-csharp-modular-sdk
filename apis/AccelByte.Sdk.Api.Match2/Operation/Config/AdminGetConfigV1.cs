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

using AccelByte.Sdk.Api.Match2.Model;

namespace AccelByte.Sdk.Api.Match2.Operation
{
    /// <summary>
    /// adminGetConfigV1
    ///
    /// Get matchmaking config of a namespaces.
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

            public Model.ConfigmodelsNamespaceConfig? Execute(
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

        public override string Path => "/match2/v1/config/namespaces/{namespace}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ConfigmodelsNamespaceConfig? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ConfigmodelsNamespaceConfig>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ConfigmodelsNamespaceConfig>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
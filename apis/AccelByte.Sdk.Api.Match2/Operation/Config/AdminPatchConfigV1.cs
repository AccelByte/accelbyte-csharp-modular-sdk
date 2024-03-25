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
    /// adminPatchConfigV1
    ///
    /// Patch update matchmaking config of a namespaces. Partially update matchmaking config, will only update value that defined on the request.
    /// </summary>
    public class AdminPatchConfigV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminPatchConfigV1Builder Builder { get => new AdminPatchConfigV1Builder(); }

        public class AdminPatchConfigV1Builder
            : OperationBuilder<AdminPatchConfigV1Builder>
        {





            internal AdminPatchConfigV1Builder() { }

            internal AdminPatchConfigV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminPatchConfigV1 Build(
                ApiPatchNamespaceConfigRequest body,
                string namespace_
            )
            {
                AdminPatchConfigV1 op = new AdminPatchConfigV1(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<AdminPatchConfigV1Builder>(this);
                return op;
            }

            public Model.ConfigmodelsNamespaceConfig? Execute(
                ApiPatchNamespaceConfigRequest body,
                string namespace_
            )
            {
                AdminPatchConfigV1 op = Build(
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
        }

        private AdminPatchConfigV1(AdminPatchConfigV1Builder builder,
            ApiPatchNamespaceConfigRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminPatchConfigV1(
            string namespace_,
            Model.ApiPatchNamespaceConfigRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/config/namespaces/{namespace}";

        public override HttpMethod Method => HttpMethod.Patch;

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
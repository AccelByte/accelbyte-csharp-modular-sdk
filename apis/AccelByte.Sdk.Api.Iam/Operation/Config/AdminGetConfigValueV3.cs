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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminGetConfigValueV3
    ///
    /// This endpoint return the value of config key. The namespace should be publisher namespace or studio namespace.
    /// 
    /// **Supported config key:**
    /// * uniqueDisplayNameEnabled
    /// * usernameDisabled
    /// * mandatoryEmailVerificationEnabled
    /// </summary>
    public class AdminGetConfigValueV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetConfigValueV3Builder Builder { get => new AdminGetConfigValueV3Builder(); }

        public class AdminGetConfigValueV3Builder
            : OperationBuilder<AdminGetConfigValueV3Builder>
        {





            internal AdminGetConfigValueV3Builder() { }

            internal AdminGetConfigValueV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetConfigValueV3 Build(
                string configKey,
                string namespace_
            )
            {
                AdminGetConfigValueV3 op = new AdminGetConfigValueV3(this,
                    configKey,
                    namespace_
                );

                op.SetBaseFields<AdminGetConfigValueV3Builder>(this);
                return op;
            }

            public Model.ModelConfigValueResponseV3? Execute(
                string configKey,
                string namespace_
            )
            {
                AdminGetConfigValueV3 op = Build(
                    configKey,
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
            public async Task<Model.ModelConfigValueResponseV3?> ExecuteAsync(
                string configKey,
                string namespace_
            )
            {
                AdminGetConfigValueV3 op = Build(
                    configKey,
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

            public Model.ModelConfigValueResponseV3<T1>? Execute<T1>(
                string configKey,
                string namespace_
            )
            {
                AdminGetConfigValueV3 op = Build(
                    configKey,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.ModelConfigValueResponseV3<T1>?> ExecuteAsync<T1>(
                string configKey,
                string namespace_
            )
            {
                AdminGetConfigValueV3 op = Build(
                    configKey,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private AdminGetConfigValueV3(AdminGetConfigValueV3Builder builder,
            string configKey,
            string namespace_
        )
        {
            PathParams["configKey"] = configKey;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetConfigValueV3(
            string configKey,
            string namespace_
        )
        {
            PathParams["configKey"] = configKey;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/config/{configKey}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelConfigValueResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelConfigValueResponseV3>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelConfigValueResponseV3>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ModelConfigValueResponseV3<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelConfigValueResponseV3<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelConfigValueResponseV3<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}
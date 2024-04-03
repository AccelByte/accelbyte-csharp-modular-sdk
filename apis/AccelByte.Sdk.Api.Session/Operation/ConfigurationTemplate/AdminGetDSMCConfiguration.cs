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

using AccelByte.Sdk.Api.Session.Model;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// adminGetDSMCConfiguration
    ///
    /// Get a dsmc configuration.
    /// </summary>
    public class AdminGetDSMCConfiguration : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetDSMCConfigurationBuilder Builder { get => new AdminGetDSMCConfigurationBuilder(); }

        public class AdminGetDSMCConfigurationBuilder
            : OperationBuilder<AdminGetDSMCConfigurationBuilder>
        {





            internal AdminGetDSMCConfigurationBuilder() { }

            internal AdminGetDSMCConfigurationBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetDSMCConfiguration Build(
                string namespace_
            )
            {
                AdminGetDSMCConfiguration op = new AdminGetDSMCConfiguration(this,
                    namespace_
                );

                op.SetBaseFields<AdminGetDSMCConfigurationBuilder>(this);
                return op;
            }

            public Model.ModelsDSMConfigRecord? Execute(
                string namespace_
            )
            {
                AdminGetDSMCConfiguration op = Build(
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
            public async Task<Model.ModelsDSMConfigRecord?> ExecuteAsync(
                string namespace_
            )
            {
                AdminGetDSMCConfiguration op = Build(
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

        private AdminGetDSMCConfiguration(AdminGetDSMCConfigurationBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetDSMCConfiguration(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/namespaces/{namespace}/dsconfigs";

        public override HttpMethod Method => HttpMethod.Get;

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
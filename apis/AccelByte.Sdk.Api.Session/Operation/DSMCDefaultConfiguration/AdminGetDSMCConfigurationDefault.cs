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

using AccelByte.Sdk.Api.Session.Model;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// adminGetDSMCConfigurationDefault
    ///
    /// Get dsmc default configuration.
    /// </summary>
    public class AdminGetDSMCConfigurationDefault : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetDSMCConfigurationDefaultBuilder Builder { get => new AdminGetDSMCConfigurationDefaultBuilder(); }

        public class AdminGetDSMCConfigurationDefaultBuilder
            : OperationBuilder<AdminGetDSMCConfigurationDefaultBuilder>
        {





            internal AdminGetDSMCConfigurationDefaultBuilder() { }

            internal AdminGetDSMCConfigurationDefaultBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetDSMCConfigurationDefault Build(
            )
            {
                AdminGetDSMCConfigurationDefault op = new AdminGetDSMCConfigurationDefault(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsDefaultDSMCConfig? Execute(
            )
            {
                AdminGetDSMCConfigurationDefault op = Build(
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

        private AdminGetDSMCConfigurationDefault(AdminGetDSMCConfigurationDefaultBuilder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetDSMCConfigurationDefault(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/dsconfigs/default";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsDefaultDSMCConfig? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsDefaultDSMCConfig>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsDefaultDSMCConfig>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
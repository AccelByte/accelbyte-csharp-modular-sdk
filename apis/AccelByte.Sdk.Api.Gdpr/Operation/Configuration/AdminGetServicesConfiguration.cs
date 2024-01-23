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

using AccelByte.Sdk.Api.Gdpr.Model;

namespace AccelByte.Sdk.Api.Gdpr.Operation
{
    /// <summary>
    /// AdminGetServicesConfiguration
    ///
    /// Get Registered Services Configuration.
    /// 
    /// 
    /// Required permission `ADMIN:NAMESPACE:{namespace}:GDPR:CONFIGURATION [READ]` and scope `account`
    /// </summary>
    public class AdminGetServicesConfiguration : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetServicesConfigurationBuilder Builder { get => new AdminGetServicesConfigurationBuilder(); }

        public class AdminGetServicesConfigurationBuilder
            : OperationBuilder<AdminGetServicesConfigurationBuilder>
        {





            internal AdminGetServicesConfigurationBuilder() { }

            internal AdminGetServicesConfigurationBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetServicesConfiguration Build(
                string namespace_
            )
            {
                AdminGetServicesConfiguration op = new AdminGetServicesConfiguration(this,
                    namespace_
                );

                op.SetBaseFields<AdminGetServicesConfigurationBuilder>(this);
                return op;
            }

            public Model.DtoServicesConfigurationResponse? Execute(
                string namespace_
            )
            {
                AdminGetServicesConfiguration op = Build(
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

        private AdminGetServicesConfiguration(AdminGetServicesConfigurationBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetServicesConfiguration(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/admin/namespaces/{namespace}/services/configurations";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.DtoServicesConfigurationResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.DtoServicesConfigurationResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.DtoServicesConfigurationResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
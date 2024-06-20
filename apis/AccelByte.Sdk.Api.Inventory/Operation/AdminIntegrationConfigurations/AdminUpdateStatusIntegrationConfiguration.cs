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

using AccelByte.Sdk.Api.Inventory.Model;

namespace AccelByte.Sdk.Api.Inventory.Operation
{
    /// <summary>
    /// AdminUpdateStatusIntegrationConfiguration
    ///
    /// 
    /// to update status integration configuration to be Active / Not Active.
    /// There cannot be duplicate serviceName per namespace.
    /// 
    /// Permission: ADMIN:NAMESPACE:{namespace}:INVENTORY:INTEGRATIONCONFIGURATION [UPDATE]
    /// </summary>
    public class AdminUpdateStatusIntegrationConfiguration : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateStatusIntegrationConfigurationBuilder Builder { get => new AdminUpdateStatusIntegrationConfigurationBuilder(); }

        public class AdminUpdateStatusIntegrationConfigurationBuilder
            : OperationBuilder<AdminUpdateStatusIntegrationConfigurationBuilder>
        {





            internal AdminUpdateStatusIntegrationConfigurationBuilder() { }

            internal AdminUpdateStatusIntegrationConfigurationBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpdateStatusIntegrationConfiguration Build(
                ApimodelsUpdateStatusIntegrationConfigurationReq body,
                string integrationConfigurationId,
                string namespace_
            )
            {
                AdminUpdateStatusIntegrationConfiguration op = new AdminUpdateStatusIntegrationConfiguration(this,
                    body,
                    integrationConfigurationId,
                    namespace_
                );

                op.SetBaseFields<AdminUpdateStatusIntegrationConfigurationBuilder>(this);
                return op;
            }

            public Model.ApimodelsIntegrationConfigurationResp? Execute(
                ApimodelsUpdateStatusIntegrationConfigurationReq body,
                string integrationConfigurationId,
                string namespace_
            )
            {
                AdminUpdateStatusIntegrationConfiguration op = Build(
                    body,
                    integrationConfigurationId,
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
            public async Task<Model.ApimodelsIntegrationConfigurationResp?> ExecuteAsync(
                ApimodelsUpdateStatusIntegrationConfigurationReq body,
                string integrationConfigurationId,
                string namespace_
            )
            {
                AdminUpdateStatusIntegrationConfiguration op = Build(
                    body,
                    integrationConfigurationId,
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

        private AdminUpdateStatusIntegrationConfiguration(AdminUpdateStatusIntegrationConfigurationBuilder builder,
            ApimodelsUpdateStatusIntegrationConfigurationReq body,
            string integrationConfigurationId,
            string namespace_
        )
        {
            PathParams["integrationConfigurationId"] = integrationConfigurationId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateStatusIntegrationConfiguration(
            string integrationConfigurationId,
            string namespace_,
            Model.ApimodelsUpdateStatusIntegrationConfigurationReq body
        )
        {
            PathParams["integrationConfigurationId"] = integrationConfigurationId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/integrationConfigurations/{integrationConfigurationId}/status";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApimodelsIntegrationConfigurationResp? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsIntegrationConfigurationResp>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsIntegrationConfigurationResp>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
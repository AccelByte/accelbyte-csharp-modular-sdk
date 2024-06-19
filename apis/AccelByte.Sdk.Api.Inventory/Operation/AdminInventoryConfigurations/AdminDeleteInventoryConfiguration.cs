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
    /// AdminDeleteInventoryConfiguration
    ///
    /// 
    /// Deleting an inventory configuration.
    /// If an inventory already reference this type (i.e. STATUS is "TIED"), then the type cannot be deleted anymore.
    /// 
    /// ADMIN:NAMESPACE:{namespace}:INVENTORY:CONFIGURATION [DELETE]
    /// </summary>
    public class AdminDeleteInventoryConfiguration : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteInventoryConfigurationBuilder Builder { get => new AdminDeleteInventoryConfigurationBuilder(); }

        public class AdminDeleteInventoryConfigurationBuilder
            : OperationBuilder<AdminDeleteInventoryConfigurationBuilder>
        {





            internal AdminDeleteInventoryConfigurationBuilder() { }

            internal AdminDeleteInventoryConfigurationBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeleteInventoryConfiguration Build(
                string inventoryConfigurationId,
                string namespace_
            )
            {
                AdminDeleteInventoryConfiguration op = new AdminDeleteInventoryConfiguration(this,
                    inventoryConfigurationId,
                    namespace_
                );

                op.SetBaseFields<AdminDeleteInventoryConfigurationBuilder>(this);
                return op;
            }

            public void Execute(
                string inventoryConfigurationId,
                string namespace_
            )
            {
                AdminDeleteInventoryConfiguration op = Build(
                    inventoryConfigurationId,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task ExecuteAsync(
                string inventoryConfigurationId,
                string namespace_
            )
            {
                AdminDeleteInventoryConfiguration op = Build(
                    inventoryConfigurationId,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private AdminDeleteInventoryConfiguration(AdminDeleteInventoryConfigurationBuilder builder,
            string inventoryConfigurationId,
            string namespace_
        )
        {
            PathParams["inventoryConfigurationId"] = inventoryConfigurationId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteInventoryConfiguration(
            string inventoryConfigurationId,
            string namespace_
        )
        {
            PathParams["inventoryConfigurationId"] = inventoryConfigurationId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/inventoryConfigurations/{inventoryConfigurationId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
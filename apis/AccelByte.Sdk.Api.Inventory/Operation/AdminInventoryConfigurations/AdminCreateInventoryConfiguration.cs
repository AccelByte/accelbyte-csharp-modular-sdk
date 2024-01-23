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

using AccelByte.Sdk.Api.Inventory.Model;

namespace AccelByte.Sdk.Api.Inventory.Operation
{
    /// <summary>
    /// AdminCreateInventoryConfiguration
    ///
    /// 
    /// Creating inventory configuration.
    /// There cannot be one inventory configuration duplicate code per namespace.
    /// 
    /// Permission: ADMIN:NAMESPACE:{namespace}:INVENTORY:CONFIGURATION [CREATE]
    /// </summary>
    public class AdminCreateInventoryConfiguration : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCreateInventoryConfigurationBuilder Builder { get => new AdminCreateInventoryConfigurationBuilder(); }

        public class AdminCreateInventoryConfigurationBuilder
            : OperationBuilder<AdminCreateInventoryConfigurationBuilder>
        {





            internal AdminCreateInventoryConfigurationBuilder() { }

            internal AdminCreateInventoryConfigurationBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminCreateInventoryConfiguration Build(
                ApimodelsCreateInventoryConfigurationReq body,
                string namespace_
            )
            {
                AdminCreateInventoryConfiguration op = new AdminCreateInventoryConfiguration(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<AdminCreateInventoryConfigurationBuilder>(this);
                return op;
            }

            public Model.ApimodelsInventoryConfigurationResp? Execute(
                ApimodelsCreateInventoryConfigurationReq body,
                string namespace_
            )
            {
                AdminCreateInventoryConfiguration op = Build(
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

        private AdminCreateInventoryConfiguration(AdminCreateInventoryConfigurationBuilder builder,
            ApimodelsCreateInventoryConfigurationReq body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminCreateInventoryConfiguration(
            string namespace_,
            Model.ApimodelsCreateInventoryConfigurationReq body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/inventoryConfigurations";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApimodelsInventoryConfigurationResp? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsInventoryConfigurationResp>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsInventoryConfigurationResp>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
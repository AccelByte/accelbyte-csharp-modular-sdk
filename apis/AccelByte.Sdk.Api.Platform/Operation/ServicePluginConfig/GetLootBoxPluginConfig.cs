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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// getLootBoxPluginConfig
    ///
    /// Get lootbox plugin config.
    /// Other detail info:
    /// 
    ///   * Required permission : resource= ADMIN:NAMESPACE:{namespace}:PLUGIN:CATALOG , action=2 (READ)
    /// </summary>
    public class GetLootBoxPluginConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetLootBoxPluginConfigBuilder Builder { get => new GetLootBoxPluginConfigBuilder(); }

        public class GetLootBoxPluginConfigBuilder
            : OperationBuilder<GetLootBoxPluginConfigBuilder>
        {





            internal GetLootBoxPluginConfigBuilder() { }

            internal GetLootBoxPluginConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetLootBoxPluginConfig Build(
                string namespace_
            )
            {
                GetLootBoxPluginConfig op = new GetLootBoxPluginConfig(this,
                    namespace_
                );

                op.SetBaseFields<GetLootBoxPluginConfigBuilder>(this);
                return op;
            }

            public Model.LootBoxPluginConfigInfo? Execute(
                string namespace_
            )
            {
                GetLootBoxPluginConfig op = Build(
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

        private GetLootBoxPluginConfig(GetLootBoxPluginConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetLootBoxPluginConfig(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/catalog/plugins/lootbox";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { };

        public Model.LootBoxPluginConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.LootBoxPluginConfigInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.LootBoxPluginConfigInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
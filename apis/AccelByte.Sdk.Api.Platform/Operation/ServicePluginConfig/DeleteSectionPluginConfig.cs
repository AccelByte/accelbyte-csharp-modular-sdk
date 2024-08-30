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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// deleteSectionPluginConfig
    ///
    /// Delete section plugin config.
    /// </summary>
    public class DeleteSectionPluginConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteSectionPluginConfigBuilder Builder { get => new DeleteSectionPluginConfigBuilder(); }

        public class DeleteSectionPluginConfigBuilder
            : OperationBuilder<DeleteSectionPluginConfigBuilder>
        {





            internal DeleteSectionPluginConfigBuilder() { }

            internal DeleteSectionPluginConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteSectionPluginConfig Build(
                string namespace_
            )
            {
                DeleteSectionPluginConfig op = new DeleteSectionPluginConfig(this,
                    namespace_
                );

                op.SetBaseFields<DeleteSectionPluginConfigBuilder>(this);
                return op;
            }

            public void Execute(
                string namespace_
            )
            {
                DeleteSectionPluginConfig op = Build(
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
                string namespace_
            )
            {
                DeleteSectionPluginConfig op = Build(
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

        private DeleteSectionPluginConfig(DeleteSectionPluginConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteSectionPluginConfig(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/catalog/plugins/section";

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
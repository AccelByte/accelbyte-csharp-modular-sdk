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
    /// updateRevocationPluginConfig
    ///
    /// Update revocation plugin config. Other detail info:
    ///   * Required permission : resource=ADMIN:NAMESPACE:{namespace}:PLUGIN:REVOCATION, action=4 (UPDATE)
    ///   *  Returns : updated service plugin config
    /// </summary>
    public class UpdateRevocationPluginConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateRevocationPluginConfigBuilder Builder { get => new UpdateRevocationPluginConfigBuilder(); }

        public class UpdateRevocationPluginConfigBuilder
            : OperationBuilder<UpdateRevocationPluginConfigBuilder>
        {


            public Model.RevocationPluginConfigUpdate? Body { get; set; }




            internal UpdateRevocationPluginConfigBuilder() { }

            internal UpdateRevocationPluginConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdateRevocationPluginConfigBuilder SetBody(Model.RevocationPluginConfigUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdateRevocationPluginConfig Build(
                string namespace_
            )
            {
                UpdateRevocationPluginConfig op = new UpdateRevocationPluginConfig(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.RevocationPluginConfigInfo? Execute(
                string namespace_
            )
            {
                UpdateRevocationPluginConfig op = Build(
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

        private UpdateRevocationPluginConfig(UpdateRevocationPluginConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateRevocationPluginConfig(
            string namespace_,
            Model.RevocationPluginConfigUpdate body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/revocation/plugins/revocation";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.RevocationPluginConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.RevocationPluginConfigInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RevocationPluginConfigInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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
    /// updateSectionPluginConfig
    ///
    /// Update section config. Other detail info:
    ///   * Required permission : resource=ADMIN:NAMESPACE:{namespace}:PLUGIN:CATALOG, action=4 (UPDATE)
    ///   *  Returns : updated service plugin config
    /// </summary>
    public class UpdateSectionPluginConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateSectionPluginConfigBuilder Builder { get => new UpdateSectionPluginConfigBuilder(); }

        public class UpdateSectionPluginConfigBuilder
            : OperationBuilder<UpdateSectionPluginConfigBuilder>
        {


            public Model.SectionPluginConfigUpdate? Body { get; set; }




            internal UpdateSectionPluginConfigBuilder() { }

            internal UpdateSectionPluginConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdateSectionPluginConfigBuilder SetBody(Model.SectionPluginConfigUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdateSectionPluginConfig Build(
                string namespace_
            )
            {
                UpdateSectionPluginConfig op = new UpdateSectionPluginConfig(this,
                    namespace_
                );

                op.SetBaseFields<UpdateSectionPluginConfigBuilder>(this);
                return op;
            }

            public Model.SectionPluginConfigInfo? Execute(
                string namespace_
            )
            {
                UpdateSectionPluginConfig op = Build(
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

        private UpdateSectionPluginConfig(UpdateSectionPluginConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateSectionPluginConfig(
            string namespace_,
            Model.SectionPluginConfigUpdate body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/catalog/plugins/section";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.SectionPluginConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.SectionPluginConfigInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.SectionPluginConfigInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
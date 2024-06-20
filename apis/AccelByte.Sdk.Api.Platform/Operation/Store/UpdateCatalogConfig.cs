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
    /// updateCatalogConfig
    ///
    /// Update catalog config. Other detail info:
    ///   * Returns : updated catalog config
    /// </summary>
    public class UpdateCatalogConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateCatalogConfigBuilder Builder { get => new UpdateCatalogConfigBuilder(); }

        public class UpdateCatalogConfigBuilder
            : OperationBuilder<UpdateCatalogConfigBuilder>
        {


            public Model.CatalogConfigUpdate? Body { get; set; }




            internal UpdateCatalogConfigBuilder() { }

            internal UpdateCatalogConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdateCatalogConfigBuilder SetBody(Model.CatalogConfigUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdateCatalogConfig Build(
                string namespace_
            )
            {
                UpdateCatalogConfig op = new UpdateCatalogConfig(this,
                    namespace_
                );

                op.SetBaseFields<UpdateCatalogConfigBuilder>(this);
                return op;
            }

            public Model.CatalogConfigInfo? Execute(
                string namespace_
            )
            {
                UpdateCatalogConfig op = Build(
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
            public async Task<Model.CatalogConfigInfo?> ExecuteAsync(
                string namespace_
            )
            {
                UpdateCatalogConfig op = Build(
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

        private UpdateCatalogConfig(UpdateCatalogConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateCatalogConfig(
            string namespace_,
            Model.CatalogConfigUpdate body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/catalog/configs";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.CatalogConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.CatalogConfigInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CatalogConfigInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
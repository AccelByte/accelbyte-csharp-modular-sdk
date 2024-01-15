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

using AccelByte.Sdk.Api.Cloudsave.Model;

namespace AccelByte.Sdk.Api.Cloudsave.Operation
{
    /// <summary>
    /// updatePluginConfig
    ///
    /// ## Description
    /// 
    /// This endpoints will update grpc plugins configuration
    /// </summary>
    public class UpdatePluginConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdatePluginConfigBuilder Builder { get => new UpdatePluginConfigBuilder(); }

        public class UpdatePluginConfigBuilder
            : OperationBuilder<UpdatePluginConfigBuilder>
        {





            internal UpdatePluginConfigBuilder() { }

            internal UpdatePluginConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdatePluginConfig Build(
                ModelsPluginRequest body,
                string namespace_
            )
            {
                UpdatePluginConfig op = new UpdatePluginConfig(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsPluginResponse? Execute(
                ModelsPluginRequest body,
                string namespace_
            )
            {
                UpdatePluginConfig op = Build(
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

        private UpdatePluginConfig(UpdatePluginConfigBuilder builder,
            ModelsPluginRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdatePluginConfig(
            string namespace_,
            Model.ModelsPluginRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/plugins";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsPluginResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPluginResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPluginResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
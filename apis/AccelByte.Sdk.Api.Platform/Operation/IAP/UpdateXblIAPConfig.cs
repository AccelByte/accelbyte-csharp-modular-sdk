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
    /// updateXblIAPConfig
    ///
    /// Update xbl iap config. Other detail info:
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:IAP:CONFIG", action=4 (UPDATE)
    ///   *  Returns : updated xbl iap config
    /// </summary>
    public class UpdateXblIAPConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateXblIAPConfigBuilder Builder { get => new UpdateXblIAPConfigBuilder(); }

        public class UpdateXblIAPConfigBuilder
            : OperationBuilder<UpdateXblIAPConfigBuilder>
        {


            public Model.XblIAPConfigRequest? Body { get; set; }




            internal UpdateXblIAPConfigBuilder() { }

            internal UpdateXblIAPConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdateXblIAPConfigBuilder SetBody(Model.XblIAPConfigRequest _body)
            {
                Body = _body;
                return this;
            }




            public UpdateXblIAPConfig Build(
                string namespace_
            )
            {
                UpdateXblIAPConfig op = new UpdateXblIAPConfig(this,
                    namespace_
                );

                op.SetBaseFields<UpdateXblIAPConfigBuilder>(this);
                return op;
            }

            public Model.XblIAPConfigInfo? Execute(
                string namespace_
            )
            {
                UpdateXblIAPConfig op = Build(
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
            public async Task<Model.XblIAPConfigInfo?> ExecuteAsync(
                string namespace_
            )
            {
                UpdateXblIAPConfig op = Build(
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

        private UpdateXblIAPConfig(UpdateXblIAPConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateXblIAPConfig(
            string namespace_,
            Model.XblIAPConfigRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/xbl";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.XblIAPConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.XblIAPConfigInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.XblIAPConfigInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
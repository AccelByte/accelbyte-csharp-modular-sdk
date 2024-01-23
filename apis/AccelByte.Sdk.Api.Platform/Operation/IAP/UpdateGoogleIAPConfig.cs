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
    /// updateGoogleIAPConfig
    ///
    /// Update google iap config. Other detail info:
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:IAP:CONFIG", action=4 (UPDATE)
    ///   *  Returns : updated google iap config
    /// </summary>
    public class UpdateGoogleIAPConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateGoogleIAPConfigBuilder Builder { get => new UpdateGoogleIAPConfigBuilder(); }

        public class UpdateGoogleIAPConfigBuilder
            : OperationBuilder<UpdateGoogleIAPConfigBuilder>
        {


            public Model.GoogleIAPConfigRequest? Body { get; set; }




            internal UpdateGoogleIAPConfigBuilder() { }

            internal UpdateGoogleIAPConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdateGoogleIAPConfigBuilder SetBody(Model.GoogleIAPConfigRequest _body)
            {
                Body = _body;
                return this;
            }




            public UpdateGoogleIAPConfig Build(
                string namespace_
            )
            {
                UpdateGoogleIAPConfig op = new UpdateGoogleIAPConfig(this,
                    namespace_
                );

                op.SetBaseFields<UpdateGoogleIAPConfigBuilder>(this);
                return op;
            }

            public Model.GoogleIAPConfigInfo? Execute(
                string namespace_
            )
            {
                UpdateGoogleIAPConfig op = Build(
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

        private UpdateGoogleIAPConfig(UpdateGoogleIAPConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateGoogleIAPConfig(
            string namespace_,
            Model.GoogleIAPConfigRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/google";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.GoogleIAPConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.GoogleIAPConfigInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.GoogleIAPConfigInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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
    /// updateDLCItemConfig
    ///
    /// Update DLC item config. Other detail info:
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:DLC:CONFIG", action=4 (UPDATE)
    ///   *  Returns : updated DLC item config
    /// </summary>
    public class UpdateDLCItemConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateDLCItemConfigBuilder Builder { get => new UpdateDLCItemConfigBuilder(); }

        public class UpdateDLCItemConfigBuilder
            : OperationBuilder<UpdateDLCItemConfigBuilder>
        {


            public Model.DLCItemConfigUpdate? Body { get; set; }




            internal UpdateDLCItemConfigBuilder() { }

            internal UpdateDLCItemConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdateDLCItemConfigBuilder SetBody(Model.DLCItemConfigUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdateDLCItemConfig Build(
                string namespace_
            )
            {
                UpdateDLCItemConfig op = new UpdateDLCItemConfig(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.DLCItemConfigInfo? Execute(
                string namespace_
            )
            {
                UpdateDLCItemConfig op = Build(
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

        private UpdateDLCItemConfig(UpdateDLCItemConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateDLCItemConfig(
            string namespace_,
            Model.DLCItemConfigUpdate body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/dlc/config/item";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.DLCItemConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.DLCItemConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.DLCItemConfigInfo>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
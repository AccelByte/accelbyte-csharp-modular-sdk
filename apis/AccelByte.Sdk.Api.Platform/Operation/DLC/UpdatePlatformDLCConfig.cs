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
    /// updatePlatformDLCConfig
    ///
    /// Update Platform DLC config. Other detail info:
    ///   * Returns : updated Platform DLC config
    /// 
    /// 
    /// 
    /// ## Restrictions for platform dlc map
    /// 
    /// 
    /// 1. Cannot use "." as the key name
    /// -
    /// 
    /// 
    ///     { "data.2": "value" }
    /// 
    /// 
    /// 2. Cannot use "$" as the prefix in key names
    /// -
    /// 
    /// 
    ///     { "$data": "value" }
    /// </summary>
    public class UpdatePlatformDLCConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdatePlatformDLCConfigBuilder Builder { get => new UpdatePlatformDLCConfigBuilder(); }

        public class UpdatePlatformDLCConfigBuilder
            : OperationBuilder<UpdatePlatformDLCConfigBuilder>
        {


            public Model.PlatformDLCConfigUpdate? Body { get; set; }




            internal UpdatePlatformDLCConfigBuilder() { }

            internal UpdatePlatformDLCConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdatePlatformDLCConfigBuilder SetBody(Model.PlatformDLCConfigUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdatePlatformDLCConfig Build(
                string namespace_
            )
            {
                UpdatePlatformDLCConfig op = new UpdatePlatformDLCConfig(this,
                    namespace_
                );

                op.SetBaseFields<UpdatePlatformDLCConfigBuilder>(this);
                return op;
            }

            public Model.PlatformDLCConfigInfo? Execute(
                string namespace_
            )
            {
                UpdatePlatformDLCConfig op = Build(
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
            public async Task<Model.PlatformDLCConfigInfo?> ExecuteAsync(
                string namespace_
            )
            {
                UpdatePlatformDLCConfig op = Build(
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

        private UpdatePlatformDLCConfig(UpdatePlatformDLCConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdatePlatformDLCConfig(
            string namespace_,
            Model.PlatformDLCConfigUpdate body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/dlc/config/platformMap";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.PlatformDLCConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PlatformDLCConfigInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PlatformDLCConfigInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
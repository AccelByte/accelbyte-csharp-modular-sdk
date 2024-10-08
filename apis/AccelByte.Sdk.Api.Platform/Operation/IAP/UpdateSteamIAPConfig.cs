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
    /// updateSteamIAPConfig
    ///
    /// Update steam iap config. Other detail info:
    ///   * Returns : updated steam iap config
    /// </summary>
    public class UpdateSteamIAPConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateSteamIAPConfigBuilder Builder { get => new UpdateSteamIAPConfigBuilder(); }

        public class UpdateSteamIAPConfigBuilder
            : OperationBuilder<UpdateSteamIAPConfigBuilder>
        {





            internal UpdateSteamIAPConfigBuilder() { }

            internal UpdateSteamIAPConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateSteamIAPConfig Build(
                SteamIAPConfigRequest body,
                string namespace_
            )
            {
                UpdateSteamIAPConfig op = new UpdateSteamIAPConfig(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<UpdateSteamIAPConfigBuilder>(this);
                return op;
            }

            public Model.SteamIAPConfigInfo? Execute(
                SteamIAPConfigRequest body,
                string namespace_
            )
            {
                UpdateSteamIAPConfig op = Build(
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
            public async Task<Model.SteamIAPConfigInfo?> ExecuteAsync(
                SteamIAPConfigRequest body,
                string namespace_
            )
            {
                UpdateSteamIAPConfig op = Build(
                    body,
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

        private UpdateSteamIAPConfig(UpdateSteamIAPConfigBuilder builder,
            SteamIAPConfigRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateSteamIAPConfig(
            string namespace_,
            Model.SteamIAPConfigRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/steam";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.SteamIAPConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.SteamIAPConfigInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.SteamIAPConfigInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
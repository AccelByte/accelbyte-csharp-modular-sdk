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
    /// updateEpicGamesIAPConfig
    ///
    /// Update epic games iap config. Other detail info:
    ///   * Returns : updated epic games iap config
    /// </summary>
    public class UpdateEpicGamesIAPConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateEpicGamesIAPConfigBuilder Builder { get => new UpdateEpicGamesIAPConfigBuilder(); }

        public class UpdateEpicGamesIAPConfigBuilder
            : OperationBuilder<UpdateEpicGamesIAPConfigBuilder>
        {





            internal UpdateEpicGamesIAPConfigBuilder() { }

            internal UpdateEpicGamesIAPConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateEpicGamesIAPConfig Build(
                EpicGamesIAPConfigRequest body,
                string namespace_
            )
            {
                UpdateEpicGamesIAPConfig op = new UpdateEpicGamesIAPConfig(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<UpdateEpicGamesIAPConfigBuilder>(this);
                return op;
            }

            public Model.EpicGamesIAPConfigInfo? Execute(
                EpicGamesIAPConfigRequest body,
                string namespace_
            )
            {
                UpdateEpicGamesIAPConfig op = Build(
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
            public async Task<Model.EpicGamesIAPConfigInfo?> ExecuteAsync(
                EpicGamesIAPConfigRequest body,
                string namespace_
            )
            {
                UpdateEpicGamesIAPConfig op = Build(
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

        private UpdateEpicGamesIAPConfig(UpdateEpicGamesIAPConfigBuilder builder,
            EpicGamesIAPConfigRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateEpicGamesIAPConfig(
            string namespace_,
            Model.EpicGamesIAPConfigRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/epicgames";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.EpicGamesIAPConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.EpicGamesIAPConfigInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.EpicGamesIAPConfigInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
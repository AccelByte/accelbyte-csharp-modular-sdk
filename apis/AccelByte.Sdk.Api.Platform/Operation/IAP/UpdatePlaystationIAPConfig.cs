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
    /// updatePlaystationIAPConfig
    ///
    /// Update playstation iap config. Other detail info:
    ///   * Returns : updated playstation iap config
    /// </summary>
    public class UpdatePlaystationIAPConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdatePlaystationIAPConfigBuilder Builder { get => new UpdatePlaystationIAPConfigBuilder(); }

        public class UpdatePlaystationIAPConfigBuilder
            : OperationBuilder<UpdatePlaystationIAPConfigBuilder>
        {





            internal UpdatePlaystationIAPConfigBuilder() { }

            internal UpdatePlaystationIAPConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdatePlaystationIAPConfig Build(
                PlaystationIAPConfigRequest body,
                string namespace_
            )
            {
                UpdatePlaystationIAPConfig op = new UpdatePlaystationIAPConfig(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<UpdatePlaystationIAPConfigBuilder>(this);
                return op;
            }

            public Model.PlayStationIAPConfigInfo? Execute(
                PlaystationIAPConfigRequest body,
                string namespace_
            )
            {
                UpdatePlaystationIAPConfig op = Build(
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
            public async Task<Model.PlayStationIAPConfigInfo?> ExecuteAsync(
                PlaystationIAPConfigRequest body,
                string namespace_
            )
            {
                UpdatePlaystationIAPConfig op = Build(
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

        private UpdatePlaystationIAPConfig(UpdatePlaystationIAPConfigBuilder builder,
            PlaystationIAPConfigRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdatePlaystationIAPConfig(
            string namespace_,
            Model.PlaystationIAPConfigRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/playstation";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.PlayStationIAPConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PlayStationIAPConfigInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PlayStationIAPConfigInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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

using AccelByte.Sdk.Api.Gametelemetry.Model;

namespace AccelByte.Sdk.Api.Gametelemetry.Operation
{
    /// <summary>
    /// get_namespaces_game_telemetry_v1_admin_namespaces_get
    ///
    /// This endpoint requires valid JWT token and telemetry permission
    /// This endpoint retrieves namespace list
    /// </summary>
    public class GetNamespacesGameTelemetryV1AdminNamespacesGet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetNamespacesGameTelemetryV1AdminNamespacesGetBuilder Builder { get => new GetNamespacesGameTelemetryV1AdminNamespacesGetBuilder(); }

        public class GetNamespacesGameTelemetryV1AdminNamespacesGetBuilder
            : OperationBuilder<GetNamespacesGameTelemetryV1AdminNamespacesGetBuilder>
        {





            internal GetNamespacesGameTelemetryV1AdminNamespacesGetBuilder() { }

            internal GetNamespacesGameTelemetryV1AdminNamespacesGetBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetNamespacesGameTelemetryV1AdminNamespacesGet Build(
            )
            {
                GetNamespacesGameTelemetryV1AdminNamespacesGet op = new GetNamespacesGameTelemetryV1AdminNamespacesGet(this
                );

                op.SetBaseFields<GetNamespacesGameTelemetryV1AdminNamespacesGetBuilder>(this);
                return op;
            }

            public Model.ListBaseResponseStr? Execute(
            )
            {
                GetNamespacesGameTelemetryV1AdminNamespacesGet op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.ListBaseResponseStr?> ExecuteAsync(
            )
            {
                GetNamespacesGameTelemetryV1AdminNamespacesGet op = Build(
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

        private GetNamespacesGameTelemetryV1AdminNamespacesGet(GetNamespacesGameTelemetryV1AdminNamespacesGetBuilder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_COOKIE);
        }
        #endregion

        public GetNamespacesGameTelemetryV1AdminNamespacesGet(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_COOKIE);
        }

        public override string Path => "/game-telemetry/v1/admin/namespaces";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ListBaseResponseStr? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ListBaseResponseStr>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ListBaseResponseStr>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
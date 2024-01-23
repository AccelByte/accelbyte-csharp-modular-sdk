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

using AccelByte.Sdk.Api.Ams.Model;

namespace AccelByte.Sdk.Api.Ams.Operation
{
    /// <summary>
    /// FleetServers
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:ARMADA:FLEET [READ]
    /// </summary>
    public class FleetServers : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static FleetServersBuilder Builder { get => new FleetServersBuilder(); }

        public class FleetServersBuilder
            : OperationBuilder<FleetServersBuilder>
        {





            internal FleetServersBuilder() { }

            internal FleetServersBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public FleetServers Build(
                string fleetID,
                string namespace_
            )
            {
                FleetServers op = new FleetServers(this,
                    fleetID,
                    namespace_
                );

                op.SetBaseFields<FleetServersBuilder>(this);
                return op;
            }

            public Model.ApiFleetServersResponse? Execute(
                string fleetID,
                string namespace_
            )
            {
                FleetServers op = Build(
                    fleetID,
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

        private FleetServers(FleetServersBuilder builder,
            string fleetID,
            string namespace_
        )
        {
            PathParams["fleetID"] = fleetID;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public FleetServers(
            string fleetID,
            string namespace_
        )
        {
            PathParams["fleetID"] = fleetID;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/admin/namespaces/{namespace}/fleets/{fleetID}/servers";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApiFleetServersResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApiFleetServersResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiFleetServersResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
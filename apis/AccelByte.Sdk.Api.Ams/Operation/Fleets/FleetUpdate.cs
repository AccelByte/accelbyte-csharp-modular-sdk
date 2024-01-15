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
    /// FleetUpdate
    ///
    /// Optionally, sampling rules for the fleet can also be updated
    /// 
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:ARMADA:FLEET [UPDATE]
    /// </summary>
    public class FleetUpdate : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static FleetUpdateBuilder Builder { get => new FleetUpdateBuilder(); }

        public class FleetUpdateBuilder
            : OperationBuilder<FleetUpdateBuilder>
        {





            internal FleetUpdateBuilder() { }

            internal FleetUpdateBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public FleetUpdate Build(
                ApiFleetParameters body,
                string fleetID,
                string namespace_
            )
            {
                FleetUpdate op = new FleetUpdate(this,
                    body,
                    fleetID,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                ApiFleetParameters body,
                string fleetID,
                string namespace_
            )
            {
                FleetUpdate op = Build(
                    body,
                    fleetID,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private FleetUpdate(FleetUpdateBuilder builder,
            ApiFleetParameters body,
            string fleetID,
            string namespace_
        )
        {
            PathParams["fleetID"] = fleetID;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public FleetUpdate(
            string fleetID,
            string namespace_,
            Model.ApiFleetParameters body
        )
        {
            PathParams["fleetID"] = fleetID;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/admin/namespaces/{namespace}/fleets/{fleetID}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
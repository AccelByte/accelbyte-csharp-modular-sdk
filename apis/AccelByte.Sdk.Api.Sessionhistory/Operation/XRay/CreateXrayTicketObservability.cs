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

using AccelByte.Sdk.Api.Sessionhistory.Model;

namespace AccelByte.Sdk.Api.Sessionhistory.Operation
{
    /// <summary>
    /// createXrayTicketObservability
    ///
    /// Create ticket observability request
    /// Request body details (all attributes are optional):
    /// Timestamp : timestamp when calling this endpoint
    /// Action : support one of the following value:
    /// 1. "matchFound"
    /// 2. "matchNotFound"
    /// 3. "flexed"
    /// TicketID : ticket ID
    /// MatchID : match ID will be filled only when match found
    /// Namespace : ticket current namespace
    /// GameMode : ticket current matchpool
    /// ActiveAllianceRule : current active alliance ruleset
    /// ActiveMatchingRule : current active matching ruleset
    /// Function : name of the function that called the endpoint
    /// Iteration : total iteration before match found
    /// TimeToMatchSec : time to match (in seconds) will be filled only when match found
    /// UnmatchReason : reason when unable to find match
    /// RemainingTickets : remaining ticket when unable to find match
    /// RemainingPlayersPerTicket : remaining players when unable to find match
    /// UnbackfillReason : reason when unable to backfill
    /// IsBackfillMatch : flag to distinguish between new match and backfill match
    /// IsRuleSetFlexed : flag if ruleset is getting flexed
    /// TickID : tick id for the matchmaking tick
    /// SessionTickID : session tick id for differentiate session when doing matches
    /// </summary>
    public class CreateXrayTicketObservability : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateXrayTicketObservabilityBuilder Builder { get => new CreateXrayTicketObservabilityBuilder(); }

        public class CreateXrayTicketObservabilityBuilder
            : OperationBuilder<CreateXrayTicketObservabilityBuilder>
        {





            internal CreateXrayTicketObservabilityBuilder() { }

            internal CreateXrayTicketObservabilityBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateXrayTicketObservability Build(
                ApimodelsXRayTicketObservabilityRequest body,
                string namespace_
            )
            {
                CreateXrayTicketObservability op = new CreateXrayTicketObservability(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<CreateXrayTicketObservabilityBuilder>(this);
                return op;
            }

            public Model.ApimodelsXRayTicketObservabilityResponse? Execute(
                ApimodelsXRayTicketObservabilityRequest body,
                string namespace_
            )
            {
                CreateXrayTicketObservability op = Build(
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
            public async Task<Model.ApimodelsXRayTicketObservabilityResponse?> ExecuteAsync(
                ApimodelsXRayTicketObservabilityRequest body,
                string namespace_
            )
            {
                CreateXrayTicketObservability op = Build(
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

        private CreateXrayTicketObservability(CreateXrayTicketObservabilityBuilder builder,
            ApimodelsXRayTicketObservabilityRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateXrayTicketObservability(
            string namespace_,
            Model.ApimodelsXRayTicketObservabilityRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionhistory/v2/admin/namespaces/{namespace}/xray/tickets";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApimodelsXRayTicketObservabilityResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsXRayTicketObservabilityResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsXRayTicketObservabilityResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
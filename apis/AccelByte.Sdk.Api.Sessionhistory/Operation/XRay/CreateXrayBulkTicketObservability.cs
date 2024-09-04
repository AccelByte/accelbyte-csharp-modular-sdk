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
    /// createXrayBulkTicketObservability
    ///
    /// Create bulk ticket observability request
    /// Request body details (all attributes are optional):
    /// Timestamp : timestamp when calling this endpoint
    /// Action : support one of the following value:
    /// 1. "matchFound"
    /// 2. "matchNotFound"
    /// 3. "flexed"
    /// PartyID : ticket Party ID
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
    public class CreateXrayBulkTicketObservability : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateXrayBulkTicketObservabilityBuilder Builder { get => new CreateXrayBulkTicketObservabilityBuilder(); }

        public class CreateXrayBulkTicketObservabilityBuilder
            : OperationBuilder<CreateXrayBulkTicketObservabilityBuilder>
        {





            internal CreateXrayBulkTicketObservabilityBuilder() { }

            internal CreateXrayBulkTicketObservabilityBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateXrayBulkTicketObservability Build(
                ApimodelsXRayBulkTicketObservabilityRequest body,
                string namespace_
            )
            {
                CreateXrayBulkTicketObservability op = new CreateXrayBulkTicketObservability(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<CreateXrayBulkTicketObservabilityBuilder>(this);
                return op;
            }

            public Model.ApimodelsXRayBulkTicketObservabilityResponse? Execute(
                ApimodelsXRayBulkTicketObservabilityRequest body,
                string namespace_
            )
            {
                CreateXrayBulkTicketObservability op = Build(
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
            public async Task<Model.ApimodelsXRayBulkTicketObservabilityResponse?> ExecuteAsync(
                ApimodelsXRayBulkTicketObservabilityRequest body,
                string namespace_
            )
            {
                CreateXrayBulkTicketObservability op = Build(
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

        private CreateXrayBulkTicketObservability(CreateXrayBulkTicketObservabilityBuilder builder,
            ApimodelsXRayBulkTicketObservabilityRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateXrayBulkTicketObservability(
            string namespace_,
            Model.ApimodelsXRayBulkTicketObservabilityRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionhistory/v2/admin/namespaces/{namespace}/xray/tickets/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApimodelsXRayBulkTicketObservabilityResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsXRayBulkTicketObservabilityResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsXRayBulkTicketObservabilityResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
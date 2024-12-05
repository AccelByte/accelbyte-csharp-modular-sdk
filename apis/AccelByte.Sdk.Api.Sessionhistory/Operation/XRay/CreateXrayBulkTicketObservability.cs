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

            public CreateXrayBulkTicketObservability.Response Execute(
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
            public async Task<CreateXrayBulkTicketObservability.Response> ExecuteAsync(
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

        #region Response Part        
        public class Response : ApiResponse<Model.ApimodelsXRayBulkTicketObservabilityResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Sessionhistory::XRay::CreateXrayBulkTicketObservability";
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

        public CreateXrayBulkTicketObservability.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new CreateXrayBulkTicketObservability.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.ApimodelsXRayBulkTicketObservabilityResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
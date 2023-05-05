// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Match2.Model
{
    public class ApiMatchPool : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("auto_accept_backfill_proposal")]
        public bool? AutoAcceptBackfillProposal { get; set; }

        [JsonPropertyName("backfill_proposal_expiration_seconds")]
        public int? BackfillProposalExpirationSeconds { get; set; }

        [JsonPropertyName("backfill_ticket_expiration_seconds")]
        public int? BackfillTicketExpirationSeconds { get; set; }

        [JsonPropertyName("match_function")]
        public string? MatchFunction { get; set; }

        [JsonPropertyName("match_function_override")]
        public ApiMatchFunctionOverride? MatchFunctionOverride { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("rule_set")]
        public string? RuleSet { get; set; }

        [JsonPropertyName("session_template")]
        public string? SessionTemplate { get; set; }

        [JsonPropertyName("ticket_expiration_seconds")]
        public int? TicketExpirationSeconds { get; set; }

    }


}
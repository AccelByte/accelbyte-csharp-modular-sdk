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

using AccelByte.Sdk.Api.Dsartifact.Model;

namespace AccelByte.Sdk.Api.Dsartifact.Operation
{
    /// <summary>
    /// listTerminatedServersWithNamespace
    ///
    /// ```
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSAM:SERVER [READ]
    /// 
    /// This endpoint used to retrieve terminated servers in a namespace
    /// ```
    /// </summary>
    public class ListTerminatedServersWithNamespace : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListTerminatedServersWithNamespaceBuilder Builder { get => new ListTerminatedServersWithNamespaceBuilder(); }

        public class ListTerminatedServersWithNamespaceBuilder
            : OperationBuilder<ListTerminatedServersWithNamespaceBuilder>
        {

            public string? Deployment { get; set; }

            public string? GameMode { get; set; }

            public long? Limit { get; set; }

            public string? Next { get; set; }

            public string? PartyId { get; set; }

            public string? PodName { get; set; }

            public string? Previous { get; set; }

            public string? Provider { get; set; }

            public string? Region { get; set; }

            public string? SessionId { get; set; }

            public string? UserId { get; set; }





            internal ListTerminatedServersWithNamespaceBuilder() { }

            internal ListTerminatedServersWithNamespaceBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public ListTerminatedServersWithNamespaceBuilder SetDeployment(string _deployment)
            {
                Deployment = _deployment;
                return this;
            }

            public ListTerminatedServersWithNamespaceBuilder SetGameMode(string _gameMode)
            {
                GameMode = _gameMode;
                return this;
            }

            public ListTerminatedServersWithNamespaceBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public ListTerminatedServersWithNamespaceBuilder SetNext(string _next)
            {
                Next = _next;
                return this;
            }

            public ListTerminatedServersWithNamespaceBuilder SetPartyId(string _partyId)
            {
                PartyId = _partyId;
                return this;
            }

            public ListTerminatedServersWithNamespaceBuilder SetPodName(string _podName)
            {
                PodName = _podName;
                return this;
            }

            public ListTerminatedServersWithNamespaceBuilder SetPrevious(string _previous)
            {
                Previous = _previous;
                return this;
            }

            public ListTerminatedServersWithNamespaceBuilder SetProvider(string _provider)
            {
                Provider = _provider;
                return this;
            }

            public ListTerminatedServersWithNamespaceBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }

            public ListTerminatedServersWithNamespaceBuilder SetSessionId(string _sessionId)
            {
                SessionId = _sessionId;
                return this;
            }

            public ListTerminatedServersWithNamespaceBuilder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }





            public ListTerminatedServersWithNamespace Build(
                string namespace_
            )
            {
                ListTerminatedServersWithNamespace op = new ListTerminatedServersWithNamespace(this,
                    namespace_
                );

                op.SetBaseFields<ListTerminatedServersWithNamespaceBuilder>(this);
                return op;
            }

            public Model.ModelsListTerminatedServersResponse? Execute(
                string namespace_
            )
            {
                ListTerminatedServersWithNamespace op = Build(
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

        private ListTerminatedServersWithNamespace(ListTerminatedServersWithNamespaceBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Deployment is not null) QueryParams["deployment"] = builder.Deployment;
            if (builder.GameMode is not null) QueryParams["game_mode"] = builder.GameMode;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Next is not null) QueryParams["next"] = builder.Next;
            if (builder.PartyId is not null) QueryParams["party_id"] = builder.PartyId;
            if (builder.PodName is not null) QueryParams["pod_name"] = builder.PodName;
            if (builder.Previous is not null) QueryParams["previous"] = builder.Previous;
            if (builder.Provider is not null) QueryParams["provider"] = builder.Provider;
            if (builder.Region is not null) QueryParams["region"] = builder.Region;
            if (builder.SessionId is not null) QueryParams["session_id"] = builder.SessionId;
            if (builder.UserId is not null) QueryParams["user_id"] = builder.UserId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ListTerminatedServersWithNamespace(
            string namespace_,
            string? deployment,
            string? gameMode,
            long? limit,
            string? next,
            string? partyId,
            string? podName,
            string? previous,
            string? provider,
            string? region,
            string? sessionId,
            string? userId
        )
        {
            PathParams["namespace"] = namespace_;

            if (deployment is not null) QueryParams["deployment"] = deployment;
            if (gameMode is not null) QueryParams["game_mode"] = gameMode;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (next is not null) QueryParams["next"] = next;
            if (partyId is not null) QueryParams["party_id"] = partyId;
            if (podName is not null) QueryParams["pod_name"] = podName;
            if (previous is not null) QueryParams["previous"] = previous;
            if (provider is not null) QueryParams["provider"] = provider;
            if (region is not null) QueryParams["region"] = region;
            if (sessionId is not null) QueryParams["session_id"] = sessionId;
            if (userId is not null) QueryParams["user_id"] = userId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsartifact/namespaces/{namespace}/servers/search";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json", "text/x-log" };

        public Model.ModelsListTerminatedServersResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsListTerminatedServersResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListTerminatedServersResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
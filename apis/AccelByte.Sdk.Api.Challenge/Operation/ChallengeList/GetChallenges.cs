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

using AccelByte.Sdk.Api.Challenge.Model;

namespace AccelByte.Sdk.Api.Challenge.Operation
{
    /// <summary>
    /// GetChallenges
    ///
    /// 
    ///     * Required permission: NAMESPACE:{namespace}:CHALLENGE [READ]
    /// </summary>
    public class GetChallenges : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetChallengesBuilder Builder { get => new GetChallengesBuilder(); }

        public class GetChallengesBuilder
            : OperationBuilder<GetChallengesBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? SortBy { get; set; }

            public GetChallengesStatus? Status { get; set; }





            internal GetChallengesBuilder() { }

            internal GetChallengesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetChallengesBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetChallengesBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public GetChallengesBuilder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public GetChallengesBuilder SetStatus(GetChallengesStatus _status)
            {
                Status = _status;
                return this;
            }





            public GetChallenges Build(
                string namespace_
            )
            {
                GetChallenges op = new GetChallenges(this,
                    namespace_
                );

                op.SetBaseFields<GetChallengesBuilder>(this);
                return op;
            }

            public Model.ModelListChallengeResponse? Execute(
                string namespace_
            )
            {
                GetChallenges op = Build(
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

        private GetChallenges(GetChallengesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;
            if (builder.Status is not null) QueryParams["status"] = builder.Status.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetChallenges(
            string namespace_,
            long? limit,
            long? offset,
            string? sortBy,
            GetChallengesStatus? status
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;
            if (status is not null) QueryParams["status"] = status.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/challenge/v1/public/namespaces/{namespace}/challenges";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelListChallengeResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelListChallengeResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelListChallengeResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class GetChallengesStatus : StringEnum<GetChallengesStatus>
    {
        public static readonly GetChallengesStatus INIT
            = new GetChallengesStatus("INIT");

        public static readonly GetChallengesStatus RETIRED
            = new GetChallengesStatus("RETIRED");

        public static readonly GetChallengesStatus TIED
            = new GetChallengesStatus("TIED");


        public static implicit operator GetChallengesStatus(string value)
        {
            return NewValue(value);
        }

        public GetChallengesStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

}
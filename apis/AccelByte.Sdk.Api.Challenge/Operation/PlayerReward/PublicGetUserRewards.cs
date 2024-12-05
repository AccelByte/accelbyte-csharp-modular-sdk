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

using AccelByte.Sdk.Api.Challenge.Model;

namespace AccelByte.Sdk.Api.Challenge.Operation
{
    /// <summary>
    /// publicGetUserRewards
    ///
    /// 
    ///     * Required permission: NAMESPACE:{namespace}:CHALLENGE:REWARD [READ]
    /// </summary>
    public class PublicGetUserRewards : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserRewardsBuilder Builder { get => new PublicGetUserRewardsBuilder(); }

        public class PublicGetUserRewardsBuilder
            : OperationBuilder<PublicGetUserRewardsBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? SortBy { get; set; }

            public PublicGetUserRewardsStatus? Status { get; set; }





            internal PublicGetUserRewardsBuilder() { }

            internal PublicGetUserRewardsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicGetUserRewardsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicGetUserRewardsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public PublicGetUserRewardsBuilder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public PublicGetUserRewardsBuilder SetStatus(PublicGetUserRewardsStatus _status)
            {
                Status = _status;
                return this;
            }





            public PublicGetUserRewards Build(
                string namespace_
            )
            {
                PublicGetUserRewards op = new PublicGetUserRewards(this,
                    namespace_
                );

                op.SetBaseFields<PublicGetUserRewardsBuilder>(this);
                return op;
            }

            public PublicGetUserRewards.Response Execute(
                string namespace_
            )
            {
                PublicGetUserRewards op = Build(
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
            public async Task<PublicGetUserRewards.Response> ExecuteAsync(
                string namespace_
            )
            {
                PublicGetUserRewards op = Build(
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

        private PublicGetUserRewards(PublicGetUserRewardsBuilder builder,
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

        #region Response Part        
        public class Response : ApiResponse<Model.ModelListUserRewardsResponse>
        {

            public IamErrorResponse? Error401 { get; set; } = null;

            public IamErrorResponse? Error403 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Challenge::PlayerReward::PublicGetUserRewards";
        }

        #endregion

        public PublicGetUserRewards(
            string namespace_,
            long? limit,
            long? offset,
            string? sortBy,
            PublicGetUserRewardsStatus? status
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;
            if (status is not null) QueryParams["status"] = status.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/challenge/v1/public/namespaces/{namespace}/users/me/rewards";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public PublicGetUserRewards.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicGetUserRewards.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelListUserRewardsResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<IamErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<IamErrorResponse>(payload, ResponseJsonOptions);
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

    public class PublicGetUserRewardsStatus : StringEnum<PublicGetUserRewardsStatus>
    {
        public static readonly PublicGetUserRewardsStatus CLAIMED
            = new PublicGetUserRewardsStatus("CLAIMED");

        public static readonly PublicGetUserRewardsStatus UNCLAIMED
            = new PublicGetUserRewardsStatus("UNCLAIMED");


        public static implicit operator PublicGetUserRewardsStatus(string value)
        {
            return NewValue(value);
        }

        public PublicGetUserRewardsStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

}
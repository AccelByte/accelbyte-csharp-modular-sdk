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

using AccelByte.Sdk.Api.Seasonpass.Model;

namespace AccelByte.Sdk.Api.Seasonpass.Operation
{
    /// <summary>
    /// getUserParticipatedSeasons
    ///
    /// This API is used to get user participated season data, season only located in non-publisher namespace.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:SEASONPASS", action=2 (READ)
    ///   *  Returns : user participated season data
    /// </summary>
    public class GetUserParticipatedSeasons : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserParticipatedSeasonsBuilder Builder { get => new GetUserParticipatedSeasonsBuilder(); }

        public class GetUserParticipatedSeasonsBuilder
            : OperationBuilder<GetUserParticipatedSeasonsBuilder>
        {

            public int? Limit { get; set; }

            public int? Offset { get; set; }





            internal GetUserParticipatedSeasonsBuilder() { }

            internal GetUserParticipatedSeasonsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetUserParticipatedSeasonsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetUserParticipatedSeasonsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetUserParticipatedSeasons Build(
                string namespace_,
                string userId
            )
            {
                GetUserParticipatedSeasons op = new GetUserParticipatedSeasons(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ListUserSeasonInfoPagingSlicedResult? Execute(
                string namespace_,
                string userId
            )
            {
                GetUserParticipatedSeasons op = Build(
                    namespace_,
                    userId
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

        private GetUserParticipatedSeasons(GetUserParticipatedSeasonsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserParticipatedSeasons(
            string namespace_,
            string userId,
            int? limit,
            int? offset
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ListUserSeasonInfoPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ListUserSeasonInfoPagingSlicedResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ListUserSeasonInfoPagingSlicedResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
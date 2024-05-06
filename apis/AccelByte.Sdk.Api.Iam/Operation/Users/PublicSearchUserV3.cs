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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// PublicSearchUserV3
    ///
    /// This endpoint search all users on the specified namespace that match the query on these fields: display name, unique display name, username or by 3rd party display name.
    /// The query length should between 3-20, otherwise will not query the database.
    /// The default limit value is 20.
    /// 
    /// ## Searching by 3rd party platform
    /// 
    /// **Note: searching by 3rd party platform display name will use exact query, not fuzzy query.**
    /// 
    /// Step when searching by 3rd party platform display name:
    /// 1. set __by__ to __thirdPartyPlatform__
    /// 2. set __platformId__ to the _supported platform id_
    /// 3. set __platformBy__ to __platformDisplayName__
    /// 
    /// ### Supported platform id:
    /// * Steam group(steamnetwork)
    /// * steam
    /// * steamopenid
    /// * PSN group(psn)
    /// * ps4web
    /// * ps4
    /// * ps5
    /// * XBOX group(xbox)
    /// * live
    /// * xblweb
    /// * Oculus group(oculusgroup)
    /// * oculus
    /// * oculusweb
    /// * facebook
    /// * google
    /// * twitch
    /// * discord
    /// * android
    /// * ios
    /// * apple
    /// * device
    /// * epicgames
    /// * nintendo
    /// * awscognito
    /// * netflix
    /// * snapchat
    /// * _oidc platform id_
    /// 
    /// Note: you can use either platform ID or platform group as __platformId__ query parameter.
    /// </summary>
    public class PublicSearchUserV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicSearchUserV3Builder Builder { get => new PublicSearchUserV3Builder(); }

        public class PublicSearchUserV3Builder
            : OperationBuilder<PublicSearchUserV3Builder>
        {

            public string? By { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? PlatformBy { get; set; }

            public string? PlatformId { get; set; }

            public string? Query { get; set; }





            internal PublicSearchUserV3Builder() { }

            internal PublicSearchUserV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicSearchUserV3Builder SetBy(string _by)
            {
                By = _by;
                return this;
            }

            public PublicSearchUserV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicSearchUserV3Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public PublicSearchUserV3Builder SetPlatformBy(string _platformBy)
            {
                PlatformBy = _platformBy;
                return this;
            }

            public PublicSearchUserV3Builder SetPlatformId(string _platformId)
            {
                PlatformId = _platformId;
                return this;
            }

            public PublicSearchUserV3Builder SetQuery(string _query)
            {
                Query = _query;
                return this;
            }





            public PublicSearchUserV3 Build(
                string namespace_
            )
            {
                PublicSearchUserV3 op = new PublicSearchUserV3(this,
                    namespace_
                );

                op.SetBaseFields<PublicSearchUserV3Builder>(this);
                return op;
            }

            public Model.ModelPublicUserInformationResponseV3? Execute(
                string namespace_
            )
            {
                PublicSearchUserV3 op = Build(
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
            public async Task<Model.ModelPublicUserInformationResponseV3?> ExecuteAsync(
                string namespace_
            )
            {
                PublicSearchUserV3 op = Build(
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

        private PublicSearchUserV3(PublicSearchUserV3Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.By is not null) QueryParams["by"] = builder.By;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.PlatformBy is not null) QueryParams["platformBy"] = builder.PlatformBy;
            if (builder.PlatformId is not null) QueryParams["platformId"] = builder.PlatformId;
            if (builder.Query is not null) QueryParams["query"] = builder.Query;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicSearchUserV3(
            string namespace_,
            string? by,
            long? limit,
            long? offset,
            string? platformBy,
            string? platformId,
            string? query
        )
        {
            PathParams["namespace"] = namespace_;

            if (by is not null) QueryParams["by"] = by;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (platformBy is not null) QueryParams["platformBy"] = platformBy;
            if (platformId is not null) QueryParams["platformId"] = platformId;
            if (query is not null) QueryParams["query"] = query;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelPublicUserInformationResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelPublicUserInformationResponseV3>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelPublicUserInformationResponseV3>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
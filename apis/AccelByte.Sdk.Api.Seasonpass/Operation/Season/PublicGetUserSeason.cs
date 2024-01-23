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
    /// publicGetUserSeason
    ///
    /// This API is used to get user season data, season only located in non-publisher namespace.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:SEASONPASS", action=2 (READ)
    ///   *  Returns : user season data
    /// </summary>
    public class PublicGetUserSeason : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserSeasonBuilder Builder { get => new PublicGetUserSeasonBuilder(); }

        public class PublicGetUserSeasonBuilder
            : OperationBuilder<PublicGetUserSeasonBuilder>
        {





            internal PublicGetUserSeasonBuilder() { }

            internal PublicGetUserSeasonBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetUserSeason Build(
                string namespace_,
                string seasonId,
                string userId
            )
            {
                PublicGetUserSeason op = new PublicGetUserSeason(this,
                    namespace_,
                    seasonId,
                    userId
                );

                op.SetBaseFields<PublicGetUserSeasonBuilder>(this);
                return op;
            }

            public Model.ClaimableUserSeasonInfo? Execute(
                string namespace_,
                string seasonId,
                string userId
            )
            {
                PublicGetUserSeason op = Build(
                    namespace_,
                    seasonId,
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

            public Model.ClaimableUserSeasonInfo<T1, T2>? Execute<T1, T2>(
                string namespace_,
                string seasonId,
                string userId
            )
            {
                PublicGetUserSeason op = Build(
                    namespace_,
                    seasonId,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private PublicGetUserSeason(PublicGetUserSeasonBuilder builder,
            string namespace_,
            string seasonId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetUserSeason(
            string namespace_,
            string seasonId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/public/namespaces/{namespace}/users/{userId}/seasons/{seasonId}/data";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ClaimableUserSeasonInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ClaimableUserSeasonInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ClaimableUserSeasonInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ClaimableUserSeasonInfo<T1, T2>? ParseResponse<T1, T2>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ClaimableUserSeasonInfo<T1, T2>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ClaimableUserSeasonInfo<T1, T2>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}
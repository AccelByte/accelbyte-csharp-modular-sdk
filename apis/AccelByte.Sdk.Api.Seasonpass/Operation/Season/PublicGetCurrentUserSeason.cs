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
    /// publicGetCurrentUserSeason
    ///
    /// This API is used to get current user season data, it will auto enroll if there's no user season but active published season exist, season only located in non-publisher namespace.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:SEASONPASS", action=2 (READ)
    ///   *  Returns : user season data
    /// </summary>
    public class PublicGetCurrentUserSeason : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetCurrentUserSeasonBuilder Builder { get => new PublicGetCurrentUserSeasonBuilder(); }

        public class PublicGetCurrentUserSeasonBuilder
            : OperationBuilder<PublicGetCurrentUserSeasonBuilder>
        {





            internal PublicGetCurrentUserSeasonBuilder() { }

            internal PublicGetCurrentUserSeasonBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetCurrentUserSeason Build(
                string namespace_,
                string userId
            )
            {
                PublicGetCurrentUserSeason op = new PublicGetCurrentUserSeason(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<PublicGetCurrentUserSeasonBuilder>(this);
                return op;
            }

            public Model.ClaimableUserSeasonInfo? Execute(
                string namespace_,
                string userId
            )
            {
                PublicGetCurrentUserSeason op = Build(
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

            public Model.ClaimableUserSeasonInfo<T1, T2>? Execute<T1, T2>(
                string namespace_,
                string userId
            )
            {
                PublicGetCurrentUserSeason op = Build(
                    namespace_,
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

        private PublicGetCurrentUserSeason(PublicGetCurrentUserSeasonBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetCurrentUserSeason(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/public/namespaces/{namespace}/users/{userId}/seasons/current/data";

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
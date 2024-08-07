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

using AccelByte.Sdk.Api.Social.Model;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// publicGetProfile
    ///
    /// Returns profile for a user.
    /// Other detail info:
    ///         *  Returns : game profile info
    /// </summary>
    public class PublicGetProfile : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetProfileBuilder Builder { get => new PublicGetProfileBuilder(); }

        public class PublicGetProfileBuilder
            : OperationBuilder<PublicGetProfileBuilder>
        {





            internal PublicGetProfileBuilder() { }

            internal PublicGetProfileBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetProfile Build(
                string namespace_,
                string profileId,
                string userId
            )
            {
                PublicGetProfile op = new PublicGetProfile(this,
                    namespace_,
                    profileId,
                    userId
                );

                op.SetBaseFields<PublicGetProfileBuilder>(this);
                return op;
            }

            public Model.GameProfileInfo? Execute(
                string namespace_,
                string profileId,
                string userId
            )
            {
                PublicGetProfile op = Build(
                    namespace_,
                    profileId,
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
            public async Task<Model.GameProfileInfo?> ExecuteAsync(
                string namespace_,
                string profileId,
                string userId
            )
            {
                PublicGetProfile op = Build(
                    namespace_,
                    profileId,
                    userId
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

        private PublicGetProfile(PublicGetProfileBuilder builder,
            string namespace_,
            string profileId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["profileId"] = profileId;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetProfile(
            string namespace_,
            string profileId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["profileId"] = profileId;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/public/namespaces/{namespace}/users/{userId}/profiles/{profileId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.GameProfileInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.GameProfileInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.GameProfileInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
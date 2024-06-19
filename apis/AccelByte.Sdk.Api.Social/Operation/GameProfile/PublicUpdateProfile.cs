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
    /// publicUpdateProfile
    ///
    /// Updates user game profile, returns updated profile.
    /// Other detail info:
    ///         *  Returns : updated game profile
    /// </summary>
    public class PublicUpdateProfile : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpdateProfileBuilder Builder { get => new PublicUpdateProfileBuilder(); }

        public class PublicUpdateProfileBuilder
            : OperationBuilder<PublicUpdateProfileBuilder>
        {


            public Model.GameProfileRequest? Body { get; set; }




            internal PublicUpdateProfileBuilder() { }

            internal PublicUpdateProfileBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public PublicUpdateProfileBuilder SetBody(Model.GameProfileRequest _body)
            {
                Body = _body;
                return this;
            }




            public PublicUpdateProfile Build(
                string namespace_,
                string profileId,
                string userId
            )
            {
                PublicUpdateProfile op = new PublicUpdateProfile(this,
                    namespace_,
                    profileId,
                    userId
                );

                op.SetBaseFields<PublicUpdateProfileBuilder>(this);
                return op;
            }

            public Model.GameProfileInfo? Execute(
                string namespace_,
                string profileId,
                string userId
            )
            {
                PublicUpdateProfile op = Build(
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
                PublicUpdateProfile op = Build(
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

        private PublicUpdateProfile(PublicUpdateProfileBuilder builder,
            string namespace_,
            string profileId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["profileId"] = profileId;
            PathParams["userId"] = userId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicUpdateProfile(
            string namespace_,
            string profileId,
            string userId,
            Model.GameProfileRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["profileId"] = profileId;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/public/namespaces/{namespace}/users/{userId}/profiles/{profileId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

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
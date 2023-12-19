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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// PublicGetMyUserV3
    ///
    /// Get my user data
    /// 
    /// __Supported 3rd platforms:__
    /// 
    /// * __PSN(ps4web, ps4, ps5)__
    /// * display name
    /// * avatar
    /// * __Xbox(live, xblweb)__
    /// * display name
    /// * __Steam(steam, steamopenid)__
    /// * display name
    /// * avatar
    /// * __EpicGames(epicgames)__
    /// * display name
    /// 
    /// action code : 10147
    /// </summary>
    public class PublicGetMyUserV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetMyUserV3Builder Builder { get => new PublicGetMyUserV3Builder(); }

        public class PublicGetMyUserV3Builder
            : OperationBuilder<PublicGetMyUserV3Builder>
        {

            public bool? IncludeAllPlatforms { get; set; }





            internal PublicGetMyUserV3Builder() { }

            internal PublicGetMyUserV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicGetMyUserV3Builder SetIncludeAllPlatforms(bool _includeAllPlatforms)
            {
                IncludeAllPlatforms = _includeAllPlatforms;
                return this;
            }





            public PublicGetMyUserV3 Build(
            )
            {
                PublicGetMyUserV3 op = new PublicGetMyUserV3(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelUserResponseV3? Execute(
            )
            {
                PublicGetMyUserV3 op = Build(
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

        private PublicGetMyUserV3(PublicGetMyUserV3Builder builder
        )
        {

            if (builder.IncludeAllPlatforms != null) QueryParams["includeAllPlatforms"] = Convert.ToString(builder.IncludeAllPlatforms)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetMyUserV3(
            bool? includeAllPlatforms
        )
        {

            if (includeAllPlatforms != null) QueryParams["includeAllPlatforms"] = Convert.ToString(includeAllPlatforms)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/users/me";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelUserResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponseV3>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponseV3>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
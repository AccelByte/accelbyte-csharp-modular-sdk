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

using AccelByte.Sdk.Api.Leaderboard.Model;

namespace AccelByte.Sdk.Api.Leaderboard.Operation
{
    /// <summary>
    /// SetUserLeaderboardVisibilityStatusV2
    ///
    /// User with false visibility status will have hidden attribute set to true on it's leaderboard entry
    /// </summary>
    public class SetUserLeaderboardVisibilityStatusV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SetUserLeaderboardVisibilityStatusV2Builder Builder { get => new SetUserLeaderboardVisibilityStatusV2Builder(); }

        public class SetUserLeaderboardVisibilityStatusV2Builder
            : OperationBuilder<SetUserLeaderboardVisibilityStatusV2Builder>
        {





            internal SetUserLeaderboardVisibilityStatusV2Builder() { }

            internal SetUserLeaderboardVisibilityStatusV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public SetUserLeaderboardVisibilityStatusV2 Build(
                ModelsSetUserVisibilityRequest body,
                string leaderboardCode,
                string namespace_,
                string userId
            )
            {
                SetUserLeaderboardVisibilityStatusV2 op = new SetUserLeaderboardVisibilityStatusV2(this,
                    body,
                    leaderboardCode,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsGetUserVisibilityResponse? Execute(
                ModelsSetUserVisibilityRequest body,
                string leaderboardCode,
                string namespace_,
                string userId
            )
            {
                SetUserLeaderboardVisibilityStatusV2 op = Build(
                    body,
                    leaderboardCode,
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

        private SetUserLeaderboardVisibilityStatusV2(SetUserLeaderboardVisibilityStatusV2Builder builder,
            ModelsSetUserVisibilityRequest body,
            string leaderboardCode,
            string namespace_,
            string userId
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SetUserLeaderboardVisibilityStatusV2(
            string leaderboardCode,
            string namespace_,
            string userId,
            Model.ModelsSetUserVisibilityRequest body
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v2/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/users/{userId}/visibility";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsGetUserVisibilityResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetUserVisibilityResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetUserVisibilityResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
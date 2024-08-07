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

using AccelByte.Sdk.Api.Leaderboard.Model;

namespace AccelByte.Sdk.Api.Leaderboard.Operation
{
    /// <summary>
    /// updateUserPointAdminV1
    ///
    /// 
    /// 
    /// Update user point in a leaderboard. This endpoint uses for test utility only.
    /// 
    /// 
    /// 
    /// 
    /// Other detail info:
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    ///   * Returns: user ranking
    /// </summary>
    public class UpdateUserPointAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateUserPointAdminV1Builder Builder { get => new UpdateUserPointAdminV1Builder(); }

        public class UpdateUserPointAdminV1Builder
            : OperationBuilder<UpdateUserPointAdminV1Builder>
        {





            internal UpdateUserPointAdminV1Builder() { }

            internal UpdateUserPointAdminV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateUserPointAdminV1 Build(
                ModelsUpdateUserPointAdminV1Request body,
                string leaderboardCode,
                string namespace_,
                string userId
            )
            {
                UpdateUserPointAdminV1 op = new UpdateUserPointAdminV1(this,
                    body,
                    leaderboardCode,
                    namespace_,
                    userId
                );

                op.SetBaseFields<UpdateUserPointAdminV1Builder>(this);
                return op;
            }

            public Model.ModelsUpdateUserPointAdminV1Response? Execute(
                ModelsUpdateUserPointAdminV1Request body,
                string leaderboardCode,
                string namespace_,
                string userId
            )
            {
                UpdateUserPointAdminV1 op = Build(
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
            public async Task<Model.ModelsUpdateUserPointAdminV1Response?> ExecuteAsync(
                ModelsUpdateUserPointAdminV1Request body,
                string leaderboardCode,
                string namespace_,
                string userId
            )
            {
                UpdateUserPointAdminV1 op = Build(
                    body,
                    leaderboardCode,
                    namespace_,
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

        private UpdateUserPointAdminV1(UpdateUserPointAdminV1Builder builder,
            ModelsUpdateUserPointAdminV1Request body,
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

        public UpdateUserPointAdminV1(
            string leaderboardCode,
            string namespace_,
            string userId,
            Model.ModelsUpdateUserPointAdminV1Request body
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsUpdateUserPointAdminV1Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsUpdateUserPointAdminV1Response>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsUpdateUserPointAdminV1Response>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
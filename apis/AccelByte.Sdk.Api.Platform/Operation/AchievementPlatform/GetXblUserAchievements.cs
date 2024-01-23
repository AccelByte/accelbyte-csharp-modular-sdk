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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// getXblUserAchievements
    ///
    /// This API is used to get xbox live user achievements(Only for test).
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource=ADMIN:NAMESPACE:{namespace}:USER:{userId}:ACHIEVEMENT, action=2 (READ)
    /// </summary>
    public class GetXblUserAchievements : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetXblUserAchievementsBuilder Builder { get => new GetXblUserAchievementsBuilder(); }

        public class GetXblUserAchievementsBuilder
            : OperationBuilder<GetXblUserAchievementsBuilder>
        {





            internal GetXblUserAchievementsBuilder() { }

            internal GetXblUserAchievementsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetXblUserAchievements Build(
                string namespace_,
                string userId,
                string xboxUserId
            )
            {
                GetXblUserAchievements op = new GetXblUserAchievements(this,
                    namespace_,
                    userId,
                    xboxUserId
                );

                op.SetBaseFields<GetXblUserAchievementsBuilder>(this);
                return op;
            }

            public Model.XblUserAchievements? Execute(
                string namespace_,
                string userId,
                string xboxUserId
            )
            {
                GetXblUserAchievements op = Build(
                    namespace_,
                    userId,
                    xboxUserId
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

        private GetXblUserAchievements(GetXblUserAchievementsBuilder builder,
            string namespace_,
            string userId,
            string xboxUserId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (xboxUserId is not null) QueryParams["xboxUserId"] = xboxUserId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetXblUserAchievements(
            string namespace_,
            string userId,
            string xboxUserId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (xboxUserId is not null) QueryParams["xboxUserId"] = xboxUserId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/achievement/xbl";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.XblUserAchievements? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.XblUserAchievements>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.XblUserAchievements>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
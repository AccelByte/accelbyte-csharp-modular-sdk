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

using AccelByte.Sdk.Api.Seasonpass.Model;

namespace AccelByte.Sdk.Api.Seasonpass.Operation
{
    /// <summary>
    /// getCurrentUserSeasonProgression
    ///
    /// This API is used to get current user season progression, season only located in non-publisher namespace.
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : user season progression
    /// </summary>
    public class GetCurrentUserSeasonProgression : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetCurrentUserSeasonProgressionBuilder Builder { get => new GetCurrentUserSeasonProgressionBuilder(); }

        public class GetCurrentUserSeasonProgressionBuilder
            : OperationBuilder<GetCurrentUserSeasonProgressionBuilder>
        {





            internal GetCurrentUserSeasonProgressionBuilder() { }

            internal GetCurrentUserSeasonProgressionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetCurrentUserSeasonProgression Build(
                string namespace_,
                string userId
            )
            {
                GetCurrentUserSeasonProgression op = new GetCurrentUserSeasonProgression(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<GetCurrentUserSeasonProgressionBuilder>(this);
                return op;
            }

            public Model.UserSeasonSummary? Execute(
                string namespace_,
                string userId
            )
            {
                GetCurrentUserSeasonProgression op = Build(
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
            public async Task<Model.UserSeasonSummary?> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                GetCurrentUserSeasonProgression op = Build(
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

        private GetCurrentUserSeasonProgression(GetCurrentUserSeasonProgressionBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetCurrentUserSeasonProgression(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/current/progression";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.UserSeasonSummary? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.UserSeasonSummary>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UserSeasonSummary>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
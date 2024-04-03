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
    /// SetUserVisibilityV3
    ///
    /// User with false visibility status will have hidden attribute set to true on it's leaderboard entry
    /// </summary>
    public class SetUserVisibilityV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SetUserVisibilityV3Builder Builder { get => new SetUserVisibilityV3Builder(); }

        public class SetUserVisibilityV3Builder
            : OperationBuilder<SetUserVisibilityV3Builder>
        {





            internal SetUserVisibilityV3Builder() { }

            internal SetUserVisibilityV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public SetUserVisibilityV3 Build(
                ModelsSetUserVisibilityRequest body,
                string namespace_,
                string userId
            )
            {
                SetUserVisibilityV3 op = new SetUserVisibilityV3(this,
                    body,
                    namespace_,
                    userId
                );

                op.SetBaseFields<SetUserVisibilityV3Builder>(this);
                return op;
            }

            public Model.ModelsGetUserVisibilityResponse? Execute(
                ModelsSetUserVisibilityRequest body,
                string namespace_,
                string userId
            )
            {
                SetUserVisibilityV3 op = Build(
                    body,
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
            public async Task<Model.ModelsGetUserVisibilityResponse?> ExecuteAsync(
                ModelsSetUserVisibilityRequest body,
                string namespace_,
                string userId
            )
            {
                SetUserVisibilityV3 op = Build(
                    body,
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

        private SetUserVisibilityV3(SetUserVisibilityV3Builder builder,
            ModelsSetUserVisibilityRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SetUserVisibilityV3(
            string namespace_,
            string userId,
            Model.ModelsSetUserVisibilityRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v3/admin/namespaces/{namespace}/users/{userId}/visibility";

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
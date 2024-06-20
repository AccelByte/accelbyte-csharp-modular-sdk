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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// getUserPlatformAccountClosureHistories
    ///
    /// Get user platform account closure history.
    /// </summary>
    public class GetUserPlatformAccountClosureHistories : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserPlatformAccountClosureHistoriesBuilder Builder { get => new GetUserPlatformAccountClosureHistoriesBuilder(); }

        public class GetUserPlatformAccountClosureHistoriesBuilder
            : OperationBuilder<GetUserPlatformAccountClosureHistoriesBuilder>
        {





            internal GetUserPlatformAccountClosureHistoriesBuilder() { }

            internal GetUserPlatformAccountClosureHistoriesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetUserPlatformAccountClosureHistories Build(
                string namespace_,
                string userId
            )
            {
                GetUserPlatformAccountClosureHistories op = new GetUserPlatformAccountClosureHistories(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<GetUserPlatformAccountClosureHistoriesBuilder>(this);
                return op;
            }

            public List<Model.PlatformAccountClosureHistoryInfo>? Execute(
                string namespace_,
                string userId
            )
            {
                GetUserPlatformAccountClosureHistories op = Build(
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
            public async Task<List<Model.PlatformAccountClosureHistoryInfo>?> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                GetUserPlatformAccountClosureHistories op = Build(
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

        private GetUserPlatformAccountClosureHistories(GetUserPlatformAccountClosureHistoriesBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserPlatformAccountClosureHistories(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/platform/closure/history";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.PlatformAccountClosureHistoryInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.PlatformAccountClosureHistoryInfo>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.PlatformAccountClosureHistoryInfo>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
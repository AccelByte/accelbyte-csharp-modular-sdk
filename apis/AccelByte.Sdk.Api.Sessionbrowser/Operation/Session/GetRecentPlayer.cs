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

using AccelByte.Sdk.Api.Sessionbrowser.Model;

namespace AccelByte.Sdk.Api.Sessionbrowser.Operation
{
    /// <summary>
    /// GetRecentPlayer
    ///
    /// Query recent player by user ID
    /// </summary>
    public class GetRecentPlayer : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetRecentPlayerBuilder Builder { get => new GetRecentPlayerBuilder(); }

        public class GetRecentPlayerBuilder
            : OperationBuilder<GetRecentPlayerBuilder>
        {





            internal GetRecentPlayerBuilder() { }

            internal GetRecentPlayerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetRecentPlayer Build(
                string namespace_,
                string userID
            )
            {
                GetRecentPlayer op = new GetRecentPlayer(this,
                    namespace_,
                    userID
                );

                op.SetBaseFields<GetRecentPlayerBuilder>(this);
                return op;
            }

            public Model.ModelsRecentPlayerQueryResponse? Execute(
                string namespace_,
                string userID
            )
            {
                GetRecentPlayer op = Build(
                    namespace_,
                    userID
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.ModelsRecentPlayerQueryResponse?> ExecuteAsync(
                string namespace_,
                string userID
            )
            {
                GetRecentPlayer op = Build(
                    namespace_,
                    userID
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

        private GetRecentPlayer(GetRecentPlayerBuilder builder,
            string namespace_,
            string userID
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userID"] = userID;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetRecentPlayer(
            string namespace_,
            string userID
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userID"] = userID;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionbrowser/namespaces/{namespace}/recentplayer/{userID}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsRecentPlayerQueryResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsRecentPlayerQueryResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsRecentPlayerQueryResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
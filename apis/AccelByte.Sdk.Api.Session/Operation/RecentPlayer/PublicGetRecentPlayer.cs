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

using AccelByte.Sdk.Api.Session.Model;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// publicGetRecentPlayer
    ///
    /// Query user's recent player.
    /// </summary>
    public class PublicGetRecentPlayer : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetRecentPlayerBuilder Builder { get => new PublicGetRecentPlayerBuilder(); }

        public class PublicGetRecentPlayerBuilder
            : OperationBuilder<PublicGetRecentPlayerBuilder>
        {

            public long? Limit { get; set; }





            internal PublicGetRecentPlayerBuilder() { }

            internal PublicGetRecentPlayerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicGetRecentPlayerBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }





            public PublicGetRecentPlayer Build(
                string namespace_
            )
            {
                PublicGetRecentPlayer op = new PublicGetRecentPlayer(this,
                    namespace_
                );

                op.SetBaseFields<PublicGetRecentPlayerBuilder>(this);
                return op;
            }

            public Model.ModelsRecentPlayerQueryResponse? Execute(
                string namespace_
            )
            {
                PublicGetRecentPlayer op = Build(
                    namespace_
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
                string namespace_
            )
            {
                PublicGetRecentPlayer op = Build(
                    namespace_
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

        private PublicGetRecentPlayer(PublicGetRecentPlayerBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetRecentPlayer(
            string namespace_,
            long? limit
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/recent-player";

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
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

using AccelByte.Sdk.Api.Sessionbrowser.Model;

namespace AccelByte.Sdk.Api.Sessionbrowser.Operation
{
    /// <summary>
    /// GetSessionHistoryDetailed
    ///
    /// Get session history detailed.
    /// 
    /// if party_id value empty/null, field will not show in response body.
    /// </summary>
    public class GetSessionHistoryDetailed : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetSessionHistoryDetailedBuilder Builder { get => new GetSessionHistoryDetailedBuilder(); }

        public class GetSessionHistoryDetailedBuilder
            : OperationBuilder<GetSessionHistoryDetailedBuilder>
        {





            internal GetSessionHistoryDetailedBuilder() { }

            internal GetSessionHistoryDetailedBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetSessionHistoryDetailed Build(
                string matchID,
                string namespace_
            )
            {
                GetSessionHistoryDetailed op = new GetSessionHistoryDetailed(this,
                    matchID,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public List<Model.ModelsGetSessionHistoryDetailedResponseItem>? Execute(
                string matchID,
                string namespace_
            )
            {
                GetSessionHistoryDetailed op = Build(
                    matchID,
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
        }

        private GetSessionHistoryDetailed(GetSessionHistoryDetailedBuilder builder,
            string matchID,
            string namespace_
        )
        {
            PathParams["matchID"] = matchID;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetSessionHistoryDetailed(
            string matchID,
            string namespace_
        )
        {
            PathParams["matchID"] = matchID;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionbrowser/admin/namespaces/{namespace}/sessions/{matchID}/history/detailed";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.ModelsGetSessionHistoryDetailedResponseItem>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsGetSessionHistoryDetailedResponseItem>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsGetSessionHistoryDetailedResponseItem>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
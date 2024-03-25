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

using AccelByte.Sdk.Api.Session.Model;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// publicUpdateInsertSessionStorageLeader
    ///
    /// 
    /// Update Insert Session Storage Leader. only Leader can update or insert user session storage data Leader.
    /// can store generic json
    /// example json can store :
    /// {
    /// "leader": {
    /// "leader": 1
    /// },
    /// "data": 123
    /// }
    /// game Admin can update or insert session storage
    /// Session Storage feature only available for Gamesession
    /// </summary>
    public class PublicUpdateInsertSessionStorageLeader : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpdateInsertSessionStorageLeaderBuilder Builder { get => new PublicUpdateInsertSessionStorageLeaderBuilder(); }

        public class PublicUpdateInsertSessionStorageLeaderBuilder
            : OperationBuilder<PublicUpdateInsertSessionStorageLeaderBuilder>
        {





            internal PublicUpdateInsertSessionStorageLeaderBuilder() { }

            internal PublicUpdateInsertSessionStorageLeaderBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicUpdateInsertSessionStorageLeader Build(
                Dictionary<string, object> body,
                string namespace_,
                string sessionId
            )
            {
                PublicUpdateInsertSessionStorageLeader op = new PublicUpdateInsertSessionStorageLeader(this,
                    body,
                    namespace_,
                    sessionId
                );

                op.SetBaseFields<PublicUpdateInsertSessionStorageLeaderBuilder>(this);
                return op;
            }

            public Dictionary<string, object>? Execute(
                Dictionary<string, object> body,
                string namespace_,
                string sessionId
            )
            {
                PublicUpdateInsertSessionStorageLeader op = Build(
                    body,
                    namespace_,
                    sessionId
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

        private PublicUpdateInsertSessionStorageLeader(PublicUpdateInsertSessionStorageLeaderBuilder builder,
            Dictionary<string, object> body,
            string namespace_,
            string sessionId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicUpdateInsertSessionStorageLeader(
            string namespace_,
            string sessionId,
            Dictionary<string, object> body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/sessions/{sessionId}/storage/leader";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Dictionary<string, object>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Dictionary<string, object>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Dictionary<string, object>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
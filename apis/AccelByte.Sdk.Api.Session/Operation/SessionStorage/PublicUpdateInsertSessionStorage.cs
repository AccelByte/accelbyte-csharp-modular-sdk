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
    /// publicUpdateInsertSessionStorage
    ///
    /// 
    /// Update Insert Session Storage User. user can only update or insert user session storage data itself.
    /// can store generic json
    /// example json can store :
    /// {
    /// "storage": {
    /// "storage": 1
    /// },
    /// "data": 123
    /// }
    /// </summary>
    public class PublicUpdateInsertSessionStorage : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpdateInsertSessionStorageBuilder Builder { get => new PublicUpdateInsertSessionStorageBuilder(); }

        public class PublicUpdateInsertSessionStorageBuilder
            : OperationBuilder<PublicUpdateInsertSessionStorageBuilder>
        {





            internal PublicUpdateInsertSessionStorageBuilder() { }

            internal PublicUpdateInsertSessionStorageBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicUpdateInsertSessionStorage Build(
                Dictionary<string, object> body,
                string namespace_,
                string sessionId,
                string userId
            )
            {
                PublicUpdateInsertSessionStorage op = new PublicUpdateInsertSessionStorage(this,
                    body,
                    namespace_,
                    sessionId,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Dictionary<string, object>? Execute(
                Dictionary<string, object> body,
                string namespace_,
                string sessionId,
                string userId
            )
            {
                PublicUpdateInsertSessionStorage op = Build(
                    body,
                    namespace_,
                    sessionId,
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

        private PublicUpdateInsertSessionStorage(PublicUpdateInsertSessionStorageBuilder builder,
            Dictionary<string, object> body,
            string namespace_,
            string sessionId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicUpdateInsertSessionStorage(
            string namespace_,
            string sessionId,
            string userId,
            Dictionary<string, object> body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/sessions/{sessionId}/storage/users/{userId}";

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
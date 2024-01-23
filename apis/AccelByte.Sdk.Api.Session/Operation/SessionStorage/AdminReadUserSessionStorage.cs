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
    /// adminReadUserSessionStorage
    ///
    /// 
    /// Read Session Storage User.
    /// </summary>
    public class AdminReadUserSessionStorage : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminReadUserSessionStorageBuilder Builder { get => new AdminReadUserSessionStorageBuilder(); }

        public class AdminReadUserSessionStorageBuilder
            : OperationBuilder<AdminReadUserSessionStorageBuilder>
        {





            internal AdminReadUserSessionStorageBuilder() { }

            internal AdminReadUserSessionStorageBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminReadUserSessionStorage Build(
                string namespace_,
                string sessionId,
                string userId
            )
            {
                AdminReadUserSessionStorage op = new AdminReadUserSessionStorage(this,
                    namespace_,
                    sessionId,
                    userId
                );

                op.SetBaseFields<AdminReadUserSessionStorageBuilder>(this);
                return op;
            }

            public Dictionary<string, object>? Execute(
                string namespace_,
                string sessionId,
                string userId
            )
            {
                AdminReadUserSessionStorage op = Build(
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

        private AdminReadUserSessionStorage(AdminReadUserSessionStorageBuilder builder,
            string namespace_,
            string sessionId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminReadUserSessionStorage(
            string namespace_,
            string sessionId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/namespaces/{namespace}/sessions/{sessionId}/storage/users/{userId}";

        public override HttpMethod Method => HttpMethod.Get;

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
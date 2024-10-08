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
    /// registerXblSessions
    ///
    /// This API is used to register/update a session on xbox.
    /// </summary>
    public class RegisterXblSessions : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RegisterXblSessionsBuilder Builder { get => new RegisterXblSessionsBuilder(); }

        public class RegisterXblSessionsBuilder
            : OperationBuilder<RegisterXblSessionsBuilder>
        {





            internal RegisterXblSessionsBuilder() { }

            internal RegisterXblSessionsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public RegisterXblSessions Build(
                XblUserSessionRequest body,
                string namespace_,
                string userId
            )
            {
                RegisterXblSessions op = new RegisterXblSessions(this,
                    body,
                    namespace_,
                    userId
                );

                op.SetBaseFields<RegisterXblSessionsBuilder>(this);
                return op;
            }

            public Dictionary<string, object>? Execute(
                XblUserSessionRequest body,
                string namespace_,
                string userId
            )
            {
                RegisterXblSessions op = Build(
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
            public async Task<Dictionary<string, object>?> ExecuteAsync(
                XblUserSessionRequest body,
                string namespace_,
                string userId
            )
            {
                RegisterXblSessions op = Build(
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

        private RegisterXblSessions(RegisterXblSessionsBuilder builder,
            XblUserSessionRequest body,
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

        public RegisterXblSessions(
            string namespace_,
            string userId,
            Model.XblUserSessionRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/session/xbl";

        public override HttpMethod Method => HttpMethod.Put;

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
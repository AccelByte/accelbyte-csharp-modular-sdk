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
    /// adminKickGameSessionMember
    ///
    /// Kick member from a game session.
    /// </summary>
    public class AdminKickGameSessionMember : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminKickGameSessionMemberBuilder Builder { get => new AdminKickGameSessionMemberBuilder(); }

        public class AdminKickGameSessionMemberBuilder
            : OperationBuilder<AdminKickGameSessionMemberBuilder>
        {





            internal AdminKickGameSessionMemberBuilder() { }

            internal AdminKickGameSessionMemberBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminKickGameSessionMember Build(
                string memberId,
                string namespace_,
                string sessionId
            )
            {
                AdminKickGameSessionMember op = new AdminKickGameSessionMember(this,
                    memberId,
                    namespace_,
                    sessionId
                );

                op.SetBaseFields<AdminKickGameSessionMemberBuilder>(this);
                return op;
            }

            public void Execute(
                string memberId,
                string namespace_,
                string sessionId
            )
            {
                AdminKickGameSessionMember op = Build(
                    memberId,
                    namespace_,
                    sessionId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task ExecuteAsync(
                string memberId,
                string namespace_,
                string sessionId
            )
            {
                AdminKickGameSessionMember op = Build(
                    memberId,
                    namespace_,
                    sessionId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private AdminKickGameSessionMember(AdminKickGameSessionMemberBuilder builder,
            string memberId,
            string namespace_,
            string sessionId
        )
        {
            PathParams["memberId"] = memberId;
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminKickGameSessionMember(
            string memberId,
            string namespace_,
            string sessionId
        )
        {
            PathParams["memberId"] = memberId;
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/namespaces/{namespace}/gamesessions/{sessionId}/members/{memberId}/kick";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
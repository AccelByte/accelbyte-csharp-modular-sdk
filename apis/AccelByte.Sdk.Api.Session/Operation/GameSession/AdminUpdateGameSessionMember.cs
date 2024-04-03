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
    /// adminUpdateGameSessionMember
    ///
    /// Update a game session member status.
    /// </summary>
    public class AdminUpdateGameSessionMember : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateGameSessionMemberBuilder Builder { get => new AdminUpdateGameSessionMemberBuilder(); }

        public class AdminUpdateGameSessionMemberBuilder
            : OperationBuilder<AdminUpdateGameSessionMemberBuilder>
        {





            internal AdminUpdateGameSessionMemberBuilder() { }

            internal AdminUpdateGameSessionMemberBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpdateGameSessionMember Build(
                string memberId,
                string namespace_,
                string sessionId,
                string statusType
            )
            {
                AdminUpdateGameSessionMember op = new AdminUpdateGameSessionMember(this,
                    memberId,
                    namespace_,
                    sessionId,
                    statusType
                );

                op.SetBaseFields<AdminUpdateGameSessionMemberBuilder>(this);
                return op;
            }

            public Model.ApimodelsUpdateGameSessionMemberStatusResponse? Execute(
                string memberId,
                string namespace_,
                string sessionId,
                string statusType
            )
            {
                AdminUpdateGameSessionMember op = Build(
                    memberId,
                    namespace_,
                    sessionId,
                    statusType
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.ApimodelsUpdateGameSessionMemberStatusResponse?> ExecuteAsync(
                string memberId,
                string namespace_,
                string sessionId,
                string statusType
            )
            {
                AdminUpdateGameSessionMember op = Build(
                    memberId,
                    namespace_,
                    sessionId,
                    statusType
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

        private AdminUpdateGameSessionMember(AdminUpdateGameSessionMemberBuilder builder,
            string memberId,
            string namespace_,
            string sessionId,
            string statusType
        )
        {
            PathParams["memberId"] = memberId;
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;
            PathParams["statusType"] = statusType;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateGameSessionMember(
            string memberId,
            string namespace_,
            string sessionId,
            string statusType
        )
        {
            PathParams["memberId"] = memberId;
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;
            PathParams["statusType"] = statusType;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/namespaces/{namespace}/gamesessions/{sessionId}/members/{memberId}/status/{statusType}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApimodelsUpdateGameSessionMemberStatusResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsUpdateGameSessionMemberStatusResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsUpdateGameSessionMemberStatusResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
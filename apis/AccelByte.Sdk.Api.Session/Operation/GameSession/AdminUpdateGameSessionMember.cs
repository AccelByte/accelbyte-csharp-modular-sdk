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

            public AdminUpdateGameSessionMember.Response Execute(
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
            public async Task<AdminUpdateGameSessionMember.Response> ExecuteAsync(
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

        #region Response Part        
        public class Response : ApiResponse<Model.ApimodelsUpdateGameSessionMemberStatusResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Session::GameSession::AdminUpdateGameSessionMember";
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

        public AdminUpdateGameSessionMember.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminUpdateGameSessionMember.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.ApimodelsUpdateGameSessionMemberStatusResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
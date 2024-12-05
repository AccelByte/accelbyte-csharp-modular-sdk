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

using AccelByte.Sdk.Api.Group.Model;

namespace AccelByte.Sdk.Api.Group.Operation
{
    /// <summary>
    /// rejectGroupInvitationPublicV1
    ///
    /// Required valid user authentication
    /// 
    /// This endpoint is used to reject group invitation.
    /// 
    /// Reject group invitation. If specific user is not invited in the specific group ID, it will show the the error to show if the user is not invited yet.
    /// 
    /// Action Code: 73402
    /// </summary>
    public class RejectGroupInvitationPublicV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RejectGroupInvitationPublicV1Builder Builder { get => new RejectGroupInvitationPublicV1Builder(); }

        public class RejectGroupInvitationPublicV1Builder
            : OperationBuilder<RejectGroupInvitationPublicV1Builder>
        {





            internal RejectGroupInvitationPublicV1Builder() { }

            internal RejectGroupInvitationPublicV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public RejectGroupInvitationPublicV1 Build(
                string groupId,
                string namespace_
            )
            {
                RejectGroupInvitationPublicV1 op = new RejectGroupInvitationPublicV1(this,
                    groupId,
                    namespace_
                );

                op.SetBaseFields<RejectGroupInvitationPublicV1Builder>(this);
                return op;
            }

            public RejectGroupInvitationPublicV1.Response Execute(
                string groupId,
                string namespace_
            )
            {
                RejectGroupInvitationPublicV1 op = Build(
                    groupId,
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
            public async Task<RejectGroupInvitationPublicV1.Response> ExecuteAsync(
                string groupId,
                string namespace_
            )
            {
                RejectGroupInvitationPublicV1 op = Build(
                    groupId,
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

        private RejectGroupInvitationPublicV1(RejectGroupInvitationPublicV1Builder builder,
            string groupId,
            string namespace_
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsMemberRequestGroupResponseV1>
        {

            public ResponseErrorResponse? Error400 { get; set; } = null;

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error404 { get; set; } = null;

            public ResponseErrorResponse? Error409 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Group::GroupMember::RejectGroupInvitationPublicV1";
        }

        #endregion

        public RejectGroupInvitationPublicV1(
            string groupId,
            string namespace_
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v1/public/namespaces/{namespace}/groups/{groupId}/invite/reject";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public RejectGroupInvitationPublicV1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new RejectGroupInvitationPublicV1.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsMemberRequestGroupResponseV1>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
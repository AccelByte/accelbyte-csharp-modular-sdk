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
    /// deleteMemberRolePublicV2
    ///
    /// Required Member Role Permission: "GROUP:ROLE [UPDATE]"
    /// 
    /// This endpoint is used to remove role from group member
    /// 
    /// Action Code: 73204
    /// </summary>
    public class DeleteMemberRolePublicV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteMemberRolePublicV2Builder Builder { get => new DeleteMemberRolePublicV2Builder(); }

        public class DeleteMemberRolePublicV2Builder
            : OperationBuilder<DeleteMemberRolePublicV2Builder>
        {





            internal DeleteMemberRolePublicV2Builder() { }

            internal DeleteMemberRolePublicV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteMemberRolePublicV2 Build(
                ModelsRemoveRoleFromMemberRequestV1 body,
                string groupId,
                string memberRoleId,
                string namespace_
            )
            {
                DeleteMemberRolePublicV2 op = new DeleteMemberRolePublicV2(this,
                    body,
                    groupId,
                    memberRoleId,
                    namespace_
                );

                op.SetBaseFields<DeleteMemberRolePublicV2Builder>(this);
                return op;
            }

            public DeleteMemberRolePublicV2.Response Execute(
                ModelsRemoveRoleFromMemberRequestV1 body,
                string groupId,
                string memberRoleId,
                string namespace_
            )
            {
                DeleteMemberRolePublicV2 op = Build(
                    body,
                    groupId,
                    memberRoleId,
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
            public async Task<DeleteMemberRolePublicV2.Response> ExecuteAsync(
                ModelsRemoveRoleFromMemberRequestV1 body,
                string groupId,
                string memberRoleId,
                string namespace_
            )
            {
                DeleteMemberRolePublicV2 op = Build(
                    body,
                    groupId,
                    memberRoleId,
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

        private DeleteMemberRolePublicV2(DeleteMemberRolePublicV2Builder builder,
            ModelsRemoveRoleFromMemberRequestV1 body,
            string groupId,
            string memberRoleId,
            string namespace_
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["memberRoleId"] = memberRoleId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ResponseErrorResponse? Error400 { get; set; } = null;

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error404 { get; set; } = null;

            public ResponseErrorResponse? Error422 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Group::GroupRoles::DeleteMemberRolePublicV2";
        }

        #endregion

        public DeleteMemberRolePublicV2(
            string groupId,
            string memberRoleId,
            string namespace_,
            Model.ModelsRemoveRoleFromMemberRequestV1 body
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["memberRoleId"] = memberRoleId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v2/public/namespaces/{namespace}/roles/{memberRoleId}/groups/{groupId}/members";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public DeleteMemberRolePublicV2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DeleteMemberRolePublicV2.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)

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
            else if (code == (HttpStatusCode)422)

            {
                response.Error422 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error422!.TranslateToApiError();
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
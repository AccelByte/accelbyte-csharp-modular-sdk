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
    /// updateMemberRolePublicV2
    ///
    /// Required Member Role Permission: "GROUP:ROLE [UPDATE]
    /// 
    /// This endpoint is used to assign role to group member
    /// 
    /// Action Code: 73204
    /// </summary>
    public class UpdateMemberRolePublicV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateMemberRolePublicV2Builder Builder { get => new UpdateMemberRolePublicV2Builder(); }

        public class UpdateMemberRolePublicV2Builder
            : OperationBuilder<UpdateMemberRolePublicV2Builder>
        {





            internal UpdateMemberRolePublicV2Builder() { }

            internal UpdateMemberRolePublicV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateMemberRolePublicV2 Build(
                ModelsAssignRoleToMemberRequestV1 body,
                string groupId,
                string memberRoleId,
                string namespace_
            )
            {
                UpdateMemberRolePublicV2 op = new UpdateMemberRolePublicV2(this,
                    body,                    
                    groupId,                    
                    memberRoleId,                    
                    namespace_                    
                );

                op.SetBaseFields<UpdateMemberRolePublicV2Builder>(this);
                return op;
            }

            public UpdateMemberRolePublicV2.Response Execute(
                ModelsAssignRoleToMemberRequestV1 body,
                string groupId,
                string memberRoleId,
                string namespace_
            )
            {
                UpdateMemberRolePublicV2 op = Build(
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
            public async Task<UpdateMemberRolePublicV2.Response> ExecuteAsync(
                ModelsAssignRoleToMemberRequestV1 body,
                string groupId,
                string memberRoleId,
                string namespace_
            )
            {
                UpdateMemberRolePublicV2 op = Build(
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

        private UpdateMemberRolePublicV2(UpdateMemberRolePublicV2Builder builder,
            ModelsAssignRoleToMemberRequestV1 body,
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
        public class Response : ApiResponse<Model.ModelsGetUserGroupInformationResponseV1>
        {

            public ResponseErrorResponse? Error400 { get; set; } = null;

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error404 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Group::GroupRoles::UpdateMemberRolePublicV2";
        }

        #endregion

        public UpdateMemberRolePublicV2(
            string groupId,            
            string memberRoleId,            
            string namespace_,            
            Model.ModelsAssignRoleToMemberRequestV1 body            
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["memberRoleId"] = memberRoleId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v2/public/namespaces/{namespace}/roles/{memberRoleId}/groups/{groupId}/members";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public UpdateMemberRolePublicV2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdateMemberRolePublicV2.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsGetUserGroupInformationResponseV1>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
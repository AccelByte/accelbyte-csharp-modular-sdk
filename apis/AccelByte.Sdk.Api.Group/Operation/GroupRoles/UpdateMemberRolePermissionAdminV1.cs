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
    /// updateMemberRolePermissionAdminV1
    ///
    /// 
    /// 
    /// Required permission ADMIN:NAMESPACE:{namespace}:GROUP:ROLE [UPDATE]
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to update member role permission. It will replace the existing permission based on the request from this endpoint
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73205
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// memberRolePermissions example value :
    /// 
    /// 
    /// 
    /// 
    /// "action": 2
    /// 
    /// 
    /// 
    /// 
    /// "resourceName": "GROUP:ROLE"
    /// 
    /// 
    /// 
    /// 
    /// The changes will update user role to be able to read a role of other member
    /// </summary>
    public class UpdateMemberRolePermissionAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateMemberRolePermissionAdminV1Builder Builder { get => new UpdateMemberRolePermissionAdminV1Builder(); }

        public class UpdateMemberRolePermissionAdminV1Builder
            : OperationBuilder<UpdateMemberRolePermissionAdminV1Builder>
        {





            internal UpdateMemberRolePermissionAdminV1Builder() { }

            internal UpdateMemberRolePermissionAdminV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateMemberRolePermissionAdminV1 Build(
                ModelsUpdateMemberRolePermissionsRequestV1 body,
                string memberRoleId,
                string namespace_
            )
            {
                UpdateMemberRolePermissionAdminV1 op = new UpdateMemberRolePermissionAdminV1(this,
                    body,
                    memberRoleId,
                    namespace_
                );

                op.SetBaseFields<UpdateMemberRolePermissionAdminV1Builder>(this);
                return op;
            }

            public Model.ModelsMemberRoleResponseV1? Execute(
                ModelsUpdateMemberRolePermissionsRequestV1 body,
                string memberRoleId,
                string namespace_
            )
            {
                UpdateMemberRolePermissionAdminV1 op = Build(
                    body,
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
            public async Task<Model.ModelsMemberRoleResponseV1?> ExecuteAsync(
                ModelsUpdateMemberRolePermissionsRequestV1 body,
                string memberRoleId,
                string namespace_
            )
            {
                UpdateMemberRolePermissionAdminV1 op = Build(
                    body,
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

        private UpdateMemberRolePermissionAdminV1(UpdateMemberRolePermissionAdminV1Builder builder,
            ModelsUpdateMemberRolePermissionsRequestV1 body,
            string memberRoleId,
            string namespace_
        )
        {
            PathParams["memberRoleId"] = memberRoleId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateMemberRolePermissionAdminV1(
            string memberRoleId,
            string namespace_,
            Model.ModelsUpdateMemberRolePermissionsRequestV1 body
        )
        {
            PathParams["memberRoleId"] = memberRoleId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v1/admin/namespaces/{namespace}/roles/{memberRoleId}/permissions";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsMemberRoleResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsMemberRoleResponseV1>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsMemberRoleResponseV1>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
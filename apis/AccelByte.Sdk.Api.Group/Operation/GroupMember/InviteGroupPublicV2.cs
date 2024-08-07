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
    /// inviteGroupPublicV2
    ///
    /// Required valid user authentication
    /// 
    /// Required Member Role Permission: "GROUP:INVITE [CREATE]"
    /// 
    /// This endpoint is used to invite specific user to the group.
    /// 
    /// invite specific user to the group. If specific user is already have the join request to the group, this endpoint will notify if this user already have join request that needs to be accepted / rejected
    /// 
    /// Invited user will receive notification through lobby.
    /// 
    /// Action Code: 73406
    /// 
    /// 
    /// 
    /// memberRolePermissions example value :
    /// 
    /// "action": 1
    /// 
    /// "resourceName": "GROUP:INVITE"
    /// 
    /// The invited user will have a permission to invite another user to the group
    /// </summary>
    public class InviteGroupPublicV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static InviteGroupPublicV2Builder Builder { get => new InviteGroupPublicV2Builder(); }

        public class InviteGroupPublicV2Builder
            : OperationBuilder<InviteGroupPublicV2Builder>
        {





            internal InviteGroupPublicV2Builder() { }

            internal InviteGroupPublicV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public InviteGroupPublicV2 Build(
                string groupId,
                string namespace_,
                string userId
            )
            {
                InviteGroupPublicV2 op = new InviteGroupPublicV2(this,
                    groupId,
                    namespace_,
                    userId
                );

                op.SetBaseFields<InviteGroupPublicV2Builder>(this);
                return op;
            }

            public Model.ModelsUserInvitationResponseV1? Execute(
                string groupId,
                string namespace_,
                string userId
            )
            {
                InviteGroupPublicV2 op = Build(
                    groupId,
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
            public async Task<Model.ModelsUserInvitationResponseV1?> ExecuteAsync(
                string groupId,
                string namespace_,
                string userId
            )
            {
                InviteGroupPublicV2 op = Build(
                    groupId,
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

        private InviteGroupPublicV2(InviteGroupPublicV2Builder builder,
            string groupId,
            string namespace_,
            string userId
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public InviteGroupPublicV2(
            string groupId,
            string namespace_,
            string userId
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v2/public/namespaces/{namespace}/users/{userId}/groups/{groupId}/invite";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsUserInvitationResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsUserInvitationResponseV1>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsUserInvitationResponseV1>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
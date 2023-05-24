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

using AccelByte.Sdk.Api.Group.Model;

namespace AccelByte.Sdk.Api.Group.Operation
{
    /// <summary>
    /// CancelInvitationGroupMemberV2
    ///
    /// 
    /// 
    /// Required valid user authentication
    /// 
    /// 
    /// 
    /// 
    /// Required Member Role Permission: "GROUP:INVITE [DELETE]"
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to cancel invitation group member.
    /// 
    /// 
    /// 
    /// 
    /// cancel invitation group member. This endpoint will cancel invitation to specific user, and also the role permission of the the user who accesses this endpoint
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73409
    /// </summary>
    public class CancelInvitationGroupMemberV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CancelInvitationGroupMemberV2Builder Builder { get => new CancelInvitationGroupMemberV2Builder(); }

        public class CancelInvitationGroupMemberV2Builder
            : OperationBuilder<CancelInvitationGroupMemberV2Builder>
        {





            internal CancelInvitationGroupMemberV2Builder() { }

            internal CancelInvitationGroupMemberV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CancelInvitationGroupMemberV2 Build(
                string groupId,
                string namespace_,
                string userId
            )
            {
                CancelInvitationGroupMemberV2 op = new CancelInvitationGroupMemberV2(this,
                    groupId,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelsCancelInvitationGroupResponseV2? Execute(
                string groupId,
                string namespace_,
                string userId
            )
            {
                CancelInvitationGroupMemberV2 op = Build(
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
        }

        private CancelInvitationGroupMemberV2(CancelInvitationGroupMemberV2Builder builder,
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

        public CancelInvitationGroupMemberV2(
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

        public override string Path => "/group/v2/public/namespaces/{namespace}/users/{userId}/groups/{groupId}/invite/cancel";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsCancelInvitationGroupResponseV2? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsCancelInvitationGroupResponseV2>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsCancelInvitationGroupResponseV2>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
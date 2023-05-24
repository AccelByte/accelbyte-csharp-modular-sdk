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
    /// acceptGroupInvitationPublicV1
    ///
    /// 
    /// 
    /// Required valid user authentication
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to accept group invitation.
    /// 
    /// 
    /// 
    /// 
    /// Accept group invitation. If specific user is not invited in the specific group ID, it will show the the error to show if the user is not invited yet.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint will also check if the user who access this endpoint is already joined to specific group
    /// 
    /// 
    /// 
    /// 
    /// Accessing this endpoint will make all requests (invite / join request) will be deleted for the user who access this endpoint
    /// 
    /// 
    /// 
    /// 
    /// Existing members will receive notification of newly accepted member.
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73401
    /// </summary>
    public class AcceptGroupInvitationPublicV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AcceptGroupInvitationPublicV1Builder Builder { get => new AcceptGroupInvitationPublicV1Builder(); }

        public class AcceptGroupInvitationPublicV1Builder
            : OperationBuilder<AcceptGroupInvitationPublicV1Builder>
        {





            internal AcceptGroupInvitationPublicV1Builder() { }

            internal AcceptGroupInvitationPublicV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AcceptGroupInvitationPublicV1 Build(
                string groupId,
                string namespace_
            )
            {
                AcceptGroupInvitationPublicV1 op = new AcceptGroupInvitationPublicV1(this,
                    groupId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelsMemberRequestGroupResponseV1? Execute(
                string groupId,
                string namespace_
            )
            {
                AcceptGroupInvitationPublicV1 op = Build(
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
        }

        private AcceptGroupInvitationPublicV1(AcceptGroupInvitationPublicV1Builder builder,
            string groupId,
            string namespace_
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AcceptGroupInvitationPublicV1(
            string groupId,
            string namespace_
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v1/public/namespaces/{namespace}/groups/{groupId}/invite/accept";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsMemberRequestGroupResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsMemberRequestGroupResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsMemberRequestGroupResponseV1>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
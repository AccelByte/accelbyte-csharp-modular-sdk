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

            public Model.ModelsMemberRequestGroupResponseV1? Execute(
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
            public async Task<Model.ModelsMemberRequestGroupResponseV1?> ExecuteAsync(
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

        public Model.ModelsMemberRequestGroupResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsMemberRequestGroupResponseV1>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsMemberRequestGroupResponseV1>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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
    /// leaveGroupPublicV2
    ///
    /// 
    /// 
    /// Required valid user authentication
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to leave from group.
    /// 
    /// 
    /// 
    /// 
    /// leave from group. Admin is not allowed to leave the group. This endpoint will also give response if the user does not belong to any group.
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73404
    /// </summary>
    public class LeaveGroupPublicV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static LeaveGroupPublicV2Builder Builder { get => new LeaveGroupPublicV2Builder(); }

        public class LeaveGroupPublicV2Builder
            : OperationBuilder<LeaveGroupPublicV2Builder>
        {





            internal LeaveGroupPublicV2Builder() { }

            internal LeaveGroupPublicV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public LeaveGroupPublicV2 Build(
                string groupId,
                string namespace_
            )
            {
                LeaveGroupPublicV2 op = new LeaveGroupPublicV2(this,
                    groupId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelsLeaveGroupResponseV1? Execute(
                string groupId,
                string namespace_
            )
            {
                LeaveGroupPublicV2 op = Build(
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

        private LeaveGroupPublicV2(LeaveGroupPublicV2Builder builder,
            string groupId,
            string namespace_
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public LeaveGroupPublicV2(
            string groupId,
            string namespace_
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v2/public/namespaces/{namespace}/groups/{groupId}/leave";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsLeaveGroupResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsLeaveGroupResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsLeaveGroupResponseV1>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
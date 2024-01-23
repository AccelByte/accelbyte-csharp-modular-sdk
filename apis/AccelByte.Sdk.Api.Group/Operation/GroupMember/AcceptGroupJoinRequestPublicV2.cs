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
    /// acceptGroupJoinRequestPublicV2
    ///
    /// 
    /// 
    /// Required valid user authentication
    /// 
    /// 
    /// 
    /// 
    /// Required Member Role Permission: "GROUP:JOIN [CREATE]"
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to accept group join request.
    /// 
    /// 
    /// 
    /// 
    /// Accept group join request. If specific user is not asked to join the specific group ID, it will show the the error to show if the user is not asked to join yet.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint will also check if the specific user is already joined to specific group
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73407
    /// </summary>
    public class AcceptGroupJoinRequestPublicV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AcceptGroupJoinRequestPublicV2Builder Builder { get => new AcceptGroupJoinRequestPublicV2Builder(); }

        public class AcceptGroupJoinRequestPublicV2Builder
            : OperationBuilder<AcceptGroupJoinRequestPublicV2Builder>
        {





            internal AcceptGroupJoinRequestPublicV2Builder() { }

            internal AcceptGroupJoinRequestPublicV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AcceptGroupJoinRequestPublicV2 Build(
                string groupId,
                string namespace_,
                string userId
            )
            {
                AcceptGroupJoinRequestPublicV2 op = new AcceptGroupJoinRequestPublicV2(this,
                    groupId,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AcceptGroupJoinRequestPublicV2Builder>(this);
                return op;
            }

            public Model.ModelsMemberRequestGroupResponseV1? Execute(
                string groupId,
                string namespace_,
                string userId
            )
            {
                AcceptGroupJoinRequestPublicV2 op = Build(
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

        private AcceptGroupJoinRequestPublicV2(AcceptGroupJoinRequestPublicV2Builder builder,
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

        public AcceptGroupJoinRequestPublicV2(
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

        public override string Path => "/group/v2/public/namespaces/{namespace}/users/{userId}/groups/{groupId}/join/accept";

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
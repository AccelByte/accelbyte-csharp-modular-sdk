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
    /// getGroupInvitationRequestPublicV1
    ///
    /// 
    /// 
    /// Required valid user authentication
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to Get Group Invitation Request List
    /// 
    /// 
    /// 
    /// 
    /// Get Group Invitation Request List for the user calling this endpoint. It will check any group invitation for this user
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73502
    /// </summary>
    public class GetGroupInvitationRequestPublicV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetGroupInvitationRequestPublicV1Builder Builder { get => new GetGroupInvitationRequestPublicV1Builder(); }

        public class GetGroupInvitationRequestPublicV1Builder
            : OperationBuilder<GetGroupInvitationRequestPublicV1Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal GetGroupInvitationRequestPublicV1Builder() { }

            internal GetGroupInvitationRequestPublicV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetGroupInvitationRequestPublicV1Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetGroupInvitationRequestPublicV1Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetGroupInvitationRequestPublicV1 Build(
                string namespace_
            )
            {
                GetGroupInvitationRequestPublicV1 op = new GetGroupInvitationRequestPublicV1(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelsGetMemberRequestsListResponseV1? Execute(
                string namespace_
            )
            {
                GetGroupInvitationRequestPublicV1 op = Build(
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

        private GetGroupInvitationRequestPublicV1(GetGroupInvitationRequestPublicV1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetGroupInvitationRequestPublicV1(
            string namespace_,
            long? limit,
            long? offset
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v1/public/namespaces/{namespace}/users/me/invite/request";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsGetMemberRequestsListResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetMemberRequestsListResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetMemberRequestsListResponseV1>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
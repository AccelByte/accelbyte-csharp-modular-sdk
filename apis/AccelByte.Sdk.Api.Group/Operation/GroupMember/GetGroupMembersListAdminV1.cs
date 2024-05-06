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
    /// getGroupMembersListAdminV1
    ///
    /// This endpoint is used to get list of group members.
    /// 
    /// Action Code: 73410
    /// </summary>
    public class GetGroupMembersListAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetGroupMembersListAdminV1Builder Builder { get => new GetGroupMembersListAdminV1Builder(); }

        public class GetGroupMembersListAdminV1Builder
            : OperationBuilder<GetGroupMembersListAdminV1Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? Order { get; set; }





            internal GetGroupMembersListAdminV1Builder() { }

            internal GetGroupMembersListAdminV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetGroupMembersListAdminV1Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetGroupMembersListAdminV1Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public GetGroupMembersListAdminV1Builder SetOrder(string _order)
            {
                Order = _order;
                return this;
            }





            public GetGroupMembersListAdminV1 Build(
                string groupId,
                string namespace_
            )
            {
                GetGroupMembersListAdminV1 op = new GetGroupMembersListAdminV1(this,
                    groupId,
                    namespace_
                );

                op.SetBaseFields<GetGroupMembersListAdminV1Builder>(this);
                return op;
            }

            public Model.ModelsGetGroupMemberListResponseV1? Execute(
                string groupId,
                string namespace_
            )
            {
                GetGroupMembersListAdminV1 op = Build(
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
            public async Task<Model.ModelsGetGroupMemberListResponseV1?> ExecuteAsync(
                string groupId,
                string namespace_
            )
            {
                GetGroupMembersListAdminV1 op = Build(
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

        private GetGroupMembersListAdminV1(GetGroupMembersListAdminV1Builder builder,
            string groupId,
            string namespace_
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Order is not null) QueryParams["order"] = builder.Order;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetGroupMembersListAdminV1(
            string groupId,
            string namespace_,
            long? limit,
            long? offset,
            string? order
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (order is not null) QueryParams["order"] = order;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v1/admin/namespaces/{namespace}/groups/{groupId}/members";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsGetGroupMemberListResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetGroupMemberListResponseV1>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetGroupMemberListResponseV1>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
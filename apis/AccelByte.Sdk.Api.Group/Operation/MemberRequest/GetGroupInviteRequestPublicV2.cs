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
    /// getGroupInviteRequestPublicV2
    ///
    /// Required valid user authentication
    /// 
    /// Required Member Role Permission: "GROUP:JOIN [READ]"
    /// 
    /// This endpoint is used to Get Group Invite Request List
    /// 
    /// Get Group Invite Request List for specific group. Group members needs to have permission and also belong to the group to access this endpoint
    /// 
    /// Action Code: 73501
    /// </summary>
    public class GetGroupInviteRequestPublicV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetGroupInviteRequestPublicV2Builder Builder { get => new GetGroupInviteRequestPublicV2Builder(); }

        public class GetGroupInviteRequestPublicV2Builder
            : OperationBuilder<GetGroupInviteRequestPublicV2Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal GetGroupInviteRequestPublicV2Builder() { }

            internal GetGroupInviteRequestPublicV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetGroupInviteRequestPublicV2Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetGroupInviteRequestPublicV2Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetGroupInviteRequestPublicV2 Build(
                string groupId,
                string namespace_
            )
            {
                GetGroupInviteRequestPublicV2 op = new GetGroupInviteRequestPublicV2(this,
                    groupId,                    
                    namespace_                    
                );

                op.SetBaseFields<GetGroupInviteRequestPublicV2Builder>(this);
                return op;
            }

            public GetGroupInviteRequestPublicV2.Response Execute(
                string groupId,
                string namespace_
            )
            {
                GetGroupInviteRequestPublicV2 op = Build(
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
            public async Task<GetGroupInviteRequestPublicV2.Response> ExecuteAsync(
                string groupId,
                string namespace_
            )
            {
                GetGroupInviteRequestPublicV2 op = Build(
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

        private GetGroupInviteRequestPublicV2(GetGroupInviteRequestPublicV2Builder builder,
            string groupId,
            string namespace_
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsGetMemberRequestsListResponseV1>
        {

            public ResponseErrorResponse? Error400 { get; set; } = null;

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Group::MemberRequest::GetGroupInviteRequestPublicV2";
        }

        #endregion

        public GetGroupInviteRequestPublicV2(
            string groupId,            
            string namespace_,            
            long? limit,            
            long? offset            
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v2/public/namespaces/{namespace}/groups/{groupId}/invite/request";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public GetGroupInviteRequestPublicV2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetGroupInviteRequestPublicV2.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsGetMemberRequestsListResponseV1>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
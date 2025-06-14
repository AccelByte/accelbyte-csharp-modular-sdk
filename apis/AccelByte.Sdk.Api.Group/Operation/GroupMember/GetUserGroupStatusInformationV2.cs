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
    /// GetUserGroupStatusInformationV2
    ///
    /// Required valid user authentication
    /// 
    /// Required Member Role Permission: "GROUP [READ]"
    /// 
    /// This endpoint is used to get user group status information.
    /// 
    /// get user group status information. This endpoint will check the member and group information, and also the role permission of the the user who accesses this endpoint
    /// 
    /// Action Code: 73409
    /// </summary>
    public class GetUserGroupStatusInformationV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserGroupStatusInformationV2Builder Builder { get => new GetUserGroupStatusInformationV2Builder(); }

        public class GetUserGroupStatusInformationV2Builder
            : OperationBuilder<GetUserGroupStatusInformationV2Builder>
        {





            internal GetUserGroupStatusInformationV2Builder() { }

            internal GetUserGroupStatusInformationV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetUserGroupStatusInformationV2 Build(
                string groupId,
                string namespace_,
                string userId
            )
            {
                GetUserGroupStatusInformationV2 op = new GetUserGroupStatusInformationV2(this,
                    groupId,                    
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<GetUserGroupStatusInformationV2Builder>(this);
                return op;
            }

            public GetUserGroupStatusInformationV2.Response Execute(
                string groupId,
                string namespace_,
                string userId
            )
            {
                GetUserGroupStatusInformationV2 op = Build(
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
            public async Task<GetUserGroupStatusInformationV2.Response> ExecuteAsync(
                string groupId,
                string namespace_,
                string userId
            )
            {
                GetUserGroupStatusInformationV2 op = Build(
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

        private GetUserGroupStatusInformationV2(GetUserGroupStatusInformationV2Builder builder,
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

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsGetUserGroupInformationResponseV1>
        {

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error404 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Group::GroupMember::GetUserGroupStatusInformationV2";
        }

        #endregion

        public GetUserGroupStatusInformationV2(
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

        public override string Path => "/group/v2/public/namespaces/{namespace}/users/{userId}/groups/{groupId}/status";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public GetUserGroupStatusInformationV2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetUserGroupStatusInformationV2.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsGetUserGroupInformationResponseV1>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
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
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
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
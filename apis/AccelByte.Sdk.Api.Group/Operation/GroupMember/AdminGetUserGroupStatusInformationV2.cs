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
    /// AdminGetUserGroupStatusInformationV2
    ///
    /// This endpoint is used to get user group status information.
    /// </summary>
    public class AdminGetUserGroupStatusInformationV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetUserGroupStatusInformationV2Builder Builder { get => new AdminGetUserGroupStatusInformationV2Builder(); }

        public class AdminGetUserGroupStatusInformationV2Builder
            : OperationBuilder<AdminGetUserGroupStatusInformationV2Builder>
        {





            internal AdminGetUserGroupStatusInformationV2Builder() { }

            internal AdminGetUserGroupStatusInformationV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetUserGroupStatusInformationV2 Build(
                string groupId,
                string namespace_,
                string userId
            )
            {
                AdminGetUserGroupStatusInformationV2 op = new AdminGetUserGroupStatusInformationV2(this,
                    groupId,                    
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<AdminGetUserGroupStatusInformationV2Builder>(this);
                return op;
            }

            public AdminGetUserGroupStatusInformationV2.Response Execute(
                string groupId,
                string namespace_,
                string userId
            )
            {
                AdminGetUserGroupStatusInformationV2 op = Build(
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
            public async Task<AdminGetUserGroupStatusInformationV2.Response> ExecuteAsync(
                string groupId,
                string namespace_,
                string userId
            )
            {
                AdminGetUserGroupStatusInformationV2 op = Build(
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

        private AdminGetUserGroupStatusInformationV2(AdminGetUserGroupStatusInformationV2Builder builder,
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


            protected override string GetFullOperationId() => "Group::GroupMember::AdminGetUserGroupStatusInformationV2";
        }

        #endregion

        public AdminGetUserGroupStatusInformationV2(
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

        public override string Path => "/group/v2/admin/namespaces/{namespace}/users/{userId}/groups/{groupId}/status";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminGetUserGroupStatusInformationV2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminGetUserGroupStatusInformationV2.Response()
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
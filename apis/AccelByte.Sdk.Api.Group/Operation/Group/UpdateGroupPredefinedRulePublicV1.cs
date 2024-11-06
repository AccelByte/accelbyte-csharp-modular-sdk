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
    /// updateGroupPredefinedRulePublicV1
    ///
    /// Required valid user authentication
    /// 
    /// Required Member Role Permission: "GROUP [UPDATE]"
    /// 
    /// Update predefined group rule. This endpoint will check the group ID of the user based on the access token and compare it with the group ID in path parameter. It will also check the member role of the user based on the access token
    /// 
    /// If the rule action is not defined in the group, it will be added immediately to the predefined group rule
    /// 
    /// Action Code: 73310
    /// </summary>
    public class UpdateGroupPredefinedRulePublicV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateGroupPredefinedRulePublicV1Builder Builder { get => new UpdateGroupPredefinedRulePublicV1Builder(); }

        public class UpdateGroupPredefinedRulePublicV1Builder
            : OperationBuilder<UpdateGroupPredefinedRulePublicV1Builder>
        {





            internal UpdateGroupPredefinedRulePublicV1Builder() { }

            internal UpdateGroupPredefinedRulePublicV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateGroupPredefinedRulePublicV1 Build(
                ModelsUpdateGroupPredefinedRuleRequestV1 body,
                string allowedAction,
                string groupId,
                string namespace_
            )
            {
                UpdateGroupPredefinedRulePublicV1 op = new UpdateGroupPredefinedRulePublicV1(this,
                    body,                    
                    allowedAction,                    
                    groupId,                    
                    namespace_                    
                );

                op.SetBaseFields<UpdateGroupPredefinedRulePublicV1Builder>(this);
                return op;
            }

            public UpdateGroupPredefinedRulePublicV1.Response Execute(
                ModelsUpdateGroupPredefinedRuleRequestV1 body,
                string allowedAction,
                string groupId,
                string namespace_
            )
            {
                UpdateGroupPredefinedRulePublicV1 op = Build(
                    body,
                    allowedAction,
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
            public async Task<UpdateGroupPredefinedRulePublicV1.Response> ExecuteAsync(
                ModelsUpdateGroupPredefinedRuleRequestV1 body,
                string allowedAction,
                string groupId,
                string namespace_
            )
            {
                UpdateGroupPredefinedRulePublicV1 op = Build(
                    body,
                    allowedAction,
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

            public UpdateGroupPredefinedRulePublicV1.Response<T1> Execute<T1>(
                ModelsUpdateGroupPredefinedRuleRequestV1 body,
                string allowedAction,
                string groupId,
                string namespace_
            )
            {
                UpdateGroupPredefinedRulePublicV1 op = Build(
                    body,
                    allowedAction,
                    groupId,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<UpdateGroupPredefinedRulePublicV1.Response<T1>> ExecuteAsync<T1>(
                ModelsUpdateGroupPredefinedRuleRequestV1 body,
                string allowedAction,
                string groupId,
                string namespace_
            )
            {
                UpdateGroupPredefinedRulePublicV1 op = Build(
                    body,
                    allowedAction,
                    groupId,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private UpdateGroupPredefinedRulePublicV1(UpdateGroupPredefinedRulePublicV1Builder builder,
            ModelsUpdateGroupPredefinedRuleRequestV1 body,
            string allowedAction,
            string groupId,
            string namespace_
        )
        {
            PathParams["allowedAction"] = allowedAction;
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsGroupResponseV1>
        {

            public ResponseErrorResponse? Error400 { get; set; } = null;

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error404 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Group::Group::UpdateGroupPredefinedRulePublicV1";
        }

        public class Response<T1> : ApiResponse<Model.ModelsGroupResponseV1<T1>>
        {
            public ResponseErrorResponse? Error400 { get; set; } = null;

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error404 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Group::Group::UpdateGroupPredefinedRulePublicV1";
        }
        #endregion

        public UpdateGroupPredefinedRulePublicV1(
            string allowedAction,            
            string groupId,            
            string namespace_,            
            Model.ModelsUpdateGroupPredefinedRuleRequestV1 body            
        )
        {
            PathParams["allowedAction"] = allowedAction;
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v1/public/namespaces/{namespace}/groups/{groupId}/rules/defined/{allowedAction}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public UpdateGroupPredefinedRulePublicV1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdateGroupPredefinedRulePublicV1.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsGroupResponseV1>(payload, ResponseJsonOptions);
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

        public UpdateGroupPredefinedRulePublicV1.Response<T1> ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdateGroupPredefinedRulePublicV1.Response<T1>()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsGroupResponseV1<T1>>(payload, ResponseJsonOptions);
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
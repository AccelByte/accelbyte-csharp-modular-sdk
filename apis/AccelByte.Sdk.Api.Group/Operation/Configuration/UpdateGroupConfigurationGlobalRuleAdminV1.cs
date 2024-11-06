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
    /// updateGroupConfigurationGlobalRuleAdminV1
    ///
    /// This endpoint is used to update existing global rule configuration based on the allowed action. It will replace the permission with the request
    /// 
    /// Action Code: 73106
    /// </summary>
    public class UpdateGroupConfigurationGlobalRuleAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateGroupConfigurationGlobalRuleAdminV1Builder Builder { get => new UpdateGroupConfigurationGlobalRuleAdminV1Builder(); }

        public class UpdateGroupConfigurationGlobalRuleAdminV1Builder
            : OperationBuilder<UpdateGroupConfigurationGlobalRuleAdminV1Builder>
        {





            internal UpdateGroupConfigurationGlobalRuleAdminV1Builder() { }

            internal UpdateGroupConfigurationGlobalRuleAdminV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateGroupConfigurationGlobalRuleAdminV1 Build(
                ModelsUpdateGroupConfigurationGlobalRulesRequestV1 body,
                string allowedAction,
                string configurationCode,
                string namespace_
            )
            {
                UpdateGroupConfigurationGlobalRuleAdminV1 op = new UpdateGroupConfigurationGlobalRuleAdminV1(this,
                    body,                    
                    allowedAction,                    
                    configurationCode,                    
                    namespace_                    
                );

                op.SetBaseFields<UpdateGroupConfigurationGlobalRuleAdminV1Builder>(this);
                return op;
            }

            public UpdateGroupConfigurationGlobalRuleAdminV1.Response Execute(
                ModelsUpdateGroupConfigurationGlobalRulesRequestV1 body,
                string allowedAction,
                string configurationCode,
                string namespace_
            )
            {
                UpdateGroupConfigurationGlobalRuleAdminV1 op = Build(
                    body,
                    allowedAction,
                    configurationCode,
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
            public async Task<UpdateGroupConfigurationGlobalRuleAdminV1.Response> ExecuteAsync(
                ModelsUpdateGroupConfigurationGlobalRulesRequestV1 body,
                string allowedAction,
                string configurationCode,
                string namespace_
            )
            {
                UpdateGroupConfigurationGlobalRuleAdminV1 op = Build(
                    body,
                    allowedAction,
                    configurationCode,
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

        private UpdateGroupConfigurationGlobalRuleAdminV1(UpdateGroupConfigurationGlobalRuleAdminV1Builder builder,
            ModelsUpdateGroupConfigurationGlobalRulesRequestV1 body,
            string allowedAction,
            string configurationCode,
            string namespace_
        )
        {
            PathParams["allowedAction"] = allowedAction;
            PathParams["configurationCode"] = configurationCode;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsUpdateGroupConfigurationResponseV1>
        {

            public ResponseErrorResponse? Error400 { get; set; } = null;

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error404 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Group::Configuration::UpdateGroupConfigurationGlobalRuleAdminV1";
        }

        #endregion

        public UpdateGroupConfigurationGlobalRuleAdminV1(
            string allowedAction,            
            string configurationCode,            
            string namespace_,            
            Model.ModelsUpdateGroupConfigurationGlobalRulesRequestV1 body            
        )
        {
            PathParams["allowedAction"] = allowedAction;
            PathParams["configurationCode"] = configurationCode;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v1/admin/namespaces/{namespace}/configuration/{configurationCode}/rules/{allowedAction}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public UpdateGroupConfigurationGlobalRuleAdminV1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdateGroupConfigurationGlobalRuleAdminV1.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsUpdateGroupConfigurationResponseV1>(payload, ResponseJsonOptions);
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
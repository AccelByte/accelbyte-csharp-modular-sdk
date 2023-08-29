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
    /// updateGroupPredefinedRulePublicV2
    ///
    /// 
    /// 
    /// Required valid user authentication
    /// 
    /// 
    /// 
    /// 
    /// Required Member Role Permission: "GROUP [UPDATE]"
    /// 
    /// 
    /// 
    /// 
    /// Update predefined group rule. This endpoint will check the group ID of the user based on the access token
    /// and compare it with the group ID in path parameter. It will also check the member role of the user based on
    /// the access token
    /// 
    /// 
    /// 
    /// 
    /// If the rule action is not defined in the group, it will be added immediately to the predefined group rule
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73310
    /// </summary>
    public class UpdateGroupPredefinedRulePublicV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateGroupPredefinedRulePublicV2Builder Builder { get => new UpdateGroupPredefinedRulePublicV2Builder(); }

        public class UpdateGroupPredefinedRulePublicV2Builder
            : OperationBuilder<UpdateGroupPredefinedRulePublicV2Builder>
        {





            internal UpdateGroupPredefinedRulePublicV2Builder() { }

            internal UpdateGroupPredefinedRulePublicV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateGroupPredefinedRulePublicV2 Build(
                ModelsUpdateGroupPredefinedRuleRequestV1 body,
                string allowedAction,
                string groupId,
                string namespace_
            )
            {
                UpdateGroupPredefinedRulePublicV2 op = new UpdateGroupPredefinedRulePublicV2(this,
                    body,                    
                    allowedAction,                    
                    groupId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsGroupResponseV1? Execute(
                ModelsUpdateGroupPredefinedRuleRequestV1 body,
                string allowedAction,
                string groupId,
                string namespace_
            )
            {
                UpdateGroupPredefinedRulePublicV2 op = Build(
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

            public Model.ModelsGroupResponseV1<T1>? Execute<T1>(
                ModelsUpdateGroupPredefinedRuleRequestV1 body,
                string allowedAction,
                string groupId,
                string namespace_
            )
            {
                UpdateGroupPredefinedRulePublicV2 op = Build(
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
        }

        private UpdateGroupPredefinedRulePublicV2(UpdateGroupPredefinedRulePublicV2Builder builder,
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

        public UpdateGroupPredefinedRulePublicV2(
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

        public override string Path => "/group/v2/public/namespaces/{namespace}/groups/{groupId}/rules/defined/{allowedAction}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelsGroupResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGroupResponseV1>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGroupResponseV1>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }

        public Model.ModelsGroupResponseV1<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }            
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGroupResponseV1<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGroupResponseV1<T1>>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}
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
    /// createNewGroupPublicV2
    ///
    /// 
    /// 
    /// Required valid user authentication
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to create new group
    /// 
    /// 
    /// 
    /// 
    /// There are some fields that needs to be fulfilled
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    ///   * groupDescription : the description of the group (optional)
    /// 
    /// 
    ///   * groupIcon : group icon URL link (optional)
    /// 
    /// 
    ///   * groupName : name of the group
    /// 
    /// 
    ///   * groupRegion : region of the group
    /// 
    /// 
    ///   * groupRules : rules for specific group. It consists of groupCustomRule that can be used to save custom rule, and groupPredefinedRules that has similar usage with configuration, but this rule only works in specific group
    /// 
    /// 
    ///   * allowedAction : available action in group service. It consist of joinGroup and inviteGroup
    /// 
    /// 
    ///   * ruleAttribute : attribute of the player that needs to be checked
    /// 
    /// 
    ///   * ruleCriteria : criteria of the value. The value will be in enum of EQUAL, MINIMUM, MAXIMUM
    /// 
    /// 
    ///   * ruleValue : value that needs to be checked
    /// 
    /// 
    ///   * customAttributes : additional custom group attributes (optional)
    /// 
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73304
    /// </summary>
    public class CreateNewGroupPublicV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateNewGroupPublicV2Builder Builder { get => new CreateNewGroupPublicV2Builder(); }

        public class CreateNewGroupPublicV2Builder
            : OperationBuilder<CreateNewGroupPublicV2Builder>
        {





            internal CreateNewGroupPublicV2Builder() { }

            internal CreateNewGroupPublicV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateNewGroupPublicV2 Build(
                ModelsPublicCreateNewGroupRequestV1 body,
                string namespace_
            )
            {
                CreateNewGroupPublicV2 op = new CreateNewGroupPublicV2(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelsGroupResponseV1? Execute(
                ModelsPublicCreateNewGroupRequestV1 body,
                string namespace_
            )
            {
                CreateNewGroupPublicV2 op = Build(
                    body,
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
                ModelsPublicCreateNewGroupRequestV1 body,
                string namespace_
            )
            {
                CreateNewGroupPublicV2 op = Build(
                    body,
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

        private CreateNewGroupPublicV2(CreateNewGroupPublicV2Builder builder,
            ModelsPublicCreateNewGroupRequestV1 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateNewGroupPublicV2(
            string namespace_,            
            Model.ModelsPublicCreateNewGroupRequestV1 body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v2/public/namespaces/{namespace}/groups";

        public override HttpMethod Method => HttpMethod.Post;

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
                return JsonSerializer.Deserialize<Model.ModelsGroupResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGroupResponseV1>(payload);
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
                return JsonSerializer.Deserialize<Model.ModelsGroupResponseV1<T1>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGroupResponseV1<T1>>(payload);
            }
            
            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}
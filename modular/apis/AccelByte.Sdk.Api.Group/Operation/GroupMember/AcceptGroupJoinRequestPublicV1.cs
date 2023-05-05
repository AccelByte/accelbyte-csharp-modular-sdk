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
    /// acceptGroupJoinRequestPublicV1
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
    public class AcceptGroupJoinRequestPublicV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AcceptGroupJoinRequestPublicV1Builder Builder { get => new AcceptGroupJoinRequestPublicV1Builder(); }

        public class AcceptGroupJoinRequestPublicV1Builder
            : OperationBuilder<AcceptGroupJoinRequestPublicV1Builder>
        {





            internal AcceptGroupJoinRequestPublicV1Builder() { }

            internal AcceptGroupJoinRequestPublicV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AcceptGroupJoinRequestPublicV1 Build(
                string namespace_,
                string userId
            )
            {
                AcceptGroupJoinRequestPublicV1 op = new AcceptGroupJoinRequestPublicV1(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelsMemberRequestGroupResponseV1? Execute(
                string namespace_,
                string userId
            )
            {
                AcceptGroupJoinRequestPublicV1 op = Build(
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

        private AcceptGroupJoinRequestPublicV1(AcceptGroupJoinRequestPublicV1Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AcceptGroupJoinRequestPublicV1(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v1/public/namespaces/{namespace}/users/{userId}/join/accept";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelsMemberRequestGroupResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsMemberRequestGroupResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsMemberRequestGroupResponseV1>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
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

using AccelByte.Sdk.Api.Ugc.Model;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// AdminCreateGroup
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER:{userId}:CONTENTGROUP [CREATE]
    /// </summary>
    public class AdminCreateGroup : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCreateGroupBuilder Builder { get => new AdminCreateGroupBuilder(); }

        public class AdminCreateGroupBuilder
            : OperationBuilder<AdminCreateGroupBuilder>
        {





            internal AdminCreateGroupBuilder() { }

            internal AdminCreateGroupBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminCreateGroup Build(
                ModelsCreateGroupRequest body,
                string namespace_
            )
            {
                AdminCreateGroup op = new AdminCreateGroup(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelsCreateGroupResponse? Execute(
                ModelsCreateGroupRequest body,
                string namespace_
            )
            {
                AdminCreateGroup op = Build(
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
        }

        private AdminCreateGroup(AdminCreateGroupBuilder builder,
            ModelsCreateGroupRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminCreateGroup(
            string namespace_,            
            Model.ModelsCreateGroupRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/groups";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelsCreateGroupResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateGroupResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateGroupResponse>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
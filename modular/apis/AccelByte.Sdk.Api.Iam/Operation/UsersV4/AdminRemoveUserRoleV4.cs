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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminRemoveUserRoleV4
    ///
    /// This endpoint requires ADMIN:NAMESPACE:{namespace}:ROLE:USER:* [Delete] permission.
    /// 
    /// Remove a role from user's roles.
    /// </summary>
    public class AdminRemoveUserRoleV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminRemoveUserRoleV4Builder Builder { get => new AdminRemoveUserRoleV4Builder(); }

        public class AdminRemoveUserRoleV4Builder
            : OperationBuilder<AdminRemoveUserRoleV4Builder>
        {





            internal AdminRemoveUserRoleV4Builder() { }

            internal AdminRemoveUserRoleV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminRemoveUserRoleV4 Build(
                ModelRemoveUserRoleV4Request body,
                string namespace_,
                string userId
            )
            {
                AdminRemoveUserRoleV4 op = new AdminRemoveUserRoleV4(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public void Execute(
                ModelRemoveUserRoleV4Request body,
                string namespace_,
                string userId
            )
            {
                AdminRemoveUserRoleV4 op = Build(
                    body,
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private AdminRemoveUserRoleV4(AdminRemoveUserRoleV4Builder builder,
            ModelRemoveUserRoleV4Request body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminRemoveUserRoleV4(
            string namespace_,            
            string userId,            
            Model.ModelRemoveUserRoleV4Request body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/namespaces/{namespace}/users/{userId}/roles";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
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
    /// AdminDeleteUserRoleV3
    ///
    /// 
    /// 
    /// This endpoint removes role from user. Required permission ADMIN:NAMESPACE:{namespace}:ROLE:USER:{userId} [DELETE]
    /// 
    /// 
    /// 
    /// 
    /// action code: 10110
    /// </summary>
    public class AdminDeleteUserRoleV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteUserRoleV3Builder Builder { get => new AdminDeleteUserRoleV3Builder(); }

        public class AdminDeleteUserRoleV3Builder
            : OperationBuilder<AdminDeleteUserRoleV3Builder>
        {





            internal AdminDeleteUserRoleV3Builder() { }

            internal AdminDeleteUserRoleV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeleteUserRoleV3 Build(
                string namespace_,
                string roleId,
                string userId
            )
            {
                AdminDeleteUserRoleV3 op = new AdminDeleteUserRoleV3(this,
                    namespace_,                    
                    roleId,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public void Execute(
                string namespace_,
                string roleId,
                string userId
            )
            {
                AdminDeleteUserRoleV3 op = Build(
                    namespace_,
                    roleId,
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

        private AdminDeleteUserRoleV3(AdminDeleteUserRoleV3Builder builder,
            string namespace_,
            string roleId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["roleId"] = roleId;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteUserRoleV3(
            string namespace_,            
            string roleId,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["roleId"] = roleId;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/roles/{roleId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() {  };

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
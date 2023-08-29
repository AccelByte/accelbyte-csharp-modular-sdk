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
    /// AdminUpdateRoleV3
    ///
    /// Required permission 'ADMIN:ROLE [UPDATE]'
    /// 
    /// Update role request body:
    /// - roleName: specify role name, alphanumeric, cannot have special character (required)
    /// - isWildcard: specify if role can be assigned to wildcard (*) namespace (default false)
    /// - deletable: specify if role can be deleted or not (optional)
    /// 
    /// 
    /// action code: 10402
    /// </summary>
    public class AdminUpdateRoleV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateRoleV3Builder Builder { get => new AdminUpdateRoleV3Builder(); }

        public class AdminUpdateRoleV3Builder
            : OperationBuilder<AdminUpdateRoleV3Builder>
        {





            internal AdminUpdateRoleV3Builder() { }

            internal AdminUpdateRoleV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpdateRoleV3 Build(
                ModelRoleUpdateRequestV3 body,
                string roleId
            )
            {
                AdminUpdateRoleV3 op = new AdminUpdateRoleV3(this,
                    body,                    
                    roleId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelRoleResponseV3? Execute(
                ModelRoleUpdateRequestV3 body,
                string roleId
            )
            {
                AdminUpdateRoleV3 op = Build(
                    body,
                    roleId
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

        private AdminUpdateRoleV3(AdminUpdateRoleV3Builder builder,
            ModelRoleUpdateRequestV3 body,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateRoleV3(
            string roleId,            
            Model.ModelRoleUpdateRequestV3 body            
        )
        {
            PathParams["roleId"] = roleId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/roles/{roleId}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelRoleResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleResponseV3>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleResponseV3>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
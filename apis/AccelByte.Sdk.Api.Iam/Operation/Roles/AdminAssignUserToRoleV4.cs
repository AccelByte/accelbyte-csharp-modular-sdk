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
    /// AdminAssignUserToRoleV4
    ///
    /// Required permission ADMIN:ROLE [UPDATE]
    /// 
    /// Parameters:
    /// - userId: string (required)
    /// - namespace: string (userâs namespace) (required)
    /// - assignedNamespaces: array of string (namespaces to be assigned on role) (required)
    /// 
    /// action code: 10410
    /// </summary>
    public class AdminAssignUserToRoleV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminAssignUserToRoleV4Builder Builder { get => new AdminAssignUserToRoleV4Builder(); }

        public class AdminAssignUserToRoleV4Builder
            : OperationBuilder<AdminAssignUserToRoleV4Builder>
        {





            internal AdminAssignUserToRoleV4Builder() { }

            internal AdminAssignUserToRoleV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminAssignUserToRoleV4 Build(
                ModelAssignUserV4Request body,
                string roleId
            )
            {
                AdminAssignUserToRoleV4 op = new AdminAssignUserToRoleV4(this,
                    body,                    
                    roleId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelAssignedUserV4Response? Execute(
                ModelAssignUserV4Request body,
                string roleId
            )
            {
                AdminAssignUserToRoleV4 op = Build(
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

        private AdminAssignUserToRoleV4(AdminAssignUserToRoleV4Builder builder,
            ModelAssignUserV4Request body,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminAssignUserToRoleV4(
            string roleId,            
            Model.ModelAssignUserV4Request body            
        )
        {
            PathParams["roleId"] = roleId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/roles/{roleId}/users";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelAssignedUserV4Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelAssignedUserV4Response>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelAssignedUserV4Response>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
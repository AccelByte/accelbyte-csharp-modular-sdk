// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// DeleteRole
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Required permission 'ROLE:ADMIN [DELETE]' or 'ADMIN:ROLE [DELETE]'
    /// Endpoint migration guide
    /// 
    /// 
    ///           * Substitute endpoint: /iam/v3/admin/roles/{roleId} [DELETE]
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class DeleteRole : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteRoleBuilder Builder { get => new DeleteRoleBuilder(); }

        public class DeleteRoleBuilder
            : OperationBuilder<DeleteRoleBuilder>
        {





            internal DeleteRoleBuilder() { }






            public DeleteRole Build(
                string roleId
            )
            {
                DeleteRole op = new DeleteRole(this,
                    roleId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeleteRole(DeleteRoleBuilder builder,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteRole(
            string roleId            
        )
        {
            PathParams["roleId"] = roleId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/roles/{roleId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
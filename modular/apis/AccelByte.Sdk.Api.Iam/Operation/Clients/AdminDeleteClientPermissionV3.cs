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
    /// AdminDeleteClientPermissionV3
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:CLIENT [UPDATE]'
    /// action code : 10304
    /// </summary>
    public class AdminDeleteClientPermissionV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteClientPermissionV3Builder Builder { get => new AdminDeleteClientPermissionV3Builder(); }

        public class AdminDeleteClientPermissionV3Builder
            : OperationBuilder<AdminDeleteClientPermissionV3Builder>
        {





            internal AdminDeleteClientPermissionV3Builder() { }

            internal AdminDeleteClientPermissionV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeleteClientPermissionV3 Build(
                long action,
                string clientId,
                string namespace_,
                string resource
            )
            {
                AdminDeleteClientPermissionV3 op = new AdminDeleteClientPermissionV3(this,
                    action,                    
                    clientId,                    
                    namespace_,                    
                    resource                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public void Execute(
                long action,
                string clientId,
                string namespace_,
                string resource
            )
            {
                AdminDeleteClientPermissionV3 op = Build(
                    action,
                    clientId,
                    namespace_,
                    resource
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

        private AdminDeleteClientPermissionV3(AdminDeleteClientPermissionV3Builder builder,
            long action,
            string clientId,
            string namespace_,
            string resource
        )
        {
            PathParams["action"] = Convert.ToString(action);
            PathParams["clientId"] = clientId;
            PathParams["namespace"] = namespace_;
            PathParams["resource"] = resource;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteClientPermissionV3(
            long action,            
            string clientId,            
            string namespace_,            
            string resource            
        )
        {
            PathParams["action"] = Convert.ToString(action);
            PathParams["clientId"] = clientId;
            PathParams["namespace"] = namespace_;
            PathParams["resource"] = resource;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/clients/{clientId}/permissions/{resource}/{action}";

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
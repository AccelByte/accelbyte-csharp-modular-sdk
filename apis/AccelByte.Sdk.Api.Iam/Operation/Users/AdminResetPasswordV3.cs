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
    /// AdminResetPasswordV3
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:PASSWORD:USER:{userId} [UPDATE]'
    /// </summary>
    public class AdminResetPasswordV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminResetPasswordV3Builder Builder { get => new AdminResetPasswordV3Builder(); }

        public class AdminResetPasswordV3Builder
            : OperationBuilder<AdminResetPasswordV3Builder>
        {





            internal AdminResetPasswordV3Builder() { }

            internal AdminResetPasswordV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminResetPasswordV3 Build(
                ModelUserPasswordUpdateV3Request body,
                string namespace_,
                string userId
            )
            {
                AdminResetPasswordV3 op = new AdminResetPasswordV3(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                ModelUserPasswordUpdateV3Request body,
                string namespace_,
                string userId
            )
            {
                AdminResetPasswordV3 op = Build(
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

        private AdminResetPasswordV3(AdminResetPasswordV3Builder builder,
            ModelUserPasswordUpdateV3Request body,
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

        public AdminResetPasswordV3(
            string namespace_,            
            string userId,            
            Model.ModelUserPasswordUpdateV3Request body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/password";

        public override HttpMethod Method => HttpMethod.Put;

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
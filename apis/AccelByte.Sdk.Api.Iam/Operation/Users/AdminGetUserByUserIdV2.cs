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
    /// AdminGetUserByUserIdV2
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Endpoint migration guide
    /// 
    /// 
    ///           * Substitute endpoint: /iam/v3/admin/namespaces/{namespace}/users/{userId} [GET]
    /// 
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:USER:{userId} [READ]'
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class AdminGetUserByUserIdV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetUserByUserIdV2Builder Builder { get => new AdminGetUserByUserIdV2Builder(); }

        public class AdminGetUserByUserIdV2Builder
            : OperationBuilder<AdminGetUserByUserIdV2Builder>
        {





            internal AdminGetUserByUserIdV2Builder() { }

            internal AdminGetUserByUserIdV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetUserByUserIdV2 Build(
                string namespace_,
                string userId
            )
            {
                AdminGetUserByUserIdV2 op = new AdminGetUserByUserIdV2(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
            public Model.ModelUserResponse? Execute(
                string namespace_,
                string userId
            )
            {
                AdminGetUserByUserIdV2 op = Build(
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

        private AdminGetUserByUserIdV2(AdminGetUserByUserIdV2Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetUserByUserIdV2(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v2/admin/namespaces/{namespace}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelUserResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
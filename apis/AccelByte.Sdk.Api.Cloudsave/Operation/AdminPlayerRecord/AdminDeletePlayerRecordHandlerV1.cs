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

using AccelByte.Sdk.Api.Cloudsave.Model;

namespace AccelByte.Sdk.Api.Cloudsave.Operation
{
    /// <summary>
    /// adminDeletePlayerRecordHandlerV1
    ///
    /// Required permission: `ADMIN:NAMESPACE:{namespace}:USER:{userId}:CLOUDSAVE:RECORD [DELETE]`
    /// 
    /// Required scope: `social`
    /// 
    /// Delete a record (arbitrary JSON data) in user-level with given key.
    /// </summary>
    public class AdminDeletePlayerRecordHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeletePlayerRecordHandlerV1Builder Builder { get => new AdminDeletePlayerRecordHandlerV1Builder(); }

        public class AdminDeletePlayerRecordHandlerV1Builder
            : OperationBuilder<AdminDeletePlayerRecordHandlerV1Builder>
        {





            internal AdminDeletePlayerRecordHandlerV1Builder() { }

            internal AdminDeletePlayerRecordHandlerV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeletePlayerRecordHandlerV1 Build(
                string key,
                string namespace_,
                string userId
            )
            {
                AdminDeletePlayerRecordHandlerV1 op = new AdminDeletePlayerRecordHandlerV1(this,
                    key,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string key,
                string namespace_,
                string userId
            )
            {
                AdminDeletePlayerRecordHandlerV1 op = Build(
                    key,
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

        private AdminDeletePlayerRecordHandlerV1(AdminDeletePlayerRecordHandlerV1Builder builder,
            string key,
            string namespace_,
            string userId
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeletePlayerRecordHandlerV1(
            string key,            
            string namespace_,            
            string userId            
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}";

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
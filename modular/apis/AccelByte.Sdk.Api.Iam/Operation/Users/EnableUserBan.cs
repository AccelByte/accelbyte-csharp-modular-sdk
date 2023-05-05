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
    /// EnableUserBan
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Endpoint migration guide
    /// 
    /// 
    ///     * Substitute endpoint: /iam/v3/admin/namespaces/{namespace}/users/{userId}/bans/{banId} [PATCH]
    /// 
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:BAN:USER:{userId} [UPDATE]'.
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class EnableUserBan : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static EnableUserBanBuilder Builder { get => new EnableUserBanBuilder(); }

        public class EnableUserBanBuilder
            : OperationBuilder<EnableUserBanBuilder>
        {





            internal EnableUserBanBuilder() { }

            internal EnableUserBanBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public EnableUserBan Build(
                string banId,
                string namespace_,
                string userId
            )
            {
                EnableUserBan op = new EnableUserBan(this,
                    banId,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
            public Model.ModelUserBanResponse? Execute(
                string banId,
                string namespace_,
                string userId
            )
            {
                EnableUserBan op = Build(
                    banId,
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

        private EnableUserBan(EnableUserBanBuilder builder,
            string banId,
            string namespace_,
            string userId
        )
        {
            PathParams["banId"] = banId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public EnableUserBan(
            string banId,            
            string namespace_,            
            string userId            
        )
        {
            PathParams["banId"] = banId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/bans/{banId}/enable";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "*/*" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelUserBanResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserBanResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserBanResponse>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
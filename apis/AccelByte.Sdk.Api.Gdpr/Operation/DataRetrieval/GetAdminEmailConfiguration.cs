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

using AccelByte.Sdk.Api.Gdpr.Model;

namespace AccelByte.Sdk.Api.Gdpr.Operation
{
    /// <summary>
    /// GetAdminEmailConfiguration
    ///
    /// Get list of admin email address configuration.
    /// 
    /// 
    /// Required permission `ADMIN:NAMESPACE:{namespace}:EMAIL:CONFIGURATION [READ]` and scope `account`
    /// </summary>
    public class GetAdminEmailConfiguration : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetAdminEmailConfigurationBuilder Builder { get => new GetAdminEmailConfigurationBuilder(); }

        public class GetAdminEmailConfigurationBuilder
            : OperationBuilder<GetAdminEmailConfigurationBuilder>
        {





            internal GetAdminEmailConfigurationBuilder() { }

            internal GetAdminEmailConfigurationBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetAdminEmailConfiguration Build(
                string namespace_
            )
            {
                GetAdminEmailConfiguration op = new GetAdminEmailConfiguration(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public List<string>? Execute(
                string namespace_
            )
            {
                GetAdminEmailConfiguration op = Build(
                    namespace_
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

        private GetAdminEmailConfiguration(GetAdminEmailConfigurationBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetAdminEmailConfiguration(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/admin/namespaces/{namespace}/emails/configurations";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public List<string>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<string>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<string>>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
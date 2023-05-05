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
    /// PublicListUserAllPlatformAccountsDistinctV3
    ///
    /// 
    /// 
    /// This endpoint retrieves platform accounts linked to user.
    /// 
    /// It will query all linked platform accounts and result will be distinct & grouped, same platform we will pick oldest linked one.
    /// 
    /// Required valid user authorization.
    /// </summary>
    public class PublicListUserAllPlatformAccountsDistinctV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicListUserAllPlatformAccountsDistinctV3Builder Builder { get => new PublicListUserAllPlatformAccountsDistinctV3Builder(); }

        public class PublicListUserAllPlatformAccountsDistinctV3Builder
            : OperationBuilder<PublicListUserAllPlatformAccountsDistinctV3Builder>
        {





            internal PublicListUserAllPlatformAccountsDistinctV3Builder() { }

            internal PublicListUserAllPlatformAccountsDistinctV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicListUserAllPlatformAccountsDistinctV3 Build(
                string namespace_,
                string userId
            )
            {
                PublicListUserAllPlatformAccountsDistinctV3 op = new PublicListUserAllPlatformAccountsDistinctV3(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.AccountcommonDistinctPlatformResponseV3? Execute(
                string namespace_,
                string userId
            )
            {
                PublicListUserAllPlatformAccountsDistinctV3 op = Build(
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

        private PublicListUserAllPlatformAccountsDistinctV3(PublicListUserAllPlatformAccountsDistinctV3Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicListUserAllPlatformAccountsDistinctV3(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/{userId}/distinctPlatforms";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.AccountcommonDistinctPlatformResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonDistinctPlatformResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonDistinctPlatformResponseV3>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
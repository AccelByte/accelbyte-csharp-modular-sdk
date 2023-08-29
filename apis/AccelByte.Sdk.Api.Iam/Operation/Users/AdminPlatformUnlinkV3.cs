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
    /// AdminPlatformUnlinkV3
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:USER:{userId} [DELETE]'.
    /// 
    /// 
    /// ## Supported platforms:
    /// 
    /// 
    /// 
    /// 
    ///                 * steam
    /// 
    /// 
    ///                 * steamopenid
    /// 
    /// 
    ///                 * facebook
    /// 
    /// 
    ///                 * google
    /// 
    /// 
    ///                 * oculus
    /// 
    /// 
    ///                 * twitch
    /// 
    /// 
    ///                 * android
    /// 
    /// 
    ///                 * ios
    /// 
    /// 
    ///                 * apple
    /// 
    /// 
    ///                 * device
    /// 
    /// 
    ///                 * discord
    /// 
    /// 
    ///                 * awscognito
    /// 
    /// 
    ///                 * epicgames
    /// 
    /// 
    ///                 * nintendo
    /// 
    /// 
    ///                 * snapchat
    /// 
    /// 
    /// 
    /// 
    /// Unlink user's account from a specific platform. 'justice' platform might have multiple accounts from different namespaces linked.
    /// 
    /// platformNamespace need to be specified when the platform ID is 'justice'.
    /// 
    /// 
    /// 
    /// Unlink user's account from justice platform will enable password token grant and password update.
    /// 
    /// 
    /// 
    /// If you want to unlink user's account in a game namespace, you have to specify platformNamespace to that game namespace.
    /// 
    /// 
    /// 
    /// action code : 10121
    /// </summary>
    public class AdminPlatformUnlinkV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminPlatformUnlinkV3Builder Builder { get => new AdminPlatformUnlinkV3Builder(); }

        public class AdminPlatformUnlinkV3Builder
            : OperationBuilder<AdminPlatformUnlinkV3Builder>
        {





            internal AdminPlatformUnlinkV3Builder() { }

            internal AdminPlatformUnlinkV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminPlatformUnlinkV3 Build(
                ModelUnlinkUserPlatformRequest body,
                string namespace_,
                string platformId,
                string userId
            )
            {
                AdminPlatformUnlinkV3 op = new AdminPlatformUnlinkV3(this,
                    body,                    
                    namespace_,                    
                    platformId,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                ModelUnlinkUserPlatformRequest body,
                string namespace_,
                string platformId,
                string userId
            )
            {
                AdminPlatformUnlinkV3 op = Build(
                    body,
                    namespace_,
                    platformId,
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

        private AdminPlatformUnlinkV3(AdminPlatformUnlinkV3Builder builder,
            ModelUnlinkUserPlatformRequest body,
            string namespace_,
            string platformId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminPlatformUnlinkV3(
            string namespace_,            
            string platformId,            
            string userId,            
            Model.ModelUnlinkUserPlatformRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/platforms/{platformId}";

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
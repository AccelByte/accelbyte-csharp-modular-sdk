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
    /// AdminUpgradeHeadlessAccountV3
    ///
    /// 
    /// 
    /// If validateOnly is set false, will upgrade headless account with verification code
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:USER:{userId} [UPDATE]'
    /// 
    /// 
    /// The endpoint upgrades a headless account by linking the headless account with the email address and the password.
    /// By upgrading the headless account into a full account, the user could use the email address and password for using Justice IAM.
    /// 
    /// 
    /// 
    /// 
    /// The endpoint is a shortcut for upgrading a headless account and verifying the email address in one call.
    /// In order to get a verification code for the endpoint, please check the send verification code endpoint.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint also have an ability to update user data (if the user data field is specified) right after the upgrade account process is done.
    /// 
    /// Supported user data fields :
    /// 
    /// 
    ///             * displayName
    /// 
    /// 
    ///             * dateOfBirth : format YYYY-MM-DD, e.g. 2019-04-29
    /// 
    /// 
    ///             * country : format ISO3166-1 alpha-2 two letter, e.g. US
    /// 
    /// 
    /// 
    /// action code : 10124
    /// </summary>
    public class AdminUpgradeHeadlessAccountV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpgradeHeadlessAccountV3Builder Builder { get => new AdminUpgradeHeadlessAccountV3Builder(); }

        public class AdminUpgradeHeadlessAccountV3Builder
            : OperationBuilder<AdminUpgradeHeadlessAccountV3Builder>
        {





            internal AdminUpgradeHeadlessAccountV3Builder() { }

            internal AdminUpgradeHeadlessAccountV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpgradeHeadlessAccountV3 Build(
                ModelUpgradeHeadlessAccountWithVerificationCodeRequestV3 body,
                string namespace_,
                string userId
            )
            {
                AdminUpgradeHeadlessAccountV3 op = new AdminUpgradeHeadlessAccountV3(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelUserResponseV3? Execute(
                ModelUpgradeHeadlessAccountWithVerificationCodeRequestV3 body,
                string namespace_,
                string userId
            )
            {
                AdminUpgradeHeadlessAccountV3 op = Build(
                    body,
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

        private AdminUpgradeHeadlessAccountV3(AdminUpgradeHeadlessAccountV3Builder builder,
            ModelUpgradeHeadlessAccountWithVerificationCodeRequestV3 body,
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

        public AdminUpgradeHeadlessAccountV3(
            string namespace_,            
            string userId,            
            Model.ModelUpgradeHeadlessAccountWithVerificationCodeRequestV3 body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/headless/code/verify";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelUserResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponseV3>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
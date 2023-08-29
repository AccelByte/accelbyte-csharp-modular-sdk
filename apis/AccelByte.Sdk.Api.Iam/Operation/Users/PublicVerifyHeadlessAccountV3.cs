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
    /// PublicVerifyHeadlessAccountV3
    ///
    /// 
    /// 
    /// Require valid user authorization
    /// action code : 10124
    /// 
    /// 
    /// 
    /// 
    /// if set NeedVerificationCode = true, IAM will send verification code into email
    /// 
    /// 
    /// 
    /// 
    /// user can use that verification code to verify user through /iam/v3/public/namespaces/{namespace}/users/me/code/verify
    /// </summary>
    public class PublicVerifyHeadlessAccountV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicVerifyHeadlessAccountV3Builder Builder { get => new PublicVerifyHeadlessAccountV3Builder(); }

        public class PublicVerifyHeadlessAccountV3Builder
            : OperationBuilder<PublicVerifyHeadlessAccountV3Builder>
        {

            public bool? NeedVerificationCode { get; set; }





            internal PublicVerifyHeadlessAccountV3Builder() { }

            internal PublicVerifyHeadlessAccountV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicVerifyHeadlessAccountV3Builder SetNeedVerificationCode(bool _needVerificationCode)
            {
                NeedVerificationCode = _needVerificationCode;
                return this;
            }





            public PublicVerifyHeadlessAccountV3 Build(
                ModelUpgradeHeadlessAccountV3Request body,
                string namespace_
            )
            {
                PublicVerifyHeadlessAccountV3 op = new PublicVerifyHeadlessAccountV3(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelUserResponseV3? Execute(
                ModelUpgradeHeadlessAccountV3Request body,
                string namespace_
            )
            {
                PublicVerifyHeadlessAccountV3 op = Build(
                    body,
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

        private PublicVerifyHeadlessAccountV3(PublicVerifyHeadlessAccountV3Builder builder,
            ModelUpgradeHeadlessAccountV3Request body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.NeedVerificationCode != null) QueryParams["needVerificationCode"] = Convert.ToString(builder.NeedVerificationCode)!;
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicVerifyHeadlessAccountV3(
            string namespace_,            
            bool? needVerificationCode,            
            Model.ModelUpgradeHeadlessAccountV3Request body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (needVerificationCode != null) QueryParams["needVerificationCode"] = Convert.ToString(needVerificationCode)!;
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/me/headless/verify";

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
                return JsonSerializer.Deserialize<Model.ModelUserResponseV3>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponseV3>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
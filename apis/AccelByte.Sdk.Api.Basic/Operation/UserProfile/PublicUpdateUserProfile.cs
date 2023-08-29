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

using AccelByte.Sdk.Api.Basic.Model;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// publicUpdateUserProfile
    ///
    /// Update user profile.
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "NAMESPACE:{namespace}:USER:{userId}:PROFILE" , action=4 (UPDATE)
    ///   *  Action code : 11402
    ///   *  Language : allowed format: en, en-US
    ///   *  Timezone : IANA time zone, e.g. Asia/Shanghai
    ///   *  Returns : Updated user profile
    /// </summary>
    public class PublicUpdateUserProfile : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpdateUserProfileBuilder Builder { get => new PublicUpdateUserProfileBuilder(); }

        public class PublicUpdateUserProfileBuilder
            : OperationBuilder<PublicUpdateUserProfileBuilder>
        {


            public Model.UserProfileUpdate? Body { get; set; }




            internal PublicUpdateUserProfileBuilder() { }

            internal PublicUpdateUserProfileBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public PublicUpdateUserProfileBuilder SetBody(Model.UserProfileUpdate _body)
            {
                Body = _body;
                return this;
            }




            public PublicUpdateUserProfile Build(
                string namespace_,
                string userId
            )
            {
                PublicUpdateUserProfile op = new PublicUpdateUserProfile(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.UserProfileInfo? Execute(
                string namespace_,
                string userId
            )
            {
                PublicUpdateUserProfile op = Build(
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

            public Model.UserProfileInfo<T1>? Execute<T1>(
                string namespace_,
                string userId
            )
            {
                PublicUpdateUserProfile op = Build(
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private PublicUpdateUserProfile(PublicUpdateUserProfileBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicUpdateUserProfile(
            string namespace_,            
            string userId,            
            Model.UserProfileUpdate body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/users/{userId}/profiles";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.UserProfileInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.UserProfileInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UserProfileInfo>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }

        public Model.UserProfileInfo<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }            
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.UserProfileInfo<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UserProfileInfo<T1>>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}
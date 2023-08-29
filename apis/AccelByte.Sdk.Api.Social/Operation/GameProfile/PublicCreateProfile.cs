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

using AccelByte.Sdk.Api.Social.Model;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// publicCreateProfile
    ///
    /// Create new profile for user.
    /// Other detail info:
    ///         *  Required permission
    /// : resource="NAMESPACE:{namespace}:USER:{userId}:GAMEPROFILE", action=1 (CREATE)
    ///         *  Returns
    /// : created game profile
    /// </summary>
    public class PublicCreateProfile : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicCreateProfileBuilder Builder { get => new PublicCreateProfileBuilder(); }

        public class PublicCreateProfileBuilder
            : OperationBuilder<PublicCreateProfileBuilder>
        {


            public Model.GameProfileRequest? Body { get; set; }




            internal PublicCreateProfileBuilder() { }

            internal PublicCreateProfileBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public PublicCreateProfileBuilder SetBody(Model.GameProfileRequest _body)
            {
                Body = _body;
                return this;
            }




            public PublicCreateProfile Build(
                string namespace_,
                string userId
            )
            {
                PublicCreateProfile op = new PublicCreateProfile(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string namespace_,
                string userId
            )
            {
                PublicCreateProfile op = Build(
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

        private PublicCreateProfile(PublicCreateProfileBuilder builder,
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

        public PublicCreateProfile(
            string namespace_,            
            string userId,            
            Model.GameProfileRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/public/namespaces/{namespace}/users/{userId}/profiles";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return;
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
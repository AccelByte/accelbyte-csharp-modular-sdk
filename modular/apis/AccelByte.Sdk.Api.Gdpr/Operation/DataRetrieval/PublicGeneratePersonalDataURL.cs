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
    /// PublicGeneratePersonalDataURL
    ///
    /// 
    /// 
    /// Requires valid user access token
    /// </summary>
    public class PublicGeneratePersonalDataURL : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGeneratePersonalDataURLBuilder Builder { get => new PublicGeneratePersonalDataURLBuilder(); }

        public class PublicGeneratePersonalDataURLBuilder
            : OperationBuilder<PublicGeneratePersonalDataURLBuilder>
        {





            internal PublicGeneratePersonalDataURLBuilder() { }

            internal PublicGeneratePersonalDataURLBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGeneratePersonalDataURL Build(
                string password,
                string namespace_,
                string requestDate,
                string userId
            )
            {
                PublicGeneratePersonalDataURL op = new PublicGeneratePersonalDataURL(this,
                    password,                    
                    namespace_,                    
                    requestDate,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelsUserDataURL? Execute(
                string password,
                string namespace_,
                string requestDate,
                string userId
            )
            {
                PublicGeneratePersonalDataURL op = Build(
                    password,
                    namespace_,
                    requestDate,
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

        private PublicGeneratePersonalDataURL(PublicGeneratePersonalDataURLBuilder builder,
            string password,
            string namespace_,
            string requestDate,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["requestDate"] = requestDate;
            PathParams["userId"] = userId;
            
            
            if (password is not null) FormParams["password"] = password;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGeneratePersonalDataURL(
            string namespace_,            
            string requestDate,            
            string userId,            
            string password            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["requestDate"] = requestDate;
            PathParams["userId"] = userId;
            
            
            if (password is not null) FormParams["password"] = password;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/public/namespaces/{namespace}/users/{userId}/requests/{requestDate}/generate";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelsUserDataURL? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsUserDataURL>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsUserDataURL>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
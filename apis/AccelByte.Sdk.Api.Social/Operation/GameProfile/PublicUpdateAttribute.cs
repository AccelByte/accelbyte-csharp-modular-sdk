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
    /// publicUpdateAttribute
    ///
    /// Updates game profile attribute, returns updated profile.
    /// Other detail info:
    ///         *  Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:GAMEPROFILE", action=4 (UPDATE)
    ///         *  Returns : updated attribute
    /// </summary>
    public class PublicUpdateAttribute : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpdateAttributeBuilder Builder { get => new PublicUpdateAttributeBuilder(); }

        public class PublicUpdateAttributeBuilder
            : OperationBuilder<PublicUpdateAttributeBuilder>
        {


            public Model.Attribute? Body { get; set; }




            internal PublicUpdateAttributeBuilder() { }

            internal PublicUpdateAttributeBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public PublicUpdateAttributeBuilder SetBody(Model.Attribute _body)
            {
                Body = _body;
                return this;
            }




            public PublicUpdateAttribute Build(
                string attributeName,
                string namespace_,
                string profileId,
                string userId
            )
            {
                PublicUpdateAttribute op = new PublicUpdateAttribute(this,
                    attributeName,                    
                    namespace_,                    
                    profileId,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.GameProfileInfo? Execute(
                string attributeName,
                string namespace_,
                string profileId,
                string userId
            )
            {
                PublicUpdateAttribute op = Build(
                    attributeName,
                    namespace_,
                    profileId,
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

        private PublicUpdateAttribute(PublicUpdateAttributeBuilder builder,
            string attributeName,
            string namespace_,
            string profileId,
            string userId
        )
        {
            PathParams["attributeName"] = attributeName;
            PathParams["namespace"] = namespace_;
            PathParams["profileId"] = profileId;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicUpdateAttribute(
            string attributeName,            
            string namespace_,            
            string profileId,            
            string userId,            
            Model.Attribute body            
        )
        {
            PathParams["attributeName"] = attributeName;
            PathParams["namespace"] = namespace_;
            PathParams["profileId"] = profileId;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/public/namespaces/{namespace}/users/{userId}/profiles/{profileId}/attributes/{attributeName}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.GameProfileInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.GameProfileInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.GameProfileInfo>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
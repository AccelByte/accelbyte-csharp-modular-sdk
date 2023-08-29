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
    /// publicGetUserGameProfiles
    ///
    /// Returns all profiles for specified users.
    /// Other detail info:
    ///         *  Required permission : resource="NAMESPACE:{namespace}:GAMEPROFILE", action=2 (READ)
    /// 
    ///         *  Returns : list of profiles
    /// </summary>
    public class PublicGetUserGameProfiles : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserGameProfilesBuilder Builder { get => new PublicGetUserGameProfilesBuilder(); }

        public class PublicGetUserGameProfilesBuilder
            : OperationBuilder<PublicGetUserGameProfilesBuilder>
        {





            internal PublicGetUserGameProfilesBuilder() { }

            internal PublicGetUserGameProfilesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetUserGameProfiles Build(
                string namespace_,
                List<string> userIds
            )
            {
                PublicGetUserGameProfiles op = new PublicGetUserGameProfiles(this,
                    namespace_,                    
                    userIds                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public List<Model.UserGameProfiles>? Execute(
                string namespace_,
                List<string> userIds
            )
            {
                PublicGetUserGameProfiles op = Build(
                    namespace_,
                    userIds
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

        private PublicGetUserGameProfiles(PublicGetUserGameProfilesBuilder builder,
            string namespace_,
            List<string> userIds
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (userIds is not null) QueryParams["userIds"] = userIds;
            

            
            CollectionFormatMap["userIds"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetUserGameProfiles(
            string namespace_,            
            List<string> userIds            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (userIds is not null) QueryParams["userIds"] = userIds;
            

            
            CollectionFormatMap["userIds"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/public/namespaces/{namespace}/profiles";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public List<Model.UserGameProfiles>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.UserGameProfiles>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.UserGameProfiles>>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
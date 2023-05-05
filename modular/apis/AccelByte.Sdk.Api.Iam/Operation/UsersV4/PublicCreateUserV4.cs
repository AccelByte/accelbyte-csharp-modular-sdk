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
    /// PublicCreateUserV4
    ///
    /// Create a new user with unique email address and username.
    /// 
    /// 
    /// 
    /// Required attributes:
    /// - authType: possible value is EMAILPASSWD
    /// - emailAddress: Please refer to the rule from /v3/public/inputValidations API.
    /// - username: Please refer to the rule from /v3/public/inputValidations API.
    /// - password: Please refer to the rule from /v3/public/inputValidations API.
    /// - country: ISO3166-1 alpha-2 two letter, e.g. US.
    /// - dateOfBirth: YYYY-MM-DD, e.g. 1990-01-01. valid values are between 1905-01-01 until current date.
    /// 
    /// 
    /// Not required attributes:
    /// - displayName: Please refer to the rule from /v3/public/inputValidations API.
    /// 
    /// 
    /// 
    /// 
    /// 
    /// This endpoint support accepting agreements for the created user. Supply the accepted agreements in acceptedPolicies attribute.
    /// </summary>
    public class PublicCreateUserV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicCreateUserV4Builder Builder { get => new PublicCreateUserV4Builder(); }

        public class PublicCreateUserV4Builder
            : OperationBuilder<PublicCreateUserV4Builder>
        {





            internal PublicCreateUserV4Builder() { }

            internal PublicCreateUserV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicCreateUserV4 Build(
                AccountCreateUserRequestV4 body,
                string namespace_
            )
            {
                PublicCreateUserV4 op = new PublicCreateUserV4(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.AccountCreateUserResponseV4? Execute(
                AccountCreateUserRequestV4 body,
                string namespace_
            )
            {
                PublicCreateUserV4 op = Build(
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

        private PublicCreateUserV4(PublicCreateUserV4Builder builder,
            AccountCreateUserRequestV4 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicCreateUserV4(
            string namespace_,            
            Model.AccountCreateUserRequestV4 body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/public/namespaces/{namespace}/users";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.AccountCreateUserResponseV4? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AccountCreateUserResponseV4>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AccountCreateUserResponseV4>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
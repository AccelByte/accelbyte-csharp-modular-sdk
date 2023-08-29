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
    /// PublicValidateUserByUserIDAndPasswordV3
    ///
    /// This endpoint is used to validate the user password. Required valid user authorization and valid user ID.
    /// 
    /// 
    /// Notes:
    /// 
    /// 
    /// 
    /// 
    ///                           * This endpoint validate the user password by specifying the userId and password
    /// </summary>
    public class PublicValidateUserByUserIDAndPasswordV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicValidateUserByUserIDAndPasswordV3Builder Builder { get => new PublicValidateUserByUserIDAndPasswordV3Builder(); }

        public class PublicValidateUserByUserIDAndPasswordV3Builder
            : OperationBuilder<PublicValidateUserByUserIDAndPasswordV3Builder>
        {





            internal PublicValidateUserByUserIDAndPasswordV3Builder() { }

            internal PublicValidateUserByUserIDAndPasswordV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicValidateUserByUserIDAndPasswordV3 Build(
                string password,
                string namespace_,
                string userId
            )
            {
                PublicValidateUserByUserIDAndPasswordV3 op = new PublicValidateUserByUserIDAndPasswordV3(this,
                    password,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string password,
                string namespace_,
                string userId
            )
            {
                PublicValidateUserByUserIDAndPasswordV3 op = Build(
                    password,
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

        private PublicValidateUserByUserIDAndPasswordV3(PublicValidateUserByUserIDAndPasswordV3Builder builder,
            string password,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;


            if (password is not null) FormParams["password"] = password;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicValidateUserByUserIDAndPasswordV3(
            string namespace_,
            string userId,
            string password
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;


            if (password is not null) FormParams["password"] = password;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/{userId}/validate";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

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
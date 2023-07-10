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
    /// PublicSubmitUserAccountDeletionRequest
    ///
    /// 
    /// 
    /// Requires valid user access token and password
    /// </summary>
    public class PublicSubmitUserAccountDeletionRequest : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicSubmitUserAccountDeletionRequestBuilder Builder { get => new PublicSubmitUserAccountDeletionRequestBuilder(); }

        public class PublicSubmitUserAccountDeletionRequestBuilder
            : OperationBuilder<PublicSubmitUserAccountDeletionRequestBuilder>
        {





            internal PublicSubmitUserAccountDeletionRequestBuilder() { }

            internal PublicSubmitUserAccountDeletionRequestBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicSubmitUserAccountDeletionRequest Build(
                string password,
                string namespace_,
                string userId
            )
            {
                PublicSubmitUserAccountDeletionRequest op = new PublicSubmitUserAccountDeletionRequest(this,
                    password,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsRequestDeleteResponse? Execute(
                string password,
                string namespace_,
                string userId
            )
            {
                PublicSubmitUserAccountDeletionRequest op = Build(
                    password,
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

        private PublicSubmitUserAccountDeletionRequest(PublicSubmitUserAccountDeletionRequestBuilder builder,
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

        public PublicSubmitUserAccountDeletionRequest(
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

        public override string Path => "/gdpr/public/namespaces/{namespace}/users/{userId}/deletions";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsRequestDeleteResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsRequestDeleteResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsRequestDeleteResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
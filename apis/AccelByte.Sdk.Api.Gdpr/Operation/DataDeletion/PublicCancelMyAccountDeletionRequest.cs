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
    /// PublicCancelMyAccountDeletionRequest
    ///
    /// 
    /// 
    /// Requires valid user access token
    /// </summary>
    public class PublicCancelMyAccountDeletionRequest : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicCancelMyAccountDeletionRequestBuilder Builder { get => new PublicCancelMyAccountDeletionRequestBuilder(); }

        public class PublicCancelMyAccountDeletionRequestBuilder
            : OperationBuilder<PublicCancelMyAccountDeletionRequestBuilder>
        {





            internal PublicCancelMyAccountDeletionRequestBuilder() { }

            internal PublicCancelMyAccountDeletionRequestBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicCancelMyAccountDeletionRequest Build(
            )
            {
                PublicCancelMyAccountDeletionRequest op = new PublicCancelMyAccountDeletionRequest(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
            )
            {
                PublicCancelMyAccountDeletionRequest op = Build(
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

        private PublicCancelMyAccountDeletionRequest(PublicCancelMyAccountDeletionRequestBuilder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicCancelMyAccountDeletionRequest(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/public/users/me/deletions";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

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
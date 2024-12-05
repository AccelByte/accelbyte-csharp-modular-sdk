// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
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
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// PublicForceLinkPlatformWithProgression
    ///
    /// Force update other account's Platform Account relation to current User Account.
    /// This endpoint can transfer progression from 3rd platform binding account's to current account.
    /// This endpoint need the same requestID which also used in [Get link status](#operations-Users-PublicGetAsyncStatus).
    /// 
    /// 
    /// **Authentication:**
    /// The _**userId**_ parameter should match the one in the access token.
    /// </summary>
    public class PublicForceLinkPlatformWithProgression : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicForceLinkPlatformWithProgressionBuilder Builder { get => new PublicForceLinkPlatformWithProgressionBuilder(); }

        public class PublicForceLinkPlatformWithProgressionBuilder
            : OperationBuilder<PublicForceLinkPlatformWithProgressionBuilder>
        {





            internal PublicForceLinkPlatformWithProgressionBuilder() { }

            internal PublicForceLinkPlatformWithProgressionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicForceLinkPlatformWithProgression Build(
                ModelLinkPlatformAccountWithProgressionRequest body,
                string namespace_,
                string userId
            )
            {
                PublicForceLinkPlatformWithProgression op = new PublicForceLinkPlatformWithProgression(this,
                    body,
                    namespace_,
                    userId
                );

                op.SetBaseFields<PublicForceLinkPlatformWithProgressionBuilder>(this);
                return op;
            }

            public PublicForceLinkPlatformWithProgression.Response Execute(
                ModelLinkPlatformAccountWithProgressionRequest body,
                string namespace_,
                string userId
            )
            {
                PublicForceLinkPlatformWithProgression op = Build(
                    body,
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
            public async Task<PublicForceLinkPlatformWithProgression.Response> ExecuteAsync(
                ModelLinkPlatformAccountWithProgressionRequest body,
                string namespace_,
                string userId
            )
            {
                PublicForceLinkPlatformWithProgression op = Build(
                    body,
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private PublicForceLinkPlatformWithProgression(PublicForceLinkPlatformWithProgressionBuilder builder,
            ModelLinkPlatformAccountWithProgressionRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::Users::PublicForceLinkPlatformWithProgression";
        }

        #endregion

        public PublicForceLinkPlatformWithProgression(
            string namespace_,
            string userId,
            Model.ModelLinkPlatformAccountWithProgressionRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/{userId}/platforms/linkWithProgression";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public PublicForceLinkPlatformWithProgression.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicForceLinkPlatformWithProgression.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)

            {
                response.Error400 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)

            {
                response.Error401 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)

            {
                response.Error403 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)

            {
                response.Error500 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
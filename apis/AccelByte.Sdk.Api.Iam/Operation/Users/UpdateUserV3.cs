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
    /// UpdateUserV3
    ///
    /// This Endpoint support update user based on given data. **Single request can update single field or multi fields.**
    /// Supported field {country, displayName, languageTag, dateOfBirth, avatarUrl, userName}
    /// Country use ISO3166-1 alpha-2 two letter, e.g. US.
    /// Date of Birth format : YYYY-MM-DD, e.g. 2019-04-29.
    /// **Response body logic when user updating email address:**
    /// - User want to update email address of which have been verified, newEmailAddress response field will be filled with new email address.
    /// - User want to update email address of which have not been verified, { oldEmailAddress, emailAddress} response field will be filled with new email address.
    /// - User want to update email address of which have been verified and updated before, { oldEmailAddress, emailAddress} response field will be filled with verified email before. newEmailAddress response field will be filled with newest email address.
    /// 
    /// **Important notes:**
    /// This endpoint provides support for client that doesn't have PATCH support, i.e. UE4 before v4.23 released.
    /// If the client support PATCH method, use [PATCH] /iam/v3/public/namespaces/{namespace}/users/me instead
    /// 
    /// action code : 10103
    /// </summary>
    public class UpdateUserV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateUserV3Builder Builder { get => new UpdateUserV3Builder(); }

        public class UpdateUserV3Builder
            : OperationBuilder<UpdateUserV3Builder>
        {





            internal UpdateUserV3Builder() { }

            internal UpdateUserV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateUserV3 Build(
                ModelUserUpdateRequestV3 body,
                string namespace_
            )
            {
                UpdateUserV3 op = new UpdateUserV3(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelUserResponseV3? Execute(
                ModelUserUpdateRequestV3 body,
                string namespace_
            )
            {
                UpdateUserV3 op = Build(
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

        private UpdateUserV3(UpdateUserV3Builder builder,
            ModelUserUpdateRequestV3 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateUserV3(
            string namespace_,
            Model.ModelUserUpdateRequestV3 body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/me";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelUserResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponseV3>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponseV3>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
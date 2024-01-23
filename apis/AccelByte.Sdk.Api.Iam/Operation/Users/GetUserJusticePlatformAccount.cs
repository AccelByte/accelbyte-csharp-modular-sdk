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
    /// GetUserJusticePlatformAccount
    ///
    /// ## The endpoint is going to be deprecated
    /// ### Endpoint migration guide
    /// - **Substitute endpoint: _/iam/v3/admin/namespaces/{namespace}/users/{userId}/platforms/justice/{targetNamespace} [GET]_**
    /// 
    /// This endpoint requires the client access token as the bearer token
    /// 
    /// The endpoint returns user Justice platform account linked with the given user. If the user Justice platform account doesn't exist in the designated namespace, the endpoint is going to *create and return the new Justice platform account.*
    /// The newly user Justice platform account is going to be forced to perform token grant through the given user and can't perform password update
    /// 
    /// ### Read Justice Platform Account UserID
    /// Without permission the UserID is going to be censored and replaced with âRedactedâ text.
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class GetUserJusticePlatformAccount : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserJusticePlatformAccountBuilder Builder { get => new GetUserJusticePlatformAccountBuilder(); }

        public class GetUserJusticePlatformAccountBuilder
            : OperationBuilder<GetUserJusticePlatformAccountBuilder>
        {





            internal GetUserJusticePlatformAccountBuilder() { }

            internal GetUserJusticePlatformAccountBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetUserJusticePlatformAccount Build(
                string namespace_,
                string targetNamespace,
                string userId
            )
            {
                GetUserJusticePlatformAccount op = new GetUserJusticePlatformAccount(this,
                    namespace_,
                    targetNamespace,
                    userId
                );

                op.SetBaseFields<GetUserJusticePlatformAccountBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public Model.ModelGetUserJusticePlatformAccountResponse? Execute(
                string namespace_,
                string targetNamespace,
                string userId
            )
            {
                GetUserJusticePlatformAccount op = Build(
                    namespace_,
                    targetNamespace,
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

        private GetUserJusticePlatformAccount(GetUserJusticePlatformAccountBuilder builder,
            string namespace_,
            string targetNamespace,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["targetNamespace"] = targetNamespace;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserJusticePlatformAccount(
            string namespace_,
            string targetNamespace,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["targetNamespace"] = targetNamespace;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/platforms/justice/{targetNamespace}";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelGetUserJusticePlatformAccountResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelGetUserJusticePlatformAccountResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelGetUserJusticePlatformAccountResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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
    /// PublicGetUserByUserIDV2
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Endpoint migration guide
    /// 
    /// 
    ///             * Substitute endpoint(Public): /iam/v3/public/namespaces/{namespace}/users/{userId} [GET]
    /// 
    ///             * Substitute endpoint(Admin): /iam/v3/admin/namespaces/{namespace}/users/{userId} [GET]
    /// 
    /// 
    /// 
    ///             * Note:
    ///     format difference in response: Pascal case => Camel case
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class PublicGetUserByUserIDV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserByUserIDV2Builder Builder { get => new PublicGetUserByUserIDV2Builder(); }

        public class PublicGetUserByUserIDV2Builder
            : OperationBuilder<PublicGetUserByUserIDV2Builder>
        {





            internal PublicGetUserByUserIDV2Builder() { }

            internal PublicGetUserByUserIDV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetUserByUserIDV2 Build(
                string namespace_,
                string userId
            )
            {
                PublicGetUserByUserIDV2 op = new PublicGetUserByUserIDV2(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public Model.ModelUserResponse? Execute(
                string namespace_,
                string userId
            )
            {
                PublicGetUserByUserIDV2 op = Build(
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

        private PublicGetUserByUserIDV2(PublicGetUserByUserIDV2Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetUserByUserIDV2(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v2/public/namespaces/{namespace}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelUserResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponse>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
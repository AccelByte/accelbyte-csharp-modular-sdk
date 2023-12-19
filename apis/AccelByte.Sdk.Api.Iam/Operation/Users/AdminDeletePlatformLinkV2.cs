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
    /// AdminDeletePlatformLinkV2
    ///
    /// ## The endpoint is going to be deprecated
    /// **Endpoint migration guide**
    /// - **Substitute endpoint: _/iam/v3/admin/namespaces/{namespace}/users/{userId}/platforms/{platformId} [DELETE]_**
    /// 
    /// ## Supported platforms:
    /// - **steam**
    /// - **steamopenid**
    /// - **facebook**
    /// - **google**
    /// - **oculus**
    /// - **twitch**
    /// - **android**
    /// - **ios**
    /// - **device**
    /// - **discord**
    /// 
    /// Delete link of user's account with platform. 'justice' platform might have multiple accounts from different namespaces linked. platform_namespace need to be specified when the platform ID is 'justice'.
    /// Delete link of justice platform will enable password token grant and password update.
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class AdminDeletePlatformLinkV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeletePlatformLinkV2Builder Builder { get => new AdminDeletePlatformLinkV2Builder(); }

        public class AdminDeletePlatformLinkV2Builder
            : OperationBuilder<AdminDeletePlatformLinkV2Builder>
        {



            public string? PlatformNamespace { get; set; }



            internal AdminDeletePlatformLinkV2Builder() { }

            internal AdminDeletePlatformLinkV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }




            public AdminDeletePlatformLinkV2Builder SetPlatformNamespace(string _platformNamespace)
            {
                PlatformNamespace = _platformNamespace;
                return this;
            }



            public AdminDeletePlatformLinkV2 Build(
                string namespace_,
                string platformId,
                string userId
            )
            {
                AdminDeletePlatformLinkV2 op = new AdminDeletePlatformLinkV2(this,
                    namespace_,
                    platformId,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public void Execute(
                string namespace_,
                string platformId,
                string userId
            )
            {
                AdminDeletePlatformLinkV2 op = Build(
                    namespace_,
                    platformId,
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

        private AdminDeletePlatformLinkV2(AdminDeletePlatformLinkV2Builder builder,
            string namespace_,
            string platformId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["userId"] = userId;


            if (builder.PlatformNamespace is not null) FormParams["platform_namespace"] = builder.PlatformNamespace;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeletePlatformLinkV2(
            string namespace_,
            string platformId,
            string userId,
            string? platformNamespace
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["userId"] = userId;


            if (platformNamespace is not null) FormParams["platform_namespace"] = platformNamespace;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v2/admin/namespaces/{namespace}/users/{userId}/platforms/{platformId}/link";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded", "text/plain" };

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
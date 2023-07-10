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
    /// ListCrossNamespaceAccountLink
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Endpoint migration guide
    /// 
    /// 
    ///     * Substitute endpoint: /iam/v3/public/namespaces/{namespace}/users/me/platforms/{platformId} [POST]
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// Required permission 'NAMESPACE:{namespace}:USER:{userId} [UPDATE]'.
    /// 
    /// 
    /// 
    /// 
    /// 
    /// Access token from original namespace is needed as authorization header. Access token from designated account needed as form parameter to verify the ownership of that account.
    /// When platformID (device platfom ID) is specified, platform login method for that specific platform ID is removed.
    /// This means to protect account from second hand device usage.
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class ListCrossNamespaceAccountLink : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListCrossNamespaceAccountLinkBuilder Builder { get => new ListCrossNamespaceAccountLinkBuilder(); }

        public class ListCrossNamespaceAccountLinkBuilder
            : OperationBuilder<ListCrossNamespaceAccountLinkBuilder>
        {



            public string? PlatformId { get; set; }



            internal ListCrossNamespaceAccountLinkBuilder() { }

            internal ListCrossNamespaceAccountLinkBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }




            public ListCrossNamespaceAccountLinkBuilder SetPlatformId(string _platformId)
            {
                PlatformId = _platformId;
                return this;
            }



            public ListCrossNamespaceAccountLink Build(
                string linkingToken,
                string namespace_,
                string userId
            )
            {
                ListCrossNamespaceAccountLink op = new ListCrossNamespaceAccountLink(this,
                    linkingToken,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public void Execute(
                string linkingToken,
                string namespace_,
                string userId
            )
            {
                ListCrossNamespaceAccountLink op = Build(
                    linkingToken,
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

        private ListCrossNamespaceAccountLink(ListCrossNamespaceAccountLinkBuilder builder,
            string linkingToken,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;


            if (builder.PlatformId is not null) FormParams["platformId"] = builder.PlatformId;
            if (linkingToken is not null) FormParams["linkingToken"] = linkingToken;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ListCrossNamespaceAccountLink(
            string namespace_,
            string userId,
            string? platformId,
            string linkingToken
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;


            if (platformId is not null) FormParams["platformId"] = platformId;
            if (linkingToken is not null) FormParams["linkingToken"] = linkingToken;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/crosslink";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
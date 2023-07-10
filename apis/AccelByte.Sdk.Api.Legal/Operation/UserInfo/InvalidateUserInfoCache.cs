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

using AccelByte.Sdk.Api.Legal.Model;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// invalidateUserInfoCache
    ///
    ///  Important: GOING TO DEPRECATE
    /// 
    /// Invalidate user info cache in agreement service.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=8 (DELETE)
    /// </summary>
    public class InvalidateUserInfoCache : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static InvalidateUserInfoCacheBuilder Builder { get => new InvalidateUserInfoCacheBuilder(); }

        public class InvalidateUserInfoCacheBuilder
            : OperationBuilder<InvalidateUserInfoCacheBuilder>
        {

            public string? Namespace { get; set; }





            internal InvalidateUserInfoCacheBuilder() { }

            internal InvalidateUserInfoCacheBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public InvalidateUserInfoCacheBuilder SetNamespace(string _namespace_)
            {
                Namespace = _namespace_;
                return this;
            }





            public InvalidateUserInfoCache Build(
            )
            {
                InvalidateUserInfoCache op = new InvalidateUserInfoCache(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
            )
            {
                InvalidateUserInfoCache op = Build(
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

        private InvalidateUserInfoCache(InvalidateUserInfoCacheBuilder builder
        )
        {

            if (builder.Namespace is not null) QueryParams["namespace"] = builder.Namespace;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public InvalidateUserInfoCache(
            string? namespace_
        )
        {

            if (namespace_ is not null) QueryParams["namespace"] = namespace_;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/userInfo";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { };

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
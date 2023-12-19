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
    /// CheckUserAvailability
    ///
    /// Check user's account availability.
    /// Available field :
    /// - displayName
    /// - username
    /// 
    /// If request include access token with user ID data, that user ID will be excluded from availability check.
    /// For example, in case user update his emailAddress, he can use his own emailAddress to update his account.
    /// 
    /// Response Code :
    /// - Account Available : 404 (not found)
    /// - Account Not Available : 204 (no content)
    /// </summary>
    public class CheckUserAvailability : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CheckUserAvailabilityBuilder Builder { get => new CheckUserAvailabilityBuilder(); }

        public class CheckUserAvailabilityBuilder
            : OperationBuilder<CheckUserAvailabilityBuilder>
        {





            internal CheckUserAvailabilityBuilder() { }

            internal CheckUserAvailabilityBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CheckUserAvailability Build(
                string namespace_,
                string field,
                string query
            )
            {
                CheckUserAvailability op = new CheckUserAvailability(this,
                    namespace_,
                    field,
                    query
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string namespace_,
                string field,
                string query
            )
            {
                CheckUserAvailability op = Build(
                    namespace_,
                    field,
                    query
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

        private CheckUserAvailability(CheckUserAvailabilityBuilder builder,
            string namespace_,
            string field,
            string query
        )
        {
            PathParams["namespace"] = namespace_;

            if (field is not null) QueryParams["field"] = field;
            if (query is not null) QueryParams["query"] = query;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CheckUserAvailability(
            string namespace_,
            string field,
            string query
        )
        {
            PathParams["namespace"] = namespace_;

            if (field is not null) QueryParams["field"] = field;
            if (query is not null) QueryParams["query"] = query;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/availability";

        public override HttpMethod Method => HttpMethod.Get;

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
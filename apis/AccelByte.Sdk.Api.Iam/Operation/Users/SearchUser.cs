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
    /// SearchUser
    ///
    /// ## The endpoint is going to be deprecated
    /// ### Endpoint migration guide
    /// - **Substitute endpoint: _/iam/v3/admin/namespaces/{namespace}/users/search [GET]_**
    /// Search all users that match the query on these fields: all login IDs (email address, phone number, and platform user id),
    /// userID, display name, and on the specified namespace. If the query is not defined, then it searches all users on the specified namespace.
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class SearchUser : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SearchUserBuilder Builder { get => new SearchUserBuilder(); }

        public class SearchUserBuilder
            : OperationBuilder<SearchUserBuilder>
        {

            public string? Query { get; set; }





            internal SearchUserBuilder() { }

            internal SearchUserBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public SearchUserBuilder SetQuery(string _query)
            {
                Query = _query;
                return this;
            }





            public SearchUser Build(
                string namespace_
            )
            {
                SearchUser op = new SearchUser(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public Model.ModelSearchUsersResponse? Execute(
                string namespace_
            )
            {
                SearchUser op = Build(
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

        private SearchUser(SearchUserBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Query is not null) QueryParams["query"] = builder.Query;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SearchUser(
            string namespace_,
            string? query
        )
        {
            PathParams["namespace"] = namespace_;

            if (query is not null) QueryParams["query"] = query;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/namespaces/{namespace}/users/search";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelSearchUsersResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelSearchUsersResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelSearchUsersResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
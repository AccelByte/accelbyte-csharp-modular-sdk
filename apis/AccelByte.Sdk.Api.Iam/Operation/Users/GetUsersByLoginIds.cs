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
    /// GetUsersByLoginIds
    ///
    /// ## The endpoint is going to be deprecated
    /// ### Endpoint migration guide
    /// - **Substitute endpoint(query by email list): _/iam/v3/public/namespaces/{namespace}/users/bulk/basic [POST]_**
    /// - **Substitute endpoint(query by user id list): _/iam/v3/admin/namespaces/{namespace}/users/search/bulk [POST]_**
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class GetUsersByLoginIds : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUsersByLoginIdsBuilder Builder { get => new GetUsersByLoginIdsBuilder(); }

        public class GetUsersByLoginIdsBuilder
            : OperationBuilder<GetUsersByLoginIdsBuilder>
        {

            public string? LoginIds { get; set; }





            internal GetUsersByLoginIdsBuilder() { }

            internal GetUsersByLoginIdsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetUsersByLoginIdsBuilder SetLoginIds(string _loginIds)
            {
                LoginIds = _loginIds;
                return this;
            }





            public GetUsersByLoginIds Build(
                string namespace_
            )
            {
                GetUsersByLoginIds op = new GetUsersByLoginIds(this,
                    namespace_
                );

                op.SetBaseFields<GetUsersByLoginIdsBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public Model.ModelPublicUsersResponse? Execute(
                string namespace_
            )
            {
                GetUsersByLoginIds op = Build(
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

        private GetUsersByLoginIds(GetUsersByLoginIdsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.LoginIds is not null) QueryParams["loginIds"] = builder.LoginIds;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUsersByLoginIds(
            string namespace_,
            string? loginIds
        )
        {
            PathParams["namespace"] = namespace_;

            if (loginIds is not null) QueryParams["loginIds"] = loginIds;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/namespaces/{namespace}/users/listByLoginIds";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelPublicUsersResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelPublicUsersResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelPublicUsersResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
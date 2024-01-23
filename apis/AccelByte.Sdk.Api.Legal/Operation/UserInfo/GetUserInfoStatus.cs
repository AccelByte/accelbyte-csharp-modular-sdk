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
    /// getUserInfoStatus
    ///
    /// Get user info cache last updated time per namespace.
    /// The query parameter namespaces can be a list of namespace separated by comma.
    /// If query parameter namespaces is empty, user info cache status for all available namespaces will be returned.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=2 (READ)
    /// </summary>
    public class GetUserInfoStatus : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserInfoStatusBuilder Builder { get => new GetUserInfoStatusBuilder(); }

        public class GetUserInfoStatusBuilder
            : OperationBuilder<GetUserInfoStatusBuilder>
        {

            public string? Namespaces { get; set; }





            internal GetUserInfoStatusBuilder() { }

            internal GetUserInfoStatusBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetUserInfoStatusBuilder SetNamespaces(string _namespaces)
            {
                Namespaces = _namespaces;
                return this;
            }





            public GetUserInfoStatus Build(
            )
            {
                GetUserInfoStatus op = new GetUserInfoStatus(this
                );

                op.SetBaseFields<GetUserInfoStatusBuilder>(this);
                return op;
            }

            public List<Model.RetrieveUserInfoCacheStatusResponse>? Execute(
            )
            {
                GetUserInfoStatus op = Build(
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

        private GetUserInfoStatus(GetUserInfoStatusBuilder builder
        )
        {

            if (builder.Namespaces is not null) QueryParams["namespaces"] = builder.Namespaces;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserInfoStatus(
            string? namespaces
        )
        {

            if (namespaces is not null) QueryParams["namespaces"] = namespaces;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/userInfo";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.RetrieveUserInfoCacheStatusResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.RetrieveUserInfoCacheStatusResponse>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.RetrieveUserInfoCacheStatusResponse>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
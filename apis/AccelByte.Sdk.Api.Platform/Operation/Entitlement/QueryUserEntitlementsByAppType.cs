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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// queryUserEntitlementsByAppType
    ///
    /// Query app entitlements by appType.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=2
    ///   *  Returns : app entitlement pagination
    /// </summary>
    public class QueryUserEntitlementsByAppType : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryUserEntitlementsByAppTypeBuilder Builder { get => new QueryUserEntitlementsByAppTypeBuilder(); }

        public class QueryUserEntitlementsByAppTypeBuilder
            : OperationBuilder<QueryUserEntitlementsByAppTypeBuilder>
        {

            public bool? ActiveOnly { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }





            internal QueryUserEntitlementsByAppTypeBuilder() { }

            internal QueryUserEntitlementsByAppTypeBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QueryUserEntitlementsByAppTypeBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public QueryUserEntitlementsByAppTypeBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryUserEntitlementsByAppTypeBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }





            public QueryUserEntitlementsByAppType Build(
                string namespace_,
                string userId,
                QueryUserEntitlementsByAppTypeAppType appType
            )
            {
                QueryUserEntitlementsByAppType op = new QueryUserEntitlementsByAppType(this,
                    namespace_,
                    userId,
                    appType
                );

                op.SetBaseFields<QueryUserEntitlementsByAppTypeBuilder>(this);
                return op;
            }

            public Model.AppEntitlementPagingSlicedResult? Execute(
                string namespace_,
                string userId,
                string appType
            )
            {
                QueryUserEntitlementsByAppType op = Build(
                    namespace_,
                    userId,
                    appType
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

        private QueryUserEntitlementsByAppType(QueryUserEntitlementsByAppTypeBuilder builder,
            string namespace_,
            string userId,
            QueryUserEntitlementsByAppTypeAppType appType
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (appType is not null) QueryParams["appType"] = appType.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryUserEntitlementsByAppType(
            string namespace_,
            string userId,
            bool? activeOnly,
            int? limit,
            int? offset,
            QueryUserEntitlementsByAppTypeAppType appType
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (appType is not null) QueryParams["appType"] = appType.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/byAppType";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.AppEntitlementPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AppEntitlementPagingSlicedResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AppEntitlementPagingSlicedResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class QueryUserEntitlementsByAppTypeAppType : StringEnum<QueryUserEntitlementsByAppTypeAppType>
    {
        public static readonly QueryUserEntitlementsByAppTypeAppType DEMO
            = new QueryUserEntitlementsByAppTypeAppType("DEMO");

        public static readonly QueryUserEntitlementsByAppTypeAppType DLC
            = new QueryUserEntitlementsByAppTypeAppType("DLC");

        public static readonly QueryUserEntitlementsByAppTypeAppType GAME
            = new QueryUserEntitlementsByAppTypeAppType("GAME");

        public static readonly QueryUserEntitlementsByAppTypeAppType SOFTWARE
            = new QueryUserEntitlementsByAppTypeAppType("SOFTWARE");


        public static implicit operator QueryUserEntitlementsByAppTypeAppType(string value)
        {
            return NewValue(value);
        }

        public QueryUserEntitlementsByAppTypeAppType(string enumValue)
            : base(enumValue)
        {

        }
    }

}
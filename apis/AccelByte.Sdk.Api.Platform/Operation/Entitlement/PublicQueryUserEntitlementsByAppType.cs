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
    /// publicQueryUserEntitlementsByAppType
    ///
    /// Query app entitlements by appType.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=2 (READ)
    ///   *  Returns : app entitlement pagination
    /// </summary>
    public class PublicQueryUserEntitlementsByAppType : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicQueryUserEntitlementsByAppTypeBuilder Builder { get => new PublicQueryUserEntitlementsByAppTypeBuilder(); }

        public class PublicQueryUserEntitlementsByAppTypeBuilder
            : OperationBuilder<PublicQueryUserEntitlementsByAppTypeBuilder>
        {

            public int? Limit { get; set; }

            public int? Offset { get; set; }





            internal PublicQueryUserEntitlementsByAppTypeBuilder() { }

            internal PublicQueryUserEntitlementsByAppTypeBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicQueryUserEntitlementsByAppTypeBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicQueryUserEntitlementsByAppTypeBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }





            public PublicQueryUserEntitlementsByAppType Build(
                string namespace_,
                string userId,
                PublicQueryUserEntitlementsByAppTypeAppType appType
            )
            {
                PublicQueryUserEntitlementsByAppType op = new PublicQueryUserEntitlementsByAppType(this,
                    namespace_,
                    userId,
                    appType
                );

                op.SetBaseFields<PublicQueryUserEntitlementsByAppTypeBuilder>(this);
                return op;
            }

            public Model.AppEntitlementPagingSlicedResult? Execute(
                string namespace_,
                string userId,
                string appType
            )
            {
                PublicQueryUserEntitlementsByAppType op = Build(
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

        private PublicQueryUserEntitlementsByAppType(PublicQueryUserEntitlementsByAppTypeBuilder builder,
            string namespace_,
            string userId,
            PublicQueryUserEntitlementsByAppTypeAppType appType
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (appType is not null) QueryParams["appType"] = appType.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicQueryUserEntitlementsByAppType(
            string namespace_,
            string userId,
            int? limit,
            int? offset,
            PublicQueryUserEntitlementsByAppTypeAppType appType
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (appType is not null) QueryParams["appType"] = appType.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/entitlements/byAppType";

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

    public class PublicQueryUserEntitlementsByAppTypeAppType : StringEnum<PublicQueryUserEntitlementsByAppTypeAppType>
    {
        public static readonly PublicQueryUserEntitlementsByAppTypeAppType DEMO
            = new PublicQueryUserEntitlementsByAppTypeAppType("DEMO");

        public static readonly PublicQueryUserEntitlementsByAppTypeAppType DLC
            = new PublicQueryUserEntitlementsByAppTypeAppType("DLC");

        public static readonly PublicQueryUserEntitlementsByAppTypeAppType GAME
            = new PublicQueryUserEntitlementsByAppTypeAppType("GAME");

        public static readonly PublicQueryUserEntitlementsByAppTypeAppType SOFTWARE
            = new PublicQueryUserEntitlementsByAppTypeAppType("SOFTWARE");


        public static implicit operator PublicQueryUserEntitlementsByAppTypeAppType(string value)
        {
            return NewValue(value);
        }

        public PublicQueryUserEntitlementsByAppTypeAppType(string enumValue)
            : base(enumValue)
        {

        }
    }

}
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
    /// getUserEntitlementOwnershipBySku
    ///
    /// Get user entitlement ownership by sku.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=2 (READ)
    /// </summary>
    public class GetUserEntitlementOwnershipBySku : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserEntitlementOwnershipBySkuBuilder Builder { get => new GetUserEntitlementOwnershipBySkuBuilder(); }

        public class GetUserEntitlementOwnershipBySkuBuilder
            : OperationBuilder<GetUserEntitlementOwnershipBySkuBuilder>
        {

            public GetUserEntitlementOwnershipBySkuEntitlementClazz? EntitlementClazz { get; set; }

            public string? Platform { get; set; }





            internal GetUserEntitlementOwnershipBySkuBuilder() { }

            internal GetUserEntitlementOwnershipBySkuBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetUserEntitlementOwnershipBySkuBuilder SetEntitlementClazz(GetUserEntitlementOwnershipBySkuEntitlementClazz _entitlementClazz)
            {
                EntitlementClazz = _entitlementClazz;
                return this;
            }

            public GetUserEntitlementOwnershipBySkuBuilder SetPlatform(string _platform)
            {
                Platform = _platform;
                return this;
            }





            public GetUserEntitlementOwnershipBySku Build(
                string namespace_,
                string userId,
                string sku
            )
            {
                GetUserEntitlementOwnershipBySku op = new GetUserEntitlementOwnershipBySku(this,
                    namespace_,
                    userId,
                    sku
                );

                op.SetBaseFields<GetUserEntitlementOwnershipBySkuBuilder>(this);
                return op;
            }

            public Model.TimedOwnership? Execute(
                string namespace_,
                string userId,
                string sku
            )
            {
                GetUserEntitlementOwnershipBySku op = Build(
                    namespace_,
                    userId,
                    sku
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

        private GetUserEntitlementOwnershipBySku(GetUserEntitlementOwnershipBySkuBuilder builder,
            string namespace_,
            string userId,
            string sku
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.EntitlementClazz is not null) QueryParams["entitlementClazz"] = builder.EntitlementClazz.Value;
            if (builder.Platform is not null) QueryParams["platform"] = builder.Platform;
            if (sku is not null) QueryParams["sku"] = sku;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserEntitlementOwnershipBySku(
            string namespace_,
            string userId,
            GetUserEntitlementOwnershipBySkuEntitlementClazz? entitlementClazz,
            string? platform,
            string sku
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (entitlementClazz is not null) QueryParams["entitlementClazz"] = entitlementClazz.Value;
            if (platform is not null) QueryParams["platform"] = platform;
            if (sku is not null) QueryParams["sku"] = sku;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/ownership/bySku";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.TimedOwnership? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.TimedOwnership>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.TimedOwnership>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class GetUserEntitlementOwnershipBySkuEntitlementClazz : StringEnum<GetUserEntitlementOwnershipBySkuEntitlementClazz>
    {
        public static readonly GetUserEntitlementOwnershipBySkuEntitlementClazz APP
            = new GetUserEntitlementOwnershipBySkuEntitlementClazz("APP");

        public static readonly GetUserEntitlementOwnershipBySkuEntitlementClazz CODE
            = new GetUserEntitlementOwnershipBySkuEntitlementClazz("CODE");

        public static readonly GetUserEntitlementOwnershipBySkuEntitlementClazz ENTITLEMENT
            = new GetUserEntitlementOwnershipBySkuEntitlementClazz("ENTITLEMENT");

        public static readonly GetUserEntitlementOwnershipBySkuEntitlementClazz LOOTBOX
            = new GetUserEntitlementOwnershipBySkuEntitlementClazz("LOOTBOX");

        public static readonly GetUserEntitlementOwnershipBySkuEntitlementClazz MEDIA
            = new GetUserEntitlementOwnershipBySkuEntitlementClazz("MEDIA");

        public static readonly GetUserEntitlementOwnershipBySkuEntitlementClazz OPTIONBOX
            = new GetUserEntitlementOwnershipBySkuEntitlementClazz("OPTIONBOX");

        public static readonly GetUserEntitlementOwnershipBySkuEntitlementClazz SUBSCRIPTION
            = new GetUserEntitlementOwnershipBySkuEntitlementClazz("SUBSCRIPTION");


        public static implicit operator GetUserEntitlementOwnershipBySkuEntitlementClazz(string value)
        {
            return NewValue(value);
        }

        public GetUserEntitlementOwnershipBySkuEntitlementClazz(string enumValue)
            : base(enumValue)
        {

        }
    }

}
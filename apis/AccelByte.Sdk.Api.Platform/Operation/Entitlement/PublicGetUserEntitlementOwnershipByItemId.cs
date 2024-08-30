// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
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
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// publicGetUserEntitlementOwnershipByItemId
    ///
    /// Get user entitlement ownership by itemId.
    /// </summary>
    public class PublicGetUserEntitlementOwnershipByItemId : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserEntitlementOwnershipByItemIdBuilder Builder { get => new PublicGetUserEntitlementOwnershipByItemIdBuilder(); }

        public class PublicGetUserEntitlementOwnershipByItemIdBuilder
            : OperationBuilder<PublicGetUserEntitlementOwnershipByItemIdBuilder>
        {

            public PublicGetUserEntitlementOwnershipByItemIdEntitlementClazz? EntitlementClazz { get; set; }





            internal PublicGetUserEntitlementOwnershipByItemIdBuilder() { }

            internal PublicGetUserEntitlementOwnershipByItemIdBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicGetUserEntitlementOwnershipByItemIdBuilder SetEntitlementClazz(PublicGetUserEntitlementOwnershipByItemIdEntitlementClazz _entitlementClazz)
            {
                EntitlementClazz = _entitlementClazz;
                return this;
            }





            public PublicGetUserEntitlementOwnershipByItemId Build(
                string namespace_,
                string userId,
                string itemId
            )
            {
                PublicGetUserEntitlementOwnershipByItemId op = new PublicGetUserEntitlementOwnershipByItemId(this,
                    namespace_,
                    userId,
                    itemId
                );

                op.SetBaseFields<PublicGetUserEntitlementOwnershipByItemIdBuilder>(this);
                return op;
            }

            public Model.TimedOwnership? Execute(
                string namespace_,
                string userId,
                string itemId
            )
            {
                PublicGetUserEntitlementOwnershipByItemId op = Build(
                    namespace_,
                    userId,
                    itemId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.TimedOwnership?> ExecuteAsync(
                string namespace_,
                string userId,
                string itemId
            )
            {
                PublicGetUserEntitlementOwnershipByItemId op = Build(
                    namespace_,
                    userId,
                    itemId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private PublicGetUserEntitlementOwnershipByItemId(PublicGetUserEntitlementOwnershipByItemIdBuilder builder,
            string namespace_,
            string userId,
            string itemId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.EntitlementClazz is not null) QueryParams["entitlementClazz"] = builder.EntitlementClazz.Value;
            if (itemId is not null) QueryParams["itemId"] = itemId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetUserEntitlementOwnershipByItemId(
            string namespace_,
            string userId,
            PublicGetUserEntitlementOwnershipByItemIdEntitlementClazz? entitlementClazz,
            string itemId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (entitlementClazz is not null) QueryParams["entitlementClazz"] = entitlementClazz.Value;
            if (itemId is not null) QueryParams["itemId"] = itemId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/entitlements/ownership/byItemId";

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

    public class PublicGetUserEntitlementOwnershipByItemIdEntitlementClazz : StringEnum<PublicGetUserEntitlementOwnershipByItemIdEntitlementClazz>
    {
        public static readonly PublicGetUserEntitlementOwnershipByItemIdEntitlementClazz APP
            = new PublicGetUserEntitlementOwnershipByItemIdEntitlementClazz("APP");

        public static readonly PublicGetUserEntitlementOwnershipByItemIdEntitlementClazz CODE
            = new PublicGetUserEntitlementOwnershipByItemIdEntitlementClazz("CODE");

        public static readonly PublicGetUserEntitlementOwnershipByItemIdEntitlementClazz ENTITLEMENT
            = new PublicGetUserEntitlementOwnershipByItemIdEntitlementClazz("ENTITLEMENT");

        public static readonly PublicGetUserEntitlementOwnershipByItemIdEntitlementClazz LOOTBOX
            = new PublicGetUserEntitlementOwnershipByItemIdEntitlementClazz("LOOTBOX");

        public static readonly PublicGetUserEntitlementOwnershipByItemIdEntitlementClazz MEDIA
            = new PublicGetUserEntitlementOwnershipByItemIdEntitlementClazz("MEDIA");

        public static readonly PublicGetUserEntitlementOwnershipByItemIdEntitlementClazz OPTIONBOX
            = new PublicGetUserEntitlementOwnershipByItemIdEntitlementClazz("OPTIONBOX");

        public static readonly PublicGetUserEntitlementOwnershipByItemIdEntitlementClazz SUBSCRIPTION
            = new PublicGetUserEntitlementOwnershipByItemIdEntitlementClazz("SUBSCRIPTION");


        public static implicit operator PublicGetUserEntitlementOwnershipByItemIdEntitlementClazz(string value)
        {
            return NewValue(value);
        }

        public PublicGetUserEntitlementOwnershipByItemIdEntitlementClazz(string enumValue)
            : base(enumValue)
        {

        }
    }

}
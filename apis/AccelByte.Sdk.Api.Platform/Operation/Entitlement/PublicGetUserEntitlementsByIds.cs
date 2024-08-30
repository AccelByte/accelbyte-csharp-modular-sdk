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
    /// publicGetUserEntitlementsByIds
    ///
    /// Get user entitlements by ids..
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : entitlement list
    /// </summary>
    public class PublicGetUserEntitlementsByIds : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserEntitlementsByIdsBuilder Builder { get => new PublicGetUserEntitlementsByIdsBuilder(); }

        public class PublicGetUserEntitlementsByIdsBuilder
            : OperationBuilder<PublicGetUserEntitlementsByIdsBuilder>
        {

            public bool? AvailablePlatformOnly { get; set; }

            public List<string>? Ids { get; set; }





            internal PublicGetUserEntitlementsByIdsBuilder() { }

            internal PublicGetUserEntitlementsByIdsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicGetUserEntitlementsByIdsBuilder SetAvailablePlatformOnly(bool _availablePlatformOnly)
            {
                AvailablePlatformOnly = _availablePlatformOnly;
                return this;
            }

            public PublicGetUserEntitlementsByIdsBuilder SetIds(List<string> _ids)
            {
                Ids = _ids;
                return this;
            }





            public PublicGetUserEntitlementsByIds Build(
                string namespace_,
                string userId
            )
            {
                PublicGetUserEntitlementsByIds op = new PublicGetUserEntitlementsByIds(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<PublicGetUserEntitlementsByIdsBuilder>(this);
                return op;
            }

            public List<Model.EntitlementInfo>? Execute(
                string namespace_,
                string userId
            )
            {
                PublicGetUserEntitlementsByIds op = Build(
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<List<Model.EntitlementInfo>?> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                PublicGetUserEntitlementsByIds op = Build(
                    namespace_,
                    userId
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

        private PublicGetUserEntitlementsByIds(PublicGetUserEntitlementsByIdsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.AvailablePlatformOnly != null) QueryParams["availablePlatformOnly"] = Convert.ToString(builder.AvailablePlatformOnly)!;
            if (builder.Ids is not null) QueryParams["ids"] = builder.Ids;



            CollectionFormatMap["ids"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetUserEntitlementsByIds(
            string namespace_,
            string userId,
            bool? availablePlatformOnly,
            List<string>? ids
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (availablePlatformOnly != null) QueryParams["availablePlatformOnly"] = Convert.ToString(availablePlatformOnly)!;
            if (ids is not null) QueryParams["ids"] = ids;



            CollectionFormatMap["ids"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/entitlements/byIds";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.EntitlementInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.EntitlementInfo>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.EntitlementInfo>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
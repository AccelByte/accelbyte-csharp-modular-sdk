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
    /// existsAnyUserActiveEntitlementByItemIds
    ///
    /// Exists any user active entitlement of specified items.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=2 (READ)
    /// </summary>
    public class ExistsAnyUserActiveEntitlementByItemIds : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ExistsAnyUserActiveEntitlementByItemIdsBuilder Builder { get => new ExistsAnyUserActiveEntitlementByItemIdsBuilder(); }

        public class ExistsAnyUserActiveEntitlementByItemIdsBuilder
            : OperationBuilder<ExistsAnyUserActiveEntitlementByItemIdsBuilder>
        {

            public string? Platform { get; set; }





            internal ExistsAnyUserActiveEntitlementByItemIdsBuilder() { }

            internal ExistsAnyUserActiveEntitlementByItemIdsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public ExistsAnyUserActiveEntitlementByItemIdsBuilder SetPlatform(string _platform)
            {
                Platform = _platform;
                return this;
            }





            public ExistsAnyUserActiveEntitlementByItemIds Build(
                string namespace_,
                string userId,
                List<string> itemIds
            )
            {
                ExistsAnyUserActiveEntitlementByItemIds op = new ExistsAnyUserActiveEntitlementByItemIds(this,
                    namespace_,
                    userId,
                    itemIds
                );

                op.SetBaseFields<ExistsAnyUserActiveEntitlementByItemIdsBuilder>(this);
                return op;
            }

            public Model.Ownership? Execute(
                string namespace_,
                string userId,
                List<string> itemIds
            )
            {
                ExistsAnyUserActiveEntitlementByItemIds op = Build(
                    namespace_,
                    userId,
                    itemIds
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.Ownership?> ExecuteAsync(
                string namespace_,
                string userId,
                List<string> itemIds
            )
            {
                ExistsAnyUserActiveEntitlementByItemIds op = Build(
                    namespace_,
                    userId,
                    itemIds
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

        private ExistsAnyUserActiveEntitlementByItemIds(ExistsAnyUserActiveEntitlementByItemIdsBuilder builder,
            string namespace_,
            string userId,
            List<string> itemIds
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.Platform is not null) QueryParams["platform"] = builder.Platform;
            if (itemIds is not null) QueryParams["itemIds"] = itemIds;



            CollectionFormatMap["itemIds"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ExistsAnyUserActiveEntitlementByItemIds(
            string namespace_,
            string userId,
            string? platform,
            List<string> itemIds
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (platform is not null) QueryParams["platform"] = platform;
            if (itemIds is not null) QueryParams["itemIds"] = itemIds;



            CollectionFormatMap["itemIds"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/ownership/anyOf";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.Ownership? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.Ownership>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.Ownership>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
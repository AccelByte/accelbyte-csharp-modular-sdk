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
    /// getUserEntitlementByItemId
    ///
    /// Get user entitlement by itemId.
    /// </summary>
    public class GetUserEntitlementByItemId : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserEntitlementByItemIdBuilder Builder { get => new GetUserEntitlementByItemIdBuilder(); }

        public class GetUserEntitlementByItemIdBuilder
            : OperationBuilder<GetUserEntitlementByItemIdBuilder>
        {

            public bool? ActiveOnly { get; set; }

            public GetUserEntitlementByItemIdEntitlementClazz? EntitlementClazz { get; set; }

            public string? Platform { get; set; }





            internal GetUserEntitlementByItemIdBuilder() { }

            internal GetUserEntitlementByItemIdBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetUserEntitlementByItemIdBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public GetUserEntitlementByItemIdBuilder SetEntitlementClazz(GetUserEntitlementByItemIdEntitlementClazz _entitlementClazz)
            {
                EntitlementClazz = _entitlementClazz;
                return this;
            }

            public GetUserEntitlementByItemIdBuilder SetPlatform(string _platform)
            {
                Platform = _platform;
                return this;
            }





            public GetUserEntitlementByItemId Build(
                string namespace_,
                string userId,
                string itemId
            )
            {
                GetUserEntitlementByItemId op = new GetUserEntitlementByItemId(this,
                    namespace_,
                    userId,
                    itemId
                );

                op.SetBaseFields<GetUserEntitlementByItemIdBuilder>(this);
                return op;
            }

            public GetUserEntitlementByItemId.Response Execute(
                string namespace_,
                string userId,
                string itemId
            )
            {
                GetUserEntitlementByItemId op = Build(
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
            public async Task<GetUserEntitlementByItemId.Response> ExecuteAsync(
                string namespace_,
                string userId,
                string itemId
            )
            {
                GetUserEntitlementByItemId op = Build(
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

        private GetUserEntitlementByItemId(GetUserEntitlementByItemIdBuilder builder,
            string namespace_,
            string userId,
            string itemId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.EntitlementClazz is not null) QueryParams["entitlementClazz"] = builder.EntitlementClazz.Value;
            if (builder.Platform is not null) QueryParams["platform"] = builder.Platform;
            if (itemId is not null) QueryParams["itemId"] = itemId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.EntitlementInfo>
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Entitlement::GetUserEntitlementByItemId";
        }

        #endregion

        public GetUserEntitlementByItemId(
            string namespace_,
            string userId,
            bool? activeOnly,
            GetUserEntitlementByItemIdEntitlementClazz? entitlementClazz,
            string? platform,
            string itemId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (entitlementClazz is not null) QueryParams["entitlementClazz"] = entitlementClazz.Value;
            if (platform is not null) QueryParams["platform"] = platform;
            if (itemId is not null) QueryParams["itemId"] = itemId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/byItemId";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public GetUserEntitlementByItemId.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetUserEntitlementByItemId.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.EntitlementInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }

            return response;
        }
    }

    public class GetUserEntitlementByItemIdEntitlementClazz : StringEnum<GetUserEntitlementByItemIdEntitlementClazz>
    {
        public static readonly GetUserEntitlementByItemIdEntitlementClazz APP
            = new GetUserEntitlementByItemIdEntitlementClazz("APP");

        public static readonly GetUserEntitlementByItemIdEntitlementClazz CODE
            = new GetUserEntitlementByItemIdEntitlementClazz("CODE");

        public static readonly GetUserEntitlementByItemIdEntitlementClazz ENTITLEMENT
            = new GetUserEntitlementByItemIdEntitlementClazz("ENTITLEMENT");

        public static readonly GetUserEntitlementByItemIdEntitlementClazz LOOTBOX
            = new GetUserEntitlementByItemIdEntitlementClazz("LOOTBOX");

        public static readonly GetUserEntitlementByItemIdEntitlementClazz MEDIA
            = new GetUserEntitlementByItemIdEntitlementClazz("MEDIA");

        public static readonly GetUserEntitlementByItemIdEntitlementClazz OPTIONBOX
            = new GetUserEntitlementByItemIdEntitlementClazz("OPTIONBOX");

        public static readonly GetUserEntitlementByItemIdEntitlementClazz SUBSCRIPTION
            = new GetUserEntitlementByItemIdEntitlementClazz("SUBSCRIPTION");


        public static implicit operator GetUserEntitlementByItemIdEntitlementClazz(string value)
        {
            return NewValue(value);
        }

        public GetUserEntitlementByItemIdEntitlementClazz(string enumValue)
            : base(enumValue)
        {

        }
    }

}
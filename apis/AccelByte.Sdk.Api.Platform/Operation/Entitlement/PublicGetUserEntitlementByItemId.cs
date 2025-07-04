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
    /// publicGetUserEntitlementByItemId
    ///
    /// Get user entitlement by itemId.
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class PublicGetUserEntitlementByItemId : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserEntitlementByItemIdBuilder Builder { get => new PublicGetUserEntitlementByItemIdBuilder(); }

        public class PublicGetUserEntitlementByItemIdBuilder
            : OperationBuilder<PublicGetUserEntitlementByItemIdBuilder>
        {

            public PublicGetUserEntitlementByItemIdEntitlementClazz? EntitlementClazz { get; set; }





            internal PublicGetUserEntitlementByItemIdBuilder() { }

            internal PublicGetUserEntitlementByItemIdBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicGetUserEntitlementByItemIdBuilder SetEntitlementClazz(PublicGetUserEntitlementByItemIdEntitlementClazz _entitlementClazz)
            {
                EntitlementClazz = _entitlementClazz;
                return this;
            }





            public PublicGetUserEntitlementByItemId Build(
                string namespace_,
                string userId,
                string itemId
            )
            {
                PublicGetUserEntitlementByItemId op = new PublicGetUserEntitlementByItemId(this,
                    namespace_,                    
                    userId,                    
                    itemId                    
                );

                op.SetBaseFields<PublicGetUserEntitlementByItemIdBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
            public PublicGetUserEntitlementByItemId.Response Execute(
                string namespace_,
                string userId,
                string itemId
            )
            {
                PublicGetUserEntitlementByItemId op = Build(
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
            public async Task<PublicGetUserEntitlementByItemId.Response> ExecuteAsync(
                string namespace_,
                string userId,
                string itemId
            )
            {
                PublicGetUserEntitlementByItemId op = Build(
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

        private PublicGetUserEntitlementByItemId(PublicGetUserEntitlementByItemIdBuilder builder,
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

        #region Response Part        
        public class Response : ApiResponse<Model.EntitlementInfo>
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Entitlement::PublicGetUserEntitlementByItemId";
        }

        #endregion

        public PublicGetUserEntitlementByItemId(
            string namespace_,            
            string userId,            
            PublicGetUserEntitlementByItemIdEntitlementClazz? entitlementClazz,            
            string itemId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (entitlementClazz is not null) QueryParams["entitlementClazz"] = entitlementClazz.Value;
            if (itemId is not null) QueryParams["itemId"] = itemId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/entitlements/byItemId";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicGetUserEntitlementByItemId.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicGetUserEntitlementByItemId.Response()
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

    public class PublicGetUserEntitlementByItemIdEntitlementClazz : StringEnum<PublicGetUserEntitlementByItemIdEntitlementClazz>
    {
        public static readonly PublicGetUserEntitlementByItemIdEntitlementClazz APP
            = new PublicGetUserEntitlementByItemIdEntitlementClazz("APP");

        public static readonly PublicGetUserEntitlementByItemIdEntitlementClazz CODE
            = new PublicGetUserEntitlementByItemIdEntitlementClazz("CODE");

        public static readonly PublicGetUserEntitlementByItemIdEntitlementClazz ENTITLEMENT
            = new PublicGetUserEntitlementByItemIdEntitlementClazz("ENTITLEMENT");

        public static readonly PublicGetUserEntitlementByItemIdEntitlementClazz LOOTBOX
            = new PublicGetUserEntitlementByItemIdEntitlementClazz("LOOTBOX");

        public static readonly PublicGetUserEntitlementByItemIdEntitlementClazz MEDIA
            = new PublicGetUserEntitlementByItemIdEntitlementClazz("MEDIA");

        public static readonly PublicGetUserEntitlementByItemIdEntitlementClazz OPTIONBOX
            = new PublicGetUserEntitlementByItemIdEntitlementClazz("OPTIONBOX");

        public static readonly PublicGetUserEntitlementByItemIdEntitlementClazz SUBSCRIPTION
            = new PublicGetUserEntitlementByItemIdEntitlementClazz("SUBSCRIPTION");


        public static implicit operator PublicGetUserEntitlementByItemIdEntitlementClazz(string value)
        {
            return NewValue(value);
        }

        public PublicGetUserEntitlementByItemIdEntitlementClazz(string enumValue)
            : base(enumValue)
        {

        }
    }

}
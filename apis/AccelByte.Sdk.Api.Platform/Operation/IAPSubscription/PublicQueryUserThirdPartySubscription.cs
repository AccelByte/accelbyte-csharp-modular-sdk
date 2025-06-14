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
    /// publicQueryUserThirdPartySubscription
    ///
    /// Query user subscription, default sort by updatedAtOther detail info:
    ///   * Returns :
    /// </summary>
    public class PublicQueryUserThirdPartySubscription : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicQueryUserThirdPartySubscriptionBuilder Builder { get => new PublicQueryUserThirdPartySubscriptionBuilder(); }

        public class PublicQueryUserThirdPartySubscriptionBuilder
            : OperationBuilder<PublicQueryUserThirdPartySubscriptionBuilder>
        {

            public bool? ActiveOnly { get; set; }

            public string? GroupId { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public string? ProductId { get; set; }





            internal PublicQueryUserThirdPartySubscriptionBuilder() { }

            internal PublicQueryUserThirdPartySubscriptionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicQueryUserThirdPartySubscriptionBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public PublicQueryUserThirdPartySubscriptionBuilder SetGroupId(string _groupId)
            {
                GroupId = _groupId;
                return this;
            }

            public PublicQueryUserThirdPartySubscriptionBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicQueryUserThirdPartySubscriptionBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public PublicQueryUserThirdPartySubscriptionBuilder SetProductId(string _productId)
            {
                ProductId = _productId;
                return this;
            }





            public PublicQueryUserThirdPartySubscription Build(
                string namespace_,
                PublicQueryUserThirdPartySubscriptionPlatform platform,
                string userId
            )
            {
                PublicQueryUserThirdPartySubscription op = new PublicQueryUserThirdPartySubscription(this,
                    namespace_,                    
                    platform,                    
                    userId                    
                );

                op.SetBaseFields<PublicQueryUserThirdPartySubscriptionBuilder>(this);
                return op;
            }

            public PublicQueryUserThirdPartySubscription.Response Execute(
                string namespace_,
                string platform,
                string userId
            )
            {
                PublicQueryUserThirdPartySubscription op = Build(
                    namespace_,
                    platform,
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
            public async Task<PublicQueryUserThirdPartySubscription.Response> ExecuteAsync(
                string namespace_,
                string platform,
                string userId
            )
            {
                PublicQueryUserThirdPartySubscription op = Build(
                    namespace_,
                    platform,
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

        private PublicQueryUserThirdPartySubscription(PublicQueryUserThirdPartySubscriptionBuilder builder,
            string namespace_,
            PublicQueryUserThirdPartySubscriptionPlatform platform,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platform"] = platform.Value;
            PathParams["userId"] = userId;
            
            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.GroupId is not null) QueryParams["groupId"] = builder.GroupId;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.ProductId is not null) QueryParams["productId"] = builder.ProductId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ThirdPartyUserSubscriptionPagingSlicedResult>
        {


            protected override string GetFullOperationId() => "Platform::IAPSubscription::PublicQueryUserThirdPartySubscription";
        }

        #endregion

        public PublicQueryUserThirdPartySubscription(
            string namespace_,            
            PublicQueryUserThirdPartySubscriptionPlatform platform,            
            string userId,            
            bool? activeOnly,            
            string? groupId,            
            int? limit,            
            int? offset,            
            string? productId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platform"] = platform.Value;
            PathParams["userId"] = userId;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (groupId is not null) QueryParams["groupId"] = groupId;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (productId is not null) QueryParams["productId"] = productId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/iap/subscriptions/platforms/{platform}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicQueryUserThirdPartySubscription.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicQueryUserThirdPartySubscription.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ThirdPartyUserSubscriptionPagingSlicedResult>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

    public class PublicQueryUserThirdPartySubscriptionPlatform : StringEnum<PublicQueryUserThirdPartySubscriptionPlatform>
    {
        public static readonly PublicQueryUserThirdPartySubscriptionPlatform APPLE
            = new PublicQueryUserThirdPartySubscriptionPlatform("APPLE");

        public static readonly PublicQueryUserThirdPartySubscriptionPlatform EPICGAMES
            = new PublicQueryUserThirdPartySubscriptionPlatform("EPICGAMES");

        public static readonly PublicQueryUserThirdPartySubscriptionPlatform GOOGLE
            = new PublicQueryUserThirdPartySubscriptionPlatform("GOOGLE");

        public static readonly PublicQueryUserThirdPartySubscriptionPlatform OCULUS
            = new PublicQueryUserThirdPartySubscriptionPlatform("OCULUS");

        public static readonly PublicQueryUserThirdPartySubscriptionPlatform PLAYSTATION
            = new PublicQueryUserThirdPartySubscriptionPlatform("PLAYSTATION");

        public static readonly PublicQueryUserThirdPartySubscriptionPlatform STADIA
            = new PublicQueryUserThirdPartySubscriptionPlatform("STADIA");

        public static readonly PublicQueryUserThirdPartySubscriptionPlatform STEAM
            = new PublicQueryUserThirdPartySubscriptionPlatform("STEAM");

        public static readonly PublicQueryUserThirdPartySubscriptionPlatform TWITCH
            = new PublicQueryUserThirdPartySubscriptionPlatform("TWITCH");

        public static readonly PublicQueryUserThirdPartySubscriptionPlatform XBOX
            = new PublicQueryUserThirdPartySubscriptionPlatform("XBOX");


        public static implicit operator PublicQueryUserThirdPartySubscriptionPlatform(string value)
        {
            return NewValue(value);
        }

        public PublicQueryUserThirdPartySubscriptionPlatform(string enumValue)
            : base(enumValue)
        {

        }
    }

}
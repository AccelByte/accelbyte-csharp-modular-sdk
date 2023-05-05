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
    /// searchItemTypeConfig
    ///
    /// This API is used to get an item type config.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:ITEM:CONFIG", action=2 (READ)
    ///   *  Returns : item type config data
    /// </summary>
    public class SearchItemTypeConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SearchItemTypeConfigBuilder Builder { get => new SearchItemTypeConfigBuilder(); }

        public class SearchItemTypeConfigBuilder
            : OperationBuilder<SearchItemTypeConfigBuilder>
        {

            public string? Clazz { get; set; }





            internal SearchItemTypeConfigBuilder() { }

            internal SearchItemTypeConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public SearchItemTypeConfigBuilder SetClazz(string _clazz)
            {
                Clazz = _clazz;
                return this;
            }





            public SearchItemTypeConfig Build(
                SearchItemTypeConfigItemType itemType
            )
            {
                SearchItemTypeConfig op = new SearchItemTypeConfig(this,
                    itemType                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ItemTypeConfigInfo? Execute(
                string itemType
            )
            {
                SearchItemTypeConfig op = Build(
                    itemType
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

        private SearchItemTypeConfig(SearchItemTypeConfigBuilder builder,
            SearchItemTypeConfigItemType itemType
        )
        {
            
            if (builder.Clazz is not null) QueryParams["clazz"] = builder.Clazz;
            if (itemType is not null) QueryParams["itemType"] = itemType.Value;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SearchItemTypeConfig(
            string? clazz,            
            SearchItemTypeConfigItemType itemType            
        )
        {
            
            if (clazz is not null) QueryParams["clazz"] = clazz;
            if (itemType is not null) QueryParams["itemType"] = itemType.Value;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/items/configs/search";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ItemTypeConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ItemTypeConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ItemTypeConfigInfo>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

    public class SearchItemTypeConfigItemType : StringEnum<SearchItemTypeConfigItemType>
    {
        public static readonly SearchItemTypeConfigItemType APP
            = new SearchItemTypeConfigItemType("APP");

        public static readonly SearchItemTypeConfigItemType BUNDLE
            = new SearchItemTypeConfigItemType("BUNDLE");

        public static readonly SearchItemTypeConfigItemType CODE
            = new SearchItemTypeConfigItemType("CODE");

        public static readonly SearchItemTypeConfigItemType COINS
            = new SearchItemTypeConfigItemType("COINS");

        public static readonly SearchItemTypeConfigItemType EXTENSION
            = new SearchItemTypeConfigItemType("EXTENSION");

        public static readonly SearchItemTypeConfigItemType INGAMEITEM
            = new SearchItemTypeConfigItemType("INGAMEITEM");

        public static readonly SearchItemTypeConfigItemType LOOTBOX
            = new SearchItemTypeConfigItemType("LOOTBOX");

        public static readonly SearchItemTypeConfigItemType MEDIA
            = new SearchItemTypeConfigItemType("MEDIA");

        public static readonly SearchItemTypeConfigItemType OPTIONBOX
            = new SearchItemTypeConfigItemType("OPTIONBOX");

        public static readonly SearchItemTypeConfigItemType SEASON
            = new SearchItemTypeConfigItemType("SEASON");

        public static readonly SearchItemTypeConfigItemType SUBSCRIPTION
            = new SearchItemTypeConfigItemType("SUBSCRIPTION");


        public static implicit operator SearchItemTypeConfigItemType(string value)
        {
            return NewValue(value);
        }

        public SearchItemTypeConfigItemType(string enumValue)
            : base(enumValue)
        {

        }
    }

}
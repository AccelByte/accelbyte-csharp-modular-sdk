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
    /// searchItemTypeConfig
    ///
    ///  [Not supported yet in AGS Shared Cloud] This API is used to get an item type config.
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : item type config data
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

                op.SetBaseFields<SearchItemTypeConfigBuilder>(this);
                return op;
            }

            public SearchItemTypeConfig.Response Execute(
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
            public async Task<SearchItemTypeConfig.Response> ExecuteAsync(
                string itemType
            )
            {
                SearchItemTypeConfig op = Build(
                    itemType
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

        private SearchItemTypeConfig(SearchItemTypeConfigBuilder builder,
            SearchItemTypeConfigItemType itemType
        )
        {

            if (builder.Clazz is not null) QueryParams["clazz"] = builder.Clazz;
            if (itemType is not null) QueryParams["itemType"] = itemType.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ItemTypeConfigInfo>
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Item::SearchItemTypeConfig";
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

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public SearchItemTypeConfig.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new SearchItemTypeConfig.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ItemTypeConfigInfo>(payload, ResponseJsonOptions);
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
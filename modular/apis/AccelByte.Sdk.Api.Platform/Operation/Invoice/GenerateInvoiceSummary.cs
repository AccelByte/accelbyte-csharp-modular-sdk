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
    /// generateInvoiceSummary
    ///
    /// Generate invoice summary.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ORDER", action=2 (READ)
    ///   *  Returns : query orders
    /// </summary>
    public class GenerateInvoiceSummary : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GenerateInvoiceSummaryBuilder Builder { get => new GenerateInvoiceSummaryBuilder(); }

        public class GenerateInvoiceSummaryBuilder
            : OperationBuilder<GenerateInvoiceSummaryBuilder>
        {

            public string? Feature { get; set; }

            public string? ItemId { get; set; }

            public GenerateInvoiceSummaryItemType? ItemType { get; set; }





            internal GenerateInvoiceSummaryBuilder() { }

            internal GenerateInvoiceSummaryBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GenerateInvoiceSummaryBuilder SetFeature(string _feature)
            {
                Feature = _feature;
                return this;
            }

            public GenerateInvoiceSummaryBuilder SetItemId(string _itemId)
            {
                ItemId = _itemId;
                return this;
            }

            public GenerateInvoiceSummaryBuilder SetItemType(GenerateInvoiceSummaryItemType _itemType)
            {
                ItemType = _itemType;
                return this;
            }





            public GenerateInvoiceSummary Build(
                string namespace_,
                string endTime,
                string startTime
            )
            {
                GenerateInvoiceSummary op = new GenerateInvoiceSummary(this,
                    namespace_,                    
                    endTime,                    
                    startTime                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.InvoiceSummary? Execute(
                string namespace_,
                string endTime,
                string startTime
            )
            {
                GenerateInvoiceSummary op = Build(
                    namespace_,
                    endTime,
                    startTime
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

        private GenerateInvoiceSummary(GenerateInvoiceSummaryBuilder builder,
            string namespace_,
            string endTime,
            string startTime
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Feature is not null) QueryParams["feature"] = builder.Feature;
            if (builder.ItemId is not null) QueryParams["itemId"] = builder.ItemId;
            if (builder.ItemType is not null) QueryParams["itemType"] = builder.ItemType.Value;
            if (endTime is not null) QueryParams["endTime"] = endTime;
            if (startTime is not null) QueryParams["startTime"] = startTime;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GenerateInvoiceSummary(
            string namespace_,            
            string? feature,            
            string? itemId,            
            GenerateInvoiceSummaryItemType? itemType,            
            string endTime,            
            string startTime            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (feature is not null) QueryParams["feature"] = feature;
            if (itemId is not null) QueryParams["itemId"] = itemId;
            if (itemType is not null) QueryParams["itemType"] = itemType.Value;
            if (endTime is not null) QueryParams["endTime"] = endTime;
            if (startTime is not null) QueryParams["startTime"] = startTime;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/invoice/summary";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.InvoiceSummary? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.InvoiceSummary>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.InvoiceSummary>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

    public class GenerateInvoiceSummaryItemType : StringEnum<GenerateInvoiceSummaryItemType>
    {
        public static readonly GenerateInvoiceSummaryItemType APP
            = new GenerateInvoiceSummaryItemType("APP");

        public static readonly GenerateInvoiceSummaryItemType BUNDLE
            = new GenerateInvoiceSummaryItemType("BUNDLE");

        public static readonly GenerateInvoiceSummaryItemType CODE
            = new GenerateInvoiceSummaryItemType("CODE");

        public static readonly GenerateInvoiceSummaryItemType COINS
            = new GenerateInvoiceSummaryItemType("COINS");

        public static readonly GenerateInvoiceSummaryItemType EXTENSION
            = new GenerateInvoiceSummaryItemType("EXTENSION");

        public static readonly GenerateInvoiceSummaryItemType INGAMEITEM
            = new GenerateInvoiceSummaryItemType("INGAMEITEM");

        public static readonly GenerateInvoiceSummaryItemType LOOTBOX
            = new GenerateInvoiceSummaryItemType("LOOTBOX");

        public static readonly GenerateInvoiceSummaryItemType MEDIA
            = new GenerateInvoiceSummaryItemType("MEDIA");

        public static readonly GenerateInvoiceSummaryItemType OPTIONBOX
            = new GenerateInvoiceSummaryItemType("OPTIONBOX");

        public static readonly GenerateInvoiceSummaryItemType SEASON
            = new GenerateInvoiceSummaryItemType("SEASON");

        public static readonly GenerateInvoiceSummaryItemType SUBSCRIPTION
            = new GenerateInvoiceSummaryItemType("SUBSCRIPTION");


        public static implicit operator GenerateInvoiceSummaryItemType(string value)
        {
            return NewValue(value);
        }

        public GenerateInvoiceSummaryItemType(string enumValue)
            : base(enumValue)
        {

        }
    }

}
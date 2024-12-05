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
    /// downloadInvoiceDetails
    ///
    /// Download invoice details as a csv file.
    /// Other detail info:
    /// 
    ///   * Returns : invoice details csv file
    /// </summary>
    public class DownloadInvoiceDetails : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DownloadInvoiceDetailsBuilder Builder { get => new DownloadInvoiceDetailsBuilder(); }

        public class DownloadInvoiceDetailsBuilder
            : OperationBuilder<DownloadInvoiceDetailsBuilder>
        {





            internal DownloadInvoiceDetailsBuilder() { }

            internal DownloadInvoiceDetailsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DownloadInvoiceDetails Build(
                string namespace_,
                string endTime,
                string feature,
                string itemId,
                DownloadInvoiceDetailsItemType itemType,
                string startTime
            )
            {
                DownloadInvoiceDetails op = new DownloadInvoiceDetails(this,
                    namespace_,
                    endTime,
                    feature,
                    itemId,
                    itemType,
                    startTime
                );

                op.SetBaseFields<DownloadInvoiceDetailsBuilder>(this);
                return op;
            }

            public DownloadInvoiceDetails.Response Execute(
                string namespace_,
                string endTime,
                string feature,
                string itemId,
                string itemType,
                string startTime
            )
            {
                DownloadInvoiceDetails op = Build(
                    namespace_,
                    endTime,
                    feature,
                    itemId,
                    itemType,
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
            public async Task<DownloadInvoiceDetails.Response> ExecuteAsync(
                string namespace_,
                string endTime,
                string feature,
                string itemId,
                string itemType,
                string startTime
            )
            {
                DownloadInvoiceDetails op = Build(
                    namespace_,
                    endTime,
                    feature,
                    itemId,
                    itemType,
                    startTime
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

        private DownloadInvoiceDetails(DownloadInvoiceDetailsBuilder builder,
            string namespace_,
            string endTime,
            string feature,
            string itemId,
            DownloadInvoiceDetailsItemType itemType,
            string startTime
        )
        {
            PathParams["namespace"] = namespace_;

            if (endTime is not null) QueryParams["endTime"] = endTime;
            if (feature is not null) QueryParams["feature"] = feature;
            if (itemId is not null) QueryParams["itemId"] = itemId;
            if (itemType is not null) QueryParams["itemType"] = itemType.Value;
            if (startTime is not null) QueryParams["startTime"] = startTime;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Stream>
        {


            protected override string GetFullOperationId() => "Platform::Invoice::DownloadInvoiceDetails";
        }

        #endregion

        public DownloadInvoiceDetails(
            string namespace_,
            string endTime,
            string feature,
            string itemId,
            DownloadInvoiceDetailsItemType itemType,
            string startTime
        )
        {
            PathParams["namespace"] = namespace_;

            if (endTime is not null) QueryParams["endTime"] = endTime;
            if (feature is not null) QueryParams["feature"] = feature;
            if (itemId is not null) QueryParams["itemId"] = itemId;
            if (itemType is not null) QueryParams["itemType"] = itemType.Value;
            if (startTime is not null) QueryParams["startTime"] = startTime;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/invoice/details.csv";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "text/csv" };

        public DownloadInvoiceDetails.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DownloadInvoiceDetails.Response()
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
                response.Data = payload;
                response.IsSuccess = true;
            }

            return response;
        }
    }

    public class DownloadInvoiceDetailsItemType : StringEnum<DownloadInvoiceDetailsItemType>
    {
        public static readonly DownloadInvoiceDetailsItemType APP
            = new DownloadInvoiceDetailsItemType("APP");

        public static readonly DownloadInvoiceDetailsItemType BUNDLE
            = new DownloadInvoiceDetailsItemType("BUNDLE");

        public static readonly DownloadInvoiceDetailsItemType CODE
            = new DownloadInvoiceDetailsItemType("CODE");

        public static readonly DownloadInvoiceDetailsItemType COINS
            = new DownloadInvoiceDetailsItemType("COINS");

        public static readonly DownloadInvoiceDetailsItemType EXTENSION
            = new DownloadInvoiceDetailsItemType("EXTENSION");

        public static readonly DownloadInvoiceDetailsItemType INGAMEITEM
            = new DownloadInvoiceDetailsItemType("INGAMEITEM");

        public static readonly DownloadInvoiceDetailsItemType LOOTBOX
            = new DownloadInvoiceDetailsItemType("LOOTBOX");

        public static readonly DownloadInvoiceDetailsItemType MEDIA
            = new DownloadInvoiceDetailsItemType("MEDIA");

        public static readonly DownloadInvoiceDetailsItemType OPTIONBOX
            = new DownloadInvoiceDetailsItemType("OPTIONBOX");

        public static readonly DownloadInvoiceDetailsItemType SEASON
            = new DownloadInvoiceDetailsItemType("SEASON");

        public static readonly DownloadInvoiceDetailsItemType SUBSCRIPTION
            = new DownloadInvoiceDetailsItemType("SUBSCRIPTION");


        public static implicit operator DownloadInvoiceDetailsItemType(string value)
        {
            return NewValue(value);
        }

        public DownloadInvoiceDetailsItemType(string enumValue)
            : base(enumValue)
        {

        }
    }

}
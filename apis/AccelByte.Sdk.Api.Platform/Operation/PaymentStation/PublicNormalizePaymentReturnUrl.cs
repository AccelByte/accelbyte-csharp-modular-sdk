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
    /// publicNormalizePaymentReturnUrl
    ///
    /// Normalize payment return url for payment provider
    /// Field                                                                                                                                                        | Type   | Required | Description
    /// -------------------------------------------------------------------------------------------------------------------------------------------------------------|--------|----------|-----------------------
    /// orderNo                                                                                                                                                      | String | Yes      | order no
    /// paymentStatus                                                                                                                                                | String | Yes      |
    /// 
    ///   * DONE: The payment was successfully completed.
    ///   * CANCELLED: The payment was cancelled by the shopper before completion, or the shopper returned to the merchant's site before completing the transaction.
    ///   * PENDING: Inform the shopper that you've received their order, and are waiting for the payment to be completed.
    /// 
    /// When the shopper has completed the payment you will receive a successful AUTHORISATION.
    ///   * RECEIVED: Inform the shopper that you've received their order, and are waiting for the payment to clear.
    ///   * UNKNOWN: An error occurred during the payment processing.
    ///   * FAILED: Shopper paid failed because of various reasons.
    /// 
    /// 
    /// reason                                                                                                                                                       | String | No       | payment status reason
    /// 
    /// Other detail info:
    /// 
    ///   * xsolla : parameters 'user_id', 'foreinginvoice', 'invoice_id' and 'status' will be automatically added to the link
    ///   *  adyen : https://docs.adyen.com/developers/checkout/web-sdk
    /// </summary>
    public class PublicNormalizePaymentReturnUrl : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicNormalizePaymentReturnUrlBuilder Builder { get => new PublicNormalizePaymentReturnUrlBuilder(); }

        public class PublicNormalizePaymentReturnUrlBuilder
            : OperationBuilder<PublicNormalizePaymentReturnUrlBuilder>
        {

            public string? PayerID { get; set; }

            public string? Foreinginvoice { get; set; }

            public string? InvoiceId { get; set; }

            public string? Payload { get; set; }

            public string? RedirectResult { get; set; }

            public string? ResultCode { get; set; }

            public string? SessionId { get; set; }

            public string? Status { get; set; }

            public string? Token { get; set; }

            public string? Type { get; set; }

            public string? UserId { get; set; }





            internal PublicNormalizePaymentReturnUrlBuilder() { }

            internal PublicNormalizePaymentReturnUrlBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicNormalizePaymentReturnUrlBuilder SetPayerID(string _payerID)
            {
                PayerID = _payerID;
                return this;
            }

            public PublicNormalizePaymentReturnUrlBuilder SetForeinginvoice(string _foreinginvoice)
            {
                Foreinginvoice = _foreinginvoice;
                return this;
            }

            public PublicNormalizePaymentReturnUrlBuilder SetInvoiceId(string _invoiceId)
            {
                InvoiceId = _invoiceId;
                return this;
            }

            public PublicNormalizePaymentReturnUrlBuilder SetPayload(string _payload)
            {
                Payload = _payload;
                return this;
            }

            public PublicNormalizePaymentReturnUrlBuilder SetRedirectResult(string _redirectResult)
            {
                RedirectResult = _redirectResult;
                return this;
            }

            public PublicNormalizePaymentReturnUrlBuilder SetResultCode(string _resultCode)
            {
                ResultCode = _resultCode;
                return this;
            }

            public PublicNormalizePaymentReturnUrlBuilder SetSessionId(string _sessionId)
            {
                SessionId = _sessionId;
                return this;
            }

            public PublicNormalizePaymentReturnUrlBuilder SetStatus(string _status)
            {
                Status = _status;
                return this;
            }

            public PublicNormalizePaymentReturnUrlBuilder SetToken(string _token)
            {
                Token = _token;
                return this;
            }

            public PublicNormalizePaymentReturnUrlBuilder SetType(string _type)
            {
                Type = _type;
                return this;
            }

            public PublicNormalizePaymentReturnUrlBuilder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }





            public PublicNormalizePaymentReturnUrl Build(
                string namespace_,
                string orderNo,
                string paymentOrderNo,
                PublicNormalizePaymentReturnUrlPaymentProvider paymentProvider,
                string returnUrl
            )
            {
                PublicNormalizePaymentReturnUrl op = new PublicNormalizePaymentReturnUrl(this,
                    namespace_,
                    orderNo,
                    paymentOrderNo,
                    paymentProvider,
                    returnUrl
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string namespace_,
                string orderNo,
                string paymentOrderNo,
                string paymentProvider,
                string returnUrl
            )
            {
                PublicNormalizePaymentReturnUrl op = Build(
                    namespace_,
                    orderNo,
                    paymentOrderNo,
                    paymentProvider,
                    returnUrl
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private PublicNormalizePaymentReturnUrl(PublicNormalizePaymentReturnUrlBuilder builder,
            string namespace_,
            string orderNo,
            string paymentOrderNo,
            PublicNormalizePaymentReturnUrlPaymentProvider paymentProvider,
            string returnUrl
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.PayerID is not null) QueryParams["PayerID"] = builder.PayerID;
            if (builder.Foreinginvoice is not null) QueryParams["foreinginvoice"] = builder.Foreinginvoice;
            if (builder.InvoiceId is not null) QueryParams["invoice_id"] = builder.InvoiceId;
            if (builder.Payload is not null) QueryParams["payload"] = builder.Payload;
            if (builder.RedirectResult is not null) QueryParams["redirectResult"] = builder.RedirectResult;
            if (builder.ResultCode is not null) QueryParams["resultCode"] = builder.ResultCode;
            if (builder.SessionId is not null) QueryParams["sessionId"] = builder.SessionId;
            if (builder.Status is not null) QueryParams["status"] = builder.Status;
            if (builder.Token is not null) QueryParams["token"] = builder.Token;
            if (builder.Type is not null) QueryParams["type"] = builder.Type;
            if (builder.UserId is not null) QueryParams["user_id"] = builder.UserId;
            if (orderNo is not null) QueryParams["orderNo"] = orderNo;
            if (paymentOrderNo is not null) QueryParams["paymentOrderNo"] = paymentOrderNo;
            if (paymentProvider is not null) QueryParams["paymentProvider"] = paymentProvider.Value;
            if (returnUrl is not null) QueryParams["returnUrl"] = returnUrl;






        }
        #endregion

        public PublicNormalizePaymentReturnUrl(
            string namespace_,
            string? payerID,
            string? foreinginvoice,
            string? invoiceId,
            string? payload,
            string? redirectResult,
            string? resultCode,
            string? sessionId,
            string? status,
            string? token,
            string? type,
            string? userId,
            string orderNo,
            string paymentOrderNo,
            PublicNormalizePaymentReturnUrlPaymentProvider paymentProvider,
            string returnUrl
        )
        {
            PathParams["namespace"] = namespace_;

            if (payerID is not null) QueryParams["PayerID"] = payerID;
            if (foreinginvoice is not null) QueryParams["foreinginvoice"] = foreinginvoice;
            if (invoiceId is not null) QueryParams["invoice_id"] = invoiceId;
            if (payload is not null) QueryParams["payload"] = payload;
            if (redirectResult is not null) QueryParams["redirectResult"] = redirectResult;
            if (resultCode is not null) QueryParams["resultCode"] = resultCode;
            if (sessionId is not null) QueryParams["sessionId"] = sessionId;
            if (status is not null) QueryParams["status"] = status;
            if (token is not null) QueryParams["token"] = token;
            if (type is not null) QueryParams["type"] = type;
            if (userId is not null) QueryParams["user_id"] = userId;
            if (orderNo is not null) QueryParams["orderNo"] = orderNo;
            if (paymentOrderNo is not null) QueryParams["paymentOrderNo"] = paymentOrderNo;
            if (paymentProvider is not null) QueryParams["paymentProvider"] = paymentProvider.Value;
            if (returnUrl is not null) QueryParams["returnUrl"] = returnUrl;






        }

        public override string Path => "/platform/public/namespaces/{namespace}/payment/returnurl";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class PublicNormalizePaymentReturnUrlPaymentProvider : StringEnum<PublicNormalizePaymentReturnUrlPaymentProvider>
    {
        public static readonly PublicNormalizePaymentReturnUrlPaymentProvider ADYEN
            = new PublicNormalizePaymentReturnUrlPaymentProvider("ADYEN");

        public static readonly PublicNormalizePaymentReturnUrlPaymentProvider ALIPAY
            = new PublicNormalizePaymentReturnUrlPaymentProvider("ALIPAY");

        public static readonly PublicNormalizePaymentReturnUrlPaymentProvider CHECKOUT
            = new PublicNormalizePaymentReturnUrlPaymentProvider("CHECKOUT");

        public static readonly PublicNormalizePaymentReturnUrlPaymentProvider PAYPAL
            = new PublicNormalizePaymentReturnUrlPaymentProvider("PAYPAL");

        public static readonly PublicNormalizePaymentReturnUrlPaymentProvider STRIPE
            = new PublicNormalizePaymentReturnUrlPaymentProvider("STRIPE");

        public static readonly PublicNormalizePaymentReturnUrlPaymentProvider WALLET
            = new PublicNormalizePaymentReturnUrlPaymentProvider("WALLET");

        public static readonly PublicNormalizePaymentReturnUrlPaymentProvider WXPAY
            = new PublicNormalizePaymentReturnUrlPaymentProvider("WXPAY");

        public static readonly PublicNormalizePaymentReturnUrlPaymentProvider XSOLLA
            = new PublicNormalizePaymentReturnUrlPaymentProvider("XSOLLA");


        public static implicit operator PublicNormalizePaymentReturnUrlPaymentProvider(string value)
        {
            return NewValue(value);
        }

        public PublicNormalizePaymentReturnUrlPaymentProvider(string enumValue)
            : base(enumValue)
        {

        }
    }

}
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
    /// publicDownloadUserOrderReceipt
    ///
    /// Download user order receipt by orderNo.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:ORDER", action=2 (READ)
    ///   *  Returns : order receipt pdf
    /// </summary>
    public class PublicDownloadUserOrderReceipt : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicDownloadUserOrderReceiptBuilder Builder { get => new PublicDownloadUserOrderReceiptBuilder(); }

        public class PublicDownloadUserOrderReceiptBuilder
            : OperationBuilder<PublicDownloadUserOrderReceiptBuilder>
        {





            internal PublicDownloadUserOrderReceiptBuilder() { }

            internal PublicDownloadUserOrderReceiptBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicDownloadUserOrderReceipt Build(
                string namespace_,
                string orderNo,
                string userId
            )
            {
                PublicDownloadUserOrderReceipt op = new PublicDownloadUserOrderReceipt(this,
                    namespace_,
                    orderNo,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Stream? Execute(
                string namespace_,
                string orderNo,
                string userId
            )
            {
                PublicDownloadUserOrderReceipt op = Build(
                    namespace_,
                    orderNo,
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
        }

        private PublicDownloadUserOrderReceipt(PublicDownloadUserOrderReceiptBuilder builder,
            string namespace_,
            string orderNo,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["orderNo"] = orderNo;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicDownloadUserOrderReceipt(
            string namespace_,
            string orderNo,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["orderNo"] = orderNo;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/orders/{orderNo}/receipt.pdf";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/pdf" };

        public Stream? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return payload;
            }
            else if (code == (HttpStatusCode)200)
            {
                return payload;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
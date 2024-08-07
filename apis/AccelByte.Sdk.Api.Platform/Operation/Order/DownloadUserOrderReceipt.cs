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
    /// downloadUserOrderReceipt
    ///
    /// Download user order receipt by orderNo.
    /// Other detail info:
    /// 
    ///   * Returns : order receipt pdf
    /// </summary>
    public class DownloadUserOrderReceipt : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DownloadUserOrderReceiptBuilder Builder { get => new DownloadUserOrderReceiptBuilder(); }

        public class DownloadUserOrderReceiptBuilder
            : OperationBuilder<DownloadUserOrderReceiptBuilder>
        {





            internal DownloadUserOrderReceiptBuilder() { }

            internal DownloadUserOrderReceiptBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DownloadUserOrderReceipt Build(
                string namespace_,
                string orderNo,
                string userId
            )
            {
                DownloadUserOrderReceipt op = new DownloadUserOrderReceipt(this,
                    namespace_,
                    orderNo,
                    userId
                );

                op.SetBaseFields<DownloadUserOrderReceiptBuilder>(this);
                return op;
            }

            public Stream? Execute(
                string namespace_,
                string orderNo,
                string userId
            )
            {
                DownloadUserOrderReceipt op = Build(
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
            public async Task<Stream?> ExecuteAsync(
                string namespace_,
                string orderNo,
                string userId
            )
            {
                DownloadUserOrderReceipt op = Build(
                    namespace_,
                    orderNo,
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

        private DownloadUserOrderReceipt(DownloadUserOrderReceiptBuilder builder,
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

        public DownloadUserOrderReceipt(
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

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo}/receipt.pdf";

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
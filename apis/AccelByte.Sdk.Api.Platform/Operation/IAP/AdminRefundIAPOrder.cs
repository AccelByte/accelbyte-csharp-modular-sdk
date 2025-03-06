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
    /// adminRefundIAPOrder
    ///
    /// Only support steam transaction mode
    /// </summary>
    public class AdminRefundIAPOrder : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminRefundIAPOrderBuilder Builder { get => new AdminRefundIAPOrderBuilder(); }

        public class AdminRefundIAPOrderBuilder
            : OperationBuilder<AdminRefundIAPOrderBuilder>
        {





            internal AdminRefundIAPOrderBuilder() { }

            internal AdminRefundIAPOrderBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminRefundIAPOrder Build(
                string iapOrderNo,
                string namespace_
            )
            {
                AdminRefundIAPOrder op = new AdminRefundIAPOrder(this,
                    iapOrderNo,
                    namespace_
                );

                op.SetBaseFields<AdminRefundIAPOrderBuilder>(this);
                return op;
            }

            public AdminRefundIAPOrder.Response Execute(
                string iapOrderNo,
                string namespace_
            )
            {
                AdminRefundIAPOrder op = Build(
                    iapOrderNo,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<AdminRefundIAPOrder.Response> ExecuteAsync(
                string iapOrderNo,
                string namespace_
            )
            {
                AdminRefundIAPOrder op = Build(
                    iapOrderNo,
                    namespace_
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

        private AdminRefundIAPOrder(AdminRefundIAPOrderBuilder builder,
            string iapOrderNo,
            string namespace_
        )
        {
            PathParams["iapOrderNo"] = iapOrderNo;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.IAPOrderInfo>
        {

            public ErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error404 { get; set; } = null;

            public ErrorEntity? Error409 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::IAP::AdminRefundIAPOrder";
        }

        #endregion

        public AdminRefundIAPOrder(
            string iapOrderNo,
            string namespace_
        )
        {
            PathParams["iapOrderNo"] = iapOrderNo;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/steam/orders/{iapOrderNo}/refund";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public AdminRefundIAPOrder.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminRefundIAPOrder.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.IAPOrderInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }

            return response;
        }
    }

}
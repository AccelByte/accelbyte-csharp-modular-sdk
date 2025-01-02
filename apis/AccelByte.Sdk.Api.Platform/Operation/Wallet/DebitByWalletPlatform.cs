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
    /// debitByWalletPlatform
    ///
    /// Debit user wallet by currency code and client platform.
    /// Other detail info:
    /// 
    /// 
    /// 
    /// 
    /// ## Restrictions for metadata
    /// 
    /// 
    /// 1. Cannot use "." as the key name
    /// -
    /// 
    /// 
    ///     { "data.2": "value" }
    /// 
    /// 
    /// 2. Cannot use "$" as the prefix in key names
    /// -
    /// 
    /// 
    ///     { "$data": "value" }
    /// </summary>
    public class DebitByWalletPlatform : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DebitByWalletPlatformBuilder Builder { get => new DebitByWalletPlatformBuilder(); }

        public class DebitByWalletPlatformBuilder
            : OperationBuilder<DebitByWalletPlatformBuilder>
        {





            internal DebitByWalletPlatformBuilder() { }

            internal DebitByWalletPlatformBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DebitByWalletPlatform Build(
                DebitByWalletPlatformRequest request,
                string currencyCode,
                string namespace_,
                string userId
            )
            {
                DebitByWalletPlatform op = new DebitByWalletPlatform(this,
                    request,
                    currencyCode,
                    namespace_,
                    userId
                );

                op.SetBaseFields<DebitByWalletPlatformBuilder>(this);
                return op;
            }

            public DebitByWalletPlatform.Response Execute(
                DebitByWalletPlatformRequest request,
                string currencyCode,
                string namespace_,
                string userId
            )
            {
                DebitByWalletPlatform op = Build(
                    request,
                    currencyCode,
                    namespace_,
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
            public async Task<DebitByWalletPlatform.Response> ExecuteAsync(
                DebitByWalletPlatformRequest request,
                string currencyCode,
                string namespace_,
                string userId
            )
            {
                DebitByWalletPlatform op = Build(
                    request,
                    currencyCode,
                    namespace_,
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

        private DebitByWalletPlatform(DebitByWalletPlatformBuilder builder,
            DebitByWalletPlatformRequest request,
            string currencyCode,
            string namespace_,
            string userId
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = request;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.PlatformWallet>
        {

            public ErrorEntity? Error400 { get; set; } = null;

            public ValidationErrorEntity? Error422 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Wallet::DebitByWalletPlatform";
        }

        #endregion

        public DebitByWalletPlatform(
            string currencyCode,
            string namespace_,
            string userId,
            Model.DebitByWalletPlatformRequest request
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = request;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/wallets/{currencyCode}/debitByWalletPlatform";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public DebitByWalletPlatform.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DebitByWalletPlatform.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.PlatformWallet>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)422)
            {
                response.Error422 = JsonSerializer.Deserialize<ValidationErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error422!.TranslateToApiError();
            }

            return response;
        }
    }

}
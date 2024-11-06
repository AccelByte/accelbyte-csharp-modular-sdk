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
    /// checkBalance
    ///
    /// Checks if the user has enough balance based on the provided criteria.
    /// Other detail info:
    /// 
    ///   * Returns : boolean value indicating if the user has enough balance
    /// </summary>
    public class CheckBalance : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CheckBalanceBuilder Builder { get => new CheckBalanceBuilder(); }

        public class CheckBalanceBuilder
            : OperationBuilder<CheckBalanceBuilder>
        {





            internal CheckBalanceBuilder() { }

            internal CheckBalanceBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CheckBalance Build(
                DebitByWalletPlatformRequest request,
                string currencyCode,
                string namespace_,
                string userId
            )
            {
                CheckBalance op = new CheckBalance(this,
                    request,                    
                    currencyCode,                    
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<CheckBalanceBuilder>(this);
                return op;
            }

            public CheckBalance.Response Execute(
                DebitByWalletPlatformRequest request,
                string currencyCode,
                string namespace_,
                string userId
            )
            {
                CheckBalance op = Build(
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
            public async Task<CheckBalance.Response> ExecuteAsync(
                DebitByWalletPlatformRequest request,
                string currencyCode,
                string namespace_,
                string userId
            )
            {
                CheckBalance op = Build(
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

        private CheckBalance(CheckBalanceBuilder builder,
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
        public class Response : ApiResponse
        {

            public ErrorEntity? Error400 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Wallet::CheckBalance";
        }

        #endregion

        public CheckBalance(
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

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/wallets/{currencyCode}/balanceCheck";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public CheckBalance.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new CheckBalance.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)
            
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }

            return response;
        }
    }

}
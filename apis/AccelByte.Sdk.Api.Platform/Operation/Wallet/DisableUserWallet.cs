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
    /// disableUserWallet
    ///
    /// disable a user wallet.
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class DisableUserWallet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DisableUserWalletBuilder Builder { get => new DisableUserWalletBuilder(); }

        public class DisableUserWalletBuilder
            : OperationBuilder<DisableUserWalletBuilder>
        {





            internal DisableUserWalletBuilder() { }

            internal DisableUserWalletBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DisableUserWallet Build(
                string namespace_,
                string userId,
                string walletId
            )
            {
                DisableUserWallet op = new DisableUserWallet(this,
                    namespace_,                    
                    userId,                    
                    walletId                    
                );

                op.SetBaseFields<DisableUserWalletBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
            public DisableUserWallet.Response Execute(
                string namespace_,
                string userId,
                string walletId
            )
            {
                DisableUserWallet op = Build(
                    namespace_,
                    userId,
                    walletId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<DisableUserWallet.Response> ExecuteAsync(
                string namespace_,
                string userId,
                string walletId
            )
            {
                DisableUserWallet op = Build(
                    namespace_,
                    userId,
                    walletId
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

        private DisableUserWallet(DisableUserWalletBuilder builder,
            string namespace_,
            string userId,
            string walletId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            PathParams["walletId"] = walletId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ErrorEntity? Error404 { get; set; } = null;

            public ErrorEntity? Error409 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Wallet::DisableUserWallet";
        }

        #endregion

        public DisableUserWallet(
            string namespace_,            
            string userId,            
            string walletId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            PathParams["walletId"] = walletId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/wallets/{walletId}/disable";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public DisableUserWallet.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DisableUserWallet.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)404)
            
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
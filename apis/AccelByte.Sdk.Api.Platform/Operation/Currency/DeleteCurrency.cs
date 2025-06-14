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
    /// deleteCurrency
    ///
    /// Delete a currency by currency code.
    /// Other detail info:
    /// 
    ///   * Returns :
    /// </summary>
    public class DeleteCurrency : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteCurrencyBuilder Builder { get => new DeleteCurrencyBuilder(); }

        public class DeleteCurrencyBuilder
            : OperationBuilder<DeleteCurrencyBuilder>
        {





            internal DeleteCurrencyBuilder() { }

            internal DeleteCurrencyBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteCurrency Build(
                string currencyCode,
                string namespace_
            )
            {
                DeleteCurrency op = new DeleteCurrency(this,
                    currencyCode,                    
                    namespace_                    
                );

                op.SetBaseFields<DeleteCurrencyBuilder>(this);
                return op;
            }

            public DeleteCurrency.Response Execute(
                string currencyCode,
                string namespace_
            )
            {
                DeleteCurrency op = Build(
                    currencyCode,
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
            public async Task<DeleteCurrency.Response> ExecuteAsync(
                string currencyCode,
                string namespace_
            )
            {
                DeleteCurrency op = Build(
                    currencyCode,
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

        private DeleteCurrency(DeleteCurrencyBuilder builder,
            string currencyCode,
            string namespace_
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.CurrencyInfo>
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Currency::DeleteCurrency";
        }

        #endregion

        public DeleteCurrency(
            string currencyCode,            
            string namespace_            
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/currencies/{currencyCode}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public DeleteCurrency.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DeleteCurrency.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.CurrencyInfo>(payload, ResponseJsonOptions);
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

}
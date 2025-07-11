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
    /// updateCurrency
    ///
    /// Update a currency by currency code.
    /// Other detail info:
    /// 
    ///   * Returns : updated currency
    /// </summary>
    public class UpdateCurrency : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateCurrencyBuilder Builder { get => new UpdateCurrencyBuilder(); }

        public class UpdateCurrencyBuilder
            : OperationBuilder<UpdateCurrencyBuilder>
        {





            internal UpdateCurrencyBuilder() { }

            internal UpdateCurrencyBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateCurrency Build(
                CurrencyUpdate body,
                string currencyCode,
                string namespace_
            )
            {
                UpdateCurrency op = new UpdateCurrency(this,
                    body,                    
                    currencyCode,                    
                    namespace_                    
                );

                op.SetBaseFields<UpdateCurrencyBuilder>(this);
                return op;
            }

            public UpdateCurrency.Response Execute(
                CurrencyUpdate body,
                string currencyCode,
                string namespace_
            )
            {
                UpdateCurrency op = Build(
                    body,
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
            public async Task<UpdateCurrency.Response> ExecuteAsync(
                CurrencyUpdate body,
                string currencyCode,
                string namespace_
            )
            {
                UpdateCurrency op = Build(
                    body,
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

        private UpdateCurrency(UpdateCurrencyBuilder builder,
            CurrencyUpdate body,
            string currencyCode,
            string namespace_
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.CurrencyInfo>
        {

            public ErrorEntity? Error404 { get; set; } = null;

            public ValidationErrorEntity? Error422 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Currency::UpdateCurrency";
        }

        #endregion

        public UpdateCurrency(
            string currencyCode,            
            string namespace_,            
            Model.CurrencyUpdate body            
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/currencies/{currencyCode}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public UpdateCurrency.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdateCurrency.Response()
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
            else if (code == (HttpStatusCode)422)
            {
                response.Error422 = JsonSerializer.Deserialize<ValidationErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error422!.TranslateToApiError();
            }

            return response;
        }
    }

}
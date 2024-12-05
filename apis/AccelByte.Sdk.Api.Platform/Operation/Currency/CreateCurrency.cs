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
    /// createCurrency
    ///
    /// Create a currency.
    /// Other detail info:
    /// 
    ///   * Returns : created currency
    /// </summary>
    public class CreateCurrency : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateCurrencyBuilder Builder { get => new CreateCurrencyBuilder(); }

        public class CreateCurrencyBuilder
            : OperationBuilder<CreateCurrencyBuilder>
        {





            internal CreateCurrencyBuilder() { }

            internal CreateCurrencyBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateCurrency Build(
                CurrencyCreate body,
                string namespace_
            )
            {
                CreateCurrency op = new CreateCurrency(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<CreateCurrencyBuilder>(this);
                return op;
            }

            public CreateCurrency.Response Execute(
                CurrencyCreate body,
                string namespace_
            )
            {
                CreateCurrency op = Build(
                    body,
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
            public async Task<CreateCurrency.Response> ExecuteAsync(
                CurrencyCreate body,
                string namespace_
            )
            {
                CreateCurrency op = Build(
                    body,
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

        private CreateCurrency(CreateCurrencyBuilder builder,
            CurrencyCreate body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.CurrencyInfo>
        {

            public ErrorEntity? Error409 { get; set; } = null;

            public ValidationErrorEntity? Error422 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Currency::CreateCurrency";
        }

        #endregion

        public CreateCurrency(
            string namespace_,
            Model.CurrencyCreate body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/currencies";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public CreateCurrency.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new CreateCurrency.Response()
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
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
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
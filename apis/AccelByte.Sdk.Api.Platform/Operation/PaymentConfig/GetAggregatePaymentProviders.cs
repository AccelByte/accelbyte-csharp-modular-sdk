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
    /// getAggregatePaymentProviders
    ///
    ///  [Not supported yet in AGS Shared Cloud] Get aggregate payment providers, such as XSOLLA, ADYEN.
    /// Other detail info:
    /// 
    ///   * Returns : payment provider list
    /// </summary>
    public class GetAggregatePaymentProviders : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetAggregatePaymentProvidersBuilder Builder { get => new GetAggregatePaymentProvidersBuilder(); }

        public class GetAggregatePaymentProvidersBuilder
            : OperationBuilder<GetAggregatePaymentProvidersBuilder>
        {





            internal GetAggregatePaymentProvidersBuilder() { }

            internal GetAggregatePaymentProvidersBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetAggregatePaymentProviders Build(
            )
            {
                GetAggregatePaymentProviders op = new GetAggregatePaymentProviders(this
                );

                op.SetBaseFields<GetAggregatePaymentProvidersBuilder>(this);
                return op;
            }

            public GetAggregatePaymentProviders.Response Execute(
            )
            {
                GetAggregatePaymentProviders op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<GetAggregatePaymentProviders.Response> ExecuteAsync(
            )
            {
                GetAggregatePaymentProviders op = Build(
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

        private GetAggregatePaymentProviders(GetAggregatePaymentProvidersBuilder builder
        )
        {
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<List<string>>
        {


            protected override string GetFullOperationId() => "Platform::PaymentConfig::GetAggregatePaymentProviders";
        }

        #endregion

        public GetAggregatePaymentProviders(
        )
        {
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/provider/aggregate";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public GetAggregatePaymentProviders.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetAggregatePaymentProviders.Response()
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
                response.Data = JsonSerializer.Deserialize<List<string>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}
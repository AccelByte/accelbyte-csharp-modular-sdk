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
    /// getSpecialPaymentProviders
    ///
    /// Get special payment providers, such as ALIPAY, WXPAY.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:PAYMENT:CONFIG", action=2 (READ)
    ///   *  Returns : payment provider list
    /// </summary>
    public class GetSpecialPaymentProviders : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetSpecialPaymentProvidersBuilder Builder { get => new GetSpecialPaymentProvidersBuilder(); }

        public class GetSpecialPaymentProvidersBuilder
            : OperationBuilder<GetSpecialPaymentProvidersBuilder>
        {





            internal GetSpecialPaymentProvidersBuilder() { }

            internal GetSpecialPaymentProvidersBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetSpecialPaymentProviders Build(
            )
            {
                GetSpecialPaymentProviders op = new GetSpecialPaymentProviders(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public List<string>? Execute(
            )
            {
                GetSpecialPaymentProviders op = Build(
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

        private GetSpecialPaymentProviders(GetSpecialPaymentProvidersBuilder builder
        )
        {
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetSpecialPaymentProviders(
        )
        {
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/provider/special";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public List<string>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<string>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<string>>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
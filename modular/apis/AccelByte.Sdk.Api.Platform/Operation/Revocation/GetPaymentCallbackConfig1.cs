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
    /// getPaymentCallbackConfig_1
    ///
    /// Get revocation configuration.
    /// Other detail info:
    /// 
    ///   * Required permission : resource=ADMIN:NAMESPACE:{namespace}:REVOCATION, action=2 (READ)
    ///   *  Returns : Revocation config
    /// </summary>
    public class GetPaymentCallbackConfig1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetPaymentCallbackConfig1Builder Builder { get => new GetPaymentCallbackConfig1Builder(); }

        public class GetPaymentCallbackConfig1Builder
            : OperationBuilder<GetPaymentCallbackConfig1Builder>
        {





            internal GetPaymentCallbackConfig1Builder() { }

            internal GetPaymentCallbackConfig1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetPaymentCallbackConfig1 Build(
                string namespace_
            )
            {
                GetPaymentCallbackConfig1 op = new GetPaymentCallbackConfig1(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.RevocationConfigInfo? Execute(
                string namespace_
            )
            {
                GetPaymentCallbackConfig1 op = Build(
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
        }

        private GetPaymentCallbackConfig1(GetPaymentCallbackConfig1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetPaymentCallbackConfig1(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/revocation/config";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.RevocationConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.RevocationConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RevocationConfigInfo>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
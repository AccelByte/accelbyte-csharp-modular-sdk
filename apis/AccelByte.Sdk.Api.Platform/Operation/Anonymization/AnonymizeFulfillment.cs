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
    /// anonymizeFulfillment
    ///
    /// Anonymize fulfillment. At current it will only anonymize fulfillment history.
    /// </summary>
    public class AnonymizeFulfillment : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AnonymizeFulfillmentBuilder Builder { get => new AnonymizeFulfillmentBuilder(); }

        public class AnonymizeFulfillmentBuilder
            : OperationBuilder<AnonymizeFulfillmentBuilder>
        {





            internal AnonymizeFulfillmentBuilder() { }

            internal AnonymizeFulfillmentBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AnonymizeFulfillment Build(
                string namespace_,
                string userId
            )
            {
                AnonymizeFulfillment op = new AnonymizeFulfillment(this,
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<AnonymizeFulfillmentBuilder>(this);
                return op;
            }

            public AnonymizeFulfillment.Response Execute(
                string namespace_,
                string userId
            )
            {
                AnonymizeFulfillment op = Build(
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
            public async Task<AnonymizeFulfillment.Response> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                AnonymizeFulfillment op = Build(
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

        private AnonymizeFulfillment(AnonymizeFulfillmentBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {


            protected override string GetFullOperationId() => "Platform::Anonymization::AnonymizeFulfillment";
        }

        #endregion

        public AnonymizeFulfillment(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/anonymization/fulfillment";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AnonymizeFulfillment.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AnonymizeFulfillment.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };


            return response;
        }
    }

}
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
    /// anonymizeSubscription
    ///
    /// Anonymize subscription. At current it will anonymize subscription, billing history and subscription activity.
    /// </summary>
    public class AnonymizeSubscription : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AnonymizeSubscriptionBuilder Builder { get => new AnonymizeSubscriptionBuilder(); }

        public class AnonymizeSubscriptionBuilder
            : OperationBuilder<AnonymizeSubscriptionBuilder>
        {





            internal AnonymizeSubscriptionBuilder() { }

            internal AnonymizeSubscriptionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AnonymizeSubscription Build(
                string namespace_,
                string userId
            )
            {
                AnonymizeSubscription op = new AnonymizeSubscription(this,
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<AnonymizeSubscriptionBuilder>(this);
                return op;
            }

            public AnonymizeSubscription.Response Execute(
                string namespace_,
                string userId
            )
            {
                AnonymizeSubscription op = Build(
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
            public async Task<AnonymizeSubscription.Response> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                AnonymizeSubscription op = Build(
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

        private AnonymizeSubscription(AnonymizeSubscriptionBuilder builder,
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


            protected override string GetFullOperationId() => "Platform::Anonymization::AnonymizeSubscription";
        }

        #endregion

        public AnonymizeSubscription(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/anonymization/subscriptions";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AnonymizeSubscription.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AnonymizeSubscription.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };


            return response;
        }
    }

}
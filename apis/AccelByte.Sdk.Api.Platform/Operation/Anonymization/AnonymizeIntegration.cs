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
    /// anonymizeIntegration
    ///
    /// Anonymize integrations. At current it will only anonymize iap histories.
    /// </summary>
    public class AnonymizeIntegration : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AnonymizeIntegrationBuilder Builder { get => new AnonymizeIntegrationBuilder(); }

        public class AnonymizeIntegrationBuilder
            : OperationBuilder<AnonymizeIntegrationBuilder>
        {





            internal AnonymizeIntegrationBuilder() { }

            internal AnonymizeIntegrationBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AnonymizeIntegration Build(
                string namespace_,
                string userId
            )
            {
                AnonymizeIntegration op = new AnonymizeIntegration(this,
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<AnonymizeIntegrationBuilder>(this);
                return op;
            }

            public AnonymizeIntegration.Response Execute(
                string namespace_,
                string userId
            )
            {
                AnonymizeIntegration op = Build(
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
            public async Task<AnonymizeIntegration.Response> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                AnonymizeIntegration op = Build(
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

        private AnonymizeIntegration(AnonymizeIntegrationBuilder builder,
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


            protected override string GetFullOperationId() => "Platform::Anonymization::AnonymizeIntegration";
        }

        #endregion

        public AnonymizeIntegration(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/anonymization/integrations";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AnonymizeIntegration.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AnonymizeIntegration.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };


            return response;
        }
    }

}
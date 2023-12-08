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

using AccelByte.Sdk.Api.Chat.Model;

namespace AccelByte.Sdk.Api.Chat.Operation
{
    /// <summary>
    /// adminGetCategorySchema
    ///
    /// Get category schema.
    /// </summary>
    public class AdminGetCategorySchema : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetCategorySchemaBuilder Builder { get => new AdminGetCategorySchemaBuilder(); }

        public class AdminGetCategorySchemaBuilder
            : OperationBuilder<AdminGetCategorySchemaBuilder>
        {





            internal AdminGetCategorySchemaBuilder() { }

            internal AdminGetCategorySchemaBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetCategorySchema Build(
                string category,
                string namespace_
            )
            {
                AdminGetCategorySchema op = new AdminGetCategorySchema(this,
                    category,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsJSONSchemaType? Execute(
                string category,
                string namespace_
            )
            {
                AdminGetCategorySchema op = Build(
                    category,
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

        private AdminGetCategorySchema(AdminGetCategorySchemaBuilder builder,
            string category,
            string namespace_
        )
        {
            PathParams["category"] = category;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetCategorySchema(
            string category,            
            string namespace_            
        )
        {
            PathParams["category"] = category;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/v1/admin/inbox/namespaces/{namespace}/categories/{category}/schema.json";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelsJSONSchemaType? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsJSONSchemaType>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsJSONSchemaType>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
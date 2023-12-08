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
    /// adminCreateTopic
    ///
    /// Create new group topic in a namespace.
    /// </summary>
    public class AdminCreateTopic : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCreateTopicBuilder Builder { get => new AdminCreateTopicBuilder(); }

        public class AdminCreateTopicBuilder
            : OperationBuilder<AdminCreateTopicBuilder>
        {





            internal AdminCreateTopicBuilder() { }

            internal AdminCreateTopicBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminCreateTopic Build(
                ApiCreateTopicParams body,
                string namespace_
            )
            {
                AdminCreateTopic op = new AdminCreateTopic(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ApiCreateTopicResponse? Execute(
                ApiCreateTopicParams body,
                string namespace_
            )
            {
                AdminCreateTopic op = Build(
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
        }

        private AdminCreateTopic(AdminCreateTopicBuilder builder,
            ApiCreateTopicParams body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminCreateTopic(
            string namespace_,            
            Model.ApiCreateTopicParams body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/admin/namespaces/{namespace}/topic";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ApiCreateTopicResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApiCreateTopicResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiCreateTopicResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
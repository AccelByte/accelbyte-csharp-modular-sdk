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

using AccelByte.Sdk.Api.Chat.Model;

namespace AccelByte.Sdk.Api.Chat.Operation
{
    /// <summary>
    /// adminCreateNamespaceTopic
    ///
    /// Create new namespace group topic in a namespace.
    /// </summary>
    public class AdminCreateNamespaceTopic : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCreateNamespaceTopicBuilder Builder { get => new AdminCreateNamespaceTopicBuilder(); }

        public class AdminCreateNamespaceTopicBuilder
            : OperationBuilder<AdminCreateNamespaceTopicBuilder>
        {





            internal AdminCreateNamespaceTopicBuilder() { }

            internal AdminCreateNamespaceTopicBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminCreateNamespaceTopic Build(
                ApiCreateNamespaceTopicParams body,
                string namespace_
            )
            {
                AdminCreateNamespaceTopic op = new AdminCreateNamespaceTopic(this,
                    body,                    
                    namespace_                    
                );

                op.SetBaseFields<AdminCreateNamespaceTopicBuilder>(this);
                return op;
            }

            public AdminCreateNamespaceTopic.Response Execute(
                ApiCreateNamespaceTopicParams body,
                string namespace_
            )
            {
                AdminCreateNamespaceTopic op = Build(
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
            public async Task<AdminCreateNamespaceTopic.Response> ExecuteAsync(
                ApiCreateNamespaceTopicParams body,
                string namespace_
            )
            {
                AdminCreateNamespaceTopic op = Build(
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

        private AdminCreateNamespaceTopic(AdminCreateNamespaceTopicBuilder builder,
            ApiCreateNamespaceTopicParams body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ApiCreateTopicResponse>
        {


            protected override string GetFullOperationId() => "Chat::Topic::AdminCreateNamespaceTopic";
        }

        #endregion

        public AdminCreateNamespaceTopic(
            string namespace_,            
            Model.ApiCreateNamespaceTopicParams body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/admin/namespaces/{namespace}/namespace-topic";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminCreateNamespaceTopic.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminCreateNamespaceTopic.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ApiCreateTopicResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}
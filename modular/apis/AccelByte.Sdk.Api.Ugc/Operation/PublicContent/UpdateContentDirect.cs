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

using AccelByte.Sdk.Api.Ugc.Model;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// UpdateContentDirect
    ///
    /// Required permission NAMESPACE:{namespace}:USER:{userId}:CONTENT [UPDATE].
    /// 
    /// All request body are required except preview, tags and customAttributes.
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class UpdateContentDirect : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateContentDirectBuilder Builder { get => new UpdateContentDirectBuilder(); }

        public class UpdateContentDirectBuilder
            : OperationBuilder<UpdateContentDirectBuilder>
        {





            internal UpdateContentDirectBuilder() { }

            internal UpdateContentDirectBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateContentDirect Build(
                ModelsCreateContentRequest body,
                string channelId,
                string contentId,
                string namespace_,
                string userId
            )
            {
                UpdateContentDirect op = new UpdateContentDirect(this,
                    body,                    
                    channelId,                    
                    contentId,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
            public Model.ModelsCreateContentResponse? Execute(
                ModelsCreateContentRequest body,
                string channelId,
                string contentId,
                string namespace_,
                string userId
            )
            {
                UpdateContentDirect op = Build(
                    body,
                    channelId,
                    contentId,
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

            public Model.ModelsCreateContentResponse<T1>? Execute<T1>(
                ModelsCreateContentRequest body,
                string channelId,
                string contentId,
                string namespace_,
                string userId
            )
            {
                UpdateContentDirect op = Build(
                    body,
                    channelId,
                    contentId,
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private UpdateContentDirect(UpdateContentDirectBuilder builder,
            ModelsCreateContentRequest body,
            string channelId,
            string contentId,
            string namespace_,
            string userId
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateContentDirect(
            string channelId,            
            string contentId,            
            string namespace_,            
            string userId,            
            Model.ModelsCreateContentRequest body            
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json","application/octet-stream" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelsCreateContentResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateContentResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateContentResponse>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }

        public Model.ModelsCreateContentResponse<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }            
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateContentResponse<T1>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateContentResponse<T1>>(payload);
            }
            
            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}
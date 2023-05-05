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
    /// PublicGetContentBulk
    ///
    /// Maximum requested Ids: 100.
    /// Public user can access without token or if token specified, requires valid user token
    /// </summary>
    public class PublicGetContentBulk : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetContentBulkBuilder Builder { get => new PublicGetContentBulkBuilder(); }

        public class PublicGetContentBulkBuilder
            : OperationBuilder<PublicGetContentBulkBuilder>
        {





            internal PublicGetContentBulkBuilder() { }

            internal PublicGetContentBulkBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetContentBulk Build(
                ModelsPublicGetContentBulkRequest body,
                string namespace_
            )
            {
                PublicGetContentBulk op = new PublicGetContentBulk(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public List<Model.ModelsContentDownloadResponse>? Execute(
                ModelsPublicGetContentBulkRequest body,
                string namespace_
            )
            {
                PublicGetContentBulk op = Build(
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

            public List<Model.ModelsContentDownloadResponse<T1>>? Execute<T1>(
                ModelsPublicGetContentBulkRequest body,
                string namespace_
            )
            {
                PublicGetContentBulk op = Build(
                    body,
                    namespace_
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

        private PublicGetContentBulk(PublicGetContentBulkBuilder builder,
            ModelsPublicGetContentBulkRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetContentBulk(
            string namespace_,            
            Model.ModelsPublicGetContentBulkRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/contents/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json","application/octet-stream" };

        public override List<string> Produces => new() { "application/json" };        
        
        public List<Model.ModelsContentDownloadResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsContentDownloadResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsContentDownloadResponse>>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }

        public List<Model.ModelsContentDownloadResponse<T1>>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }            
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsContentDownloadResponse<T1>>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsContentDownloadResponse<T1>>>(payload);
            }
            
            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}
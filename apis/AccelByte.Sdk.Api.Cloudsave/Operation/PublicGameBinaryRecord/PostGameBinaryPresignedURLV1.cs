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

using AccelByte.Sdk.Api.Cloudsave.Model;

namespace AccelByte.Sdk.Api.Cloudsave.Operation
{
    /// <summary>
    /// postGameBinaryPresignedURLV1
    ///
    /// Required permission: `NAMESPACE:{namespace}:CLOUDSAVE:RECORD [CREATE]`
    /// Required scope: `social`
    /// 
    /// Request presigned URL to upload the binary record to s3.
    /// 
    /// 
    /// Other detail info:
    /// 
    /// 
    /// 
    /// Supported file types: jpeg, jpg, png, bmp, gif, mp3, webp, and bin.
    /// </summary>
    public class PostGameBinaryPresignedURLV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PostGameBinaryPresignedURLV1Builder Builder { get => new PostGameBinaryPresignedURLV1Builder(); }

        public class PostGameBinaryPresignedURLV1Builder
            : OperationBuilder<PostGameBinaryPresignedURLV1Builder>
        {





            internal PostGameBinaryPresignedURLV1Builder() { }

            internal PostGameBinaryPresignedURLV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PostGameBinaryPresignedURLV1 Build(
                ModelsUploadBinaryRecordRequest body,
                string key,
                string namespace_
            )
            {
                PostGameBinaryPresignedURLV1 op = new PostGameBinaryPresignedURLV1(this,
                    body,                    
                    key,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsUploadBinaryRecordResponse? Execute(
                ModelsUploadBinaryRecordRequest body,
                string key,
                string namespace_
            )
            {
                PostGameBinaryPresignedURLV1 op = Build(
                    body,
                    key,
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

        private PostGameBinaryPresignedURLV1(PostGameBinaryPresignedURLV1Builder builder,
            ModelsUploadBinaryRecordRequest body,
            string key,
            string namespace_
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PostGameBinaryPresignedURLV1(
            string key,            
            string namespace_,            
            Model.ModelsUploadBinaryRecordRequest body            
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/namespaces/{namespace}/binaries/{key}/presigned";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelsUploadBinaryRecordResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsUploadBinaryRecordResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsUploadBinaryRecordResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
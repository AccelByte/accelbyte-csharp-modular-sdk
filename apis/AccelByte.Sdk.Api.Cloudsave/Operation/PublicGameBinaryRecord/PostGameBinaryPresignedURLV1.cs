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

using AccelByte.Sdk.Api.Cloudsave.Model;

namespace AccelByte.Sdk.Api.Cloudsave.Operation
{
    /// <summary>
    /// postGameBinaryPresignedURLV1
    ///
    /// Request presigned URL to upload the binary record to s3.
    /// 
    /// Other detail info:
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

                op.SetBaseFields<PostGameBinaryPresignedURLV1Builder>(this);
                return op;
            }

            public PostGameBinaryPresignedURLV1.Response Execute(
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
            public async Task<PostGameBinaryPresignedURLV1.Response> ExecuteAsync(
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

                var response = await _Sdk.RunRequestAsync(op);
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

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsUploadBinaryRecordResponse>
        {

            public ModelsResponseError? Error400 { get; set; } = null;

            public ModelsResponseError? Error401 { get; set; } = null;

            public ModelsResponseError? Error403 { get; set; } = null;

            public ModelsResponseError? Error404 { get; set; } = null;

            public ModelsResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Cloudsave::PublicGameBinaryRecord::PostGameBinaryPresignedURLV1";
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
        
        public PostGameBinaryPresignedURLV1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PostGameBinaryPresignedURLV1.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsUploadBinaryRecordResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ModelsResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ModelsResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ModelsResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ModelsResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ModelsResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
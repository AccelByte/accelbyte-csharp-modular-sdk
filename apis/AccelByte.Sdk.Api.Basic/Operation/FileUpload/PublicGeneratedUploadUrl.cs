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

using AccelByte.Sdk.Api.Basic.Model;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// publicGeneratedUploadUrl
    ///
    /// Generate an upload URL. It's valid for 10 minutes.
    /// Other detail info:
    /// 
    ///   * Action code : 11101
    ///   *  Returns : URL data
    /// </summary>
    public class PublicGeneratedUploadUrl : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGeneratedUploadUrlBuilder Builder { get => new PublicGeneratedUploadUrlBuilder(); }

        public class PublicGeneratedUploadUrlBuilder
            : OperationBuilder<PublicGeneratedUploadUrlBuilder>
        {





            internal PublicGeneratedUploadUrlBuilder() { }

            internal PublicGeneratedUploadUrlBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGeneratedUploadUrl Build(
                string folder,
                string namespace_,
                string fileType
            )
            {
                PublicGeneratedUploadUrl op = new PublicGeneratedUploadUrl(this,
                    folder,                    
                    namespace_,                    
                    fileType                    
                );

                op.SetBaseFields<PublicGeneratedUploadUrlBuilder>(this);
                return op;
            }

            public PublicGeneratedUploadUrl.Response Execute(
                string folder,
                string namespace_,
                string fileType
            )
            {
                PublicGeneratedUploadUrl op = Build(
                    folder,
                    namespace_,
                    fileType
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<PublicGeneratedUploadUrl.Response> ExecuteAsync(
                string folder,
                string namespace_,
                string fileType
            )
            {
                PublicGeneratedUploadUrl op = Build(
                    folder,
                    namespace_,
                    fileType
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

        private PublicGeneratedUploadUrl(PublicGeneratedUploadUrlBuilder builder,
            string folder,
            string namespace_,
            string fileType
        )
        {
            PathParams["folder"] = folder;
            PathParams["namespace"] = namespace_;
            
            if (fileType is not null) QueryParams["fileType"] = fileType;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.FileUploadUrlInfo>
        {

            public ValidationErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error401 { get; set; } = null;

            public ErrorEntity? Error403 { get; set; } = null;

            public ErrorEntity? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Basic::FileUpload::PublicGeneratedUploadUrl";
        }

        #endregion

        public PublicGeneratedUploadUrl(
            string folder,            
            string namespace_,            
            string fileType            
        )
        {
            PathParams["folder"] = folder;
            PathParams["namespace"] = namespace_;
            
            if (fileType is not null) QueryParams["fileType"] = fileType;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/folders/{folder}/files";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicGeneratedUploadUrl.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicGeneratedUploadUrl.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.FileUploadUrlInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ValidationErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
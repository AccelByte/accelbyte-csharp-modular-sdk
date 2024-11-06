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

using AccelByte.Sdk.Api.Ams.Model;

namespace AccelByte.Sdk.Api.Ams.Operation
{
    /// <summary>
    /// ImagePatch
    ///
    /// This allows editing of the image name, toggling `IsProtected`, or adding & removal of tags
    /// 
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:AMS:IMAGE [UPDATE]
    /// </summary>
    public class ImagePatch : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ImagePatchBuilder Builder { get => new ImagePatchBuilder(); }

        public class ImagePatchBuilder
            : OperationBuilder<ImagePatchBuilder>
        {





            internal ImagePatchBuilder() { }

            internal ImagePatchBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public ImagePatch Build(
                ApiImageUpdate body,
                string imageID,
                string namespace_
            )
            {
                ImagePatch op = new ImagePatch(this,
                    body,                    
                    imageID,                    
                    namespace_                    
                );

                op.SetBaseFields<ImagePatchBuilder>(this);
                return op;
            }

            public ImagePatch.Response Execute(
                ApiImageUpdate body,
                string imageID,
                string namespace_
            )
            {
                ImagePatch op = Build(
                    body,
                    imageID,
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
            public async Task<ImagePatch.Response> ExecuteAsync(
                ApiImageUpdate body,
                string imageID,
                string namespace_
            )
            {
                ImagePatch op = Build(
                    body,
                    imageID,
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

        private ImagePatch(ImagePatchBuilder builder,
            ApiImageUpdate body,
            string imageID,
            string namespace_
        )
        {
            PathParams["imageID"] = imageID;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ApiImageDetails>
        {

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error404 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Ams::Images::ImagePatch";
        }

        #endregion

        public ImagePatch(
            string imageID,            
            string namespace_,            
            Model.ApiImageUpdate body            
        )
        {
            PathParams["imageID"] = imageID;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/admin/namespaces/{namespace}/images/{imageID}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public ImagePatch.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new ImagePatch.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ApiImageDetails>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
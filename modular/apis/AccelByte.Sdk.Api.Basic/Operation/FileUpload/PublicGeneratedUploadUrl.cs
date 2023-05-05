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

using AccelByte.Sdk.Api.Basic.Model;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// publicGeneratedUploadUrl
    ///
    /// Generate an upload URL. It's valid for 10 minutes.
    /// Other detail info:
    /// 
    ///   * Required permission : resource = "NAMESPACE:{namespace}:FILEUPLOAD" , action=1 (CREATE)
    ///   *  Action code : 11101
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
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.FileUploadUrlInfo? Execute(
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
        
        public Model.FileUploadUrlInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.FileUploadUrlInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FileUploadUrlInfo>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
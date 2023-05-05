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
    /// publicGeneratedUserUploadContentUrl
    ///
    /// Generate an upload URL for user content. It's valid for 10 minutes.
    /// There are 2 kinds of storage limitation per user : maximum file count and maximum file size.
    /// The threshold of those limitations is different between upload category that is used.
    /// Other detail info:
    /// 
    ///   * Required permission : resource = "NAMESPACE:{namespace}:USER:{userId}:FILEUPLOAD" , action=1 (CREATE)
    ///   *  Action code : 11102
    ///   *  Default maximum file count per user : 10 files
    ///   *  Default maximum file size per user : 104857600 bytes
    ///   *  Returns : URL data
    /// </summary>
    public class PublicGeneratedUserUploadContentUrl : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGeneratedUserUploadContentUrlBuilder Builder { get => new PublicGeneratedUserUploadContentUrlBuilder(); }

        public class PublicGeneratedUserUploadContentUrlBuilder
            : OperationBuilder<PublicGeneratedUserUploadContentUrlBuilder>
        {

            public string? Category { get; set; }





            internal PublicGeneratedUserUploadContentUrlBuilder() { }

            internal PublicGeneratedUserUploadContentUrlBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicGeneratedUserUploadContentUrlBuilder SetCategory(string _category)
            {
                Category = _category;
                return this;
            }





            public PublicGeneratedUserUploadContentUrl Build(
                string namespace_,
                string userId,
                string fileType
            )
            {
                PublicGeneratedUserUploadContentUrl op = new PublicGeneratedUserUploadContentUrl(this,
                    namespace_,                    
                    userId,                    
                    fileType                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.FileUploadUrlInfo? Execute(
                string namespace_,
                string userId,
                string fileType
            )
            {
                PublicGeneratedUserUploadContentUrl op = Build(
                    namespace_,
                    userId,
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

        private PublicGeneratedUserUploadContentUrl(PublicGeneratedUserUploadContentUrlBuilder builder,
            string namespace_,
            string userId,
            string fileType
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.Category is not null) QueryParams["category"] = builder.Category;
            if (fileType is not null) QueryParams["fileType"] = fileType;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGeneratedUserUploadContentUrl(
            string namespace_,            
            string userId,            
            string? category,            
            string fileType            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (category is not null) QueryParams["category"] = category;
            if (fileType is not null) QueryParams["fileType"] = fileType;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/users/{userId}/files";

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
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

using AccelByte.Sdk.Api.Dsmc.Model;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// ImportImages
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [CREATE]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint import a dedicated servers images in a namespace.
    /// 
    /// The image will be upsert. Existing version will be replaced with imported image, will create new one if not found.
    /// 
    /// Example data inside imported file
    /// [
    /// {
    /// "namespace": "dewa",
    /// "image": "123456789.dkr.ecr.us-west-2.amazonaws.com/ds-dewa:0.0.1-alpha",
    /// "version": "0.0.1",
    /// "persistent": true
    /// }
    /// ]
    /// </summary>
    public class ImportImages : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ImportImagesBuilder Builder { get => new ImportImagesBuilder(); }

        public class ImportImagesBuilder
            : OperationBuilder<ImportImagesBuilder>
        {





            internal ImportImagesBuilder() { }

            internal ImportImagesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public ImportImages Build(
                Stream file
            )
            {
                ImportImages op = new ImportImages(this,
                    file                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelsImportResponse? Execute(
                Stream file
            )
            {
                ImportImages op = Build(
                    file
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

        private ImportImages(ImportImagesBuilder builder,
            Stream file
        )
        {
            
            
            if (file is not null) FormParams["file"] = file;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ImportImages(
            Stream file            
        )
        {
            
            
            if (file is not null) FormParams["file"] = file;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/images/import";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "multipart/form-data" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelsImportResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsImportResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsImportResponse>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
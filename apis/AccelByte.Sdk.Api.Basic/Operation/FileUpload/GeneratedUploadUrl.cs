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
    /// generatedUploadUrl
    ///
    /// Generate an upload URL. It's valid for 10 minutes.
    /// Other detail info:
    /// 
    ///   * Required permission : resource = "ADMIN:NAMESPACE:{namespace}:FILEUPLOAD" , action=1 (CREATE)
    ///   *  Action code : 11101
    ///   *  Returns : URL data
    /// </summary>
    public class GeneratedUploadUrl : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GeneratedUploadUrlBuilder Builder { get => new GeneratedUploadUrlBuilder(); }

        public class GeneratedUploadUrlBuilder
            : OperationBuilder<GeneratedUploadUrlBuilder>
        {





            internal GeneratedUploadUrlBuilder() { }

            internal GeneratedUploadUrlBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GeneratedUploadUrl Build(
                string folder,
                string namespace_,
                string fileType
            )
            {
                GeneratedUploadUrl op = new GeneratedUploadUrl(this,
                    folder,
                    namespace_,
                    fileType
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.FileUploadUrlInfo? Execute(
                string folder,
                string namespace_,
                string fileType
            )
            {
                GeneratedUploadUrl op = Build(
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

        private GeneratedUploadUrl(GeneratedUploadUrlBuilder builder,
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

        public GeneratedUploadUrl(
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

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/folders/{folder}/files";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.FileUploadUrlInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.FileUploadUrlInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FileUploadUrlInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
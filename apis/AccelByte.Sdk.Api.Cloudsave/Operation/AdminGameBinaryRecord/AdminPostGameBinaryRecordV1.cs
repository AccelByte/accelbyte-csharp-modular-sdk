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
    /// adminPostGameBinaryRecordV1
    ///
    /// Required permission: `ADMIN:NAMESPACE:{namespace}:CLOUDSAVE:RECORD [CREATE]`
    /// Required scope: `social`
    /// 
    /// Create a game binary record.
    /// 
    /// 
    /// Other detail info:
    /// 
    /// 
    /// 
    /// `key` should follow these rules:
    /// 1. support uppercase and lowercase letters, numbers, and separators "-" , "_" , "." are allowed
    /// 2. begin and end with letters or numbers
    /// 3. spaces are not allowed
    /// 4. separators must not appears twice in a row
    /// 
    /// 
    /// Supported file types: jpeg, jpg, png, bmp, gif, mp3, webp, and bin.
    /// </summary>
    public class AdminPostGameBinaryRecordV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminPostGameBinaryRecordV1Builder Builder { get => new AdminPostGameBinaryRecordV1Builder(); }

        public class AdminPostGameBinaryRecordV1Builder
            : OperationBuilder<AdminPostGameBinaryRecordV1Builder>
        {





            internal AdminPostGameBinaryRecordV1Builder() { }

            internal AdminPostGameBinaryRecordV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminPostGameBinaryRecordV1 Build(
                ModelsGameBinaryRecordCreate body,
                string namespace_
            )
            {
                AdminPostGameBinaryRecordV1 op = new AdminPostGameBinaryRecordV1(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsUploadBinaryRecordResponse? Execute(
                ModelsGameBinaryRecordCreate body,
                string namespace_
            )
            {
                AdminPostGameBinaryRecordV1 op = Build(
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
        }

        private AdminPostGameBinaryRecordV1(AdminPostGameBinaryRecordV1Builder builder,
            ModelsGameBinaryRecordCreate body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminPostGameBinaryRecordV1(
            string namespace_,
            Model.ModelsGameBinaryRecordCreate body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/binaries";

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
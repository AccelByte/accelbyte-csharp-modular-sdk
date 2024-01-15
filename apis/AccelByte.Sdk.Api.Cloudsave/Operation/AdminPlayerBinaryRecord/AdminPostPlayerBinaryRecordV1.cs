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
    /// adminPostPlayerBinaryRecordV1
    ///
    /// Create a player binary record.
    /// 
    /// Other detail info:
    /// 
    /// `key` should follow these rules:
    /// 1. support uppercase and lowercase letters, numbers, and separators **"-"**, **"_"**, **"."** are allowed
    /// 2. begin and end with letters or numbers
    /// 3. spaces are not allowed
    /// 4. separators must not appears twice in a row
    /// 
    /// 
    /// Supported file types: jpeg, jpg, png, bmp, gif, mp3, webp, and bin.
    /// </summary>
    public class AdminPostPlayerBinaryRecordV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminPostPlayerBinaryRecordV1Builder Builder { get => new AdminPostPlayerBinaryRecordV1Builder(); }

        public class AdminPostPlayerBinaryRecordV1Builder
            : OperationBuilder<AdminPostPlayerBinaryRecordV1Builder>
        {





            internal AdminPostPlayerBinaryRecordV1Builder() { }

            internal AdminPostPlayerBinaryRecordV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminPostPlayerBinaryRecordV1 Build(
                ModelsPlayerBinaryRecordCreate body,
                string namespace_,
                string userId
            )
            {
                AdminPostPlayerBinaryRecordV1 op = new AdminPostPlayerBinaryRecordV1(this,
                    body,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsUploadBinaryRecordResponse? Execute(
                ModelsPlayerBinaryRecordCreate body,
                string namespace_,
                string userId
            )
            {
                AdminPostPlayerBinaryRecordV1 op = Build(
                    body,
                    namespace_,
                    userId
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

        private AdminPostPlayerBinaryRecordV1(AdminPostPlayerBinaryRecordV1Builder builder,
            ModelsPlayerBinaryRecordCreate body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminPostPlayerBinaryRecordV1(
            string namespace_,
            string userId,
            Model.ModelsPlayerBinaryRecordCreate body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/binaries";

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
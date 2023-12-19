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

using AccelByte.Sdk.Api.Lobby.Model;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// adminImportConfigV1
    ///
    /// 
    /// Import config configuration from file. The existing configuration will be replaced.
    /// The json file to import can be obtained from the /export endpoint.
    /// 
    /// MaxDSWaitTime value is cannot less than 1, if null it will use default value in 120 (second)
    /// </summary>
    public class AdminImportConfigV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminImportConfigV1Builder Builder { get => new AdminImportConfigV1Builder(); }

        public class AdminImportConfigV1Builder
            : OperationBuilder<AdminImportConfigV1Builder>
        {



            public Stream? File { get; set; }



            internal AdminImportConfigV1Builder() { }

            internal AdminImportConfigV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }




            public AdminImportConfigV1Builder SetFile(Stream _file)
            {
                File = _file;
                return this;
            }



            public AdminImportConfigV1 Build(
                string namespace_
            )
            {
                AdminImportConfigV1 op = new AdminImportConfigV1(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsImportConfigResponse? Execute(
                string namespace_
            )
            {
                AdminImportConfigV1 op = Build(
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

        private AdminImportConfigV1(AdminImportConfigV1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;


            if (builder.File is not null) FormParams["file"] = builder.File;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminImportConfigV1(
            string namespace_,
            Stream? file
        )
        {
            PathParams["namespace"] = namespace_;


            if (file is not null) FormParams["file"] = file;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/config/namespaces/{namespace}/import";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "multipart/form-data" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsImportConfigResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsImportConfigResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsImportConfigResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
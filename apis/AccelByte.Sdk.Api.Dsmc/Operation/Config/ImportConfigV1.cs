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

using AccelByte.Sdk.Api.Dsmc.Model;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// importConfigV1
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [CREATE]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint import a dedicated servers config in a namespace.
    /// 
    /// If there is an existing configuration, the configuration would be replaced.
    /// </summary>
    public class ImportConfigV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ImportConfigV1Builder Builder { get => new ImportConfigV1Builder(); }

        public class ImportConfigV1Builder
            : OperationBuilder<ImportConfigV1Builder>
        {



            public Stream? File { get; set; }



            internal ImportConfigV1Builder() { }

            internal ImportConfigV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }




            public ImportConfigV1Builder SetFile(Stream _file)
            {
                File = _file;
                return this;
            }



            public ImportConfigV1 Build(
                string namespace_
            )
            {
                ImportConfigV1 op = new ImportConfigV1(this,
                    namespace_                    
                );

                op.SetBaseFields<ImportConfigV1Builder>(this);
                return op;
            }

            public ImportConfigV1.Response Execute(
                string namespace_
            )
            {
                ImportConfigV1 op = Build(
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
            public async Task<ImportConfigV1.Response> ExecuteAsync(
                string namespace_
            )
            {
                ImportConfigV1 op = Build(
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

        private ImportConfigV1(ImportConfigV1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            if (builder.File is not null) FormParams["file"] = builder.File;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsImportResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Dsmc::Config::ImportConfigV1";
        }

        #endregion

        public ImportConfigV1(
            string namespace_,            
            Stream? file            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            if (file is not null) FormParams["file"] = file;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/v1/namespaces/{namespace}/configs/import";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "multipart/form-data" };

        public override List<string> Produces => new() { "application/json" };
        
        public ImportConfigV1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new ImportConfigV1.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsImportResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
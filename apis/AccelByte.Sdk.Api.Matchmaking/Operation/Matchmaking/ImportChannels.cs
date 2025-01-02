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

using AccelByte.Sdk.Api.Matchmaking.Model;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    /// <summary>
    /// ImportChannels
    ///
    /// Import channels configuration from file. It will merge with existing channels.
    /// Available import strategy:
    /// - leaveOut: if channel with same key exist, the existing will be used and imported one will be ignored (default)
    /// - replace: if channel with same key exist, the imported channel will be used and existing one will be removed
    /// 
    /// Action Code: 510113
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class ImportChannels : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ImportChannelsBuilder Builder { get => new ImportChannelsBuilder(); }

        public class ImportChannelsBuilder
            : OperationBuilder<ImportChannelsBuilder>
        {



            public Stream? File { get; set; }

            public string? Strategy { get; set; }



            internal ImportChannelsBuilder() { }

            internal ImportChannelsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }




            public ImportChannelsBuilder SetFile(Stream _file)
            {
                File = _file;
                return this;
            }

            public ImportChannelsBuilder SetStrategy(string _strategy)
            {
                Strategy = _strategy;
                return this;
            }



            public ImportChannels Build(
                string namespace_
            )
            {
                ImportChannels op = new ImportChannels(this,
                    namespace_
                );

                op.SetBaseFields<ImportChannelsBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public ImportChannels.Response Execute(
                string namespace_
            )
            {
                ImportChannels op = Build(
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
            public async Task<ImportChannels.Response> ExecuteAsync(
                string namespace_
            )
            {
                ImportChannels op = Build(
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

        private ImportChannels(ImportChannelsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;


            if (builder.File is not null) FormParams["file"] = builder.File;
            if (builder.Strategy is not null) FormParams["strategy"] = builder.Strategy;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsImportConfigResponse>
        {

            public ResponseErrorV1? Error400 { get; set; } = null;

            public ResponseErrorV1? Error401 { get; set; } = null;

            public ResponseErrorV1? Error403 { get; set; } = null;

            public ResponseErrorV1? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Matchmaking::Matchmaking::ImportChannels";
        }

        #endregion

        public ImportChannels(
            string namespace_,
            Stream? file,
            string? strategy
        )
        {
            PathParams["namespace"] = namespace_;


            if (file is not null) FormParams["file"] = file;
            if (strategy is not null) FormParams["strategy"] = strategy;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/matchmaking/v1/admin/namespaces/{namespace}/channels/import";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "multipart/form-data" };

        public override List<string> Produces => new() { "application/json" };

        public ImportChannels.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new ImportChannels.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsImportConfigResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseErrorV1>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseErrorV1>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseErrorV1>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseErrorV1>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
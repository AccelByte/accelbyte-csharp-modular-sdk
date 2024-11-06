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

using AccelByte.Sdk.Api.Social.Model;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// importStats
    ///
    /// Import stat configurations for a given namespace from file. At current, only JSON file is supported.
    /// </summary>
    public class ImportStats : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ImportStatsBuilder Builder { get => new ImportStatsBuilder(); }

        public class ImportStatsBuilder
            : OperationBuilder<ImportStatsBuilder>
        {

            public bool? ReplaceExisting { get; set; }



            public Stream? File { get; set; }



            internal ImportStatsBuilder() { }

            internal ImportStatsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public ImportStatsBuilder SetReplaceExisting(bool _replaceExisting)
            {
                ReplaceExisting = _replaceExisting;
                return this;
            }



            public ImportStatsBuilder SetFile(Stream _file)
            {
                File = _file;
                return this;
            }



            public ImportStats Build(
                string namespace_
            )
            {
                ImportStats op = new ImportStats(this,
                    namespace_                    
                );

                op.SetBaseFields<ImportStatsBuilder>(this);
                return op;
            }

            public ImportStats.Response Execute(
                string namespace_
            )
            {
                ImportStats op = Build(
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
            public async Task<ImportStats.Response> ExecuteAsync(
                string namespace_
            )
            {
                ImportStats op = Build(
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

        private ImportStats(ImportStatsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.ReplaceExisting != null) QueryParams["replaceExisting"] = Convert.ToString(builder.ReplaceExisting)!;
            
            if (builder.File is not null) FormParams["file"] = builder.File;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.StatImportInfo>
        {

            public ErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error401 { get; set; } = null;

            public ErrorEntity? Error403 { get; set; } = null;

            public ErrorEntity? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Social::StatConfiguration::ImportStats";
        }

        #endregion

        public ImportStats(
            string namespace_,            
            bool? replaceExisting,            
            Stream? file            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (replaceExisting != null) QueryParams["replaceExisting"] = Convert.ToString(replaceExisting)!;
            
            if (file is not null) FormParams["file"] = file;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/stats/import";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "multipart/form-data" };

        public override List<string> Produces => new() { "application/json" };
        
        public ImportStats.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new ImportStats.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.StatImportInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
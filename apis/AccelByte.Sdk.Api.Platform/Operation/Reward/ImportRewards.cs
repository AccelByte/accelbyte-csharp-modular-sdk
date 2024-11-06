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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// importRewards
    ///
    /// Import reward configurations for a given namespace from file. At current, only JSON file is supported.
    /// </summary>
    public class ImportRewards : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ImportRewardsBuilder Builder { get => new ImportRewardsBuilder(); }

        public class ImportRewardsBuilder
            : OperationBuilder<ImportRewardsBuilder>
        {



            public Stream? File { get; set; }



            internal ImportRewardsBuilder() { }

            internal ImportRewardsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }




            public ImportRewardsBuilder SetFile(Stream _file)
            {
                File = _file;
                return this;
            }



            public ImportRewards Build(
                string namespace_,
                bool replaceExisting
            )
            {
                ImportRewards op = new ImportRewards(this,
                    namespace_,                    
                    replaceExisting                    
                );

                op.SetBaseFields<ImportRewardsBuilder>(this);
                return op;
            }

            public ImportRewards.Response Execute(
                string namespace_,
                bool replaceExisting
            )
            {
                ImportRewards op = Build(
                    namespace_,
                    replaceExisting
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<ImportRewards.Response> ExecuteAsync(
                string namespace_,
                bool replaceExisting
            )
            {
                ImportRewards op = Build(
                    namespace_,
                    replaceExisting
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

        private ImportRewards(ImportRewardsBuilder builder,
            string namespace_,
            bool replaceExisting
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            QueryParams["replaceExisting"] = Convert.ToString(replaceExisting)!;
            
            if (builder.File is not null) FormParams["file"] = builder.File;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error409 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Reward::ImportRewards";
        }

        #endregion

        public ImportRewards(
            string namespace_,            
            bool replaceExisting,            
            Stream? file            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            QueryParams["replaceExisting"] = Convert.ToString(replaceExisting)!;
            
            if (file is not null) FormParams["file"] = file;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/rewards/import";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "multipart/form-data" };

        public override List<string> Produces => new() { "application/json" };
        
        public ImportRewards.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new ImportRewards.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)
            
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)409)
            
            {
                response.Error409 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }

            return response;
        }
    }

}
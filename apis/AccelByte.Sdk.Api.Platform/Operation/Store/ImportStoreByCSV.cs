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
    /// importStoreByCSV
    ///
    /// This API is used to import a store by CSV format.
    /// </summary>
    public class ImportStoreByCSV : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ImportStoreByCSVBuilder Builder { get => new ImportStoreByCSVBuilder(); }

        public class ImportStoreByCSVBuilder
            : OperationBuilder<ImportStoreByCSVBuilder>
        {





            internal ImportStoreByCSVBuilder() { }

            internal ImportStoreByCSVBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public ImportStoreByCSV Build(
                Stream category,
                Stream display,
                Stream item,
                string notes,
                Stream section,
                string namespace_,
                string storeId
            )
            {
                ImportStoreByCSV op = new ImportStoreByCSV(this,
                    category,                    
                    display,                    
                    item,                    
                    notes,                    
                    section,                    
                    namespace_,                    
                    storeId                    
                );

                op.SetBaseFields<ImportStoreByCSVBuilder>(this);
                return op;
            }

            public ImportStoreByCSV.Response Execute(
                Stream category,
                Stream display,
                Stream item,
                string notes,
                Stream section,
                string namespace_,
                string storeId
            )
            {
                ImportStoreByCSV op = Build(
                    category,
                    display,
                    item,
                    notes,
                    section,
                    namespace_,
                    storeId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<ImportStoreByCSV.Response> ExecuteAsync(
                Stream category,
                Stream display,
                Stream item,
                string notes,
                Stream section,
                string namespace_,
                string storeId
            )
            {
                ImportStoreByCSV op = Build(
                    category,
                    display,
                    item,
                    notes,
                    section,
                    namespace_,
                    storeId
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

        private ImportStoreByCSV(ImportStoreByCSVBuilder builder,
            Stream category,
            Stream display,
            Stream item,
            string notes,
            Stream section,
            string namespace_,
            string storeId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;
            
            
            if (category is not null) FormParams["category"] = category;
            if (display is not null) FormParams["display"] = display;
            if (item is not null) FormParams["item"] = item;
            if (notes is not null) FormParams["notes"] = notes;
            if (section is not null) FormParams["section"] = section;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ImportStoreResult>
        {

            public ErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error404 { get; set; } = null;

            public ErrorEntity? Error409 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Store::ImportStoreByCSV";
        }

        #endregion

        public ImportStoreByCSV(
            string namespace_,            
            string storeId,            
            Stream category,            
            Stream display,            
            Stream item,            
            string notes,            
            Stream section            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;
            
            
            if (category is not null) FormParams["category"] = category;
            if (display is not null) FormParams["display"] = display;
            if (item is not null) FormParams["item"] = item;
            if (notes is not null) FormParams["notes"] = notes;
            if (section is not null) FormParams["section"] = section;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/stores/{storeId}/importByCSV";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "multipart/form-data" };

        public override List<string> Produces => new() { "application/json" };
        
        public ImportStoreByCSV.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new ImportStoreByCSV.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ImportStoreResult>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
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
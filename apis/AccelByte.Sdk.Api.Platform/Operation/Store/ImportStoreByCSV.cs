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
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:STORE", action=4 (UPDATE)
    /// </summary>
    public class ImportStoreByCSV : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ImportStoreByCSVBuilder Builder { get => new ImportStoreByCSVBuilder(); }

        public class ImportStoreByCSVBuilder
            : OperationBuilder<ImportStoreByCSVBuilder>
        {



            public Stream? Category { get; set; }

            public Stream? Display { get; set; }

            public Stream? Item { get; set; }

            public string? Notes { get; set; }

            public Stream? Section { get; set; }



            internal ImportStoreByCSVBuilder() { }

            internal ImportStoreByCSVBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }




            public ImportStoreByCSVBuilder SetCategory(Stream _category)
            {
                Category = _category;
                return this;
            }

            public ImportStoreByCSVBuilder SetDisplay(Stream _display)
            {
                Display = _display;
                return this;
            }

            public ImportStoreByCSVBuilder SetItem(Stream _item)
            {
                Item = _item;
                return this;
            }

            public ImportStoreByCSVBuilder SetNotes(string _notes)
            {
                Notes = _notes;
                return this;
            }

            public ImportStoreByCSVBuilder SetSection(Stream _section)
            {
                Section = _section;
                return this;
            }



            public ImportStoreByCSV Build(
                string namespace_,
                string storeId
            )
            {
                ImportStoreByCSV op = new ImportStoreByCSV(this,
                    namespace_,
                    storeId
                );

                op.SetBaseFields<ImportStoreByCSVBuilder>(this);
                return op;
            }

            public Model.ImportStoreResult? Execute(
                string namespace_,
                string storeId
            )
            {
                ImportStoreByCSV op = Build(
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
            public async Task<Model.ImportStoreResult?> ExecuteAsync(
                string namespace_,
                string storeId
            )
            {
                ImportStoreByCSV op = Build(
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
            string namespace_,
            string storeId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;


            if (builder.Category is not null) FormParams["category"] = builder.Category;
            if (builder.Display is not null) FormParams["display"] = builder.Display;
            if (builder.Item is not null) FormParams["item"] = builder.Item;
            if (builder.Notes is not null) FormParams["notes"] = builder.Notes;
            if (builder.Section is not null) FormParams["section"] = builder.Section;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ImportStoreByCSV(
            string namespace_,
            string storeId,
            Stream? category,
            Stream? display,
            Stream? item,
            string? notes,
            Stream? section
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

        public Model.ImportStoreResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ImportStoreResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ImportStoreResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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
    /// importStore_1
    ///
    /// This API is used to import a store.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:STORE", action=4 (UPDATE)
    /// </summary>
    public class ImportStore1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ImportStore1Builder Builder { get => new ImportStore1Builder(); }

        public class ImportStore1Builder
            : OperationBuilder<ImportStore1Builder>
        {

            public string? StoreId { get; set; }

            public bool? StrictMode { get; set; }



            public Stream? File { get; set; }



            internal ImportStore1Builder() { }

            internal ImportStore1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public ImportStore1Builder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }

            public ImportStore1Builder SetStrictMode(bool _strictMode)
            {
                StrictMode = _strictMode;
                return this;
            }



            public ImportStore1Builder SetFile(Stream _file)
            {
                File = _file;
                return this;
            }



            public ImportStore1 Build(
                string namespace_
            )
            {
                ImportStore1 op = new ImportStore1(this,
                    namespace_
                );

                op.SetBaseFields<ImportStore1Builder>(this);
                return op;
            }

            public Model.ImportStoreResult? Execute(
                string namespace_
            )
            {
                ImportStore1 op = Build(
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
            public async Task<Model.ImportStoreResult?> ExecuteAsync(
                string namespace_
            )
            {
                ImportStore1 op = Build(
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

        private ImportStore1(ImportStore1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.StoreId is not null) QueryParams["storeId"] = builder.StoreId;
            if (builder.StrictMode != null) QueryParams["strictMode"] = Convert.ToString(builder.StrictMode)!;

            if (builder.File is not null) FormParams["file"] = builder.File;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ImportStore1(
            string namespace_,
            string? storeId,
            bool? strictMode,
            Stream? file
        )
        {
            PathParams["namespace"] = namespace_;

            if (storeId is not null) QueryParams["storeId"] = storeId;
            if (strictMode != null) QueryParams["strictMode"] = Convert.ToString(strictMode)!;

            if (file is not null) FormParams["file"] = file;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/v2/admin/namespaces/{namespace}/stores/import";

        public override HttpMethod Method => HttpMethod.Put;

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
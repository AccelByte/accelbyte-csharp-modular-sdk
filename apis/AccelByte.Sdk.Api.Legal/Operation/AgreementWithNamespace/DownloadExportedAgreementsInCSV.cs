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

using AccelByte.Sdk.Api.Legal.Model;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// downloadExportedAgreementsInCSV
    ///
    /// This API will check the status of export process.
    /// If the export process has been completed, the response body will include the download url.
    /// </summary>
    public class DownloadExportedAgreementsInCSV : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DownloadExportedAgreementsInCSVBuilder Builder { get => new DownloadExportedAgreementsInCSVBuilder(); }

        public class DownloadExportedAgreementsInCSVBuilder
            : OperationBuilder<DownloadExportedAgreementsInCSVBuilder>
        {





            internal DownloadExportedAgreementsInCSVBuilder() { }

            internal DownloadExportedAgreementsInCSVBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DownloadExportedAgreementsInCSV Build(
                string namespace_,
                string exportId
            )
            {
                DownloadExportedAgreementsInCSV op = new DownloadExportedAgreementsInCSV(this,
                    namespace_,
                    exportId
                );

                op.SetBaseFields<DownloadExportedAgreementsInCSVBuilder>(this);
                return op;
            }

            public Model.DownloadExportedAgreementsInCSVResponse? Execute(
                string namespace_,
                string exportId
            )
            {
                DownloadExportedAgreementsInCSV op = Build(
                    namespace_,
                    exportId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.DownloadExportedAgreementsInCSVResponse?> ExecuteAsync(
                string namespace_,
                string exportId
            )
            {
                DownloadExportedAgreementsInCSV op = Build(
                    namespace_,
                    exportId
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

        private DownloadExportedAgreementsInCSV(DownloadExportedAgreementsInCSVBuilder builder,
            string namespace_,
            string exportId
        )
        {
            PathParams["namespace"] = namespace_;

            if (exportId is not null) QueryParams["exportId"] = exportId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DownloadExportedAgreementsInCSV(
            string namespace_,
            string exportId
        )
        {
            PathParams["namespace"] = namespace_;

            if (exportId is not null) QueryParams["exportId"] = exportId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/namespaces/{namespace}/agreements/policy-versions/users/export-csv/download";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.DownloadExportedAgreementsInCSVResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.DownloadExportedAgreementsInCSVResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.DownloadExportedAgreementsInCSVResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
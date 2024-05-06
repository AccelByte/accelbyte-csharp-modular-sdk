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
    /// download
    ///
    /// Download all or a batch of campaign's codes as a csv file.
    /// Other detail info:
    /// 
    ///   * Returns : codes csv file
    /// </summary>
    public class Download : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DownloadBuilder Builder { get => new DownloadBuilder(); }

        public class DownloadBuilder
            : OperationBuilder<DownloadBuilder>
        {

            public int? BatchNo { get; set; }





            internal DownloadBuilder() { }

            internal DownloadBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public DownloadBuilder SetBatchNo(int _batchNo)
            {
                BatchNo = _batchNo;
                return this;
            }





            public Download Build(
                string campaignId,
                string namespace_
            )
            {
                Download op = new Download(this,
                    campaignId,
                    namespace_
                );

                op.SetBaseFields<DownloadBuilder>(this);
                return op;
            }

            public Stream? Execute(
                string campaignId,
                string namespace_
            )
            {
                Download op = Build(
                    campaignId,
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
            public async Task<Stream?> ExecuteAsync(
                string campaignId,
                string namespace_
            )
            {
                Download op = Build(
                    campaignId,
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

        private Download(DownloadBuilder builder,
            string campaignId,
            string namespace_
        )
        {
            PathParams["campaignId"] = campaignId;
            PathParams["namespace"] = namespace_;

            if (builder.BatchNo != null) QueryParams["batchNo"] = Convert.ToString(builder.BatchNo)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public Download(
            string campaignId,
            string namespace_,
            int? batchNo
        )
        {
            PathParams["campaignId"] = campaignId;
            PathParams["namespace"] = namespace_;

            if (batchNo != null) QueryParams["batchNo"] = Convert.ToString(batchNo)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}/codes.csv";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "text/csv" };

        public Stream? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return payload;
            }
            else if (code == (HttpStatusCode)200)
            {
                return payload;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
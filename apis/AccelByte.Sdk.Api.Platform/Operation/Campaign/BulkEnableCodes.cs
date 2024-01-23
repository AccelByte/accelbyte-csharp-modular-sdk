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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// bulkEnableCodes
    ///
    /// Bulk enable campaign codes.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:CAMPAIGN", action=4 (UPDATE)
    ///   *  Returns : the number of code actually enabled
    /// </summary>
    public class BulkEnableCodes : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkEnableCodesBuilder Builder { get => new BulkEnableCodesBuilder(); }

        public class BulkEnableCodesBuilder
            : OperationBuilder<BulkEnableCodesBuilder>
        {

            public int? BatchNo { get; set; }





            internal BulkEnableCodesBuilder() { }

            internal BulkEnableCodesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public BulkEnableCodesBuilder SetBatchNo(int _batchNo)
            {
                BatchNo = _batchNo;
                return this;
            }





            public BulkEnableCodes Build(
                string campaignId,
                string namespace_
            )
            {
                BulkEnableCodes op = new BulkEnableCodes(this,
                    campaignId,
                    namespace_
                );

                op.SetBaseFields<BulkEnableCodesBuilder>(this);
                return op;
            }

            public Model.BulkOperationResult? Execute(
                string campaignId,
                string namespace_
            )
            {
                BulkEnableCodes op = Build(
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
        }

        private BulkEnableCodes(BulkEnableCodesBuilder builder,
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

        public BulkEnableCodes(
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

        public override string Path => "/platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}/enable/bulk";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.BulkOperationResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.BulkOperationResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.BulkOperationResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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
    /// bulkDisableCodes
    ///
    /// Bulk disable codes.
    /// 
    /// Bulk disable campaign codes, all matched codes will be disabled except those have already been redeemed.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:CAMPAIGN", action=4 (UPDATE)
    ///   *  Returns : the number of code actually disabled
    /// </summary>
    public class BulkDisableCodes : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkDisableCodesBuilder Builder { get => new BulkDisableCodesBuilder(); }

        public class BulkDisableCodesBuilder
            : OperationBuilder<BulkDisableCodesBuilder>
        {

            public int? BatchNo { get; set; }





            internal BulkDisableCodesBuilder() { }

            internal BulkDisableCodesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public BulkDisableCodesBuilder SetBatchNo(int _batchNo)
            {
                BatchNo = _batchNo;
                return this;
            }





            public BulkDisableCodes Build(
                string campaignId,
                string namespace_
            )
            {
                BulkDisableCodes op = new BulkDisableCodes(this,
                    campaignId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.BulkOperationResult? Execute(
                string campaignId,
                string namespace_
            )
            {
                BulkDisableCodes op = Build(
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

        private BulkDisableCodes(BulkDisableCodesBuilder builder,
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

        public BulkDisableCodes(
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

        public override string Path => "/platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}/disable/bulk";

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
                return JsonSerializer.Deserialize<Model.BulkOperationResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.BulkOperationResult>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
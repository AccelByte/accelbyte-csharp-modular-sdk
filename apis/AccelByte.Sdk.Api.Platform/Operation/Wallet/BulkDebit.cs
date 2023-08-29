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
    /// bulkDebit
    ///
    /// Debit different users' wallets.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:WALLET", action=4 (UPDATE)
    ///   *  Returns : bulk credit result
    /// </summary>
    public class BulkDebit : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkDebitBuilder Builder { get => new BulkDebitBuilder(); }

        public class BulkDebitBuilder
            : OperationBuilder<BulkDebitBuilder>
        {


            public List<Model.BulkDebitRequest>? Body { get; set; }




            internal BulkDebitBuilder() { }

            internal BulkDebitBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public BulkDebitBuilder SetBody(List<Model.BulkDebitRequest> _body)
            {
                Body = _body;
                return this;
            }




            public BulkDebit Build(
                string namespace_
            )
            {
                BulkDebit op = new BulkDebit(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.BulkDebitResult? Execute(
                string namespace_
            )
            {
                BulkDebit op = Build(
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

        private BulkDebit(BulkDebitBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public BulkDebit(
            string namespace_,            
            List<Model.BulkDebitRequest> body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/wallets/debit";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.BulkDebitResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.BulkDebitResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.BulkDebitResult>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
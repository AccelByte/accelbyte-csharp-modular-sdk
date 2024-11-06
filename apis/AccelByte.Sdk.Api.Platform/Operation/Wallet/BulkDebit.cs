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
    /// bulkDebit
    ///
    /// Debit different users' wallets.
    /// Other detail info:
    /// 
    ///   * Returns : bulk credit result
    /// </summary>
    public class BulkDebit : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkDebitBuilder Builder { get => new BulkDebitBuilder(); }

        public class BulkDebitBuilder
            : OperationBuilder<BulkDebitBuilder>
        {





            internal BulkDebitBuilder() { }

            internal BulkDebitBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public BulkDebit Build(
                List<BulkDebitRequest> body,
                string namespace_
            )
            {
                BulkDebit op = new BulkDebit(this,
                    body,                    
                    namespace_                    
                );

                op.SetBaseFields<BulkDebitBuilder>(this);
                return op;
            }

            public BulkDebit.Response Execute(
                List<BulkDebitRequest> body,
                string namespace_
            )
            {
                BulkDebit op = Build(
                    body,
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
            public async Task<BulkDebit.Response> ExecuteAsync(
                List<BulkDebitRequest> body,
                string namespace_
            )
            {
                BulkDebit op = Build(
                    body,
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

        private BulkDebit(BulkDebitBuilder builder,
            List<BulkDebitRequest> body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.BulkDebitResult>
        {

            public ValidationErrorEntity? Error422 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Wallet::BulkDebit";
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
        
        public BulkDebit.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new BulkDebit.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.BulkDebitResult>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)422)
            {
                response.Error422 = JsonSerializer.Deserialize<ValidationErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error422!.TranslateToApiError();
            }

            return response;
        }
    }

}
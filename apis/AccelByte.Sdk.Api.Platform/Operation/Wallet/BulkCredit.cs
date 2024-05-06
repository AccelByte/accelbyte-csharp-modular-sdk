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
    /// bulkCredit
    ///
    /// Credit different users' wallets.
    /// Other detail info:
    /// 
    ///   * Returns : bulk credit result
    /// </summary>
    public class BulkCredit : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkCreditBuilder Builder { get => new BulkCreditBuilder(); }

        public class BulkCreditBuilder
            : OperationBuilder<BulkCreditBuilder>
        {


            public List<Model.BulkCreditRequest>? Body { get; set; }




            internal BulkCreditBuilder() { }

            internal BulkCreditBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public BulkCreditBuilder SetBody(List<Model.BulkCreditRequest> _body)
            {
                Body = _body;
                return this;
            }




            public BulkCredit Build(
                string namespace_
            )
            {
                BulkCredit op = new BulkCredit(this,
                    namespace_
                );

                op.SetBaseFields<BulkCreditBuilder>(this);
                return op;
            }

            public Model.BulkCreditResult? Execute(
                string namespace_
            )
            {
                BulkCredit op = Build(
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
            public async Task<Model.BulkCreditResult?> ExecuteAsync(
                string namespace_
            )
            {
                BulkCredit op = Build(
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

        private BulkCredit(BulkCreditBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public BulkCredit(
            string namespace_,
            List<Model.BulkCreditRequest> body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/wallets/credit";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.BulkCreditResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.BulkCreditResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.BulkCreditResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
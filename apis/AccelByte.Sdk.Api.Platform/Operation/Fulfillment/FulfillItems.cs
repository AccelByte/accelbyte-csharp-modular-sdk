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
    /// fulfillItems
    ///
    ///  [Not Supported Yet In Starter] Fulfill items by transactionId.
    /// Other detail info:
    /// 
    ///   * Returns : fulfillment v2 result
    /// </summary>
    public class FulfillItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static FulfillItemsBuilder Builder { get => new FulfillItemsBuilder(); }

        public class FulfillItemsBuilder
            : OperationBuilder<FulfillItemsBuilder>
        {


            public Model.FulfillmentV2Request? Body { get; set; }




            internal FulfillItemsBuilder() { }

            internal FulfillItemsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public FulfillItemsBuilder SetBody(Model.FulfillmentV2Request _body)
            {
                Body = _body;
                return this;
            }




            public FulfillItems Build(
                string namespace_,
                string transactionId,
                string userId
            )
            {
                FulfillItems op = new FulfillItems(this,
                    namespace_,
                    transactionId,
                    userId
                );

                op.SetBaseFields<FulfillItemsBuilder>(this);
                return op;
            }

            public Model.FulfillmentV2Result? Execute(
                string namespace_,
                string transactionId,
                string userId
            )
            {
                FulfillItems op = Build(
                    namespace_,
                    transactionId,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.FulfillmentV2Result?> ExecuteAsync(
                string namespace_,
                string transactionId,
                string userId
            )
            {
                FulfillItems op = Build(
                    namespace_,
                    transactionId,
                    userId
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

        private FulfillItems(FulfillItemsBuilder builder,
            string namespace_,
            string transactionId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["transactionId"] = transactionId;
            PathParams["userId"] = userId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public FulfillItems(
            string namespace_,
            string transactionId,
            string userId,
            Model.FulfillmentV2Request body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["transactionId"] = transactionId;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/v2/admin/namespaces/{namespace}/users/{userId}/fulfillments/{transactionId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.FulfillmentV2Result? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.FulfillmentV2Result>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FulfillmentV2Result>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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
    /// preCheckFulfillItem
    ///
    /// Retrieve and check fulfillment items based on the provided request.
    /// Other detail info:
    /// 
    ///   * Returns : list of fulfillment items
    /// </summary>
    public class PreCheckFulfillItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PreCheckFulfillItemBuilder Builder { get => new PreCheckFulfillItemBuilder(); }

        public class PreCheckFulfillItemBuilder
            : OperationBuilder<PreCheckFulfillItemBuilder>
        {


            public Model.PreCheckFulfillmentRequest? Body { get; set; }




            internal PreCheckFulfillItemBuilder() { }

            internal PreCheckFulfillItemBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public PreCheckFulfillItemBuilder SetBody(Model.PreCheckFulfillmentRequest _body)
            {
                Body = _body;
                return this;
            }




            public PreCheckFulfillItem Build(
                string namespace_,
                string userId
            )
            {
                PreCheckFulfillItem op = new PreCheckFulfillItem(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<PreCheckFulfillItemBuilder>(this);
                return op;
            }

            public List<Model.FulfillmentItem>? Execute(
                string namespace_,
                string userId
            )
            {
                PreCheckFulfillItem op = Build(
                    namespace_,
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
            public async Task<List<Model.FulfillmentItem>?> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                PreCheckFulfillItem op = Build(
                    namespace_,
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

        private PreCheckFulfillItem(PreCheckFulfillItemBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PreCheckFulfillItem(
            string namespace_,
            string userId,
            Model.PreCheckFulfillmentRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/fulfillment/preCheck";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.FulfillmentItem>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.FulfillmentItem>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.FulfillmentItem>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
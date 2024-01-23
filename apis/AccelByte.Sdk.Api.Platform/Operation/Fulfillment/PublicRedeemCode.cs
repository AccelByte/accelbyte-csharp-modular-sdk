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
    /// publicRedeemCode
    ///
    /// Redeem campaign code, this api have rate limit, default: only allow request once per user in 2 seconds
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:FULFILLMENT", action=1 (CREATED)
    ///   *  Returns : fulfillment result
    /// </summary>
    public class PublicRedeemCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicRedeemCodeBuilder Builder { get => new PublicRedeemCodeBuilder(); }

        public class PublicRedeemCodeBuilder
            : OperationBuilder<PublicRedeemCodeBuilder>
        {


            public Model.FulfillCodeRequest? Body { get; set; }




            internal PublicRedeemCodeBuilder() { }

            internal PublicRedeemCodeBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public PublicRedeemCodeBuilder SetBody(Model.FulfillCodeRequest _body)
            {
                Body = _body;
                return this;
            }




            public PublicRedeemCode Build(
                string namespace_,
                string userId
            )
            {
                PublicRedeemCode op = new PublicRedeemCode(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<PublicRedeemCodeBuilder>(this);
                return op;
            }

            public Model.FulfillmentResult? Execute(
                string namespace_,
                string userId
            )
            {
                PublicRedeemCode op = Build(
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
        }

        private PublicRedeemCode(PublicRedeemCodeBuilder builder,
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

        public PublicRedeemCode(
            string namespace_,
            string userId,
            Model.FulfillCodeRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/fulfillment/code";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.FulfillmentResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.FulfillmentResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FulfillmentResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
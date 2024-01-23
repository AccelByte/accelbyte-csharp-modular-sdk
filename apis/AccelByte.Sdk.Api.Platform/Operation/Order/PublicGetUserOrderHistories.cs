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
    /// publicGetUserOrderHistories
    ///
    /// Get user order histories.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:ORDER", action=2 (READ)
    ///   *  Returns : get order history
    /// </summary>
    public class PublicGetUserOrderHistories : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserOrderHistoriesBuilder Builder { get => new PublicGetUserOrderHistoriesBuilder(); }

        public class PublicGetUserOrderHistoriesBuilder
            : OperationBuilder<PublicGetUserOrderHistoriesBuilder>
        {





            internal PublicGetUserOrderHistoriesBuilder() { }

            internal PublicGetUserOrderHistoriesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetUserOrderHistories Build(
                string namespace_,
                string orderNo,
                string userId
            )
            {
                PublicGetUserOrderHistories op = new PublicGetUserOrderHistories(this,
                    namespace_,
                    orderNo,
                    userId
                );

                op.SetBaseFields<PublicGetUserOrderHistoriesBuilder>(this);
                return op;
            }

            public List<Model.OrderHistoryInfo>? Execute(
                string namespace_,
                string orderNo,
                string userId
            )
            {
                PublicGetUserOrderHistories op = Build(
                    namespace_,
                    orderNo,
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

        private PublicGetUserOrderHistories(PublicGetUserOrderHistoriesBuilder builder,
            string namespace_,
            string orderNo,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["orderNo"] = orderNo;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetUserOrderHistories(
            string namespace_,
            string orderNo,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["orderNo"] = orderNo;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/orders/{orderNo}/history";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.OrderHistoryInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.OrderHistoryInfo>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.OrderHistoryInfo>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
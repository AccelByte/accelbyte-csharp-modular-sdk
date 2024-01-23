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
    /// queryAllUserIAPOrders
    ///
    /// Query all user IAP orders.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:IAP", action=2 (READ)
    ///   *  Returns : list of iap orders
    /// </summary>
    public class QueryAllUserIAPOrders : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryAllUserIAPOrdersBuilder Builder { get => new QueryAllUserIAPOrdersBuilder(); }

        public class QueryAllUserIAPOrdersBuilder
            : OperationBuilder<QueryAllUserIAPOrdersBuilder>
        {





            internal QueryAllUserIAPOrdersBuilder() { }

            internal QueryAllUserIAPOrdersBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public QueryAllUserIAPOrders Build(
                string namespace_,
                string userId
            )
            {
                QueryAllUserIAPOrders op = new QueryAllUserIAPOrders(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<QueryAllUserIAPOrdersBuilder>(this);
                return op;
            }

            public Model.IAPOrderPagingSlicedResult? Execute(
                string namespace_,
                string userId
            )
            {
                QueryAllUserIAPOrders op = Build(
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

        private QueryAllUserIAPOrders(QueryAllUserIAPOrdersBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryAllUserIAPOrders(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/iap/all";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.IAPOrderPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.IAPOrderPagingSlicedResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.IAPOrderPagingSlicedResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
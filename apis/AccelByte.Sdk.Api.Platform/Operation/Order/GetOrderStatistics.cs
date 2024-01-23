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
    /// getOrderStatistics
    ///
    /// Get Order Statistics.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ORDER", action=2 (READ)
    ///   *  Returns : order statistics
    /// </summary>
    public class GetOrderStatistics : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetOrderStatisticsBuilder Builder { get => new GetOrderStatisticsBuilder(); }

        public class GetOrderStatisticsBuilder
            : OperationBuilder<GetOrderStatisticsBuilder>
        {





            internal GetOrderStatisticsBuilder() { }

            internal GetOrderStatisticsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetOrderStatistics Build(
                string namespace_
            )
            {
                GetOrderStatistics op = new GetOrderStatistics(this,
                    namespace_
                );

                op.SetBaseFields<GetOrderStatisticsBuilder>(this);
                return op;
            }

            public Model.OrderStatistics? Execute(
                string namespace_
            )
            {
                GetOrderStatistics op = Build(
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

        private GetOrderStatistics(GetOrderStatisticsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetOrderStatistics(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/orders/stats";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.OrderStatistics? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OrderStatistics>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OrderStatistics>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
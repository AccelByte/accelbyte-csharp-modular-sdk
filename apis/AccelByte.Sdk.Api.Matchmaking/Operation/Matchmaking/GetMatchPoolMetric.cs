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

using AccelByte.Sdk.Api.Matchmaking.Model;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    /// <summary>
    /// GetMatchPoolMetric
    ///
    /// Get metric for a specific match pool
    /// 
    /// Result: queue_time in seconds
    /// </summary>
    public class GetMatchPoolMetric : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetMatchPoolMetricBuilder Builder { get => new GetMatchPoolMetricBuilder(); }

        public class GetMatchPoolMetricBuilder
            : OperationBuilder<GetMatchPoolMetricBuilder>
        {





            internal GetMatchPoolMetricBuilder() { }

            internal GetMatchPoolMetricBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetMatchPoolMetric Build(
                string channelName,
                string namespace_
            )
            {
                GetMatchPoolMetric op = new GetMatchPoolMetric(this,
                    channelName,
                    namespace_
                );

                op.SetBaseFields<GetMatchPoolMetricBuilder>(this);
                return op;
            }

            public Model.ModelsTicketMetricResultRecord? Execute(
                string channelName,
                string namespace_
            )
            {
                GetMatchPoolMetric op = Build(
                    channelName,
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
            public async Task<Model.ModelsTicketMetricResultRecord?> ExecuteAsync(
                string channelName,
                string namespace_
            )
            {
                GetMatchPoolMetric op = Build(
                    channelName,
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

        private GetMatchPoolMetric(GetMatchPoolMetricBuilder builder,
            string channelName,
            string namespace_
        )
        {
            PathParams["channelName"] = channelName;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetMatchPoolMetric(
            string channelName,
            string namespace_
        )
        {
            PathParams["channelName"] = channelName;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/matchmaking/namespaces/{namespace}/channels/{channelName}/metrics";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsTicketMetricResultRecord? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsTicketMetricResultRecord>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsTicketMetricResultRecord>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
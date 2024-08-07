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

using AccelByte.Sdk.Api.Eventlog.Model;

namespace AccelByte.Sdk.Api.Eventlog.Operation
{
    /// <summary>
    /// GetEventByEventTypeAndEventIDHandler
    ///
    /// Required permission `NAMESPACE:{namespace}:EVENT [UPDATE]`and scope `analytics`
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class GetEventByEventTypeAndEventIDHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetEventByEventTypeAndEventIDHandlerBuilder Builder { get => new GetEventByEventTypeAndEventIDHandlerBuilder(); }

        public class GetEventByEventTypeAndEventIDHandlerBuilder
            : OperationBuilder<GetEventByEventTypeAndEventIDHandlerBuilder>
        {

            public long? Offset { get; set; }





            internal GetEventByEventTypeAndEventIDHandlerBuilder() { }

            internal GetEventByEventTypeAndEventIDHandlerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetEventByEventTypeAndEventIDHandlerBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetEventByEventTypeAndEventIDHandler Build(
                double eventId,
                double eventType,
                string namespace_,
                string endDate,
                long pageSize,
                string startDate
            )
            {
                GetEventByEventTypeAndEventIDHandler op = new GetEventByEventTypeAndEventIDHandler(this,
                    eventId,
                    eventType,
                    namespace_,
                    endDate,
                    pageSize,
                    startDate
                );

                op.SetBaseFields<GetEventByEventTypeAndEventIDHandlerBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public Model.ModelsEventResponse? Execute(
                double eventId,
                double eventType,
                string namespace_,
                string endDate,
                long pageSize,
                string startDate
            )
            {
                GetEventByEventTypeAndEventIDHandler op = Build(
                    eventId,
                    eventType,
                    namespace_,
                    endDate,
                    pageSize,
                    startDate
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.ModelsEventResponse?> ExecuteAsync(
                double eventId,
                double eventType,
                string namespace_,
                string endDate,
                long pageSize,
                string startDate
            )
            {
                GetEventByEventTypeAndEventIDHandler op = Build(
                    eventId,
                    eventType,
                    namespace_,
                    endDate,
                    pageSize,
                    startDate
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

        private GetEventByEventTypeAndEventIDHandler(GetEventByEventTypeAndEventIDHandlerBuilder builder,
            double eventId,
            double eventType,
            string namespace_,
            string endDate,
            long pageSize,
            string startDate
        )
        {
            PathParams["eventId"] = Convert.ToString(eventId);
            PathParams["eventType"] = Convert.ToString(eventType);
            PathParams["namespace"] = namespace_;

            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (endDate is not null) QueryParams["endDate"] = endDate;

            QueryParams["pageSize"] = Convert.ToString(pageSize)!;
            if (startDate is not null) QueryParams["startDate"] = startDate;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetEventByEventTypeAndEventIDHandler(
            double eventId,
            double eventType,
            string namespace_,
            long? offset,
            string endDate,
            long pageSize,
            string startDate
        )
        {
            PathParams["eventId"] = Convert.ToString(eventId);
            PathParams["eventType"] = Convert.ToString(eventType);
            PathParams["namespace"] = namespace_;

            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (endDate is not null) QueryParams["endDate"] = endDate;

            QueryParams["pageSize"] = Convert.ToString(pageSize)!;
            if (startDate is not null) QueryParams["startDate"] = startDate;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/event/namespaces/{namespace}/eventType/{eventType}/eventId/{eventId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsEventResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsEventResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsEventResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
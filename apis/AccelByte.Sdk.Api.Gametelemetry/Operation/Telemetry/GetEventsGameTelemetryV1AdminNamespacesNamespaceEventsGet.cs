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

using AccelByte.Sdk.Api.Gametelemetry.Model;

namespace AccelByte.Sdk.Api.Gametelemetry.Operation
{
    /// <summary>
    /// get_events_game_telemetry_v1_admin_namespaces__namespace__events_get
    ///
    /// This endpoint requires valid JWT token and telemetry permission
    /// This endpoint retrieves event list
    /// </summary>
    public class GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGetBuilder Builder { get => new GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGetBuilder(); }

        public class GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGetBuilder
            : OperationBuilder<GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGetBuilder>
        {

            public string? DeviceType { get; set; }

            public string? EndTime { get; set; }

            public string? EventId { get; set; }

            public string? EventName { get; set; }

            public string? EventPayload { get; set; }

            public string? FlightId { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? StartTime { get; set; }

            public string? UserId { get; set; }





            internal GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGetBuilder() { }

            internal GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGetBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGetBuilder SetDeviceType(string _deviceType)
            {
                DeviceType = _deviceType;
                return this;
            }

            public GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGetBuilder SetEndTime(string _endTime)
            {
                EndTime = _endTime;
                return this;
            }

            public GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGetBuilder SetEventId(string _eventId)
            {
                EventId = _eventId;
                return this;
            }

            public GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGetBuilder SetEventName(string _eventName)
            {
                EventName = _eventName;
                return this;
            }

            public GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGetBuilder SetEventPayload(string _eventPayload)
            {
                EventPayload = _eventPayload;
                return this;
            }

            public GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGetBuilder SetFlightId(string _flightId)
            {
                FlightId = _flightId;
                return this;
            }

            public GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGetBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGetBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGetBuilder SetStartTime(string _startTime)
            {
                StartTime = _startTime;
                return this;
            }

            public GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGetBuilder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }





            public GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet Build(
                string namespace_
            )
            {
                GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet op = new GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet(this,
                    namespace_
                );

                op.SetBaseFields<GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGetBuilder>(this);
                return op;
            }

            public GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet.Response Execute(
                string namespace_
            )
            {
                GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet op = Build(
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
            public async Task<GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet.Response> ExecuteAsync(
                string namespace_
            )
            {
                GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet op = Build(
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

        private GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet(GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGetBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.DeviceType is not null) QueryParams["deviceType"] = builder.DeviceType;
            if (builder.EndTime is not null) QueryParams["endTime"] = builder.EndTime;
            if (builder.EventId is not null) QueryParams["eventId"] = builder.EventId;
            if (builder.EventName is not null) QueryParams["eventName"] = builder.EventName;
            if (builder.EventPayload is not null) QueryParams["eventPayload"] = builder.EventPayload;
            if (builder.FlightId is not null) QueryParams["flightId"] = builder.FlightId;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.StartTime is not null) QueryParams["startTime"] = builder.StartTime;
            if (builder.UserId is not null) QueryParams["userId"] = builder.UserId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_COOKIE);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.PagedResponseGetNamespaceEventResponse>
        {

            public BaseErrorResponse? Error400 { get; set; } = null;

            public HTTPValidationError? Error422 { get; set; } = null;


            protected override string GetFullOperationId() => "Gametelemetry::Telemetry::GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet";
        }

        #endregion

        public GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet(
            string namespace_,
            string? deviceType,
            string? endTime,
            string? eventId,
            string? eventName,
            string? eventPayload,
            string? flightId,
            long? limit,
            long? offset,
            string? startTime,
            string? userId
        )
        {
            PathParams["namespace"] = namespace_;

            if (deviceType is not null) QueryParams["deviceType"] = deviceType;
            if (endTime is not null) QueryParams["endTime"] = endTime;
            if (eventId is not null) QueryParams["eventId"] = eventId;
            if (eventName is not null) QueryParams["eventName"] = eventName;
            if (eventPayload is not null) QueryParams["eventPayload"] = eventPayload;
            if (flightId is not null) QueryParams["flightId"] = flightId;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (startTime is not null) QueryParams["startTime"] = startTime;
            if (userId is not null) QueryParams["userId"] = userId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_COOKIE);
        }

        public override string Path => "/game-telemetry/v1/admin/namespaces/{namespace}/events";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.PagedResponseGetNamespaceEventResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<BaseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)422)
            {
                response.Error422 = JsonSerializer.Deserialize<HTTPValidationError>(payload, ResponseJsonOptions);
                response.Error = response.Error422!.TranslateToApiError();
            }

            return response;
        }
    }

}
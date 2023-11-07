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

using AccelByte.Sdk.Api.Eventlog.Model;

namespace AccelByte.Sdk.Api.Eventlog.Operation
{
    /// <summary>
    /// GetEventSpecificUserV2Handler
    ///
    /// Get events from a specific user
    /// </summary>
    public class GetEventSpecificUserV2Handler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetEventSpecificUserV2HandlerBuilder Builder { get => new GetEventSpecificUserV2HandlerBuilder(); }

        public class GetEventSpecificUserV2HandlerBuilder
            : OperationBuilder<GetEventSpecificUserV2HandlerBuilder>
        {

            public string? EndDate { get; set; }

            public string? EventName { get; set; }

            public long? Offset { get; set; }

            public long? PageSize { get; set; }

            public string? StartDate { get; set; }





            internal GetEventSpecificUserV2HandlerBuilder() { }

            internal GetEventSpecificUserV2HandlerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetEventSpecificUserV2HandlerBuilder SetEndDate(string _endDate)
            {
                EndDate = _endDate;
                return this;
            }

            public GetEventSpecificUserV2HandlerBuilder SetEventName(string _eventName)
            {
                EventName = _eventName;
                return this;
            }

            public GetEventSpecificUserV2HandlerBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public GetEventSpecificUserV2HandlerBuilder SetPageSize(long _pageSize)
            {
                PageSize = _pageSize;
                return this;
            }

            public GetEventSpecificUserV2HandlerBuilder SetStartDate(string _startDate)
            {
                StartDate = _startDate;
                return this;
            }





            public GetEventSpecificUserV2Handler Build(
                string namespace_,
                string userId
            )
            {
                GetEventSpecificUserV2Handler op = new GetEventSpecificUserV2Handler(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsEventResponseV2? Execute(
                string namespace_,
                string userId
            )
            {
                GetEventSpecificUserV2Handler op = Build(
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

        private GetEventSpecificUserV2Handler(GetEventSpecificUserV2HandlerBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.EndDate is not null) QueryParams["endDate"] = builder.EndDate;
            if (builder.EventName is not null) QueryParams["eventName"] = builder.EventName;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.PageSize != null) QueryParams["pageSize"] = Convert.ToString(builder.PageSize)!;
            if (builder.StartDate is not null) QueryParams["startDate"] = builder.StartDate;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetEventSpecificUserV2Handler(
            string namespace_,
            string userId,
            string? endDate,
            string? eventName,
            long? offset,
            long? pageSize,
            string? startDate
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (endDate is not null) QueryParams["endDate"] = endDate;
            if (eventName is not null) QueryParams["eventName"] = eventName;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (pageSize != null) QueryParams["pageSize"] = Convert.ToString(pageSize)!;
            if (startDate is not null) QueryParams["startDate"] = startDate;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/event/v2/admin/namespaces/{namespace}/users/{userId}/event";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsEventResponseV2? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsEventResponseV2>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsEventResponseV2>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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
    /// GetEventByUserIDAndEventIDHandler
    ///
    /// Required permission `NAMESPACE:{namespace}:EVENT [UPDATE]` and scope `analytics`
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class GetEventByUserIDAndEventIDHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetEventByUserIDAndEventIDHandlerBuilder Builder { get => new GetEventByUserIDAndEventIDHandlerBuilder(); }

        public class GetEventByUserIDAndEventIDHandlerBuilder
            : OperationBuilder<GetEventByUserIDAndEventIDHandlerBuilder>
        {

            public long? Offset { get; set; }





            internal GetEventByUserIDAndEventIDHandlerBuilder() { }

            internal GetEventByUserIDAndEventIDHandlerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetEventByUserIDAndEventIDHandlerBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetEventByUserIDAndEventIDHandler Build(
                double eventId,
                string namespace_,
                string userId,
                string endDate,
                long pageSize,
                string startDate
            )
            {
                GetEventByUserIDAndEventIDHandler op = new GetEventByUserIDAndEventIDHandler(this,
                    eventId,
                    namespace_,
                    userId,
                    endDate,
                    pageSize,
                    startDate
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public Model.ModelsEventResponse? Execute(
                double eventId,
                string namespace_,
                string userId,
                string endDate,
                long pageSize,
                string startDate
            )
            {
                GetEventByUserIDAndEventIDHandler op = Build(
                    eventId,
                    namespace_,
                    userId,
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
        }

        private GetEventByUserIDAndEventIDHandler(GetEventByUserIDAndEventIDHandlerBuilder builder,
            double eventId,
            string namespace_,
            string userId,
            string endDate,
            long pageSize,
            string startDate
        )
        {
            PathParams["eventId"] = Convert.ToString(eventId);
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (endDate is not null) QueryParams["endDate"] = endDate;
            QueryParams["pageSize"] = Convert.ToString(pageSize)!;
            if (startDate is not null) QueryParams["startDate"] = startDate;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetEventByUserIDAndEventIDHandler(
            double eventId,
            string namespace_,
            string userId,
            long? offset,
            string endDate,
            long pageSize,
            string startDate
        )
        {
            PathParams["eventId"] = Convert.ToString(eventId);
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (endDate is not null) QueryParams["endDate"] = endDate;
            QueryParams["pageSize"] = Convert.ToString(pageSize)!;
            if (startDate is not null) QueryParams["startDate"] = startDate;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/event/namespaces/{namespace}/users/{userId}/eventId/{eventId}";

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
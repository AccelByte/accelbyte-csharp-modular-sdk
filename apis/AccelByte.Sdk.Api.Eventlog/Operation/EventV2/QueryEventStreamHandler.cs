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
    /// QueryEventStreamHandler
    ///
    /// 
    /// 
    /// This endpoint is using POST which is somewhat unfamiliar,
    /// but it's logical that we have to send/post a filter (search term) in order to get the data.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint will not return anything if you give it an empty filters in the request body.
    /// 
    /// 
    /// 
    /// 
    /// Required permission `ADMIN:NAMESPACE:{namespace}:EVENT [READ]` and scope `"+scope+"`
    /// </summary>
    public class QueryEventStreamHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryEventStreamHandlerBuilder Builder { get => new QueryEventStreamHandlerBuilder(); }

        public class QueryEventStreamHandlerBuilder
            : OperationBuilder<QueryEventStreamHandlerBuilder>
        {

            public string? EndDate { get; set; }

            public long? Offset { get; set; }

            public long? PageSize { get; set; }

            public string? StartDate { get; set; }





            internal QueryEventStreamHandlerBuilder() { }

            internal QueryEventStreamHandlerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QueryEventStreamHandlerBuilder SetEndDate(string _endDate)
            {
                EndDate = _endDate;
                return this;
            }

            public QueryEventStreamHandlerBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryEventStreamHandlerBuilder SetPageSize(long _pageSize)
            {
                PageSize = _pageSize;
                return this;
            }

            public QueryEventStreamHandlerBuilder SetStartDate(string _startDate)
            {
                StartDate = _startDate;
                return this;
            }





            public QueryEventStreamHandler Build(
                ModelsGenericQueryPayload body,
                string namespace_
            )
            {
                QueryEventStreamHandler op = new QueryEventStreamHandler(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsEventResponseV2? Execute(
                ModelsGenericQueryPayload body,
                string namespace_
            )
            {
                QueryEventStreamHandler op = Build(
                    body,
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

        private QueryEventStreamHandler(QueryEventStreamHandlerBuilder builder,
            ModelsGenericQueryPayload body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.EndDate is not null) QueryParams["endDate"] = builder.EndDate;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.PageSize != null) QueryParams["pageSize"] = Convert.ToString(builder.PageSize)!;
            if (builder.StartDate is not null) QueryParams["startDate"] = builder.StartDate;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryEventStreamHandler(
            string namespace_,
            string? endDate,
            long? offset,
            long? pageSize,
            string? startDate,
            Model.ModelsGenericQueryPayload body
        )
        {
            PathParams["namespace"] = namespace_;

            if (endDate is not null) QueryParams["endDate"] = endDate;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (pageSize != null) QueryParams["pageSize"] = Convert.ToString(pageSize)!;
            if (startDate is not null) QueryParams["startDate"] = startDate;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/event/v2/admin/namespaces/{namespace}/query";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

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
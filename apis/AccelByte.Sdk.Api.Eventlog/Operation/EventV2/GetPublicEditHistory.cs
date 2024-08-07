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
    /// GetPublicEditHistory
    ///
    /// Available Type:
    /// * email
    /// * password
    /// * displayname
    /// * dateofbirth
    /// * country
    /// * language
    /// </summary>
    public class GetPublicEditHistory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetPublicEditHistoryBuilder Builder { get => new GetPublicEditHistoryBuilder(); }

        public class GetPublicEditHistoryBuilder
            : OperationBuilder<GetPublicEditHistoryBuilder>
        {

            public string? EndDate { get; set; }

            public long? Offset { get; set; }

            public long? PageSize { get; set; }

            public string? StartDate { get; set; }

            public string? Type { get; set; }





            internal GetPublicEditHistoryBuilder() { }

            internal GetPublicEditHistoryBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetPublicEditHistoryBuilder SetEndDate(string _endDate)
            {
                EndDate = _endDate;
                return this;
            }

            public GetPublicEditHistoryBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public GetPublicEditHistoryBuilder SetPageSize(long _pageSize)
            {
                PageSize = _pageSize;
                return this;
            }

            public GetPublicEditHistoryBuilder SetStartDate(string _startDate)
            {
                StartDate = _startDate;
                return this;
            }

            public GetPublicEditHistoryBuilder SetType(string _type)
            {
                Type = _type;
                return this;
            }





            public GetPublicEditHistory Build(
                string namespace_,
                string userId
            )
            {
                GetPublicEditHistory op = new GetPublicEditHistory(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<GetPublicEditHistoryBuilder>(this);
                return op;
            }

            public Model.ModelsEventResponseV2? Execute(
                string namespace_,
                string userId
            )
            {
                GetPublicEditHistory op = Build(
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
            public async Task<Model.ModelsEventResponseV2?> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                GetPublicEditHistory op = Build(
                    namespace_,
                    userId
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

        private GetPublicEditHistory(GetPublicEditHistoryBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.EndDate is not null) QueryParams["endDate"] = builder.EndDate;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.PageSize != null) QueryParams["pageSize"] = Convert.ToString(builder.PageSize)!;
            if (builder.StartDate is not null) QueryParams["startDate"] = builder.StartDate;
            if (builder.Type is not null) QueryParams["type"] = builder.Type;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetPublicEditHistory(
            string namespace_,
            string userId,
            string? endDate,
            long? offset,
            long? pageSize,
            string? startDate,
            string? type
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (endDate is not null) QueryParams["endDate"] = endDate;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (pageSize != null) QueryParams["pageSize"] = Convert.ToString(pageSize)!;
            if (startDate is not null) QueryParams["startDate"] = startDate;
            if (type is not null) QueryParams["type"] = type;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/event/v2/public/namespaces/{namespace}/users/{userId}/edithistory";

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
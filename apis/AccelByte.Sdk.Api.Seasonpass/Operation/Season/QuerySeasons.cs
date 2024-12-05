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

using AccelByte.Sdk.Api.Seasonpass.Model;

namespace AccelByte.Sdk.Api.Seasonpass.Operation
{
    /// <summary>
    /// querySeasons
    ///
    /// This API is used to query seasons, seasons only located in non-publisher namespace.
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : the list of season basic info
    /// </summary>
    public class QuerySeasons : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QuerySeasonsBuilder Builder { get => new QuerySeasonsBuilder(); }

        public class QuerySeasonsBuilder
            : OperationBuilder<QuerySeasonsBuilder>
        {

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public List<QuerySeasonsStatus>? Status { get; set; }





            internal QuerySeasonsBuilder() { }

            internal QuerySeasonsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QuerySeasonsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QuerySeasonsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QuerySeasonsBuilder SetStatus(List<QuerySeasonsStatus> _status)
            {
                Status = _status;
                return this;
            }





            public QuerySeasons Build(
                string namespace_
            )
            {
                QuerySeasons op = new QuerySeasons(this,
                    namespace_
                );

                op.SetBaseFields<QuerySeasonsBuilder>(this);
                return op;
            }

            public QuerySeasons.Response Execute(
                string namespace_
            )
            {
                QuerySeasons op = Build(
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
            public async Task<QuerySeasons.Response> ExecuteAsync(
                string namespace_
            )
            {
                QuerySeasons op = Build(
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

        private QuerySeasons(QuerySeasonsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Status is not null) QueryParams["status"] = builder.Status;



            CollectionFormatMap["status"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ListSeasonInfoPagingSlicedResult>
        {

            public ErrorEntity? Error400 { get; set; } = null;


            protected override string GetFullOperationId() => "Seasonpass::Season::QuerySeasons";
        }

        #endregion

        public QuerySeasons(
            string namespace_,
            int? limit,
            int? offset,
            List<QuerySeasonsStatus>? status
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (status is not null) QueryParams["status"] = status;



            CollectionFormatMap["status"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/seasons";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public QuerySeasons.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new QuerySeasons.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ListSeasonInfoPagingSlicedResult>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }

            return response;
        }
    }

    public class QuerySeasonsStatus : StringEnum<QuerySeasonsStatus>
    {
        public static readonly QuerySeasonsStatus DRAFT
            = new QuerySeasonsStatus("DRAFT");

        public static readonly QuerySeasonsStatus PUBLISHED
            = new QuerySeasonsStatus("PUBLISHED");

        public static readonly QuerySeasonsStatus RETIRED
            = new QuerySeasonsStatus("RETIRED");


        public static implicit operator QuerySeasonsStatus(string value)
        {
            return NewValue(value);
        }

        public QuerySeasonsStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

}
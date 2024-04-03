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

using AccelByte.Sdk.Api.Dsmc.Model;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// ListImagesClient
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [READ]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint lists all of dedicated servers images.
    /// 
    /// Parameter Offset and Count is Required
    /// </summary>
    public class ListImagesClient : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListImagesClientBuilder Builder { get => new ListImagesClientBuilder(); }

        public class ListImagesClientBuilder
            : OperationBuilder<ListImagesClientBuilder>
        {

            public long? Count { get; set; }

            public long? Offset { get; set; }

            public string? Q { get; set; }

            public ListImagesClientSortBy? SortBy { get; set; }

            public ListImagesClientSortDirection? SortDirection { get; set; }





            internal ListImagesClientBuilder() { }

            internal ListImagesClientBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public ListImagesClientBuilder SetCount(long _count)
            {
                Count = _count;
                return this;
            }

            public ListImagesClientBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public ListImagesClientBuilder SetQ(string _q)
            {
                Q = _q;
                return this;
            }

            public ListImagesClientBuilder SetSortBy(ListImagesClientSortBy _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public ListImagesClientBuilder SetSortDirection(ListImagesClientSortDirection _sortDirection)
            {
                SortDirection = _sortDirection;
                return this;
            }





            public ListImagesClient Build(
                string namespace_
            )
            {
                ListImagesClient op = new ListImagesClient(this,
                    namespace_
                );

                op.SetBaseFields<ListImagesClientBuilder>(this);
                return op;
            }

            public Model.ModelsListImageResponse? Execute(
                string namespace_
            )
            {
                ListImagesClient op = Build(
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
            public async Task<Model.ModelsListImageResponse?> ExecuteAsync(
                string namespace_
            )
            {
                ListImagesClient op = Build(
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

        private ListImagesClient(ListImagesClientBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Count != null) QueryParams["count"] = Convert.ToString(builder.Count)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Q is not null) QueryParams["q"] = builder.Q;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy.Value;
            if (builder.SortDirection is not null) QueryParams["sortDirection"] = builder.SortDirection.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ListImagesClient(
            string namespace_,
            long? count,
            long? offset,
            string? q,
            ListImagesClientSortBy? sortBy,
            ListImagesClientSortDirection? sortDirection
        )
        {
            PathParams["namespace"] = namespace_;

            if (count != null) QueryParams["count"] = Convert.ToString(count)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (q is not null) QueryParams["q"] = q;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy.Value;
            if (sortDirection is not null) QueryParams["sortDirection"] = sortDirection.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/namespaces/{namespace}/images";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsListImageResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsListImageResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListImageResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class ListImagesClientSortBy : StringEnum<ListImagesClientSortBy>
    {
        public static readonly ListImagesClientSortBy CreatedAt
            = new ListImagesClientSortBy("createdAt");

        public static readonly ListImagesClientSortBy UpdatedAt
            = new ListImagesClientSortBy("updatedAt");

        public static readonly ListImagesClientSortBy Version
            = new ListImagesClientSortBy("version");


        public static implicit operator ListImagesClientSortBy(string value)
        {
            return NewValue(value);
        }

        public ListImagesClientSortBy(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class ListImagesClientSortDirection : StringEnum<ListImagesClientSortDirection>
    {
        public static readonly ListImagesClientSortDirection Asc
            = new ListImagesClientSortDirection("asc");

        public static readonly ListImagesClientSortDirection Desc
            = new ListImagesClientSortDirection("desc");


        public static implicit operator ListImagesClientSortDirection(string value)
        {
            return NewValue(value);
        }

        public ListImagesClientSortDirection(string enumValue)
            : base(enumValue)
        {

        }
    }

}
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

using AccelByte.Sdk.Api.Social.Model;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// getGlobalStatItems
    ///
    /// List global statItems by pagination.
    /// Other detail info:
    ///         *  Required permission : resource="ADMIN:NAMESPACE:{namespace}:STATITEM", action=2 (READ)
    ///         *  Returns : stat items
    /// </summary>
    public class GetGlobalStatItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetGlobalStatItemsBuilder Builder { get => new GetGlobalStatItemsBuilder(); }

        public class GetGlobalStatItemsBuilder
            : OperationBuilder<GetGlobalStatItemsBuilder>
        {

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public string? StatCodes { get; set; }





            internal GetGlobalStatItemsBuilder() { }

            internal GetGlobalStatItemsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetGlobalStatItemsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetGlobalStatItemsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public GetGlobalStatItemsBuilder SetStatCodes(string _statCodes)
            {
                StatCodes = _statCodes;
                return this;
            }





            public GetGlobalStatItems Build(
                string namespace_
            )
            {
                GetGlobalStatItems op = new GetGlobalStatItems(this,
                    namespace_
                );

                op.SetBaseFields<GetGlobalStatItemsBuilder>(this);
                return op;
            }

            public Model.GlobalStatItemPagingSlicedResult? Execute(
                string namespace_
            )
            {
                GetGlobalStatItems op = Build(
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

        private GetGlobalStatItems(GetGlobalStatItemsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.StatCodes is not null) QueryParams["statCodes"] = builder.StatCodes;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetGlobalStatItems(
            string namespace_,
            int? limit,
            int? offset,
            string? statCodes
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (statCodes is not null) QueryParams["statCodes"] = statCodes;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/globalstatitems";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.GlobalStatItemPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.GlobalStatItemPagingSlicedResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.GlobalStatItemPagingSlicedResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
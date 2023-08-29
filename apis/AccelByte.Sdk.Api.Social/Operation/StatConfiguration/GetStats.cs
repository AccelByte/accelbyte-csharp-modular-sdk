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
    /// getStats
    ///
    /// List stats by pagination.
    /// Other detail info:
    ///         *  Required permission : resource="ADMIN:NAMESPACE:{namespace}:STAT", action=2 (READ)
    ///         *  Returns : stats
    /// </summary>
    public class GetStats : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetStatsBuilder Builder { get => new GetStatsBuilder(); }

        public class GetStatsBuilder
            : OperationBuilder<GetStatsBuilder>
        {

            public string? CycleIds { get; set; }

            public bool? IsGlobal { get; set; }

            public bool? IsPublic { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }





            internal GetStatsBuilder() { }

            internal GetStatsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetStatsBuilder SetCycleIds(string _cycleIds)
            {
                CycleIds = _cycleIds;
                return this;
            }

            public GetStatsBuilder SetIsGlobal(bool _isGlobal)
            {
                IsGlobal = _isGlobal;
                return this;
            }

            public GetStatsBuilder SetIsPublic(bool _isPublic)
            {
                IsPublic = _isPublic;
                return this;
            }

            public GetStatsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetStatsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetStats Build(
                string namespace_
            )
            {
                GetStats op = new GetStats(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.StatPagingSlicedResult? Execute(
                string namespace_
            )
            {
                GetStats op = Build(
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

        private GetStats(GetStatsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.CycleIds is not null) QueryParams["cycleIds"] = builder.CycleIds;
            if (builder.IsGlobal != null) QueryParams["isGlobal"] = Convert.ToString(builder.IsGlobal)!;
            if (builder.IsPublic != null) QueryParams["isPublic"] = Convert.ToString(builder.IsPublic)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetStats(
            string namespace_,            
            string? cycleIds,            
            bool? isGlobal,            
            bool? isPublic,            
            int? limit,            
            int? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (cycleIds is not null) QueryParams["cycleIds"] = cycleIds;
            if (isGlobal != null) QueryParams["isGlobal"] = Convert.ToString(isGlobal)!;
            if (isPublic != null) QueryParams["isPublic"] = Convert.ToString(isPublic)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/stats";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.StatPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.StatPagingSlicedResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StatPagingSlicedResult>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
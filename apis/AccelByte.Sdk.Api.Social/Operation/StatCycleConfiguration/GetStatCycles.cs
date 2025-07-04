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

using AccelByte.Sdk.Api.Social.Model;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// getStatCycles
    ///
    /// List stat cycles by pagination.
    /// Other detail info:
    ///         *  Returns : stat cycles
    /// </summary>
    public class GetStatCycles : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetStatCyclesBuilder Builder { get => new GetStatCyclesBuilder(); }

        public class GetStatCyclesBuilder
            : OperationBuilder<GetStatCyclesBuilder>
        {

            public GetStatCyclesCycleType? CycleType { get; set; }

            public int? Limit { get; set; }

            public string? Name { get; set; }

            public int? Offset { get; set; }

            public string? SortBy { get; set; }

            public GetStatCyclesStatus? Status { get; set; }





            internal GetStatCyclesBuilder() { }

            internal GetStatCyclesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetStatCyclesBuilder SetCycleType(GetStatCyclesCycleType _cycleType)
            {
                CycleType = _cycleType;
                return this;
            }

            public GetStatCyclesBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetStatCyclesBuilder SetName(string _name)
            {
                Name = _name;
                return this;
            }

            public GetStatCyclesBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public GetStatCyclesBuilder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public GetStatCyclesBuilder SetStatus(GetStatCyclesStatus _status)
            {
                Status = _status;
                return this;
            }





            public GetStatCycles Build(
                string namespace_
            )
            {
                GetStatCycles op = new GetStatCycles(this,
                    namespace_                    
                );

                op.SetBaseFields<GetStatCyclesBuilder>(this);
                return op;
            }

            public GetStatCycles.Response Execute(
                string namespace_
            )
            {
                GetStatCycles op = Build(
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
            public async Task<GetStatCycles.Response> ExecuteAsync(
                string namespace_
            )
            {
                GetStatCycles op = Build(
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

        private GetStatCycles(GetStatCyclesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.CycleType is not null) QueryParams["cycleType"] = builder.CycleType.Value;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Name is not null) QueryParams["name"] = builder.Name;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;
            if (builder.Status is not null) QueryParams["status"] = builder.Status.Value;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.StatCyclePagingSlicedResult>
        {

            public ErrorEntity? Error401 { get; set; } = null;

            public ErrorEntity? Error403 { get; set; } = null;

            public ErrorEntity? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Social::StatCycleConfiguration::GetStatCycles";
        }

        #endregion

        public GetStatCycles(
            string namespace_,            
            GetStatCyclesCycleType? cycleType,            
            int? limit,            
            string? name,            
            int? offset,            
            string? sortBy,            
            GetStatCyclesStatus? status            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (cycleType is not null) QueryParams["cycleType"] = cycleType.Value;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (name is not null) QueryParams["name"] = name;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;
            if (status is not null) QueryParams["status"] = status.Value;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/statCycles";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public GetStatCycles.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetStatCycles.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.StatCyclePagingSlicedResult>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

    public class GetStatCyclesCycleType : StringEnum<GetStatCyclesCycleType>
    {
        public static readonly GetStatCyclesCycleType ANNUALLY
            = new GetStatCyclesCycleType("ANNUALLY");

        public static readonly GetStatCyclesCycleType DAILY
            = new GetStatCyclesCycleType("DAILY");

        public static readonly GetStatCyclesCycleType MONTHLY
            = new GetStatCyclesCycleType("MONTHLY");

        public static readonly GetStatCyclesCycleType SEASONAL
            = new GetStatCyclesCycleType("SEASONAL");

        public static readonly GetStatCyclesCycleType WEEKLY
            = new GetStatCyclesCycleType("WEEKLY");


        public static implicit operator GetStatCyclesCycleType(string value)
        {
            return NewValue(value);
        }

        public GetStatCyclesCycleType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class GetStatCyclesStatus : StringEnum<GetStatCyclesStatus>
    {
        public static readonly GetStatCyclesStatus ACTIVE
            = new GetStatCyclesStatus("ACTIVE");

        public static readonly GetStatCyclesStatus INIT
            = new GetStatCyclesStatus("INIT");

        public static readonly GetStatCyclesStatus STOPPED
            = new GetStatCyclesStatus("STOPPED");


        public static implicit operator GetStatCyclesStatus(string value)
        {
            return NewValue(value);
        }

        public GetStatCyclesStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

}
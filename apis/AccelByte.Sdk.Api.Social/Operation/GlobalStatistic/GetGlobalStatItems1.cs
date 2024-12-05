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
    /// getGlobalStatItems_1
    ///
    /// List global statItems by pagination.
    /// Other detail info:
    ///             *  Returns : stat items
    /// </summary>
    public class GetGlobalStatItems1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetGlobalStatItems1Builder Builder { get => new GetGlobalStatItems1Builder(); }

        public class GetGlobalStatItems1Builder
            : OperationBuilder<GetGlobalStatItems1Builder>
        {

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public string? StatCodes { get; set; }





            internal GetGlobalStatItems1Builder() { }

            internal GetGlobalStatItems1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetGlobalStatItems1Builder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetGlobalStatItems1Builder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public GetGlobalStatItems1Builder SetStatCodes(string _statCodes)
            {
                StatCodes = _statCodes;
                return this;
            }





            public GetGlobalStatItems1 Build(
                string namespace_
            )
            {
                GetGlobalStatItems1 op = new GetGlobalStatItems1(this,
                    namespace_
                );

                op.SetBaseFields<GetGlobalStatItems1Builder>(this);
                return op;
            }

            public GetGlobalStatItems1.Response Execute(
                string namespace_
            )
            {
                GetGlobalStatItems1 op = Build(
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
            public async Task<GetGlobalStatItems1.Response> ExecuteAsync(
                string namespace_
            )
            {
                GetGlobalStatItems1 op = Build(
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

        private GetGlobalStatItems1(GetGlobalStatItems1Builder builder,
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

        #region Response Part        
        public class Response : ApiResponse<Model.GlobalStatItemPagingSlicedResult>
        {

            public ErrorEntity? Error401 { get; set; } = null;

            public ErrorEntity? Error403 { get; set; } = null;

            public ErrorEntity? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Social::GlobalStatistic::GetGlobalStatItems1";
        }

        #endregion

        public GetGlobalStatItems1(
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

        public override string Path => "/social/v1/public/namespaces/{namespace}/globalstatitems";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public GetGlobalStatItems1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetGlobalStatItems1.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.GlobalStatItemPagingSlicedResult>(payload, ResponseJsonOptions);
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

}
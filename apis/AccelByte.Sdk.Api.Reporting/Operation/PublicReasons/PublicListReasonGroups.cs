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

using AccelByte.Sdk.Api.Reporting.Model;

namespace AccelByte.Sdk.Api.Reporting.Operation
{
    /// <summary>
    /// publicListReasonGroups
    ///
    /// Return list of reason groups ID and title under given namespace.
    /// </summary>
    public class PublicListReasonGroups : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicListReasonGroupsBuilder Builder { get => new PublicListReasonGroupsBuilder(); }

        public class PublicListReasonGroupsBuilder
            : OperationBuilder<PublicListReasonGroupsBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal PublicListReasonGroupsBuilder() { }

            internal PublicListReasonGroupsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicListReasonGroupsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicListReasonGroupsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public PublicListReasonGroups Build(
                string namespace_
            )
            {
                PublicListReasonGroups op = new PublicListReasonGroups(this,
                    namespace_
                );

                op.SetBaseFields<PublicListReasonGroupsBuilder>(this);
                return op;
            }

            public PublicListReasonGroups.Response Execute(
                string namespace_
            )
            {
                PublicListReasonGroups op = Build(
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
            public async Task<PublicListReasonGroups.Response> ExecuteAsync(
                string namespace_
            )
            {
                PublicListReasonGroups op = Build(
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

        private PublicListReasonGroups(PublicListReasonGroupsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.RestapiReasonGroupListResponse>
        {

            public RestapiErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Reporting::PublicReasons::PublicListReasonGroups";
        }

        #endregion

        public PublicListReasonGroups(
            string namespace_,
            long? limit,
            long? offset
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/public/namespaces/{namespace}/reasonGroups";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public PublicListReasonGroups.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicListReasonGroups.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.RestapiReasonGroupListResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<RestapiErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
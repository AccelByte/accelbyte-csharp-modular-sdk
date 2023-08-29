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

using AccelByte.Sdk.Api.Reporting.Model;

namespace AccelByte.Sdk.Api.Reporting.Operation
{
    /// <summary>
    /// adminGetReasons
    /// </summary>
    public class AdminGetReasons : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetReasonsBuilder Builder { get => new AdminGetReasonsBuilder(); }

        public class AdminGetReasonsBuilder
            : OperationBuilder<AdminGetReasonsBuilder>
        {

            public string? Group { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? Title { get; set; }





            internal AdminGetReasonsBuilder() { }

            internal AdminGetReasonsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminGetReasonsBuilder SetGroup(string _group)
            {
                Group = _group;
                return this;
            }

            public AdminGetReasonsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminGetReasonsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminGetReasonsBuilder SetTitle(string _title)
            {
                Title = _title;
                return this;
            }





            public AdminGetReasons Build(
                string namespace_
            )
            {
                AdminGetReasons op = new AdminGetReasons(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.RestapiAdminReasonListResponse? Execute(
                string namespace_
            )
            {
                AdminGetReasons op = Build(
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

        private AdminGetReasons(AdminGetReasonsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Group is not null) QueryParams["group"] = builder.Group;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Title is not null) QueryParams["title"] = builder.Title;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetReasons(
            string namespace_,
            string? group,
            long? limit,
            long? offset,
            string? title
        )
        {
            PathParams["namespace"] = namespace_;

            if (group is not null) QueryParams["group"] = group;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (title is not null) QueryParams["title"] = title;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/admin/namespaces/{namespace}/reasons";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.RestapiAdminReasonListResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.RestapiAdminReasonListResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RestapiAdminReasonListResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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

using AccelByte.Sdk.Api.Gdpr.Model;

namespace AccelByte.Sdk.Api.Gdpr.Operation
{
    /// <summary>
    /// AdminGetListPersonalDataRequest
    ///
    /// 
    /// 
    /// Required permission `ADMIN:NAMESPACE:{namespace}:INFORMATION:USER [READ]` and scope `account`
    /// </summary>
    public class AdminGetListPersonalDataRequest : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetListPersonalDataRequestBuilder Builder { get => new AdminGetListPersonalDataRequestBuilder(); }

        public class AdminGetListPersonalDataRequestBuilder
            : OperationBuilder<AdminGetListPersonalDataRequestBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? RequestDate { get; set; }





            internal AdminGetListPersonalDataRequestBuilder() { }

            internal AdminGetListPersonalDataRequestBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminGetListPersonalDataRequestBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminGetListPersonalDataRequestBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminGetListPersonalDataRequestBuilder SetRequestDate(string _requestDate)
            {
                RequestDate = _requestDate;
                return this;
            }





            public AdminGetListPersonalDataRequest Build(
                string namespace_
            )
            {
                AdminGetListPersonalDataRequest op = new AdminGetListPersonalDataRequest(this,
                    namespace_
                );

                op.SetBaseFields<AdminGetListPersonalDataRequestBuilder>(this);
                return op;
            }

            public Model.ModelsListPersonalDataResponse? Execute(
                string namespace_
            )
            {
                AdminGetListPersonalDataRequest op = Build(
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
            public async Task<Model.ModelsListPersonalDataResponse?> ExecuteAsync(
                string namespace_
            )
            {
                AdminGetListPersonalDataRequest op = Build(
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

        private AdminGetListPersonalDataRequest(AdminGetListPersonalDataRequestBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.RequestDate is not null) QueryParams["requestDate"] = builder.RequestDate;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetListPersonalDataRequest(
            string namespace_,
            long? limit,
            long? offset,
            string? requestDate
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (requestDate is not null) QueryParams["requestDate"] = requestDate;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/admin/namespaces/{namespace}/requests";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsListPersonalDataResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsListPersonalDataResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListPersonalDataResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
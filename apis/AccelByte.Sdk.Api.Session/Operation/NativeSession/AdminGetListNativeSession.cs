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

using AccelByte.Sdk.Api.Session.Model;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// adminGetListNativeSession
    ///
    /// List of native sessions.
    /// </summary>
    public class AdminGetListNativeSession : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetListNativeSessionBuilder Builder { get => new AdminGetListNativeSessionBuilder(); }

        public class AdminGetListNativeSessionBuilder
            : OperationBuilder<AdminGetListNativeSessionBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? Order { get; set; }





            internal AdminGetListNativeSessionBuilder() { }

            internal AdminGetListNativeSessionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminGetListNativeSessionBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminGetListNativeSessionBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminGetListNativeSessionBuilder SetOrder(string _order)
            {
                Order = _order;
                return this;
            }





            public AdminGetListNativeSession Build(
                string namespace_
            )
            {
                AdminGetListNativeSession op = new AdminGetListNativeSession(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ApimodelsNativeSessionPagingResponse? Execute(
                string namespace_
            )
            {
                AdminGetListNativeSession op = Build(
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

        private AdminGetListNativeSession(AdminGetListNativeSessionBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Order is not null) QueryParams["order"] = builder.Order;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetListNativeSession(
            string namespace_,
            long? limit,
            long? offset,
            string? order
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (order is not null) QueryParams["order"] = order;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/namespaces/{namespace}/native-sessions";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApimodelsNativeSessionPagingResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsNativeSessionPagingResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsNativeSessionPagingResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
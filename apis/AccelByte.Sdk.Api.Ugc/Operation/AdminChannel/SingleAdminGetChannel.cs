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

using AccelByte.Sdk.Api.Ugc.Model;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// SingleAdminGetChannel
    ///
    /// Get official channel paginated
    /// </summary>
    public class SingleAdminGetChannel : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SingleAdminGetChannelBuilder Builder { get => new SingleAdminGetChannelBuilder(); }

        public class SingleAdminGetChannelBuilder
            : OperationBuilder<SingleAdminGetChannelBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal SingleAdminGetChannelBuilder() { }

            internal SingleAdminGetChannelBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public SingleAdminGetChannelBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public SingleAdminGetChannelBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public SingleAdminGetChannel Build(
                string namespace_
            )
            {
                SingleAdminGetChannel op = new SingleAdminGetChannel(this,
                    namespace_
                );

                op.SetBaseFields<SingleAdminGetChannelBuilder>(this);
                return op;
            }

            public Model.ModelsPaginatedGetChannelResponse? Execute(
                string namespace_
            )
            {
                SingleAdminGetChannel op = Build(
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
            public async Task<Model.ModelsPaginatedGetChannelResponse?> ExecuteAsync(
                string namespace_
            )
            {
                SingleAdminGetChannel op = Build(
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

        private SingleAdminGetChannel(SingleAdminGetChannelBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SingleAdminGetChannel(
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

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/channels";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsPaginatedGetChannelResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedGetChannelResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedGetChannelResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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
    /// ListSession
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:SESSION [READ]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint lists all of sessions in a namespace managed by this service.
    /// 
    /// Parameter Offset and Count is Required
    /// </summary>
    public class ListSession : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListSessionBuilder Builder { get => new ListSessionBuilder(); }

        public class ListSessionBuilder
            : OperationBuilder<ListSessionBuilder>
        {

            public string? Region { get; set; }

            public bool? WithServer { get; set; }





            internal ListSessionBuilder() { }

            internal ListSessionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public ListSessionBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }

            public ListSessionBuilder SetWithServer(bool _withServer)
            {
                WithServer = _withServer;
                return this;
            }





            public ListSession Build(
                string namespace_,
                long count,
                long offset
            )
            {
                ListSession op = new ListSession(this,
                    namespace_,
                    count,
                    offset
                );

                op.SetBaseFields<ListSessionBuilder>(this);
                return op;
            }

            public Model.ModelsListSessionResponse? Execute(
                string namespace_,
                long count,
                long offset
            )
            {
                ListSession op = Build(
                    namespace_,
                    count,
                    offset
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.ModelsListSessionResponse?> ExecuteAsync(
                string namespace_,
                long count,
                long offset
            )
            {
                ListSession op = Build(
                    namespace_,
                    count,
                    offset
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

        private ListSession(ListSessionBuilder builder,
            string namespace_,
            long count,
            long offset
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Region is not null) QueryParams["region"] = builder.Region;
            if (builder.WithServer != null) QueryParams["withServer"] = Convert.ToString(builder.WithServer)!;

            QueryParams["count"] = Convert.ToString(count)!;

            QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ListSession(
            string namespace_,
            string? region,
            bool? withServer,
            long count,
            long offset
        )
        {
            PathParams["namespace"] = namespace_;

            if (region is not null) QueryParams["region"] = region;
            if (withServer != null) QueryParams["withServer"] = Convert.ToString(withServer)!;

            QueryParams["count"] = Convert.ToString(count)!;

            QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/sessions";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsListSessionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsListSessionResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListSessionResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
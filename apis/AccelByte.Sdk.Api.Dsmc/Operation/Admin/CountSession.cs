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
    /// CountSession
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:SESSION [READ]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint count all of sessions in a namespace managed by this service.
    /// </summary>
    public class CountSession : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CountSessionBuilder Builder { get => new CountSessionBuilder(); }

        public class CountSessionBuilder
            : OperationBuilder<CountSessionBuilder>
        {

            public string? Region { get; set; }





            internal CountSessionBuilder() { }

            internal CountSessionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public CountSessionBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }





            public CountSession Build(
                string namespace_
            )
            {
                CountSession op = new CountSession(this,
                    namespace_
                );

                op.SetBaseFields<CountSessionBuilder>(this);
                return op;
            }

            public Model.ModelsCountSessionResponse? Execute(
                string namespace_
            )
            {
                CountSession op = Build(
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
            public async Task<Model.ModelsCountSessionResponse?> ExecuteAsync(
                string namespace_
            )
            {
                CountSession op = Build(
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

        private CountSession(CountSessionBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Region is not null) QueryParams["region"] = builder.Region;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CountSession(
            string namespace_,
            string? region
        )
        {
            PathParams["namespace"] = namespace_;

            if (region is not null) QueryParams["region"] = region;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/sessions/count";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsCountSessionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsCountSessionResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsCountSessionResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
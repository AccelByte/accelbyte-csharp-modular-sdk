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

using AccelByte.Sdk.Api.Dsmc.Model;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// CountServer
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:SERVER [READ]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint counts all of dedicated servers in a namespace managed by this service.
    /// </summary>
    public class CountServer : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CountServerBuilder Builder { get => new CountServerBuilder(); }

        public class CountServerBuilder
            : OperationBuilder<CountServerBuilder>
        {





            internal CountServerBuilder() { }

            internal CountServerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CountServer Build(
                string namespace_
            )
            {
                CountServer op = new CountServer(this,
                    namespace_
                );

                op.SetBaseFields<CountServerBuilder>(this);
                return op;
            }

            public Model.ModelsCountServerResponse? Execute(
                string namespace_
            )
            {
                CountServer op = Build(
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

        private CountServer(CountServerBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CountServer(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/servers/count";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsCountServerResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsCountServerResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsCountServerResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
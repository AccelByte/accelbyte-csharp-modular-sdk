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
    /// getWorkerConfig
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:WORKER:CONFIG [READ]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint retrieves a worker configuration to control the worker in the DSMC.
    /// </summary>
    public class GetWorkerConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetWorkerConfigBuilder Builder { get => new GetWorkerConfigBuilder(); }

        public class GetWorkerConfigBuilder
            : OperationBuilder<GetWorkerConfigBuilder>
        {





            internal GetWorkerConfigBuilder() { }

            internal GetWorkerConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetWorkerConfig Build(
                string namespace_
            )
            {
                GetWorkerConfig op = new GetWorkerConfig(this,
                    namespace_
                );

                op.SetBaseFields<GetWorkerConfigBuilder>(this);
                return op;
            }

            public Model.ModelsWorkerConfig? Execute(
                string namespace_
            )
            {
                GetWorkerConfig op = Build(
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
            public async Task<Model.ModelsWorkerConfig?> ExecuteAsync(
                string namespace_
            )
            {
                GetWorkerConfig op = Build(
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

        private GetWorkerConfig(GetWorkerConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetWorkerConfig(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespace/{namespace}/workers";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsWorkerConfig? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsWorkerConfig>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsWorkerConfig>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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
    /// GetAllPodConfig
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [READ]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint get a all pod configs in a namespace
    /// 
    /// Parameter Offset and Count is Required
    /// </summary>
    public class GetAllPodConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetAllPodConfigBuilder Builder { get => new GetAllPodConfigBuilder(); }

        public class GetAllPodConfigBuilder
            : OperationBuilder<GetAllPodConfigBuilder>
        {





            internal GetAllPodConfigBuilder() { }

            internal GetAllPodConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetAllPodConfig Build(
                string namespace_,
                long count,
                long offset
            )
            {
                GetAllPodConfig op = new GetAllPodConfig(this,
                    namespace_,
                    count,
                    offset
                );

                op.SetBaseFields<GetAllPodConfigBuilder>(this);
                return op;
            }

            public Model.ModelsListPodConfigResponse? Execute(
                string namespace_,
                long count,
                long offset
            )
            {
                GetAllPodConfig op = Build(
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
            public async Task<Model.ModelsListPodConfigResponse?> ExecuteAsync(
                string namespace_,
                long count,
                long offset
            )
            {
                GetAllPodConfig op = Build(
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

        private GetAllPodConfig(GetAllPodConfigBuilder builder,
            string namespace_,
            long count,
            long offset
        )
        {
            PathParams["namespace"] = namespace_;

            QueryParams["count"] = Convert.ToString(count)!;
            QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetAllPodConfig(
            string namespace_,
            long count,
            long offset
        )
        {
            PathParams["namespace"] = namespace_;

            QueryParams["count"] = Convert.ToString(count)!;
            QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/configs/pods";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsListPodConfigResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsListPodConfigResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListPodConfigResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
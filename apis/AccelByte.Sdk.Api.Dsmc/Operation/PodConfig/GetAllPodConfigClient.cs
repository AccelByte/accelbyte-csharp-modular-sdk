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
    /// GetAllPodConfigClient
    ///
    /// Required permission: NAMESPACE:{namespace}:DSM:CONFIG [READ]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint get a all pod configs in a namespace
    /// 
    /// Parameter Offset and Count is Required
    /// </summary>
    public class GetAllPodConfigClient : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetAllPodConfigClientBuilder Builder { get => new GetAllPodConfigClientBuilder(); }

        public class GetAllPodConfigClientBuilder
            : OperationBuilder<GetAllPodConfigClientBuilder>
        {





            internal GetAllPodConfigClientBuilder() { }

            internal GetAllPodConfigClientBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetAllPodConfigClient Build(
                string namespace_,
                long count,
                long offset
            )
            {
                GetAllPodConfigClient op = new GetAllPodConfigClient(this,
                    namespace_,
                    count,
                    offset
                );

                op.SetBaseFields<GetAllPodConfigClientBuilder>(this);
                return op;
            }

            public Model.ModelsListPodConfigResponse? Execute(
                string namespace_,
                long count,
                long offset
            )
            {
                GetAllPodConfigClient op = Build(
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
                GetAllPodConfigClient op = Build(
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

        private GetAllPodConfigClient(GetAllPodConfigClientBuilder builder,
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

        public GetAllPodConfigClient(
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

        public override string Path => "/dsmcontroller/namespaces/{namespace}/configs/pods";

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
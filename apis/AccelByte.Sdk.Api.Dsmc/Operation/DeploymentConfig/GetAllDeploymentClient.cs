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
    /// GetAllDeploymentClient
    ///
    /// Required permission: NAMESPACE:{namespace}:DSM:CONFIG [READ]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint get a all deployments in a namespace
    /// 
    /// Parameter Offset and Count is Required
    /// </summary>
    public class GetAllDeploymentClient : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetAllDeploymentClientBuilder Builder { get => new GetAllDeploymentClientBuilder(); }

        public class GetAllDeploymentClientBuilder
            : OperationBuilder<GetAllDeploymentClientBuilder>
        {

            public string? Name { get; set; }





            internal GetAllDeploymentClientBuilder() { }

            internal GetAllDeploymentClientBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetAllDeploymentClientBuilder SetName(string _name)
            {
                Name = _name;
                return this;
            }





            public GetAllDeploymentClient Build(
                string namespace_,
                long count,
                long offset
            )
            {
                GetAllDeploymentClient op = new GetAllDeploymentClient(this,
                    namespace_,
                    count,
                    offset
                );

                op.SetBaseFields<GetAllDeploymentClientBuilder>(this);
                return op;
            }

            public Model.ModelsListDeploymentResponse? Execute(
                string namespace_,
                long count,
                long offset
            )
            {
                GetAllDeploymentClient op = Build(
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
            public async Task<Model.ModelsListDeploymentResponse?> ExecuteAsync(
                string namespace_,
                long count,
                long offset
            )
            {
                GetAllDeploymentClient op = Build(
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

        private GetAllDeploymentClient(GetAllDeploymentClientBuilder builder,
            string namespace_,
            long count,
            long offset
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Name is not null) QueryParams["name"] = builder.Name;

            QueryParams["count"] = Convert.ToString(count)!;

            QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetAllDeploymentClient(
            string namespace_,
            string? name,
            long count,
            long offset
        )
        {
            PathParams["namespace"] = namespace_;

            if (name is not null) QueryParams["name"] = name;

            QueryParams["count"] = Convert.ToString(count)!;

            QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/namespaces/{namespace}/configs/deployments";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsListDeploymentResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsListDeploymentResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListDeploymentResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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
    /// GetAllDeployment
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [READ]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint get a all deployments in a namespace
    /// 
    /// Parameter Offset and Count is Required
    /// </summary>
    public class GetAllDeployment : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetAllDeploymentBuilder Builder { get => new GetAllDeploymentBuilder(); }

        public class GetAllDeploymentBuilder
            : OperationBuilder<GetAllDeploymentBuilder>
        {

            public string? Name { get; set; }





            internal GetAllDeploymentBuilder() { }

            internal GetAllDeploymentBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetAllDeploymentBuilder SetName(string _name)
            {
                Name = _name;
                return this;
            }





            public GetAllDeployment Build(
                string namespace_,
                long count,
                long offset
            )
            {
                GetAllDeployment op = new GetAllDeployment(this,
                    namespace_,
                    count,
                    offset
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsListDeploymentResponse? Execute(
                string namespace_,
                long count,
                long offset
            )
            {
                GetAllDeployment op = Build(
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
        }

        private GetAllDeployment(GetAllDeploymentBuilder builder,
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

        public GetAllDeployment(
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

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/configs/deployments";

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
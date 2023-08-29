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
    /// CountServerDetailed
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:SERVER [READ]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint counts all of dedicated servers in a region managed by this service.
    /// </summary>
    public class CountServerDetailed : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CountServerDetailedBuilder Builder { get => new CountServerDetailedBuilder(); }

        public class CountServerDetailedBuilder
            : OperationBuilder<CountServerDetailedBuilder>
        {

            public string? Region { get; set; }





            internal CountServerDetailedBuilder() { }

            internal CountServerDetailedBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public CountServerDetailedBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }





            public CountServerDetailed Build(
                string namespace_
            )
            {
                CountServerDetailed op = new CountServerDetailed(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsDetailedCountServerResponse? Execute(
                string namespace_
            )
            {
                CountServerDetailed op = Build(
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

        private CountServerDetailed(CountServerDetailedBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Region is not null) QueryParams["region"] = builder.Region;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CountServerDetailed(
            string namespace_,
            string? region
        )
        {
            PathParams["namespace"] = namespace_;

            if (region is not null) QueryParams["region"] = region;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/servers/count/detailed";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsDetailedCountServerResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsDetailedCountServerResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsDetailedCountServerResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
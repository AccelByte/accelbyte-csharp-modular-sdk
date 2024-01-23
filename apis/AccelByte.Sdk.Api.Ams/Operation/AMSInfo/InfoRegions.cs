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

using AccelByte.Sdk.Api.Ams.Model;

namespace AccelByte.Sdk.Api.Ams.Operation
{
    /// <summary>
    /// InfoRegions
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:ARMADA [READ]
    /// </summary>
    public class InfoRegions : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static InfoRegionsBuilder Builder { get => new InfoRegionsBuilder(); }

        public class InfoRegionsBuilder
            : OperationBuilder<InfoRegionsBuilder>
        {





            internal InfoRegionsBuilder() { }

            internal InfoRegionsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public InfoRegions Build(
                string namespace_
            )
            {
                InfoRegions op = new InfoRegions(this,
                    namespace_
                );

                op.SetBaseFields<InfoRegionsBuilder>(this);
                return op;
            }

            public Model.ApiAMSRegionsResponse? Execute(
                string namespace_
            )
            {
                InfoRegions op = Build(
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

        private InfoRegions(InfoRegionsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public InfoRegions(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/admin/namespaces/{namespace}/regions";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApiAMSRegionsResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApiAMSRegionsResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiAMSRegionsResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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
    /// ArtifactGetURL
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:AMS:ARTIFACT [READ]
    /// </summary>
    public class ArtifactGetURL : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ArtifactGetURLBuilder Builder { get => new ArtifactGetURLBuilder(); }

        public class ArtifactGetURLBuilder
            : OperationBuilder<ArtifactGetURLBuilder>
        {





            internal ArtifactGetURLBuilder() { }

            internal ArtifactGetURLBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public ArtifactGetURL Build(
                string artifactID,
                string namespace_
            )
            {
                ArtifactGetURL op = new ArtifactGetURL(this,
                    artifactID,
                    namespace_
                );

                op.SetBaseFields<ArtifactGetURLBuilder>(this);
                return op;
            }

            public Model.ApiArtifactURLResponse? Execute(
                string artifactID,
                string namespace_
            )
            {
                ArtifactGetURL op = Build(
                    artifactID,
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

        private ArtifactGetURL(ArtifactGetURLBuilder builder,
            string artifactID,
            string namespace_
        )
        {
            PathParams["artifactID"] = artifactID;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ArtifactGetURL(
            string artifactID,
            string namespace_
        )
        {
            PathParams["artifactID"] = artifactID;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/admin/namespaces/{namespace}/artifacts/{artifactID}/url";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApiArtifactURLResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApiArtifactURLResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiArtifactURLResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
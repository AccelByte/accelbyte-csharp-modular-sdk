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
    /// UpdateOverrideRegionOverride
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [UPDATE]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint update a dedicated servers deployment override in a namespace in a region for deployment overrides.
    /// </summary>
    public class UpdateOverrideRegionOverride : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateOverrideRegionOverrideBuilder Builder { get => new UpdateOverrideRegionOverrideBuilder(); }

        public class UpdateOverrideRegionOverrideBuilder
            : OperationBuilder<UpdateOverrideRegionOverrideBuilder>
        {





            internal UpdateOverrideRegionOverrideBuilder() { }

            internal UpdateOverrideRegionOverrideBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateOverrideRegionOverride Build(
                ModelsUpdateRegionOverrideRequest body,
                string deployment,
                string namespace_,
                string region,
                string version
            )
            {
                UpdateOverrideRegionOverride op = new UpdateOverrideRegionOverride(this,
                    body,
                    deployment,
                    namespace_,
                    region,
                    version
                );

                op.SetBaseFields<UpdateOverrideRegionOverrideBuilder>(this);
                return op;
            }

            public Model.ModelsDeploymentWithOverride? Execute(
                ModelsUpdateRegionOverrideRequest body,
                string deployment,
                string namespace_,
                string region,
                string version
            )
            {
                UpdateOverrideRegionOverride op = Build(
                    body,
                    deployment,
                    namespace_,
                    region,
                    version
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

        private UpdateOverrideRegionOverride(UpdateOverrideRegionOverrideBuilder builder,
            ModelsUpdateRegionOverrideRequest body,
            string deployment,
            string namespace_,
            string region,
            string version
        )
        {
            PathParams["deployment"] = deployment;
            PathParams["namespace"] = namespace_;
            PathParams["region"] = region;
            PathParams["version"] = version;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateOverrideRegionOverride(
            string deployment,
            string namespace_,
            string region,
            string version,
            Model.ModelsUpdateRegionOverrideRequest body
        )
        {
            PathParams["deployment"] = deployment;
            PathParams["namespace"] = namespace_;
            PathParams["region"] = region;
            PathParams["version"] = version;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/versions/{version}/regions/{region}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsDeploymentWithOverride? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsDeploymentWithOverride>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsDeploymentWithOverride>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
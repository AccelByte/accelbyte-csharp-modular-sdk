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
    /// CreateRootRegionOverride
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [CREATE]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint creates a dedicated servers deployment override in a namespace in a region for root deployment.
    /// </summary>
    public class CreateRootRegionOverride : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateRootRegionOverrideBuilder Builder { get => new CreateRootRegionOverrideBuilder(); }

        public class CreateRootRegionOverrideBuilder
            : OperationBuilder<CreateRootRegionOverrideBuilder>
        {





            internal CreateRootRegionOverrideBuilder() { }

            internal CreateRootRegionOverrideBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateRootRegionOverride Build(
                ModelsCreateRegionOverrideRequest body,
                string deployment,
                string namespace_,
                string region
            )
            {
                CreateRootRegionOverride op = new CreateRootRegionOverride(this,
                    body,                    
                    deployment,                    
                    namespace_,                    
                    region                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsDeploymentWithOverride? Execute(
                ModelsCreateRegionOverrideRequest body,
                string deployment,
                string namespace_,
                string region
            )
            {
                CreateRootRegionOverride op = Build(
                    body,
                    deployment,
                    namespace_,
                    region
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

        private CreateRootRegionOverride(CreateRootRegionOverrideBuilder builder,
            ModelsCreateRegionOverrideRequest body,
            string deployment,
            string namespace_,
            string region
        )
        {
            PathParams["deployment"] = deployment;
            PathParams["namespace"] = namespace_;
            PathParams["region"] = region;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateRootRegionOverride(
            string deployment,            
            string namespace_,            
            string region,            
            Model.ModelsCreateRegionOverrideRequest body            
        )
        {
            PathParams["deployment"] = deployment;
            PathParams["namespace"] = namespace_;
            PathParams["region"] = region;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/regions/{region}";

        public override HttpMethod Method => HttpMethod.Post;

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
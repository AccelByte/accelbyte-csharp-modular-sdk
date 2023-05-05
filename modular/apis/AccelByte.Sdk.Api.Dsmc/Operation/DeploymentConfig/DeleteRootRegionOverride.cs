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
    /// DeleteRootRegionOverride
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [DELETE]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint delete a dedicated server deployment override in a namespace in a region for root deployment
    /// </summary>
    public class DeleteRootRegionOverride : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteRootRegionOverrideBuilder Builder { get => new DeleteRootRegionOverrideBuilder(); }

        public class DeleteRootRegionOverrideBuilder
            : OperationBuilder<DeleteRootRegionOverrideBuilder>
        {





            internal DeleteRootRegionOverrideBuilder() { }

            internal DeleteRootRegionOverrideBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteRootRegionOverride Build(
                string deployment,
                string namespace_,
                string region
            )
            {
                DeleteRootRegionOverride op = new DeleteRootRegionOverride(this,
                    deployment,                    
                    namespace_,                    
                    region                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelsDeploymentWithOverride? Execute(
                string deployment,
                string namespace_,
                string region
            )
            {
                DeleteRootRegionOverride op = Build(
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

        private DeleteRootRegionOverride(DeleteRootRegionOverrideBuilder builder,
            string deployment,
            string namespace_,
            string region
        )
        {
            PathParams["deployment"] = deployment;
            PathParams["namespace"] = namespace_;
            PathParams["region"] = region;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteRootRegionOverride(
            string deployment,            
            string namespace_,            
            string region            
        )
        {
            PathParams["deployment"] = deployment;
            PathParams["namespace"] = namespace_;
            PathParams["region"] = region;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/regions/{region}";

        public override HttpMethod Method => HttpMethod.Delete;

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
                return JsonSerializer.Deserialize<Model.ModelsDeploymentWithOverride>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsDeploymentWithOverride>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
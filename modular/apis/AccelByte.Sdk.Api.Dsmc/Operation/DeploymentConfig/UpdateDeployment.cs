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
    /// UpdateDeployment
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [UPDATE]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint update a dedicated servers deployment in a namespace.
    /// </summary>
    public class UpdateDeployment : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateDeploymentBuilder Builder { get => new UpdateDeploymentBuilder(); }

        public class UpdateDeploymentBuilder
            : OperationBuilder<UpdateDeploymentBuilder>
        {





            internal UpdateDeploymentBuilder() { }

            internal UpdateDeploymentBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateDeployment Build(
                ModelsUpdateDeploymentRequest body,
                string deployment,
                string namespace_
            )
            {
                UpdateDeployment op = new UpdateDeployment(this,
                    body,                    
                    deployment,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelsDeploymentWithOverride? Execute(
                ModelsUpdateDeploymentRequest body,
                string deployment,
                string namespace_
            )
            {
                UpdateDeployment op = Build(
                    body,
                    deployment,
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

        private UpdateDeployment(UpdateDeploymentBuilder builder,
            ModelsUpdateDeploymentRequest body,
            string deployment,
            string namespace_
        )
        {
            PathParams["deployment"] = deployment;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateDeployment(
            string deployment,            
            string namespace_,            
            Model.ModelsUpdateDeploymentRequest body            
        )
        {
            PathParams["deployment"] = deployment;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}";

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
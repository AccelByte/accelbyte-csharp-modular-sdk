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

using AccelByte.Sdk.Api.Qosm.Model;

namespace AccelByte.Sdk.Api.Qosm.Operation
{
    /// <summary>
    /// UpdateServerConfig
    ///
    /// ```
    /// Required permission: ADMIN:NAMESPACE:{namespace}:QOS:SERVER [UPDATE]
    /// Required scope: social
    /// 
    /// This endpoint updates the registered QoS service's configurable configuration'.
    /// ```
    /// </summary>
    public class UpdateServerConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateServerConfigBuilder Builder { get => new UpdateServerConfigBuilder(); }

        public class UpdateServerConfigBuilder
            : OperationBuilder<UpdateServerConfigBuilder>
        {





            internal UpdateServerConfigBuilder() { }

            internal UpdateServerConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateServerConfig Build(
                ModelsUpdateServerRequest body,
                string namespace_,
                string region
            )
            {
                UpdateServerConfig op = new UpdateServerConfig(this,
                    body,                    
                    namespace_,                    
                    region                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public void Execute(
                ModelsUpdateServerRequest body,
                string namespace_,
                string region
            )
            {
                UpdateServerConfig op = Build(
                    body,
                    namespace_,
                    region
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private UpdateServerConfig(UpdateServerConfigBuilder builder,
            ModelsUpdateServerRequest body,
            string namespace_,
            string region
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["region"] = region;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateServerConfig(
            string namespace_,            
            string region,            
            Model.ModelsUpdateServerRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["region"] = region;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/qosm/admin/namespaces/{namespace}/servers/{region}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
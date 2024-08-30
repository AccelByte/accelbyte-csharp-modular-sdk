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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// getServicePluginConfig
    ///
    /// Get service plugin config
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class GetServicePluginConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetServicePluginConfigBuilder Builder { get => new GetServicePluginConfigBuilder(); }

        public class GetServicePluginConfigBuilder
            : OperationBuilder<GetServicePluginConfigBuilder>
        {





            internal GetServicePluginConfigBuilder() { }

            internal GetServicePluginConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetServicePluginConfig Build(
                string namespace_
            )
            {
                GetServicePluginConfig op = new GetServicePluginConfig(this,
                    namespace_                    
                );

                op.SetBaseFields<GetServicePluginConfigBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
            public Model.ServicePluginConfigInfo? Execute(
                string namespace_
            )
            {
                GetServicePluginConfig op = Build(
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
            public async Task<Model.ServicePluginConfigInfo?> ExecuteAsync(
                string namespace_
            )
            {
                GetServicePluginConfig op = Build(
                    namespace_
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

        private GetServicePluginConfig(GetServicePluginConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetServicePluginConfig(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/configs/servicePlugin";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() {  };        
        
        public Model.ServicePluginConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ServicePluginConfigInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ServicePluginConfigInfo>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
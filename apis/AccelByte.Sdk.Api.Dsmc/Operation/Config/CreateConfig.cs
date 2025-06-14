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

using AccelByte.Sdk.Api.Dsmc.Model;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// CreateConfig
    ///
    /// ```
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [CREATE]
    /// Required scope: social
    /// 
    /// This endpoint creates config.
    /// 
    /// Port is where your game listens for incoming UDP connection, if empty it'll be set to 15000
    /// 
    /// CPU and Memory limit / request are formatted with Kubernetes format,
    /// e.g. CPU of 1000m is 1 core, and Memory of 512Mi is 512 MB.
    /// 
    /// The creation/claim/session/unreachable/heartbeat timeouts are all in seconds.
    /// Creation timeout is time limit for DS to startup until registers itself.
    /// Claim timeout is time limit for game session manager to claim its ready DS.
    /// Session timeout is time limit for match session before deleted.
    /// Unreachable timeout is time limit for DS in UNREACHABLE state before deleted.
    /// Heartbeat timeout is time limit for DS to give heartbeat before marked as UNREACHABLE.
    /// 
    /// Sample config:
    /// {
    /// "namespace": "accelbyte",
    /// "providers": [
    /// "aws"
    /// ],
    /// "port": 7777,
    /// "protocol": "udp",
    /// "creation_timeout": 120,
    /// "claim_timeout": 60,
    /// "session_timeout": 1800,
    /// "heartbeat_timeout": 30,
    /// "unreachable_timeout": 30,
    /// }
    /// ```
    /// </summary>
    public class CreateConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateConfigBuilder Builder { get => new CreateConfigBuilder(); }

        public class CreateConfigBuilder
            : OperationBuilder<CreateConfigBuilder>
        {





            internal CreateConfigBuilder() { }

            internal CreateConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateConfig Build(
                ModelsCreateDSMConfigRequest body,
                string namespace_
            )
            {
                CreateConfig op = new CreateConfig(this,
                    body,                    
                    namespace_                    
                );

                op.SetBaseFields<CreateConfigBuilder>(this);
                return op;
            }

            public CreateConfig.Response Execute(
                ModelsCreateDSMConfigRequest body,
                string namespace_
            )
            {
                CreateConfig op = Build(
                    body,
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
            public async Task<CreateConfig.Response> ExecuteAsync(
                ModelsCreateDSMConfigRequest body,
                string namespace_
            )
            {
                CreateConfig op = Build(
                    body,
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

        private CreateConfig(CreateConfigBuilder builder,
            ModelsCreateDSMConfigRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsDSMConfigRecord>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error409 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Dsmc::Config::CreateConfig";
        }

        #endregion

        public CreateConfig(
            string namespace_,            
            Model.ModelsCreateDSMConfigRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/configs";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public CreateConfig.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new CreateConfig.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.ModelsDSMConfigRecord>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
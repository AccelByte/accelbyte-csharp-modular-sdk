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
    /// RegisterLocalServer
    ///
    /// ```
    /// Required permission: NAMESPACE:{namespace}:DSM:SERVER [UPDATE]
    /// Required scope: social
    /// 
    /// Use the alternative GET of the same endpoint to upgrade DS connection to DSM via websocket.
    /// 
    /// This endpoint is intended to be called by local dedicated server to let DSM know that it is ready for use.
    /// Use local DS only for development purposes since DSM wouldn't be able to properly manage local DS in production.
    /// This MUST be called by DS after it is ready to accept match data and incoming client connections.
    /// 
    /// Upon successfully calling this endpoint, the dedicated
    /// server is listed under READY local servers.```
    /// </summary>
    public class RegisterLocalServer : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RegisterLocalServerBuilder Builder { get => new RegisterLocalServerBuilder(); }

        public class RegisterLocalServerBuilder
            : OperationBuilder<RegisterLocalServerBuilder>
        {





            internal RegisterLocalServerBuilder() { }

            internal RegisterLocalServerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public RegisterLocalServer Build(
                ModelsRegisterLocalServerRequest body,
                string namespace_
            )
            {
                RegisterLocalServer op = new RegisterLocalServer(this,
                    body,                    
                    namespace_                    
                );

                op.SetBaseFields<RegisterLocalServerBuilder>(this);
                return op;
            }

            public RegisterLocalServer.Response Execute(
                ModelsRegisterLocalServerRequest body,
                string namespace_
            )
            {
                RegisterLocalServer op = Build(
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
            public async Task<RegisterLocalServer.Response> ExecuteAsync(
                ModelsRegisterLocalServerRequest body,
                string namespace_
            )
            {
                RegisterLocalServer op = Build(
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

        private RegisterLocalServer(RegisterLocalServerBuilder builder,
            ModelsRegisterLocalServerRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsServer>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error409 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Dsmc::Server::RegisterLocalServer";
        }

        #endregion

        public RegisterLocalServer(
            string namespace_,            
            Model.ModelsRegisterLocalServerRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/namespaces/{namespace}/servers/local/register";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public RegisterLocalServer.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new RegisterLocalServer.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsServer>(payload, ResponseJsonOptions);
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
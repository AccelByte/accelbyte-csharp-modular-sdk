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

            public Model.ModelsServer? Execute(
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
            public async Task<Model.ModelsServer?> ExecuteAsync(
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

        public Model.ModelsServer? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsServer>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsServer>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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
    /// DeleteLocalServer
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:SERVER [DELETE]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint deletes a specified local dedicated server from DB.
    /// Note that DSM has no ability to shutdown local DS.
    /// </summary>
    public class DeleteLocalServer : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteLocalServerBuilder Builder { get => new DeleteLocalServerBuilder(); }

        public class DeleteLocalServerBuilder
            : OperationBuilder<DeleteLocalServerBuilder>
        {





            internal DeleteLocalServerBuilder() { }

            internal DeleteLocalServerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteLocalServer Build(
                string name,
                string namespace_
            )
            {
                DeleteLocalServer op = new DeleteLocalServer(this,
                    name,
                    namespace_
                );

                op.SetBaseFields<DeleteLocalServerBuilder>(this);
                return op;
            }

            public void Execute(
                string name,
                string namespace_
            )
            {
                DeleteLocalServer op = Build(
                    name,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task ExecuteAsync(
                string name,
                string namespace_
            )
            {
                DeleteLocalServer op = Build(
                    name,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private DeleteLocalServer(DeleteLocalServerBuilder builder,
            string name,
            string namespace_
        )
        {
            PathParams["name"] = name;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteLocalServer(
            string name,
            string namespace_
        )
        {
            PathParams["name"] = name;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/servers/local/{name}";

        public override HttpMethod Method => HttpMethod.Delete;

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
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

using AccelByte.Sdk.Api.Cloudsave.Model;

namespace AccelByte.Sdk.Api.Cloudsave.Operation
{
    /// <summary>
    /// deleteGameRecordTTLConfig
    ///
    /// ## Description
    /// 
    /// This endpoints will delete the ttl config of the game record
    /// </summary>
    public class DeleteGameRecordTTLConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteGameRecordTTLConfigBuilder Builder { get => new DeleteGameRecordTTLConfigBuilder(); }

        public class DeleteGameRecordTTLConfigBuilder
            : OperationBuilder<DeleteGameRecordTTLConfigBuilder>
        {





            internal DeleteGameRecordTTLConfigBuilder() { }

            internal DeleteGameRecordTTLConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteGameRecordTTLConfig Build(
                string key,
                string namespace_
            )
            {
                DeleteGameRecordTTLConfig op = new DeleteGameRecordTTLConfig(this,
                    key,
                    namespace_
                );

                op.SetBaseFields<DeleteGameRecordTTLConfigBuilder>(this);
                return op;
            }

            public void Execute(
                string key,
                string namespace_
            )
            {
                DeleteGameRecordTTLConfig op = Build(
                    key,
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
                string key,
                string namespace_
            )
            {
                DeleteGameRecordTTLConfig op = Build(
                    key,
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

        private DeleteGameRecordTTLConfig(DeleteGameRecordTTLConfigBuilder builder,
            string key,
            string namespace_
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteGameRecordTTLConfig(
            string key,
            string namespace_
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/records/{key}/ttl";

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
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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// UpdateClientSecret
    ///
    /// ## The endpoint is going to be deprecated
    /// **Endpoint migration guide**
    /// - **Substitute endpoint: _/iam/v3/admin/namespaces/{namespace}/{clientId}/secret [PUT]_**
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class UpdateClientSecret : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateClientSecretBuilder Builder { get => new UpdateClientSecretBuilder(); }

        public class UpdateClientSecretBuilder
            : OperationBuilder<UpdateClientSecretBuilder>
        {





            internal UpdateClientSecretBuilder() { }

            internal UpdateClientSecretBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateClientSecret Build(
                ClientmodelClientUpdateSecretRequest body,
                string clientId
            )
            {
                UpdateClientSecret op = new UpdateClientSecret(this,
                    body,
                    clientId
                );

                op.SetBaseFields<UpdateClientSecretBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public void Execute(
                ClientmodelClientUpdateSecretRequest body,
                string clientId
            )
            {
                UpdateClientSecret op = Build(
                    body,
                    clientId
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
                ClientmodelClientUpdateSecretRequest body,
                string clientId
            )
            {
                UpdateClientSecret op = Build(
                    body,
                    clientId
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

        private UpdateClientSecret(UpdateClientSecretBuilder builder,
            ClientmodelClientUpdateSecretRequest body,
            string clientId
        )
        {
            PathParams["clientId"] = clientId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateClientSecret(
            string clientId,
            Model.ClientmodelClientUpdateSecretRequest body
        )
        {
            PathParams["clientId"] = clientId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/clients/{clientId}/secret";

        public override HttpMethod Method => HttpMethod.Put;

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
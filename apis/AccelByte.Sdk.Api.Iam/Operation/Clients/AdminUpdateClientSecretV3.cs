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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminUpdateClientSecretV3
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:CLIENT [UPDATE]'
    /// </summary>
    public class AdminUpdateClientSecretV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateClientSecretV3Builder Builder { get => new AdminUpdateClientSecretV3Builder(); }

        public class AdminUpdateClientSecretV3Builder
            : OperationBuilder<AdminUpdateClientSecretV3Builder>
        {





            internal AdminUpdateClientSecretV3Builder() { }

            internal AdminUpdateClientSecretV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpdateClientSecretV3 Build(
                ClientmodelV3ClientUpdateSecretRequest body,
                string clientId,
                string namespace_
            )
            {
                AdminUpdateClientSecretV3 op = new AdminUpdateClientSecretV3(this,
                    body,
                    clientId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                ClientmodelV3ClientUpdateSecretRequest body,
                string clientId,
                string namespace_
            )
            {
                AdminUpdateClientSecretV3 op = Build(
                    body,
                    clientId,
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
        }

        private AdminUpdateClientSecretV3(AdminUpdateClientSecretV3Builder builder,
            ClientmodelV3ClientUpdateSecretRequest body,
            string clientId,
            string namespace_
        )
        {
            PathParams["clientId"] = clientId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateClientSecretV3(
            string clientId,
            string namespace_,
            Model.ClientmodelV3ClientUpdateSecretRequest body
        )
        {
            PathParams["clientId"] = clientId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/{clientId}/secret";

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
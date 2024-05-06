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

using AccelByte.Sdk.Api.Gdpr.Model;

namespace AccelByte.Sdk.Api.Gdpr.Operation
{
    /// <summary>
    /// UpdateAdminEmailConfiguration
    ///
    /// Update admin email address for receiving personal data request notification.
    /// Scope: account
    /// </summary>
    public class UpdateAdminEmailConfiguration : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateAdminEmailConfigurationBuilder Builder { get => new UpdateAdminEmailConfigurationBuilder(); }

        public class UpdateAdminEmailConfigurationBuilder
            : OperationBuilder<UpdateAdminEmailConfigurationBuilder>
        {





            internal UpdateAdminEmailConfigurationBuilder() { }

            internal UpdateAdminEmailConfigurationBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateAdminEmailConfiguration Build(
                List<string> body,
                string namespace_
            )
            {
                UpdateAdminEmailConfiguration op = new UpdateAdminEmailConfiguration(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<UpdateAdminEmailConfigurationBuilder>(this);
                return op;
            }

            public void Execute(
                List<string> body,
                string namespace_
            )
            {
                UpdateAdminEmailConfiguration op = Build(
                    body,
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
                List<string> body,
                string namespace_
            )
            {
                UpdateAdminEmailConfiguration op = Build(
                    body,
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

        private UpdateAdminEmailConfiguration(UpdateAdminEmailConfigurationBuilder builder,
            List<string> body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateAdminEmailConfiguration(
            string namespace_,
            List<string> body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/admin/namespaces/{namespace}/emails/configurations";

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
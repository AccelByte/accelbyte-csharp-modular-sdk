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
    /// DeleteAdminEmailConfiguration
    ///
    /// Delete a list of admin email addresses to stop receiving personal data request notification.
    /// 
    /// 
    /// Required permission `ADMIN:NAMESPACE:{namespace}:EMAIL:CONFIGURATION [DELETE]` and scope `account`
    /// </summary>
    public class DeleteAdminEmailConfiguration : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteAdminEmailConfigurationBuilder Builder { get => new DeleteAdminEmailConfigurationBuilder(); }

        public class DeleteAdminEmailConfigurationBuilder
            : OperationBuilder<DeleteAdminEmailConfigurationBuilder>
        {





            internal DeleteAdminEmailConfigurationBuilder() { }

            internal DeleteAdminEmailConfigurationBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteAdminEmailConfiguration Build(
                string namespace_,
                List<string> emails
            )
            {
                DeleteAdminEmailConfiguration op = new DeleteAdminEmailConfiguration(this,
                    namespace_,
                    emails
                );

                op.SetBaseFields<DeleteAdminEmailConfigurationBuilder>(this);
                return op;
            }

            public void Execute(
                string namespace_,
                List<string> emails
            )
            {
                DeleteAdminEmailConfiguration op = Build(
                    namespace_,
                    emails
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
                string namespace_,
                List<string> emails
            )
            {
                DeleteAdminEmailConfiguration op = Build(
                    namespace_,
                    emails
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

        private DeleteAdminEmailConfiguration(DeleteAdminEmailConfigurationBuilder builder,
            string namespace_,
            List<string> emails
        )
        {
            PathParams["namespace"] = namespace_;

            if (emails is not null) QueryParams["emails"] = emails;



            CollectionFormatMap["emails"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteAdminEmailConfiguration(
            string namespace_,
            List<string> emails
        )
        {
            PathParams["namespace"] = namespace_;

            if (emails is not null) QueryParams["emails"] = emails;



            CollectionFormatMap["emails"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/admin/namespaces/{namespace}/emails/configurations";

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
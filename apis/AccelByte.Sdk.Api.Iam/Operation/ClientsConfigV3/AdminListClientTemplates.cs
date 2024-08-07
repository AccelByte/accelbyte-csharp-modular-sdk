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
    /// AdminListClientTemplates
    ///
    /// List client templates
    /// </summary>
    public class AdminListClientTemplates : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListClientTemplatesBuilder Builder { get => new AdminListClientTemplatesBuilder(); }

        public class AdminListClientTemplatesBuilder
            : OperationBuilder<AdminListClientTemplatesBuilder>
        {





            internal AdminListClientTemplatesBuilder() { }

            internal AdminListClientTemplatesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminListClientTemplates Build(
            )
            {
                AdminListClientTemplates op = new AdminListClientTemplates(this
                );

                op.SetBaseFields<AdminListClientTemplatesBuilder>(this);
                return op;
            }

            public Model.ClientmodelListTemplatesResponse? Execute(
            )
            {
                AdminListClientTemplates op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.ClientmodelListTemplatesResponse?> ExecuteAsync(
            )
            {
                AdminListClientTemplates op = Build(
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

        private AdminListClientTemplates(AdminListClientTemplatesBuilder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminListClientTemplates(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/clientConfig/templates";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ClientmodelListTemplatesResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ClientmodelListTemplatesResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ClientmodelListTemplatesResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
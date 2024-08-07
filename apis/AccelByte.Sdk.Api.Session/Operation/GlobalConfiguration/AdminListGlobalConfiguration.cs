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

using AccelByte.Sdk.Api.Session.Model;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// adminListGlobalConfiguration
    ///
    /// Record of global configuration data.
    /// </summary>
    public class AdminListGlobalConfiguration : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListGlobalConfigurationBuilder Builder { get => new AdminListGlobalConfigurationBuilder(); }

        public class AdminListGlobalConfigurationBuilder
            : OperationBuilder<AdminListGlobalConfigurationBuilder>
        {





            internal AdminListGlobalConfigurationBuilder() { }

            internal AdminListGlobalConfigurationBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminListGlobalConfiguration Build(
            )
            {
                AdminListGlobalConfiguration op = new AdminListGlobalConfiguration(this
                );

                op.SetBaseFields<AdminListGlobalConfigurationBuilder>(this);
                return op;
            }

            public Model.ApimodelsGlobalConfigurationResponse? Execute(
            )
            {
                AdminListGlobalConfiguration op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.ApimodelsGlobalConfigurationResponse?> ExecuteAsync(
            )
            {
                AdminListGlobalConfiguration op = Build(
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

        private AdminListGlobalConfiguration(AdminListGlobalConfigurationBuilder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminListGlobalConfiguration(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/global-configurations";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApimodelsGlobalConfigurationResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsGlobalConfigurationResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsGlobalConfigurationResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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

using AccelByte.Sdk.Api.Session.Model;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// adminUpdateConfigurationAlertV1
    ///
    /// Update configuration alert
    /// configuration alert mandatory :
    /// - namespace
    /// - durationDays must be greater than 0
    /// </summary>
    public class AdminUpdateConfigurationAlertV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateConfigurationAlertV1Builder Builder { get => new AdminUpdateConfigurationAlertV1Builder(); }

        public class AdminUpdateConfigurationAlertV1Builder
            : OperationBuilder<AdminUpdateConfigurationAlertV1Builder>
        {





            internal AdminUpdateConfigurationAlertV1Builder() { }

            internal AdminUpdateConfigurationAlertV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpdateConfigurationAlertV1 Build(
                ApimodelsConfigAlertRequestCreate body,
                string namespace_
            )
            {
                AdminUpdateConfigurationAlertV1 op = new AdminUpdateConfigurationAlertV1(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ApimodelsConfigAlertResponse? Execute(
                ApimodelsConfigAlertRequestCreate body,
                string namespace_
            )
            {
                AdminUpdateConfigurationAlertV1 op = Build(
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
        }

        private AdminUpdateConfigurationAlertV1(AdminUpdateConfigurationAlertV1Builder builder,
            ApimodelsConfigAlertRequestCreate body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateConfigurationAlertV1(
            string namespace_,
            Model.ApimodelsConfigAlertRequestCreate body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/namespaces/{namespace}/alerts-configuration";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApimodelsConfigAlertResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsConfigAlertResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsConfigAlertResponse>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
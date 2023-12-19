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
    /// AdminUpdateClientPermissionV3
    ///
    /// **Note for Multi Tenant Mode:**
    /// 1. The assigned permission(s) should be restricted in the Default Client permission collection.
    /// action code: 10307
    /// </summary>
    public class AdminUpdateClientPermissionV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateClientPermissionV3Builder Builder { get => new AdminUpdateClientPermissionV3Builder(); }

        public class AdminUpdateClientPermissionV3Builder
            : OperationBuilder<AdminUpdateClientPermissionV3Builder>
        {





            internal AdminUpdateClientPermissionV3Builder() { }

            internal AdminUpdateClientPermissionV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpdateClientPermissionV3 Build(
                AccountcommonClientPermissionsV3 body,
                string clientId,
                string namespace_
            )
            {
                AdminUpdateClientPermissionV3 op = new AdminUpdateClientPermissionV3(this,
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
                AccountcommonClientPermissionsV3 body,
                string clientId,
                string namespace_
            )
            {
                AdminUpdateClientPermissionV3 op = Build(
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

        private AdminUpdateClientPermissionV3(AdminUpdateClientPermissionV3Builder builder,
            AccountcommonClientPermissionsV3 body,
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

        public AdminUpdateClientPermissionV3(
            string clientId,
            string namespace_,
            Model.AccountcommonClientPermissionsV3 body
        )
        {
            PathParams["clientId"] = clientId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/clients/{clientId}/permissions";

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
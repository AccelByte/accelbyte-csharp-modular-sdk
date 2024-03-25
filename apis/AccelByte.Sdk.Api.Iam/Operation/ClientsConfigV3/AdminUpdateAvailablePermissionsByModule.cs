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
    /// AdminUpdateAvailablePermissionsByModule
    ///
    /// Update Client available permissions, if module or group not exists, it will auto create.
    /// </summary>
    public class AdminUpdateAvailablePermissionsByModule : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateAvailablePermissionsByModuleBuilder Builder { get => new AdminUpdateAvailablePermissionsByModuleBuilder(); }

        public class AdminUpdateAvailablePermissionsByModuleBuilder
            : OperationBuilder<AdminUpdateAvailablePermissionsByModuleBuilder>
        {

            public bool? ForceDelete { get; set; }





            internal AdminUpdateAvailablePermissionsByModuleBuilder() { }

            internal AdminUpdateAvailablePermissionsByModuleBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminUpdateAvailablePermissionsByModuleBuilder SetForceDelete(bool _forceDelete)
            {
                ForceDelete = _forceDelete;
                return this;
            }





            public AdminUpdateAvailablePermissionsByModule Build(
                ClientmodelListUpsertModulesRequest body
            )
            {
                AdminUpdateAvailablePermissionsByModule op = new AdminUpdateAvailablePermissionsByModule(this,
                    body
                );

                op.SetBaseFields<AdminUpdateAvailablePermissionsByModuleBuilder>(this);
                return op;
            }

            public void Execute(
                ClientmodelListUpsertModulesRequest body
            )
            {
                AdminUpdateAvailablePermissionsByModule op = Build(
                    body
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

        private AdminUpdateAvailablePermissionsByModule(AdminUpdateAvailablePermissionsByModuleBuilder builder,
            ClientmodelListUpsertModulesRequest body
        )
        {

            if (builder.ForceDelete != null) QueryParams["forceDelete"] = Convert.ToString(builder.ForceDelete)!;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateAvailablePermissionsByModule(
            bool? forceDelete,
            Model.ClientmodelListUpsertModulesRequest body
        )
        {

            if (forceDelete != null) QueryParams["forceDelete"] = Convert.ToString(forceDelete)!;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/clientConfig/permissions";

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
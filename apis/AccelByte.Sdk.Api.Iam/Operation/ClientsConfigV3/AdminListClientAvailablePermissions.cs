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
    /// AdminListClientAvailablePermissions
    ///
    /// List Client available permissions
    /// </summary>
    public class AdminListClientAvailablePermissions : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListClientAvailablePermissionsBuilder Builder { get => new AdminListClientAvailablePermissionsBuilder(); }

        public class AdminListClientAvailablePermissionsBuilder
            : OperationBuilder<AdminListClientAvailablePermissionsBuilder>
        {

            public bool? ExcludePermissions { get; set; }





            internal AdminListClientAvailablePermissionsBuilder() { }

            internal AdminListClientAvailablePermissionsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminListClientAvailablePermissionsBuilder SetExcludePermissions(bool _excludePermissions)
            {
                ExcludePermissions = _excludePermissions;
                return this;
            }





            public AdminListClientAvailablePermissions Build(
            )
            {
                AdminListClientAvailablePermissions op = new AdminListClientAvailablePermissions(this
                );

                op.SetBaseFields<AdminListClientAvailablePermissionsBuilder>(this);
                return op;
            }

            public Model.ClientmodelListClientPermissionSet? Execute(
            )
            {
                AdminListClientAvailablePermissions op = Build(
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

        private AdminListClientAvailablePermissions(AdminListClientAvailablePermissionsBuilder builder
        )
        {

            if (builder.ExcludePermissions != null) QueryParams["excludePermissions"] = Convert.ToString(builder.ExcludePermissions)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminListClientAvailablePermissions(
            bool? excludePermissions
        )
        {

            if (excludePermissions != null) QueryParams["excludePermissions"] = Convert.ToString(excludePermissions)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/clientConfig/permissions";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ClientmodelListClientPermissionSet? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ClientmodelListClientPermissionSet>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ClientmodelListClientPermissionSet>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
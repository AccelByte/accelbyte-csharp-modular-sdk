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
    /// AdminDeleteConfigPermissionsByGroup
    ///
    /// Delete Client config permissions by module and group.
    /// </summary>
    public class AdminDeleteConfigPermissionsByGroup : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteConfigPermissionsByGroupBuilder Builder { get => new AdminDeleteConfigPermissionsByGroupBuilder(); }

        public class AdminDeleteConfigPermissionsByGroupBuilder
            : OperationBuilder<AdminDeleteConfigPermissionsByGroupBuilder>
        {

            public bool? ForceDelete { get; set; }





            internal AdminDeleteConfigPermissionsByGroupBuilder() { }

            internal AdminDeleteConfigPermissionsByGroupBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminDeleteConfigPermissionsByGroupBuilder SetForceDelete(bool _forceDelete)
            {
                ForceDelete = _forceDelete;
                return this;
            }





            public AdminDeleteConfigPermissionsByGroup Build(
                ClientmodelPermissionSetDeleteGroupRequest body
            )
            {
                AdminDeleteConfigPermissionsByGroup op = new AdminDeleteConfigPermissionsByGroup(this,
                    body
                );

                op.SetBaseFields<AdminDeleteConfigPermissionsByGroupBuilder>(this);
                return op;
            }

            public void Execute(
                ClientmodelPermissionSetDeleteGroupRequest body
            )
            {
                AdminDeleteConfigPermissionsByGroup op = Build(
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

        private AdminDeleteConfigPermissionsByGroup(AdminDeleteConfigPermissionsByGroupBuilder builder,
            ClientmodelPermissionSetDeleteGroupRequest body
        )
        {

            if (builder.ForceDelete != null) QueryParams["forceDelete"] = Convert.ToString(builder.ForceDelete)!;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteConfigPermissionsByGroup(
            bool? forceDelete,
            Model.ClientmodelPermissionSetDeleteGroupRequest body
        )
        {

            if (forceDelete != null) QueryParams["forceDelete"] = Convert.ToString(forceDelete)!;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/clientConfig/permissions";

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
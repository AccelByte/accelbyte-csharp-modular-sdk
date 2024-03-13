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

using AccelByte.Sdk.Api.Ugc.Model;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// AdminDeleteAllUserGroup
    ///
    /// Delete all user group
    /// </summary>
    public class AdminDeleteAllUserGroup : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteAllUserGroupBuilder Builder { get => new AdminDeleteAllUserGroupBuilder(); }

        public class AdminDeleteAllUserGroupBuilder
            : OperationBuilder<AdminDeleteAllUserGroupBuilder>
        {





            internal AdminDeleteAllUserGroupBuilder() { }

            internal AdminDeleteAllUserGroupBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeleteAllUserGroup Build(
                string namespace_,
                string userId
            )
            {
                AdminDeleteAllUserGroup op = new AdminDeleteAllUserGroup(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AdminDeleteAllUserGroupBuilder>(this);
                return op;
            }

            public void Execute(
                string namespace_,
                string userId
            )
            {
                AdminDeleteAllUserGroup op = Build(
                    namespace_,
                    userId
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

        private AdminDeleteAllUserGroup(AdminDeleteAllUserGroupBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteAllUserGroup(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/users/{userId}/groups";

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
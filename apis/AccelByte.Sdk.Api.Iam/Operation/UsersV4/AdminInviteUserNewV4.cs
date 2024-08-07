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
    /// AdminInviteUserNewV4
    ///
    /// Use this endpoint to invite admin or non-admin user and assign role to them. The role must be scoped to namespace. An admin user can only
    /// assign role with **assignedNamespaces** if the admin user has required permission which is same as the required permission of endpoint: [AdminAddUserRoleV4].
    /// 
    /// Detail request body :
    /// - **emailAddresses** is required, List of email addresses that will be invited
    /// - **isAdmin** is required, true if user is admin, false if user is not admin
    /// - **namespace** is optional. Only works on multi tenant mode,
    /// if not specified then it will be assigned Publisher namespace,
    /// if specified, it will become that studio/publisher where user is invited to.
    /// - **roleId** is optional, if not specified then it will only assign User role.
    /// - **assignedNamespaces** is optional, List of namespaces which the Role will be assigned to the user, only works when Role is not empty.
    /// 
    /// The invited admin will also assigned with "User" role by default.
    /// </summary>
    public class AdminInviteUserNewV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminInviteUserNewV4Builder Builder { get => new AdminInviteUserNewV4Builder(); }

        public class AdminInviteUserNewV4Builder
            : OperationBuilder<AdminInviteUserNewV4Builder>
        {





            internal AdminInviteUserNewV4Builder() { }

            internal AdminInviteUserNewV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminInviteUserNewV4 Build(
                ModelInviteUserRequestV4 body
            )
            {
                AdminInviteUserNewV4 op = new AdminInviteUserNewV4(this,
                    body
                );

                op.SetBaseFields<AdminInviteUserNewV4Builder>(this);
                return op;
            }

            public Model.ModelInviteUserResponseV3? Execute(
                ModelInviteUserRequestV4 body
            )
            {
                AdminInviteUserNewV4 op = Build(
                    body
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.ModelInviteUserResponseV3?> ExecuteAsync(
                ModelInviteUserRequestV4 body
            )
            {
                AdminInviteUserNewV4 op = Build(
                    body
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

        private AdminInviteUserNewV4(AdminInviteUserNewV4Builder builder,
            ModelInviteUserRequestV4 body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminInviteUserNewV4(
            Model.ModelInviteUserRequestV4 body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/users/invite";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelInviteUserResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelInviteUserResponseV3>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelInviteUserResponseV3>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
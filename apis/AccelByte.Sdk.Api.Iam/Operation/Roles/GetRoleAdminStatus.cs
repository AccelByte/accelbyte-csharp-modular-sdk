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
    /// GetRoleAdminStatus
    ///
    /// ## The endpoint is going to be deprecated
    /// Admin roles has its members listed in the role.
    /// 
    /// ### Endpoint migration guide
    /// - **Substitute endpoint: _/iam/v3/admin/roles/{roleId}/admin [GET]_**
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class GetRoleAdminStatus : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetRoleAdminStatusBuilder Builder { get => new GetRoleAdminStatusBuilder(); }

        public class GetRoleAdminStatusBuilder
            : OperationBuilder<GetRoleAdminStatusBuilder>
        {





            internal GetRoleAdminStatusBuilder() { }

            internal GetRoleAdminStatusBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetRoleAdminStatus Build(
                string roleId
            )
            {
                GetRoleAdminStatus op = new GetRoleAdminStatus(this,
                    roleId
                );

                op.SetBaseFields<GetRoleAdminStatusBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public Model.ModelRoleAdminStatusResponse? Execute(
                string roleId
            )
            {
                GetRoleAdminStatus op = Build(
                    roleId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.ModelRoleAdminStatusResponse?> ExecuteAsync(
                string roleId
            )
            {
                GetRoleAdminStatus op = Build(
                    roleId
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

        private GetRoleAdminStatus(GetRoleAdminStatusBuilder builder,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetRoleAdminStatus(
            string roleId
        )
        {
            PathParams["roleId"] = roleId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/roles/{roleId}/admin";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelRoleAdminStatusResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleAdminStatusResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleAdminStatusResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
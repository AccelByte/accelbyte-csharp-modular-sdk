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
    /// GetRoleManagers
    ///
    /// ## The endpoint is going to be deprecated
    /// Role can only be assigned to other users by the role's manager.
    /// 
    /// ### Endpoint migration guide
    /// - **Substitute endpoint: _/iam/v3/admin/roles/{roleId}/managers [GET]_**
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class GetRoleManagers : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetRoleManagersBuilder Builder { get => new GetRoleManagersBuilder(); }

        public class GetRoleManagersBuilder
            : OperationBuilder<GetRoleManagersBuilder>
        {





            internal GetRoleManagersBuilder() { }

            internal GetRoleManagersBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetRoleManagers Build(
                string roleId
            )
            {
                GetRoleManagers op = new GetRoleManagers(this,
                    roleId
                );

                op.SetBaseFields<GetRoleManagersBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public Model.ModelRoleManagersResponse? Execute(
                string roleId
            )
            {
                GetRoleManagers op = Build(
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
            public async Task<Model.ModelRoleManagersResponse?> ExecuteAsync(
                string roleId
            )
            {
                GetRoleManagers op = Build(
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

        private GetRoleManagers(GetRoleManagersBuilder builder,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetRoleManagers(
            string roleId
        )
        {
            PathParams["roleId"] = roleId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/roles/{roleId}/managers";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelRoleManagersResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleManagersResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleManagersResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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
    /// AdminGetRoleMembersV3
    ///
    /// Admin roles has its members listed in the role.
    /// action code: 10416
    /// </summary>
    public class AdminGetRoleMembersV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetRoleMembersV3Builder Builder { get => new AdminGetRoleMembersV3Builder(); }

        public class AdminGetRoleMembersV3Builder
            : OperationBuilder<AdminGetRoleMembersV3Builder>
        {

            public string? After { get; set; }

            public string? Before { get; set; }

            public long? Limit { get; set; }





            internal AdminGetRoleMembersV3Builder() { }

            internal AdminGetRoleMembersV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminGetRoleMembersV3Builder SetAfter(string _after)
            {
                After = _after;
                return this;
            }

            public AdminGetRoleMembersV3Builder SetBefore(string _before)
            {
                Before = _before;
                return this;
            }

            public AdminGetRoleMembersV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }





            public AdminGetRoleMembersV3 Build(
                string roleId
            )
            {
                AdminGetRoleMembersV3 op = new AdminGetRoleMembersV3(this,
                    roleId
                );

                op.SetBaseFields<AdminGetRoleMembersV3Builder>(this);
                return op;
            }

            public Model.ModelRoleMembersResponseV3? Execute(
                string roleId
            )
            {
                AdminGetRoleMembersV3 op = Build(
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
            public async Task<Model.ModelRoleMembersResponseV3?> ExecuteAsync(
                string roleId
            )
            {
                AdminGetRoleMembersV3 op = Build(
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

        private AdminGetRoleMembersV3(AdminGetRoleMembersV3Builder builder,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;

            if (builder.After is not null) QueryParams["after"] = builder.After;
            if (builder.Before is not null) QueryParams["before"] = builder.Before;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetRoleMembersV3(
            string roleId,
            string? after,
            string? before,
            long? limit
        )
        {
            PathParams["roleId"] = roleId;

            if (after is not null) QueryParams["after"] = after;
            if (before is not null) QueryParams["before"] = before;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/roles/{roleId}/members";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelRoleMembersResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleMembersResponseV3>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleMembersResponseV3>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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
    /// AdminGetRolesV4
    ///
    /// action code: 10414
    /// </summary>
    public class AdminGetRolesV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetRolesV4Builder Builder { get => new AdminGetRolesV4Builder(); }

        public class AdminGetRolesV4Builder
            : OperationBuilder<AdminGetRolesV4Builder>
        {

            public bool? AdminRole { get; set; }

            public bool? IsWildcard { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal AdminGetRolesV4Builder() { }

            internal AdminGetRolesV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminGetRolesV4Builder SetAdminRole(bool _adminRole)
            {
                AdminRole = _adminRole;
                return this;
            }

            public AdminGetRolesV4Builder SetIsWildcard(bool _isWildcard)
            {
                IsWildcard = _isWildcard;
                return this;
            }

            public AdminGetRolesV4Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminGetRolesV4Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public AdminGetRolesV4 Build(
            )
            {
                AdminGetRolesV4 op = new AdminGetRolesV4(this
                );

                op.SetBaseFields<AdminGetRolesV4Builder>(this);
                return op;
            }

            public Model.ModelListRoleV4Response? Execute(
            )
            {
                AdminGetRolesV4 op = Build(
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

        private AdminGetRolesV4(AdminGetRolesV4Builder builder
        )
        {

            if (builder.AdminRole != null) QueryParams["adminRole"] = Convert.ToString(builder.AdminRole)!;
            if (builder.IsWildcard != null) QueryParams["isWildcard"] = Convert.ToString(builder.IsWildcard)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetRolesV4(
            bool? adminRole,
            bool? isWildcard,
            long? limit,
            long? offset
        )
        {

            if (adminRole != null) QueryParams["adminRole"] = Convert.ToString(adminRole)!;
            if (isWildcard != null) QueryParams["isWildcard"] = Convert.ToString(isWildcard)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/roles";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelListRoleV4Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelListRoleV4Response>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelListRoleV4Response>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
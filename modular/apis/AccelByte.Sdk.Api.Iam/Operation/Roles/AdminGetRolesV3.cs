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
    /// AdminGetRolesV3
    ///
    /// Required permission 'ADMIN:ROLE [READ]'
    /// 
    /// 
    /// action code: 10414
    /// </summary>
    public class AdminGetRolesV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetRolesV3Builder Builder { get => new AdminGetRolesV3Builder(); }

        public class AdminGetRolesV3Builder
            : OperationBuilder<AdminGetRolesV3Builder>
        {

            public string? After { get; set; }

            public string? Before { get; set; }

            public bool? IsWildcard { get; set; }

            public long? Limit { get; set; }





            internal AdminGetRolesV3Builder() { }

            internal AdminGetRolesV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminGetRolesV3Builder SetAfter(string _after)
            {
                After = _after;
                return this;
            }

            public AdminGetRolesV3Builder SetBefore(string _before)
            {
                Before = _before;
                return this;
            }

            public AdminGetRolesV3Builder SetIsWildcard(bool _isWildcard)
            {
                IsWildcard = _isWildcard;
                return this;
            }

            public AdminGetRolesV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }





            public AdminGetRolesV3 Build(
            )
            {
                AdminGetRolesV3 op = new AdminGetRolesV3(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelRoleResponseWithManagersAndPaginationV3? Execute(
            )
            {
                AdminGetRolesV3 op = Build(
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

        private AdminGetRolesV3(AdminGetRolesV3Builder builder
        )
        {
            
            if (builder.After is not null) QueryParams["after"] = builder.After;
            if (builder.Before is not null) QueryParams["before"] = builder.Before;
            if (builder.IsWildcard != null) QueryParams["isWildcard"] = Convert.ToString(builder.IsWildcard)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetRolesV3(
            string? after,            
            string? before,            
            bool? isWildcard,            
            long? limit            
        )
        {
            
            if (after is not null) QueryParams["after"] = after;
            if (before is not null) QueryParams["before"] = before;
            if (isWildcard != null) QueryParams["isWildcard"] = Convert.ToString(isWildcard)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/roles";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelRoleResponseWithManagersAndPaginationV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleResponseWithManagersAndPaginationV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleResponseWithManagersAndPaginationV3>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
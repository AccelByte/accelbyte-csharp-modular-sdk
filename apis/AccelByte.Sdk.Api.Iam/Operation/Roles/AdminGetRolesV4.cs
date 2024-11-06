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

            public AdminGetRolesV4.Response Execute(
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
            public async Task<AdminGetRolesV4.Response> ExecuteAsync(
            )
            {
                AdminGetRolesV4 op = Build(
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

        #region Response Part        
        public class Response : ApiResponse<Model.ModelListRoleV4Response>
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::Roles::AdminGetRolesV4";
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

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminGetRolesV4.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminGetRolesV4.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.ModelListRoleV4Response>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
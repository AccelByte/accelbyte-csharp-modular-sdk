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
    /// GetAdminUsersByRoleID
    ///
    /// ## The endpoint is going to be deprecated
    /// ### Endpoint migration guide
    /// - **Substitute endpoint(Public): _/iam/v3/admin/namespaces/{namespace}/roles/{roleId}/users [GET]_**
    /// - **Note:**
    /// difference in V3 response, format difference: Pascal case => Camel case
    /// 
    /// This endpoint search admin users which have the roleId
    /// 
    /// Notes : this endpoint only accept admin role. Admin Role is role which have admin status and members.
    /// Use endpoint [GET] /roles/{roleId}/admin to check the role status
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class GetAdminUsersByRoleID : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetAdminUsersByRoleIDBuilder Builder { get => new GetAdminUsersByRoleIDBuilder(); }

        public class GetAdminUsersByRoleIDBuilder
            : OperationBuilder<GetAdminUsersByRoleIDBuilder>
        {

            public long? After { get; set; }

            public long? Before { get; set; }

            public long? Limit { get; set; }

            public string? RoleId { get; set; }





            internal GetAdminUsersByRoleIDBuilder() { }

            internal GetAdminUsersByRoleIDBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetAdminUsersByRoleIDBuilder SetAfter(long _after)
            {
                After = _after;
                return this;
            }

            public GetAdminUsersByRoleIDBuilder SetBefore(long _before)
            {
                Before = _before;
                return this;
            }

            public GetAdminUsersByRoleIDBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetAdminUsersByRoleIDBuilder SetRoleId(string _roleId)
            {
                RoleId = _roleId;
                return this;
            }





            public GetAdminUsersByRoleID Build(
                string namespace_
            )
            {
                GetAdminUsersByRoleID op = new GetAdminUsersByRoleID(this,
                    namespace_                    
                );

                op.SetBaseFields<GetAdminUsersByRoleIDBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
            public GetAdminUsersByRoleID.Response Execute(
                string namespace_
            )
            {
                GetAdminUsersByRoleID op = Build(
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<GetAdminUsersByRoleID.Response> ExecuteAsync(
                string namespace_
            )
            {
                GetAdminUsersByRoleID op = Build(
                    namespace_
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

        private GetAdminUsersByRoleID(GetAdminUsersByRoleIDBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.After != null) QueryParams["after"] = Convert.ToString(builder.After)!;
            if (builder.Before != null) QueryParams["before"] = Convert.ToString(builder.Before)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.RoleId is not null) QueryParams["roleId"] = builder.RoleId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelGetAdminUsersResponse>
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public string Error404 { get; set; } = "";

            public string Error500 { get; set; } = "";


            protected override string GetFullOperationId() => "Iam::Users::GetAdminUsersByRoleID";
        }

        #endregion

        public GetAdminUsersByRoleID(
            string namespace_,            
            long? after,            
            long? before,            
            long? limit,            
            string? roleId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (after != null) QueryParams["after"] = Convert.ToString(after)!;
            if (before != null) QueryParams["before"] = Convert.ToString(before)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (roleId is not null) QueryParams["roleId"] = roleId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/namespaces/{namespace}/users/admin";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public GetAdminUsersByRoleID.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetAdminUsersByRoleID.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelGetAdminUsersResponse>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = payload.ReadToString();
                response.Error = new ApiError("-1", response.Error404!);
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = payload.ReadToString();
                response.Error = new ApiError("-1", response.Error500!);
            }

            return response;
        }
    }

}
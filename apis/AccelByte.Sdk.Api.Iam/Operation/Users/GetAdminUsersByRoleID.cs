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
    /// GetAdminUsersByRoleID
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Endpoint migration guide
    /// 
    /// 
    /// 
    /// 
    ///   * Substitute endpoint(Public): /iam/v3/admin/namespaces/{namespace}/roles/{roleId}/users [GET]
    /// 
    /// 
    /// 
    ///   * Note:
    ///     difference in V3 response, format difference: Pascal case => Camel case
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:USER [READ]'
    /// 
    /// 
    /// 
    /// 
    /// This endpoint search admin users which have the roleId
    /// 
    /// 
    /// 
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
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
            public Model.ModelGetAdminUsersResponse? Execute(
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
        
        public Model.ModelGetAdminUsersResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelGetAdminUsersResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelGetAdminUsersResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
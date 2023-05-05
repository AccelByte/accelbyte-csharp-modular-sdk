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
    /// ListAdminsV3
    ///
    /// This endpoint requires ADMIN:NAMESPACE:{namespace}:USER [READ] permission.
    /// 
    /// List all users that has admin role (role that has admin_role attribute set to true).
    /// 
    /// The endpoint will return all admin from all namespace when called from publisher namespace.
    /// When not called from publisher namespace, the endpoint will return all admin from the path namespace.
    /// </summary>
    public class ListAdminsV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListAdminsV3Builder Builder { get => new ListAdminsV3Builder(); }

        public class ListAdminsV3Builder
            : OperationBuilder<ListAdminsV3Builder>
        {

            public string? After { get; set; }

            public string? Before { get; set; }

            public long? Limit { get; set; }





            internal ListAdminsV3Builder() { }

            internal ListAdminsV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public ListAdminsV3Builder SetAfter(string _after)
            {
                After = _after;
                return this;
            }

            public ListAdminsV3Builder SetBefore(string _before)
            {
                Before = _before;
                return this;
            }

            public ListAdminsV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }





            public ListAdminsV3 Build(
                string namespace_
            )
            {
                ListAdminsV3 op = new ListAdminsV3(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelGetUsersResponseWithPaginationV3? Execute(
                string namespace_
            )
            {
                ListAdminsV3 op = Build(
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

        private ListAdminsV3(ListAdminsV3Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.After is not null) QueryParams["after"] = builder.After;
            if (builder.Before is not null) QueryParams["before"] = builder.Before;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ListAdminsV3(
            string namespace_,            
            string? after,            
            string? before,            
            long? limit            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (after is not null) QueryParams["after"] = after;
            if (before is not null) QueryParams["before"] = before;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/admins";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelGetUsersResponseWithPaginationV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelGetUsersResponseWithPaginationV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelGetUsersResponseWithPaginationV3>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
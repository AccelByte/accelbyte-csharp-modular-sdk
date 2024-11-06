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
    /// RevokeUser
    ///
    /// ## The endpoint is going to be deprecated
    /// This endpoint requires all requests to have authorization header set with bearer token.
    /// 
    /// The endpoint revokes all access tokens and refresh tokens a user has prior the revocation time. It is a convenient feature for the developer (or admin) who wanted to revokes all user's access tokens and refresh tokens generated before some period of time.
    /// ### Endpoint migration guide
    /// - **Substitute endpoint: _/iam/v3/oauth/admin/namespaces/{namespace}/users/{userId}/revoke [POST]_**
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class RevokeUser : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RevokeUserBuilder Builder { get => new RevokeUserBuilder(); }

        public class RevokeUserBuilder
            : OperationBuilder<RevokeUserBuilder>
        {





            internal RevokeUserBuilder() { }

            internal RevokeUserBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public RevokeUser Build(
                string namespace_,
                string userId
            )
            {
                RevokeUser op = new RevokeUser(this,
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<RevokeUserBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
            public RevokeUser.Response Execute(
                string namespace_,
                string userId
            )
            {
                RevokeUser op = Build(
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<RevokeUser.Response> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                RevokeUser op = Build(
                    namespace_,
                    userId
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

        private RevokeUser(RevokeUserBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public string Error401 { get; set; } = "";


            protected override string GetFullOperationId() => "Iam::OAuth::RevokeUser";
        }

        #endregion

        public RevokeUser(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/oauth/namespaces/{namespace}/users/{userId}/revoke";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public RevokeUser.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new RevokeUser.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)401)
            
            {
                response.Error401 = payload.ReadToString();
                response.Error = new ApiError("-1", response.Error401!);
            }

            return response;
        }
    }

}
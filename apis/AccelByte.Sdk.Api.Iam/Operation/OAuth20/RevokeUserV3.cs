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
    /// RevokeUserV3
    ///
    /// This endpoint revokes all access tokens and refresh tokens a user has prior the revocation time.
    /// This endpoint requires authorized requests header with valid access token.
    /// It is a convenient feature for the developer (or admin) who wanted to revokes all user's access tokens and refresh tokens generated before some period of time.
    /// action code : 10707
    /// </summary>
    public class RevokeUserV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RevokeUserV3Builder Builder { get => new RevokeUserV3Builder(); }

        public class RevokeUserV3Builder
            : OperationBuilder<RevokeUserV3Builder>
        {

            public bool? IncludeGameNamespace { get; set; }





            internal RevokeUserV3Builder() { }

            internal RevokeUserV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public RevokeUserV3Builder SetIncludeGameNamespace(bool _includeGameNamespace)
            {
                IncludeGameNamespace = _includeGameNamespace;
                return this;
            }





            public RevokeUserV3 Build(
                string namespace_,
                string userId
            )
            {
                RevokeUserV3 op = new RevokeUserV3(this,
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<RevokeUserV3Builder>(this);
                return op;
            }

            public RevokeUserV3.Response Execute(
                string namespace_,
                string userId
            )
            {
                RevokeUserV3 op = Build(
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
            public async Task<RevokeUserV3.Response> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                RevokeUserV3 op = Build(
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

        private RevokeUserV3(RevokeUserV3Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.IncludeGameNamespace != null) QueryParams["includeGameNamespace"] = Convert.ToString(builder.IncludeGameNamespace)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public OauthmodelErrorResponse? Error400 { get; set; } = null;

            public OauthmodelErrorResponse? Error401 { get; set; } = null;

            public OauthmodelErrorResponse? Error403 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::OAuth20::RevokeUserV3";
        }

        #endregion

        public RevokeUserV3(
            string namespace_,            
            string userId,            
            bool? includeGameNamespace            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (includeGameNamespace != null) QueryParams["includeGameNamespace"] = Convert.ToString(includeGameNamespace)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/oauth/admin/namespaces/{namespace}/users/{userId}/revoke";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "*/*" };

        public override List<string> Produces => new() { "application/json" };
        
        public RevokeUserV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new RevokeUserV3.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)
            
            {
                response.Error400 = JsonSerializer.Deserialize<OauthmodelErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            
            {
                response.Error401 = JsonSerializer.Deserialize<OauthmodelErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            
            {
                response.Error403 = JsonSerializer.Deserialize<OauthmodelErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }

            return response;
        }
    }

}
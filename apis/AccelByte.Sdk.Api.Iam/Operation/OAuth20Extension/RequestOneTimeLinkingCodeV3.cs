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
    /// RequestOneTimeLinkingCodeV3
    ///
    /// This endpoint is being used to request the one time code [8 length] for headless account to link or upgrade to a full account.
    /// Should specify the target platform id and current user should already linked to this platform.
    /// Current user should be a headless account.
    /// ## Supported platforms:
    /// - **steam**
    /// - **steamopenid**
    /// - **facebook**
    /// - **google**
    /// - **googleplaygames**
    /// - **oculus**
    /// - **twitch**
    /// - **discord**
    /// - **android**
    /// - **ios**
    /// - **apple**
    /// - **device**
    /// - **justice**
    /// - **epicgames**
    /// - **ps4**
    /// - **ps5**
    /// - **nintendo**
    /// - **awscognito**
    /// - **live**
    /// - **xblweb**
    /// - **netflix**
    /// - **snapchat**
    /// </summary>
    public class RequestOneTimeLinkingCodeV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RequestOneTimeLinkingCodeV3Builder Builder { get => new RequestOneTimeLinkingCodeV3Builder(); }

        public class RequestOneTimeLinkingCodeV3Builder
            : OperationBuilder<RequestOneTimeLinkingCodeV3Builder>
        {



            public string? RedirectUri { get; set; }

            public string? State { get; set; }



            internal RequestOneTimeLinkingCodeV3Builder() { }

            internal RequestOneTimeLinkingCodeV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }




            public RequestOneTimeLinkingCodeV3Builder SetRedirectUri(string _redirectUri)
            {
                RedirectUri = _redirectUri;
                return this;
            }

            public RequestOneTimeLinkingCodeV3Builder SetState(string _state)
            {
                State = _state;
                return this;
            }



            public RequestOneTimeLinkingCodeV3 Build(
                string platformId
            )
            {
                RequestOneTimeLinkingCodeV3 op = new RequestOneTimeLinkingCodeV3(this,
                    platformId                    
                );

                op.SetBaseFields<RequestOneTimeLinkingCodeV3Builder>(this);
                return op;
            }

            public RequestOneTimeLinkingCodeV3.Response Execute(
                string platformId
            )
            {
                RequestOneTimeLinkingCodeV3 op = Build(
                    platformId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<RequestOneTimeLinkingCodeV3.Response> ExecuteAsync(
                string platformId
            )
            {
                RequestOneTimeLinkingCodeV3 op = Build(
                    platformId
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

        private RequestOneTimeLinkingCodeV3(RequestOneTimeLinkingCodeV3Builder builder,
            string platformId
        )
        {
            
            
            if (builder.RedirectUri is not null) FormParams["redirectUri"] = builder.RedirectUri;
            if (builder.State is not null) FormParams["state"] = builder.State;
            if (platformId is not null) FormParams["platformId"] = platformId;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.OauthmodelOneTimeLinkingCodeResponse>
        {


            protected override string GetFullOperationId() => "Iam::OAuth20Extension::RequestOneTimeLinkingCodeV3";
        }

        #endregion

        public RequestOneTimeLinkingCodeV3(
            string? redirectUri,            
            string? state,            
            string platformId            
        )
        {
            
            
            if (redirectUri is not null) FormParams["redirectUri"] = redirectUri;
            if (state is not null) FormParams["state"] = state;
            if (platformId is not null) FormParams["platformId"] = platformId;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/link/code/request";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

        public override List<string> Produces => new() { "application/json" };
        
        public RequestOneTimeLinkingCodeV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new RequestOneTimeLinkingCodeV3.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.OauthmodelOneTimeLinkingCodeResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}
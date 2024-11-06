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
    /// AddSSOLoginPlatformCredential
    ///
    /// This is the API to Add SSO Platform Credential.
    /// ## Supported platforms:
    /// - **discourse**
    /// the ssoUrl of the discourse is the discourse forum url. example: https://forum.example.com
    /// - **azure with SAML**
    /// **appId** is an application identifier in IdP, in azure it's called EntityID
    /// **acsUrl** is an endpoint on the service provider where the identity provider will redirect to with its authentication response. example: /iam/v3/sso/saml/azuresaml/authenticate
    /// **federationMetadataUrl** is an endpoint on the Identity Provider(IdP) to get IdP federation metadata for service provider to build trust relationship
    /// </summary>
    public class AddSSOLoginPlatformCredential : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AddSSOLoginPlatformCredentialBuilder Builder { get => new AddSSOLoginPlatformCredentialBuilder(); }

        public class AddSSOLoginPlatformCredentialBuilder
            : OperationBuilder<AddSSOLoginPlatformCredentialBuilder>
        {





            internal AddSSOLoginPlatformCredentialBuilder() { }

            internal AddSSOLoginPlatformCredentialBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AddSSOLoginPlatformCredential Build(
                ModelSSOPlatformCredentialRequest body,
                string namespace_,
                string platformId
            )
            {
                AddSSOLoginPlatformCredential op = new AddSSOLoginPlatformCredential(this,
                    body,                    
                    namespace_,                    
                    platformId                    
                );

                op.SetBaseFields<AddSSOLoginPlatformCredentialBuilder>(this);
                return op;
            }

            public AddSSOLoginPlatformCredential.Response Execute(
                ModelSSOPlatformCredentialRequest body,
                string namespace_,
                string platformId
            )
            {
                AddSSOLoginPlatformCredential op = Build(
                    body,
                    namespace_,
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
            public async Task<AddSSOLoginPlatformCredential.Response> ExecuteAsync(
                ModelSSOPlatformCredentialRequest body,
                string namespace_,
                string platformId
            )
            {
                AddSSOLoginPlatformCredential op = Build(
                    body,
                    namespace_,
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

        private AddSSOLoginPlatformCredential(AddSSOLoginPlatformCredentialBuilder builder,
            ModelSSOPlatformCredentialRequest body,
            string namespace_,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelSSOPlatformCredentialResponse>
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::SSOCredential::AddSSOLoginPlatformCredential";
        }

        #endregion

        public AddSSOLoginPlatformCredential(
            string namespace_,            
            string platformId,            
            Model.ModelSSOPlatformCredentialRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/sso";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AddSSOLoginPlatformCredential.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AddSSOLoginPlatformCredential.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelSSOPlatformCredentialResponse>(payload, ResponseJsonOptions);
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
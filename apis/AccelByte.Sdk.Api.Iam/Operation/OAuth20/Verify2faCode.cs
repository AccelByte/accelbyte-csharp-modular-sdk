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
    /// Verify2FACode
    ///
    /// Verify 2FA code
    /// This endpoint is used for verifying 2FA code.
    /// ## 2FA remember device
    /// To remember device for 2FA, should provide cookie: device_token or header: Device-Token
    /// </summary>
    public class Verify2faCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static Verify2faCodeBuilder Builder { get => new Verify2faCodeBuilder(); }

        public class Verify2faCodeBuilder
            : OperationBuilder<Verify2faCodeBuilder>
        {





            internal Verify2faCodeBuilder() { }

            internal Verify2faCodeBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public Verify2faCode Build(
                string code,
                string factor,
                string mfaToken,
                bool rememberDevice
            )
            {
                Verify2faCode op = new Verify2faCode(this,
                    code,                    
                    factor,                    
                    mfaToken,                    
                    rememberDevice                    
                );

                op.SetBaseFields<Verify2faCodeBuilder>(this);
                return op;
            }

            public Verify2faCode.Response Execute(
                string code,
                string factor,
                string mfaToken,
                bool rememberDevice
            )
            {
                Verify2faCode op = Build(
                    code,
                    factor,
                    mfaToken,
                    rememberDevice
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Verify2faCode.Response> ExecuteAsync(
                string code,
                string factor,
                string mfaToken,
                bool rememberDevice
            )
            {
                Verify2faCode op = Build(
                    code,
                    factor,
                    mfaToken,
                    rememberDevice
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

        private Verify2faCode(Verify2faCodeBuilder builder,
            string code,
            string factor,
            string mfaToken,
            bool rememberDevice
        )
        {
            
            
            if (code is not null) FormParams["code"] = code;
            if (factor is not null) FormParams["factor"] = factor;
            if (mfaToken is not null) FormParams["mfaToken"] = mfaToken;
            FormParams["rememberDevice"] = Convert.ToString(rememberDevice)!;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.OauthmodelTokenResponseV3>
        {

            public OauthmodelErrorResponse? Error401 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::OAuth20::Verify2faCode";
        }

        #endregion

        public Verify2faCode(
            string code,            
            string factor,            
            string mfaToken,            
            bool rememberDevice            
        )
        {
            
            
            if (code is not null) FormParams["code"] = code;
            if (factor is not null) FormParams["factor"] = factor;
            if (mfaToken is not null) FormParams["mfaToken"] = mfaToken;
            FormParams["rememberDevice"] = Convert.ToString(rememberDevice)!;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/oauth/mfa/verify";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

        public override List<string> Produces => new() { "application/json" };
        
        public Verify2faCode.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new Verify2faCode.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.OauthmodelTokenResponseV3>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<OauthmodelErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }

            return response;
        }
    }

}
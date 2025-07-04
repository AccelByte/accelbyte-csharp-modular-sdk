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
    /// Change2FAMethod
    ///
    /// Change 2FA method
    /// This endpoint is used for change 2FA method. Only enabled methods are accepted.
    /// Supported methods:
    /// - authenticator
    /// - backupCode
    /// - email
    /// </summary>
    public class Change2faMethod : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static Change2faMethodBuilder Builder { get => new Change2faMethodBuilder(); }

        public class Change2faMethodBuilder
            : OperationBuilder<Change2faMethodBuilder>
        {





            internal Change2faMethodBuilder() { }

            internal Change2faMethodBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public Change2faMethod Build(
                string factor,
                string mfaToken
            )
            {
                Change2faMethod op = new Change2faMethod(this,
                    factor,                    
                    mfaToken                    
                );

                op.SetBaseFields<Change2faMethodBuilder>(this);
                return op;
            }

            public Change2faMethod.Response Execute(
                string factor,
                string mfaToken
            )
            {
                Change2faMethod op = Build(
                    factor,
                    mfaToken
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Change2faMethod.Response> ExecuteAsync(
                string factor,
                string mfaToken
            )
            {
                Change2faMethod op = Build(
                    factor,
                    mfaToken
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

        private Change2faMethod(Change2faMethodBuilder builder,
            string factor,
            string mfaToken
        )
        {
            
            
            if (factor is not null) FormParams["factor"] = factor;
            if (mfaToken is not null) FormParams["mfaToken"] = mfaToken;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error429 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::OAuth20::Change2faMethod";
        }

        #endregion

        public Change2faMethod(
            string factor,            
            string mfaToken            
        )
        {
            
            
            if (factor is not null) FormParams["factor"] = factor;
            if (mfaToken is not null) FormParams["mfaToken"] = mfaToken;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/oauth/mfa/factor/change";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

        public override List<string> Produces => new() { "application/json" };
        
        public Change2faMethod.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new Change2faMethod.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)
            
            {
                response.Error400 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)429)
            
            {
                response.Error429 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error429!.TranslateToApiError();
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
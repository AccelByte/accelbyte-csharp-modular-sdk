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

using AccelByte.Sdk.Api.Legal.Model;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// changePreferenceConsent
    ///
    /// This API will Update Preference Consent
    /// </summary>
    public class ChangePreferenceConsent : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ChangePreferenceConsentBuilder Builder { get => new ChangePreferenceConsentBuilder(); }

        public class ChangePreferenceConsentBuilder
            : OperationBuilder<ChangePreferenceConsentBuilder>
        {


            public List<Model.AcceptAgreementRequest>? Body { get; set; }




            internal ChangePreferenceConsentBuilder() { }

            internal ChangePreferenceConsentBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public ChangePreferenceConsentBuilder SetBody(List<Model.AcceptAgreementRequest> _body)
            {
                Body = _body;
                return this;
            }




            public ChangePreferenceConsent Build(
                string namespace_,
                string userId
            )
            {
                ChangePreferenceConsent op = new ChangePreferenceConsent(this,
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<ChangePreferenceConsentBuilder>(this);
                return op;
            }

            public ChangePreferenceConsent.Response Execute(
                string namespace_,
                string userId
            )
            {
                ChangePreferenceConsent op = Build(
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
            public async Task<ChangePreferenceConsent.Response> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                ChangePreferenceConsent op = Build(
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

        private ChangePreferenceConsent(ChangePreferenceConsentBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Legal::Agreement::ChangePreferenceConsent";
        }

        #endregion

        public ChangePreferenceConsent(
            string namespace_,            
            string userId,            
            List<Model.AcceptAgreementRequest> body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/agreements/localized-policy-versions/preferences/namespaces/{namespace}/userId/{userId}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public ChangePreferenceConsent.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new ChangePreferenceConsent.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)404)
            
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }

            return response;
        }
    }

}
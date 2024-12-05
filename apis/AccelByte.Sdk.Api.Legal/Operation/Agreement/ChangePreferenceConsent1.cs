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
    /// changePreferenceConsent_1
    ///
    /// Change marketing preference consent.
    /// </summary>
    public class ChangePreferenceConsent1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ChangePreferenceConsent1Builder Builder { get => new ChangePreferenceConsent1Builder(); }

        public class ChangePreferenceConsent1Builder
            : OperationBuilder<ChangePreferenceConsent1Builder>
        {


            public List<Model.AcceptAgreementRequest>? Body { get; set; }




            internal ChangePreferenceConsent1Builder() { }

            internal ChangePreferenceConsent1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public ChangePreferenceConsent1Builder SetBody(List<Model.AcceptAgreementRequest> _body)
            {
                Body = _body;
                return this;
            }




            public ChangePreferenceConsent1 Build(
            )
            {
                ChangePreferenceConsent1 op = new ChangePreferenceConsent1(this
                );

                op.SetBaseFields<ChangePreferenceConsent1Builder>(this);
                return op;
            }

            public ChangePreferenceConsent1.Response Execute(
            )
            {
                ChangePreferenceConsent1 op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<ChangePreferenceConsent1.Response> ExecuteAsync(
            )
            {
                ChangePreferenceConsent1 op = Build(
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

        private ChangePreferenceConsent1(ChangePreferenceConsent1Builder builder
        )
        {





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ErrorEntity? Error400 { get; set; } = null;


            protected override string GetFullOperationId() => "Legal::Agreement::ChangePreferenceConsent1";
        }

        #endregion

        public ChangePreferenceConsent1(
            List<Model.AcceptAgreementRequest> body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/public/agreements/localized-policy-versions/preferences";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public ChangePreferenceConsent1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new ChangePreferenceConsent1.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)

            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }

            return response;
        }
    }

}
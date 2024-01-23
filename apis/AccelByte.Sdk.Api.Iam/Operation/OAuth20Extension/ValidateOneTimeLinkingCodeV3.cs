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
    /// ValidateOneTimeLinkingCodeV3
    ///
    /// This endpoint is being used to validate one time link code.
    /// </summary>
    public class ValidateOneTimeLinkingCodeV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ValidateOneTimeLinkingCodeV3Builder Builder { get => new ValidateOneTimeLinkingCodeV3Builder(); }

        public class ValidateOneTimeLinkingCodeV3Builder
            : OperationBuilder<ValidateOneTimeLinkingCodeV3Builder>
        {





            internal ValidateOneTimeLinkingCodeV3Builder() { }

            internal ValidateOneTimeLinkingCodeV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public ValidateOneTimeLinkingCodeV3 Build(
                string oneTimeLinkCode
            )
            {
                ValidateOneTimeLinkingCodeV3 op = new ValidateOneTimeLinkingCodeV3(this,
                    oneTimeLinkCode
                );

                op.SetBaseFields<ValidateOneTimeLinkingCodeV3Builder>(this);
                return op;
            }

            public Model.OauthmodelOneTimeLinkingCodeValidationResponse? Execute(
                string oneTimeLinkCode
            )
            {
                ValidateOneTimeLinkingCodeV3 op = Build(
                    oneTimeLinkCode
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

        private ValidateOneTimeLinkingCodeV3(ValidateOneTimeLinkingCodeV3Builder builder,
            string oneTimeLinkCode
        )
        {


            if (oneTimeLinkCode is not null) FormParams["oneTimeLinkCode"] = oneTimeLinkCode;





        }
        #endregion

        public ValidateOneTimeLinkingCodeV3(
            string oneTimeLinkCode
        )
        {


            if (oneTimeLinkCode is not null) FormParams["oneTimeLinkCode"] = oneTimeLinkCode;





        }

        public override string Path => "/iam/v3/link/code/validate";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

        public override List<string> Produces => new() { "application/json" };

        public Model.OauthmodelOneTimeLinkingCodeValidationResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelOneTimeLinkingCodeValidationResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelOneTimeLinkingCodeValidationResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
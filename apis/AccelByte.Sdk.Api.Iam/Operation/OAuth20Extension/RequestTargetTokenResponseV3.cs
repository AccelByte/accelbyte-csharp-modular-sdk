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
    /// RequestTargetTokenResponseV3
    ///
    /// This endpoint is being used to generate target token.
    /// It requires basic header with ClientID and Secret, it should match the ClientID when call `/iam/v3/namespace/{namespace}/token/request`
    /// The code should be generated from `/iam/v3/namespace/{namespace}/token/request`.
    /// </summary>
    public class RequestTargetTokenResponseV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RequestTargetTokenResponseV3Builder Builder { get => new RequestTargetTokenResponseV3Builder(); }

        public class RequestTargetTokenResponseV3Builder
            : OperationBuilder<RequestTargetTokenResponseV3Builder>
        {



            public string? AdditionalData { get; set; }



            internal RequestTargetTokenResponseV3Builder() { }

            internal RequestTargetTokenResponseV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }




            public RequestTargetTokenResponseV3Builder SetAdditionalData(string _additionalData)
            {
                AdditionalData = _additionalData;
                return this;
            }



            public RequestTargetTokenResponseV3 Build(
                string code
            )
            {
                RequestTargetTokenResponseV3 op = new RequestTargetTokenResponseV3(this,
                    code
                );

                op.SetBaseFields<RequestTargetTokenResponseV3Builder>(this);
                return op;
            }

            public Model.OauthmodelTokenResponseV3? Execute(
                string code
            )
            {
                RequestTargetTokenResponseV3 op = Build(
                    code
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

        private RequestTargetTokenResponseV3(RequestTargetTokenResponseV3Builder builder,
            string code
        )
        {


            if (builder.AdditionalData is not null) FormParams["additionalData"] = builder.AdditionalData;
            if (code is not null) FormParams["code"] = code;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RequestTargetTokenResponseV3(
            string? additionalData,
            string code
        )
        {


            if (additionalData is not null) FormParams["additionalData"] = additionalData;
            if (code is not null) FormParams["code"] = code;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/token/exchange";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

        public override List<string> Produces => new() { "application/json" };

        public Model.OauthmodelTokenResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenResponseV3>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenResponseV3>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
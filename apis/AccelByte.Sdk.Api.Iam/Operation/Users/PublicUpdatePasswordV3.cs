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
    /// PublicUpdatePasswordV3
    ///
    /// action code: 10107
    /// </summary>
    public class PublicUpdatePasswordV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpdatePasswordV3Builder Builder { get => new PublicUpdatePasswordV3Builder(); }

        public class PublicUpdatePasswordV3Builder
            : OperationBuilder<PublicUpdatePasswordV3Builder>
        {





            internal PublicUpdatePasswordV3Builder() { }

            internal PublicUpdatePasswordV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicUpdatePasswordV3 Build(
                ModelUserPasswordUpdateV3Request body,
                string namespace_
            )
            {
                PublicUpdatePasswordV3 op = new PublicUpdatePasswordV3(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                ModelUserPasswordUpdateV3Request body,
                string namespace_
            )
            {
                PublicUpdatePasswordV3 op = Build(
                    body,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private PublicUpdatePasswordV3(PublicUpdatePasswordV3Builder builder,
            ModelUserPasswordUpdateV3Request body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicUpdatePasswordV3(
            string namespace_,
            Model.ModelUserPasswordUpdateV3Request body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/me/password";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
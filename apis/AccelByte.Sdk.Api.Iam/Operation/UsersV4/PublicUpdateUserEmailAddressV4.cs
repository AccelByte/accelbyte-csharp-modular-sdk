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
    /// PublicUpdateUserEmailAddressV4
    ///
    /// 
    /// 
    /// The endpoint to update my email address.
    /// 
    /// 
    /// 
    /// 
    /// It requires a verification code from /users/me/code/request with UpdateEmailAddress context.
    /// </summary>
    public class PublicUpdateUserEmailAddressV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpdateUserEmailAddressV4Builder Builder { get => new PublicUpdateUserEmailAddressV4Builder(); }

        public class PublicUpdateUserEmailAddressV4Builder
            : OperationBuilder<PublicUpdateUserEmailAddressV4Builder>
        {





            internal PublicUpdateUserEmailAddressV4Builder() { }

            internal PublicUpdateUserEmailAddressV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicUpdateUserEmailAddressV4 Build(
                ModelEmailUpdateRequestV4 body,
                string namespace_
            )
            {
                PublicUpdateUserEmailAddressV4 op = new PublicUpdateUserEmailAddressV4(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                ModelEmailUpdateRequestV4 body,
                string namespace_
            )
            {
                PublicUpdateUserEmailAddressV4 op = Build(
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

        private PublicUpdateUserEmailAddressV4(PublicUpdateUserEmailAddressV4Builder builder,
            ModelEmailUpdateRequestV4 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicUpdateUserEmailAddressV4(
            string namespace_,
            Model.ModelEmailUpdateRequestV4 body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/public/namespaces/{namespace}/users/me/email";

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
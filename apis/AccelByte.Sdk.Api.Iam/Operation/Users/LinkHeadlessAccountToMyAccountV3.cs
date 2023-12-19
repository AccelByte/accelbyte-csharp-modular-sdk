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
    /// LinkHeadlessAccountToMyAccountV3
    ///
    /// Note:
    /// 1. My account should be full account
    /// 2. My account not linked to headless account's third platform.
    /// </summary>
    public class LinkHeadlessAccountToMyAccountV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static LinkHeadlessAccountToMyAccountV3Builder Builder { get => new LinkHeadlessAccountToMyAccountV3Builder(); }

        public class LinkHeadlessAccountToMyAccountV3Builder
            : OperationBuilder<LinkHeadlessAccountToMyAccountV3Builder>
        {





            internal LinkHeadlessAccountToMyAccountV3Builder() { }

            internal LinkHeadlessAccountToMyAccountV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public LinkHeadlessAccountToMyAccountV3 Build(
                ModelLinkHeadlessAccountRequest body
            )
            {
                LinkHeadlessAccountToMyAccountV3 op = new LinkHeadlessAccountToMyAccountV3(this,
                    body
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                ModelLinkHeadlessAccountRequest body
            )
            {
                LinkHeadlessAccountToMyAccountV3 op = Build(
                    body
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

        private LinkHeadlessAccountToMyAccountV3(LinkHeadlessAccountToMyAccountV3Builder builder,
            ModelLinkHeadlessAccountRequest body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public LinkHeadlessAccountToMyAccountV3(
            Model.ModelLinkHeadlessAccountRequest body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/users/me/headless/linkWithProgression";

        public override HttpMethod Method => HttpMethod.Post;

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
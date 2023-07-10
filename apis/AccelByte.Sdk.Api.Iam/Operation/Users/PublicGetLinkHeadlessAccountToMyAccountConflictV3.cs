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
    /// PublicGetLinkHeadlessAccountToMyAccountConflictV3
    ///
    /// Note:
    /// 
    /// 1. My account should be full account
    /// 2. My account not linked to request headless account's third platform.
    /// 
    /// After client resolving the conflict, it will call endpoint /iam/v3/public/users/me/headless/linkWithProgression [POST]
    /// </summary>
    public class PublicGetLinkHeadlessAccountToMyAccountConflictV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetLinkHeadlessAccountToMyAccountConflictV3Builder Builder { get => new PublicGetLinkHeadlessAccountToMyAccountConflictV3Builder(); }

        public class PublicGetLinkHeadlessAccountToMyAccountConflictV3Builder
            : OperationBuilder<PublicGetLinkHeadlessAccountToMyAccountConflictV3Builder>
        {





            internal PublicGetLinkHeadlessAccountToMyAccountConflictV3Builder() { }

            internal PublicGetLinkHeadlessAccountToMyAccountConflictV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetLinkHeadlessAccountToMyAccountConflictV3 Build(
                string oneTimeLinkCode
            )
            {
                PublicGetLinkHeadlessAccountToMyAccountConflictV3 op = new PublicGetLinkHeadlessAccountToMyAccountConflictV3(this,
                    oneTimeLinkCode
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelGetLinkHeadlessAccountConflictResponse? Execute(
                string oneTimeLinkCode
            )
            {
                PublicGetLinkHeadlessAccountToMyAccountConflictV3 op = Build(
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

        private PublicGetLinkHeadlessAccountToMyAccountConflictV3(PublicGetLinkHeadlessAccountToMyAccountConflictV3Builder builder,
            string oneTimeLinkCode
        )
        {

            if (oneTimeLinkCode is not null) QueryParams["oneTimeLinkCode"] = oneTimeLinkCode;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetLinkHeadlessAccountToMyAccountConflictV3(
            string oneTimeLinkCode
        )
        {

            if (oneTimeLinkCode is not null) QueryParams["oneTimeLinkCode"] = oneTimeLinkCode;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/users/me/headless/link/conflict";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelGetLinkHeadlessAccountConflictResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelGetLinkHeadlessAccountConflictResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelGetLinkHeadlessAccountConflictResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
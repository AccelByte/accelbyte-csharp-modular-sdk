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

using AccelByte.Sdk.Api.Session.Model;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// publicPartyLeave
    ///
    /// Leave a party
    /// </summary>
    public class PublicPartyLeave : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicPartyLeaveBuilder Builder { get => new PublicPartyLeaveBuilder(); }

        public class PublicPartyLeaveBuilder
            : OperationBuilder<PublicPartyLeaveBuilder>
        {





            internal PublicPartyLeaveBuilder() { }

            internal PublicPartyLeaveBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicPartyLeave Build(
                string namespace_,
                string partyId
            )
            {
                PublicPartyLeave op = new PublicPartyLeave(this,
                    namespace_,
                    partyId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public void Execute(
                string namespace_,
                string partyId
            )
            {
                PublicPartyLeave op = Build(
                    namespace_,
                    partyId
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

        private PublicPartyLeave(PublicPartyLeaveBuilder builder,
            string namespace_,
            string partyId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicPartyLeave(
            string namespace_,
            string partyId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/parties/{partyId}/users/me/leave";

        public override HttpMethod Method => HttpMethod.Delete;

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
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
    /// publicGameSessionReject
    ///
    /// Reject a game session invitation.
    /// </summary>
    public class PublicGameSessionReject : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGameSessionRejectBuilder Builder { get => new PublicGameSessionRejectBuilder(); }

        public class PublicGameSessionRejectBuilder
            : OperationBuilder<PublicGameSessionRejectBuilder>
        {





            internal PublicGameSessionRejectBuilder() { }

            internal PublicGameSessionRejectBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGameSessionReject Build(
                string namespace_,
                string sessionId
            )
            {
                PublicGameSessionReject op = new PublicGameSessionReject(this,
                    namespace_,
                    sessionId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string namespace_,
                string sessionId
            )
            {
                PublicGameSessionReject op = Build(
                    namespace_,
                    sessionId
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

        private PublicGameSessionReject(PublicGameSessionRejectBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGameSessionReject(
            string namespace_,
            string sessionId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/reject";

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
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

using AccelByte.Sdk.Api.Legal.Model;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// retrieveAgreementsPublic
    ///
    /// Retrieve accepted Legal Agreements.
    /// Other detail info:
    /// 
    ///   * Required permission : login user
    /// </summary>
    public class RetrieveAgreementsPublic : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveAgreementsPublicBuilder Builder { get => new RetrieveAgreementsPublicBuilder(); }

        public class RetrieveAgreementsPublicBuilder
            : OperationBuilder<RetrieveAgreementsPublicBuilder>
        {





            internal RetrieveAgreementsPublicBuilder() { }

            internal RetrieveAgreementsPublicBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public RetrieveAgreementsPublic Build(
            )
            {
                RetrieveAgreementsPublic op = new RetrieveAgreementsPublic(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public List<Model.RetrieveAcceptedAgreementResponse>? Execute(
            )
            {
                RetrieveAgreementsPublic op = Build(
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

        private RetrieveAgreementsPublic(RetrieveAgreementsPublicBuilder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RetrieveAgreementsPublic(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/public/agreements/policies";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.RetrieveAcceptedAgreementResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.RetrieveAcceptedAgreementResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.RetrieveAcceptedAgreementResponse>>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
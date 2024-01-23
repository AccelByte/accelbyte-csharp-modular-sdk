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
    /// acceptVersionedPolicy
    ///
    /// Accepts a legal policy version. Supply with localized version policy id to accept an agreement.
    /// Other detail info:
    /// 
    ///   * Required permission : login user
    /// </summary>
    public class AcceptVersionedPolicy : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AcceptVersionedPolicyBuilder Builder { get => new AcceptVersionedPolicyBuilder(); }

        public class AcceptVersionedPolicyBuilder
            : OperationBuilder<AcceptVersionedPolicyBuilder>
        {





            internal AcceptVersionedPolicyBuilder() { }

            internal AcceptVersionedPolicyBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AcceptVersionedPolicy Build(
                string localizedPolicyVersionId
            )
            {
                AcceptVersionedPolicy op = new AcceptVersionedPolicy(this,
                    localizedPolicyVersionId
                );

                op.SetBaseFields<AcceptVersionedPolicyBuilder>(this);
                return op;
            }

            public void Execute(
                string localizedPolicyVersionId
            )
            {
                AcceptVersionedPolicy op = Build(
                    localizedPolicyVersionId
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

        private AcceptVersionedPolicy(AcceptVersionedPolicyBuilder builder,
            string localizedPolicyVersionId
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AcceptVersionedPolicy(
            string localizedPolicyVersionId
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/public/agreements/localized-policy-versions/{localizedPolicyVersionId}";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
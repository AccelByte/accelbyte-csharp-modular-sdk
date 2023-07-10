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

using AccelByte.Sdk.Api.Match2.Model;

namespace AccelByte.Sdk.Api.Match2.Operation
{
    /// <summary>
    /// RejectBackfill
    ///
    /// Required Permission: NAMESPACE:{namespace}:MATCHMAKING:BACKFILL [UPDATE]
    /// 
    /// Required Scope: social
    /// 
    /// Reject backfill proposal
    /// </summary>
    public class RejectBackfill : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RejectBackfillBuilder Builder { get => new RejectBackfillBuilder(); }

        public class RejectBackfillBuilder
            : OperationBuilder<RejectBackfillBuilder>
        {





            internal RejectBackfillBuilder() { }

            internal RejectBackfillBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public RejectBackfill Build(
                ApiBackFillRejectRequest body,
                string backfillID,
                string namespace_
            )
            {
                RejectBackfill op = new RejectBackfill(this,
                    body,
                    backfillID,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                ApiBackFillRejectRequest body,
                string backfillID,
                string namespace_
            )
            {
                RejectBackfill op = Build(
                    body,
                    backfillID,
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

        private RejectBackfill(RejectBackfillBuilder builder,
            ApiBackFillRejectRequest body,
            string backfillID,
            string namespace_
        )
        {
            PathParams["backfillID"] = backfillID;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RejectBackfill(
            string backfillID,
            string namespace_,
            Model.ApiBackFillRejectRequest body
        )
        {
            PathParams["backfillID"] = backfillID;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/namespaces/{namespace}/backfill/{backfillID}/proposal/reject";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
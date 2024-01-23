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
    /// CreateMatchPool
    ///
    /// Creates a new matchmaking pool.
    /// 
    /// A pool is isolated from other pools (i.e. tickets may be matched with other tickets in the same pool, but not with tickets in other pools).
    /// Each pool has its own matchmaking rules and/or logic.
    /// 
    /// ticket_expiration_seconds and backfill_ticket_expiration_seconds will be set to 300 seconds (5 minutes) by default if not filled.
    /// 
    /// Match Function holds information about the name of the match logic server that matchmaking can refers to. By default we provide ("default" and "basic").
    /// Match Function will be used as reference value for Match Function Overrides if not set.
    /// In case Customer would like to use matchmaking service default match logic, then specify it in "match_function_overrides".
    /// This sample configuration will let matchmaking service will use "default" match logic for make matches, while validation will hit both "default" and "custom" match logics.
    /// e.g.
    /// {
    /// "match_function": "custom",
    /// "match_function_overrides": {
    /// "validation": []{"default","custom"},
    /// "make_matches": "default",
    /// }
    /// }
    /// </summary>
    public class CreateMatchPool : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateMatchPoolBuilder Builder { get => new CreateMatchPoolBuilder(); }

        public class CreateMatchPoolBuilder
            : OperationBuilder<CreateMatchPoolBuilder>
        {





            internal CreateMatchPoolBuilder() { }

            internal CreateMatchPoolBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateMatchPool Build(
                ApiMatchPool body,
                string namespace_
            )
            {
                CreateMatchPool op = new CreateMatchPool(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<CreateMatchPoolBuilder>(this);
                return op;
            }

            public void Execute(
                ApiMatchPool body,
                string namespace_
            )
            {
                CreateMatchPool op = Build(
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

        private CreateMatchPool(CreateMatchPoolBuilder builder,
            ApiMatchPool body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateMatchPool(
            string namespace_,
            Model.ApiMatchPool body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/namespaces/{namespace}/match-pools";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

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
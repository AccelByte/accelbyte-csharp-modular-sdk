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
    /// DeleteMatchPool
    ///
    /// Required Permission: NAMESPACE:{namespace}:MATCHMAKING:POOL [DELETE]
    /// 
    /// Required Scope: social
    /// 
    /// Deletes an existing matchmaking pool.
    /// </summary>
    public class DeleteMatchPool : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteMatchPoolBuilder Builder { get => new DeleteMatchPoolBuilder(); }

        public class DeleteMatchPoolBuilder
            : OperationBuilder<DeleteMatchPoolBuilder>
        {





            internal DeleteMatchPoolBuilder() { }

            internal DeleteMatchPoolBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteMatchPool Build(
                string namespace_,
                string pool
            )
            {
                DeleteMatchPool op = new DeleteMatchPool(this,
                    namespace_,
                    pool
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public void Execute(
                string namespace_,
                string pool
            )
            {
                DeleteMatchPool op = Build(
                    namespace_,
                    pool
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

        private DeleteMatchPool(DeleteMatchPoolBuilder builder,
            string namespace_,
            string pool
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["pool"] = pool;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteMatchPool(
            string namespace_,
            string pool
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["pool"] = pool;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/namespaces/{namespace}/match-pools/{pool}";

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
// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
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
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Seasonpass.Model;

namespace AccelByte.Sdk.Api.Seasonpass.Operation
{
    /// <summary>
    /// deleteTier
    ///
    /// This API is used to delete a tier permanently, only draft season pass can be deleted.
    /// </summary>
    public class DeleteTier : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteTierBuilder Builder { get => new DeleteTierBuilder(); }

        public class DeleteTierBuilder
            : OperationBuilder<DeleteTierBuilder>
        {





            internal DeleteTierBuilder() { }

            internal DeleteTierBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteTier Build(
                string id,
                string namespace_,
                string seasonId
            )
            {
                DeleteTier op = new DeleteTier(this,
                    id,
                    namespace_,
                    seasonId
                );

                op.SetBaseFields<DeleteTierBuilder>(this);
                return op;
            }

            public void Execute(
                string id,
                string namespace_,
                string seasonId
            )
            {
                DeleteTier op = Build(
                    id,
                    namespace_,
                    seasonId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task ExecuteAsync(
                string id,
                string namespace_,
                string seasonId
            )
            {
                DeleteTier op = Build(
                    id,
                    namespace_,
                    seasonId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private DeleteTier(DeleteTierBuilder builder,
            string id,
            string namespace_,
            string seasonId
        )
        {
            PathParams["id"] = id;
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteTier(
            string id,
            string namespace_,
            string seasonId
        )
        {
            PathParams["id"] = id;
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/tiers/{id}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { };

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
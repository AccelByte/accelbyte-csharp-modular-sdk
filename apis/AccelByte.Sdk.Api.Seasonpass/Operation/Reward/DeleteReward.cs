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

using AccelByte.Sdk.Api.Seasonpass.Model;

namespace AccelByte.Sdk.Api.Seasonpass.Operation
{
    /// <summary>
    /// deleteReward
    ///
    /// This API is used to delete a reward permanently, only draft season reward can be deleted.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:SEASONPASS", action=8 (DELETE)
    /// </summary>
    public class DeleteReward : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteRewardBuilder Builder { get => new DeleteRewardBuilder(); }

        public class DeleteRewardBuilder
            : OperationBuilder<DeleteRewardBuilder>
        {





            internal DeleteRewardBuilder() { }

            internal DeleteRewardBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteReward Build(
                string code,
                string namespace_,
                string seasonId
            )
            {
                DeleteReward op = new DeleteReward(this,
                    code,
                    namespace_,
                    seasonId
                );

                op.SetBaseFields<DeleteRewardBuilder>(this);
                return op;
            }

            public void Execute(
                string code,
                string namespace_,
                string seasonId
            )
            {
                DeleteReward op = Build(
                    code,
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
        }

        private DeleteReward(DeleteRewardBuilder builder,
            string code,
            string namespace_,
            string seasonId
        )
        {
            PathParams["code"] = code;
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteReward(
            string code,
            string namespace_,
            string seasonId
        )
        {
            PathParams["code"] = code;
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/rewards/{code}";

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
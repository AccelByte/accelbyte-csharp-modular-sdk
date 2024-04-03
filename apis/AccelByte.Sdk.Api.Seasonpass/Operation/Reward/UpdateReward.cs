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
    /// updateReward
    ///
    /// This API is used to update a reward. Only draft season reward can be updated.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:SEASONPASS", action=4 (UPDATE)
    ///   *  Returns : updated reward
    /// </summary>
    public class UpdateReward : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateRewardBuilder Builder { get => new UpdateRewardBuilder(); }

        public class UpdateRewardBuilder
            : OperationBuilder<UpdateRewardBuilder>
        {


            public Model.RewardUpdate? Body { get; set; }




            internal UpdateRewardBuilder() { }

            internal UpdateRewardBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdateRewardBuilder SetBody(Model.RewardUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdateReward Build(
                string code,
                string namespace_,
                string seasonId
            )
            {
                UpdateReward op = new UpdateReward(this,
                    code,
                    namespace_,
                    seasonId
                );

                op.SetBaseFields<UpdateRewardBuilder>(this);
                return op;
            }

            public Model.RewardInfo? Execute(
                string code,
                string namespace_,
                string seasonId
            )
            {
                UpdateReward op = Build(
                    code,
                    namespace_,
                    seasonId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.RewardInfo?> ExecuteAsync(
                string code,
                string namespace_,
                string seasonId
            )
            {
                UpdateReward op = Build(
                    code,
                    namespace_,
                    seasonId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private UpdateReward(UpdateRewardBuilder builder,
            string code,
            string namespace_,
            string seasonId
        )
        {
            PathParams["code"] = code;
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateReward(
            string code,
            string namespace_,
            string seasonId,
            Model.RewardUpdate body
        )
        {
            PathParams["code"] = code;
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/rewards/{code}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.RewardInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.RewardInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RewardInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
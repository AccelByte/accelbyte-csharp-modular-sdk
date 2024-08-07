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
    /// createTier
    ///
    /// This API is used to create tier for a draft season, can create multiple tiers at same time.
    /// </summary>
    public class CreateTier : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateTierBuilder Builder { get => new CreateTierBuilder(); }

        public class CreateTierBuilder
            : OperationBuilder<CreateTierBuilder>
        {


            public Model.TierCreate? Body { get; set; }




            internal CreateTierBuilder() { }

            internal CreateTierBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public CreateTierBuilder SetBody(Model.TierCreate _body)
            {
                Body = _body;
                return this;
            }




            public CreateTier Build(
                string namespace_,
                string seasonId
            )
            {
                CreateTier op = new CreateTier(this,
                    namespace_,
                    seasonId
                );

                op.SetBaseFields<CreateTierBuilder>(this);
                return op;
            }

            public List<Model.Tier>? Execute(
                string namespace_,
                string seasonId
            )
            {
                CreateTier op = Build(
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
            public async Task<List<Model.Tier>?> ExecuteAsync(
                string namespace_,
                string seasonId
            )
            {
                CreateTier op = Build(
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

        private CreateTier(CreateTierBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateTier(
            string namespace_,
            string seasonId,
            Model.TierCreate body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/tiers";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.Tier>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.Tier>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.Tier>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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

using AccelByte.Sdk.Api.Social.Model;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// incUserStatItemValue
    ///
    /// Update user's statitem value.
    /// Other detail info:
    ///             *  Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:STATITEM", action=4 (UPDATE)
    ///             *  Returns : updated user's statItem
    /// </summary>
    public class IncUserStatItemValue : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static IncUserStatItemValueBuilder Builder { get => new IncUserStatItemValueBuilder(); }

        public class IncUserStatItemValueBuilder
            : OperationBuilder<IncUserStatItemValueBuilder>
        {


            public Model.StatItemInc? Body { get; set; }




            internal IncUserStatItemValueBuilder() { }

            internal IncUserStatItemValueBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public IncUserStatItemValueBuilder SetBody(Model.StatItemInc _body)
            {
                Body = _body;
                return this;
            }




            public IncUserStatItemValue Build(
                string namespace_,
                string statCode,
                string userId
            )
            {
                IncUserStatItemValue op = new IncUserStatItemValue(this,
                    namespace_,
                    statCode,
                    userId
                );

                op.SetBaseFields<IncUserStatItemValueBuilder>(this);
                return op;
            }

            public Model.StatItemIncResult? Execute(
                string namespace_,
                string statCode,
                string userId
            )
            {
                IncUserStatItemValue op = Build(
                    namespace_,
                    statCode,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.StatItemIncResult?> ExecuteAsync(
                string namespace_,
                string statCode,
                string userId
            )
            {
                IncUserStatItemValue op = Build(
                    namespace_,
                    statCode,
                    userId
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

        private IncUserStatItemValue(IncUserStatItemValueBuilder builder,
            string namespace_,
            string statCode,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            PathParams["userId"] = userId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public IncUserStatItemValue(
            string namespace_,
            string statCode,
            string userId,
            Model.StatItemInc body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems/value";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.StatItemIncResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.StatItemIncResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StatItemIncResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
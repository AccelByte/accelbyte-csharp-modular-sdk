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

using AccelByte.Sdk.Api.Challenge.Model;

namespace AccelByte.Sdk.Api.Challenge.Operation
{
    /// <summary>
    /// publicGetUserProgression
    ///
    /// 
    ///     * Required permission: NAMESPACE:{namespace}:CHALLENGE:PROGRESSION [READ]
    /// </summary>
    public class PublicGetUserProgression : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserProgressionBuilder Builder { get => new PublicGetUserProgressionBuilder(); }

        public class PublicGetUserProgressionBuilder
            : OperationBuilder<PublicGetUserProgressionBuilder>
        {

            public string? GoalCode { get; set; }





            internal PublicGetUserProgressionBuilder() { }

            internal PublicGetUserProgressionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicGetUserProgressionBuilder SetGoalCode(string _goalCode)
            {
                GoalCode = _goalCode;
                return this;
            }





            public PublicGetUserProgression Build(
                string challengeCode,
                string namespace_
            )
            {
                PublicGetUserProgression op = new PublicGetUserProgression(this,
                    challengeCode,
                    namespace_
                );

                op.SetBaseFields<PublicGetUserProgressionBuilder>(this);
                return op;
            }

            public Model.ModelUserProgressionResponse? Execute(
                string challengeCode,
                string namespace_
            )
            {
                PublicGetUserProgression op = Build(
                    challengeCode,
                    namespace_
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

        private PublicGetUserProgression(PublicGetUserProgressionBuilder builder,
            string challengeCode,
            string namespace_
        )
        {
            PathParams["challengeCode"] = challengeCode;
            PathParams["namespace"] = namespace_;

            if (builder.GoalCode is not null) QueryParams["goalCode"] = builder.GoalCode;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetUserProgression(
            string challengeCode,
            string namespace_,
            string? goalCode
        )
        {
            PathParams["challengeCode"] = challengeCode;
            PathParams["namespace"] = namespace_;

            if (goalCode is not null) QueryParams["goalCode"] = goalCode;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/challenge/v1/public/namespaces/{namespace}/users/me/progress/{challengeCode}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelUserProgressionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserProgressionResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserProgressionResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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
    /// adminGetGoal
    ///
    /// 
    ///     * Required permission: ADMIN:NAMESPACE:{namespace}:CHALLENGE [READ]
    /// </summary>
    public class AdminGetGoal : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetGoalBuilder Builder { get => new AdminGetGoalBuilder(); }

        public class AdminGetGoalBuilder
            : OperationBuilder<AdminGetGoalBuilder>
        {





            internal AdminGetGoalBuilder() { }

            internal AdminGetGoalBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetGoal Build(
                string challengeCode,
                string code,
                string namespace_
            )
            {
                AdminGetGoal op = new AdminGetGoal(this,
                    challengeCode,
                    code,
                    namespace_
                );

                op.SetBaseFields<AdminGetGoalBuilder>(this);
                return op;
            }

            public Model.ModelGoalResponse? Execute(
                string challengeCode,
                string code,
                string namespace_
            )
            {
                AdminGetGoal op = Build(
                    challengeCode,
                    code,
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

        private AdminGetGoal(AdminGetGoalBuilder builder,
            string challengeCode,
            string code,
            string namespace_
        )
        {
            PathParams["challengeCode"] = challengeCode;
            PathParams["code"] = code;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetGoal(
            string challengeCode,
            string code,
            string namespace_
        )
        {
            PathParams["challengeCode"] = challengeCode;
            PathParams["code"] = code;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/challenge/v1/admin/namespaces/{namespace}/challenges/{challengeCode}/goals/{code}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelGoalResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelGoalResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelGoalResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
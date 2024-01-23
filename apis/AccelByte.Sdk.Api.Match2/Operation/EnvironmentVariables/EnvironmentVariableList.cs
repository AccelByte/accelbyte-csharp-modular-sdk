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
    /// EnvironmentVariableList
    ///
    /// List environment variables.
    /// </summary>
    public class EnvironmentVariableList : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static EnvironmentVariableListBuilder Builder { get => new EnvironmentVariableListBuilder(); }

        public class EnvironmentVariableListBuilder
            : OperationBuilder<EnvironmentVariableListBuilder>
        {





            internal EnvironmentVariableListBuilder() { }

            internal EnvironmentVariableListBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public EnvironmentVariableList Build(
            )
            {
                EnvironmentVariableList op = new EnvironmentVariableList(this
                );

                op.SetBaseFields<EnvironmentVariableListBuilder>(this);
                return op;
            }

            public Model.ApiListEnvironmentVariablesResponse? Execute(
            )
            {
                EnvironmentVariableList op = Build(
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

        private EnvironmentVariableList(EnvironmentVariableListBuilder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public EnvironmentVariableList(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/environment-variables";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApiListEnvironmentVariablesResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApiListEnvironmentVariablesResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiListEnvironmentVariablesResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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

using AccelByte.Sdk.Api.Matchmaking.Model;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    /// <summary>
    /// GetHealthcheckInfo
    /// </summary>
    public class GetHealthcheckInfo : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetHealthcheckInfoBuilder Builder { get => new GetHealthcheckInfoBuilder(); }

        public class GetHealthcheckInfoBuilder
            : OperationBuilder<GetHealthcheckInfoBuilder>
        {





            internal GetHealthcheckInfoBuilder() { }

            internal GetHealthcheckInfoBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetHealthcheckInfo Build(
            )
            {
                GetHealthcheckInfo op = new GetHealthcheckInfo(this
                );

                op.SetBaseFields<GetHealthcheckInfoBuilder>(this);
                return op;
            }

            public void Execute(
            )
            {
                GetHealthcheckInfo op = Build(
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

        private GetHealthcheckInfo(GetHealthcheckInfoBuilder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetHealthcheckInfo(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/healthz";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
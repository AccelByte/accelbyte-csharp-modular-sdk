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

using AccelByte.Sdk.Api.Sessionhistory.Model;

namespace AccelByte.Sdk.Api.Sessionhistory.Operation
{
    /// <summary>
    /// GetHealthcheckInfoV1
    /// </summary>
    public class GetHealthcheckInfoV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetHealthcheckInfoV1Builder Builder { get => new GetHealthcheckInfoV1Builder(); }

        public class GetHealthcheckInfoV1Builder
            : OperationBuilder<GetHealthcheckInfoV1Builder>
        {





            internal GetHealthcheckInfoV1Builder() { }

            internal GetHealthcheckInfoV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetHealthcheckInfoV1 Build(
            )
            {
                GetHealthcheckInfoV1 op = new GetHealthcheckInfoV1(this
                );

                op.SetBaseFields<GetHealthcheckInfoV1Builder>(this);
                return op;
            }

            public void Execute(
            )
            {
                GetHealthcheckInfoV1 op = Build(
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
            )
            {
                GetHealthcheckInfoV1 op = Build(
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

        private GetHealthcheckInfoV1(GetHealthcheckInfoV1Builder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetHealthcheckInfoV1(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionhistory/healthz";

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
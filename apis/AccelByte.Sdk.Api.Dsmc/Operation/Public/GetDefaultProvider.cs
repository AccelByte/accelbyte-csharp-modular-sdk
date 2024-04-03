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

using AccelByte.Sdk.Api.Dsmc.Model;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// GetDefaultProvider
    ///
    /// This endpoints returns the default provider.
    /// </summary>
    public class GetDefaultProvider : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetDefaultProviderBuilder Builder { get => new GetDefaultProviderBuilder(); }

        public class GetDefaultProviderBuilder
            : OperationBuilder<GetDefaultProviderBuilder>
        {





            internal GetDefaultProviderBuilder() { }

            internal GetDefaultProviderBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetDefaultProvider Build(
            )
            {
                GetDefaultProvider op = new GetDefaultProvider(this
                );

                op.SetBaseFields<GetDefaultProviderBuilder>(this);
                return op;
            }

            public Model.ModelsDefaultProvider? Execute(
            )
            {
                GetDefaultProvider op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.ModelsDefaultProvider?> ExecuteAsync(
            )
            {
                GetDefaultProvider op = Build(
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

        private GetDefaultProvider(GetDefaultProviderBuilder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetDefaultProvider(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/public/provider/default";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsDefaultProvider? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsDefaultProvider>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsDefaultProvider>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
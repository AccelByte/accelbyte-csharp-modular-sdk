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

using AccelByte.Sdk.Api.Cloudsave.Model;

namespace AccelByte.Sdk.Api.Cloudsave.Operation
{
    /// <summary>
    /// getGameBinaryRecordV1
    ///
    /// Get a game binary record by its key.
    /// </summary>
    public class GetGameBinaryRecordV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetGameBinaryRecordV1Builder Builder { get => new GetGameBinaryRecordV1Builder(); }

        public class GetGameBinaryRecordV1Builder
            : OperationBuilder<GetGameBinaryRecordV1Builder>
        {





            internal GetGameBinaryRecordV1Builder() { }

            internal GetGameBinaryRecordV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetGameBinaryRecordV1 Build(
                string key,
                string namespace_
            )
            {
                GetGameBinaryRecordV1 op = new GetGameBinaryRecordV1(this,
                    key,
                    namespace_
                );

                op.SetBaseFields<GetGameBinaryRecordV1Builder>(this);
                return op;
            }

            public Model.ModelsGameBinaryRecordResponse? Execute(
                string key,
                string namespace_
            )
            {
                GetGameBinaryRecordV1 op = Build(
                    key,
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
            public async Task<Model.ModelsGameBinaryRecordResponse?> ExecuteAsync(
                string key,
                string namespace_
            )
            {
                GetGameBinaryRecordV1 op = Build(
                    key,
                    namespace_
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

        private GetGameBinaryRecordV1(GetGameBinaryRecordV1Builder builder,
            string key,
            string namespace_
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetGameBinaryRecordV1(
            string key,
            string namespace_
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/namespaces/{namespace}/binaries/{key}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsGameBinaryRecordResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGameBinaryRecordResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGameBinaryRecordResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
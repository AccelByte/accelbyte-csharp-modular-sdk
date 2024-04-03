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
    /// putPlayerBinaryRecorMetadataV1
    ///
    /// Update a player binary record metadata by its key
    /// </summary>
    public class PutPlayerBinaryRecorMetadataV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PutPlayerBinaryRecorMetadataV1Builder Builder { get => new PutPlayerBinaryRecorMetadataV1Builder(); }

        public class PutPlayerBinaryRecorMetadataV1Builder
            : OperationBuilder<PutPlayerBinaryRecorMetadataV1Builder>
        {





            internal PutPlayerBinaryRecorMetadataV1Builder() { }

            internal PutPlayerBinaryRecorMetadataV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PutPlayerBinaryRecorMetadataV1 Build(
                ModelsPlayerBinaryRecordMetadataPublicRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                PutPlayerBinaryRecorMetadataV1 op = new PutPlayerBinaryRecorMetadataV1(this,
                    body,
                    key,
                    namespace_,
                    userId
                );

                op.SetBaseFields<PutPlayerBinaryRecorMetadataV1Builder>(this);
                return op;
            }

            public Model.ModelsPlayerBinaryRecordResponse? Execute(
                ModelsPlayerBinaryRecordMetadataPublicRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                PutPlayerBinaryRecorMetadataV1 op = Build(
                    body,
                    key,
                    namespace_,
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
            public async Task<Model.ModelsPlayerBinaryRecordResponse?> ExecuteAsync(
                ModelsPlayerBinaryRecordMetadataPublicRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                PutPlayerBinaryRecorMetadataV1 op = Build(
                    body,
                    key,
                    namespace_,
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

        private PutPlayerBinaryRecorMetadataV1(PutPlayerBinaryRecorMetadataV1Builder builder,
            ModelsPlayerBinaryRecordMetadataPublicRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PutPlayerBinaryRecorMetadataV1(
            string key,
            string namespace_,
            string userId,
            Model.ModelsPlayerBinaryRecordMetadataPublicRequest body
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/namespaces/{namespace}/users/{userId}/binaries/{key}/metadata";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsPlayerBinaryRecordResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPlayerBinaryRecordResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPlayerBinaryRecordResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
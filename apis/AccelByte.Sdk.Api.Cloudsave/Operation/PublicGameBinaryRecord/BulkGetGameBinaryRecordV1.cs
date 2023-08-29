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

using AccelByte.Sdk.Api.Cloudsave.Model;

namespace AccelByte.Sdk.Api.Cloudsave.Operation
{
    /// <summary>
    /// bulkGetGameBinaryRecordV1
    ///
    /// Required valid user token
    /// Required scope: `social`
    /// 
    /// Bulk get game binary records. Maximum key per request 20.
    /// </summary>
    public class BulkGetGameBinaryRecordV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkGetGameBinaryRecordV1Builder Builder { get => new BulkGetGameBinaryRecordV1Builder(); }

        public class BulkGetGameBinaryRecordV1Builder
            : OperationBuilder<BulkGetGameBinaryRecordV1Builder>
        {





            internal BulkGetGameBinaryRecordV1Builder() { }

            internal BulkGetGameBinaryRecordV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public BulkGetGameBinaryRecordV1 Build(
                ModelsBulkGetGameRecordRequest body,
                string namespace_
            )
            {
                BulkGetGameBinaryRecordV1 op = new BulkGetGameBinaryRecordV1(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsBulkGetGameBinaryRecordResponse? Execute(
                ModelsBulkGetGameRecordRequest body,
                string namespace_
            )
            {
                BulkGetGameBinaryRecordV1 op = Build(
                    body,
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

        private BulkGetGameBinaryRecordV1(BulkGetGameBinaryRecordV1Builder builder,
            ModelsBulkGetGameRecordRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public BulkGetGameBinaryRecordV1(
            string namespace_,
            Model.ModelsBulkGetGameRecordRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/namespaces/{namespace}/binaries/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsBulkGetGameBinaryRecordResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsBulkGetGameBinaryRecordResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsBulkGetGameBinaryRecordResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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
    /// getPlayerRecordsBulkHandlerV1
    ///
    /// Retrieve player record key and payload in bulk under given namespace.
    /// 
    /// Maximum bulk key limit per request 20
    /// </summary>
    public class GetPlayerRecordsBulkHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetPlayerRecordsBulkHandlerV1Builder Builder { get => new GetPlayerRecordsBulkHandlerV1Builder(); }

        public class GetPlayerRecordsBulkHandlerV1Builder
            : OperationBuilder<GetPlayerRecordsBulkHandlerV1Builder>
        {





            internal GetPlayerRecordsBulkHandlerV1Builder() { }

            internal GetPlayerRecordsBulkHandlerV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetPlayerRecordsBulkHandlerV1 Build(
                ModelsBulkGetPlayerRecordsRequest body,
                string namespace_
            )
            {
                GetPlayerRecordsBulkHandlerV1 op = new GetPlayerRecordsBulkHandlerV1(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsBulkGetPlayerRecordResponse? Execute(
                ModelsBulkGetPlayerRecordsRequest body,
                string namespace_
            )
            {
                GetPlayerRecordsBulkHandlerV1 op = Build(
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

        private GetPlayerRecordsBulkHandlerV1(GetPlayerRecordsBulkHandlerV1Builder builder,
            ModelsBulkGetPlayerRecordsRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetPlayerRecordsBulkHandlerV1(
            string namespace_,
            Model.ModelsBulkGetPlayerRecordsRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/namespaces/{namespace}/users/me/records/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsBulkGetPlayerRecordResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsBulkGetPlayerRecordResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsBulkGetPlayerRecordResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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

using AccelByte.Sdk.Api.Social.Model;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// bulkFetchOrDefaultStatItems_1
    ///
    /// Bulk fetch multiple user's stat item values for a given namespace and statCode.
    /// NOTE: If stat item does not exist, will return default value. Other detail info:
    /// + *Required permission*: resource=ADMIN:NAMESPACE:{namespace}:STATITEM, action=2 (READ)
    /// + *Returns*: list of user's stat item values
    /// </summary>
    public class BulkFetchOrDefaultStatItems1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkFetchOrDefaultStatItems1Builder Builder { get => new BulkFetchOrDefaultStatItems1Builder(); }

        public class BulkFetchOrDefaultStatItems1Builder
            : OperationBuilder<BulkFetchOrDefaultStatItems1Builder>
        {

            public string? AdditionalKey { get; set; }





            internal BulkFetchOrDefaultStatItems1Builder() { }

            internal BulkFetchOrDefaultStatItems1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public BulkFetchOrDefaultStatItems1Builder SetAdditionalKey(string _additionalKey)
            {
                AdditionalKey = _additionalKey;
                return this;
            }





            public BulkFetchOrDefaultStatItems1 Build(
                string namespace_,
                string statCode,
                List<string> userIds
            )
            {
                BulkFetchOrDefaultStatItems1 op = new BulkFetchOrDefaultStatItems1(this,
                    namespace_,
                    statCode,
                    userIds
                );

                op.SetBaseFields<BulkFetchOrDefaultStatItems1Builder>(this);
                return op;
            }

            public List<Model.ADTOObjectForUserStatItemValue>? Execute(
                string namespace_,
                string statCode,
                List<string> userIds
            )
            {
                BulkFetchOrDefaultStatItems1 op = Build(
                    namespace_,
                    statCode,
                    userIds
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<List<Model.ADTOObjectForUserStatItemValue>?> ExecuteAsync(
                string namespace_,
                string statCode,
                List<string> userIds
            )
            {
                BulkFetchOrDefaultStatItems1 op = Build(
                    namespace_,
                    statCode,
                    userIds
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

        private BulkFetchOrDefaultStatItems1(BulkFetchOrDefaultStatItems1Builder builder,
            string namespace_,
            string statCode,
            List<string> userIds
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.AdditionalKey is not null) QueryParams["additionalKey"] = builder.AdditionalKey;
            if (statCode is not null) QueryParams["statCode"] = statCode;
            if (userIds is not null) QueryParams["userIds"] = userIds;



            CollectionFormatMap["userIds"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public BulkFetchOrDefaultStatItems1(
            string namespace_,
            string? additionalKey,
            string statCode,
            List<string> userIds
        )
        {
            PathParams["namespace"] = namespace_;

            if (additionalKey is not null) QueryParams["additionalKey"] = additionalKey;
            if (statCode is not null) QueryParams["statCode"] = statCode;
            if (userIds is not null) QueryParams["userIds"] = userIds;



            CollectionFormatMap["userIds"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v2/admin/namespaces/{namespace}/statitems/value/bulk/getOrDefault";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.ADTOObjectForUserStatItemValue>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ADTOObjectForUserStatItemValue>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ADTOObjectForUserStatItemValue>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
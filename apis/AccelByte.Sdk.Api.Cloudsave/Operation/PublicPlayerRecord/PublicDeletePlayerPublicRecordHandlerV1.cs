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
    /// publicDeletePlayerPublicRecordHandlerV1
    ///
    /// Required valid user authorization
    /// Required scope: `social`
    /// 
    /// Delete player public record.
    /// 
    /// 
    /// 
    /// 
    /// ## Warning: This endpoint is going to deprecate
    /// 
    /// 
    /// 
    /// This endpoint is going to deprecate in the future please don't use it.
    /// 
    /// For alternative, please use these endpoints:
    /// - POST /cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key} and utilizing __META functionality
    /// - PUT /cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key} and utilizing __META functionality
    /// - DELETE /cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}
    /// </summary>
    public class PublicDeletePlayerPublicRecordHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicDeletePlayerPublicRecordHandlerV1Builder Builder { get => new PublicDeletePlayerPublicRecordHandlerV1Builder(); }

        public class PublicDeletePlayerPublicRecordHandlerV1Builder
            : OperationBuilder<PublicDeletePlayerPublicRecordHandlerV1Builder>
        {





            internal PublicDeletePlayerPublicRecordHandlerV1Builder() { }

            internal PublicDeletePlayerPublicRecordHandlerV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicDeletePlayerPublicRecordHandlerV1 Build(
                string key,
                string namespace_
            )
            {
                PublicDeletePlayerPublicRecordHandlerV1 op = new PublicDeletePlayerPublicRecordHandlerV1(this,
                    key,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string key,
                string namespace_
            )
            {
                PublicDeletePlayerPublicRecordHandlerV1 op = Build(
                    key,
                    namespace_
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

        private PublicDeletePlayerPublicRecordHandlerV1(PublicDeletePlayerPublicRecordHandlerV1Builder builder,
            string key,
            string namespace_
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicDeletePlayerPublicRecordHandlerV1(
            string key,
            string namespace_
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/namespaces/{namespace}/users/me/records/{key}/public";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
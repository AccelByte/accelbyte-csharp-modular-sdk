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

using AccelByte.Sdk.Api.Basic.Model;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// publicGetCustomAttributesInfo
    ///
    /// Get custom attributes info.
    /// Other detail info:
    /// 
    ///   * Action code : 11404
    ///   *  Returns : user custom attributes
    /// </summary>
    public class PublicGetCustomAttributesInfo : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetCustomAttributesInfoBuilder Builder { get => new PublicGetCustomAttributesInfoBuilder(); }

        public class PublicGetCustomAttributesInfoBuilder
            : OperationBuilder<PublicGetCustomAttributesInfoBuilder>
        {





            internal PublicGetCustomAttributesInfoBuilder() { }

            internal PublicGetCustomAttributesInfoBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetCustomAttributesInfo Build(
                string namespace_,
                string userId
            )
            {
                PublicGetCustomAttributesInfo op = new PublicGetCustomAttributesInfo(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<PublicGetCustomAttributesInfoBuilder>(this);
                return op;
            }

            public Dictionary<string, object>? Execute(
                string namespace_,
                string userId
            )
            {
                PublicGetCustomAttributesInfo op = Build(
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
        }

        private PublicGetCustomAttributesInfo(PublicGetCustomAttributesInfoBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







        }
        #endregion

        public PublicGetCustomAttributesInfo(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/users/{userId}/profiles/customAttributes";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Dictionary<string, object>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Dictionary<string, object>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Dictionary<string, object>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
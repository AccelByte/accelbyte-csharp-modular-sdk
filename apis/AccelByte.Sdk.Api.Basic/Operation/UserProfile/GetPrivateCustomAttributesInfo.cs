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
    /// getPrivateCustomAttributesInfo
    ///
    /// Get user private custom attributes.
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "ADMIN:NAMESPACE:{namespace}:USER:{userId}:PROFILE" , action=2 (READ)
    ///   *  Returns : custom attributes
    ///   *  Action code : 11403
    /// </summary>
    public class GetPrivateCustomAttributesInfo : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetPrivateCustomAttributesInfoBuilder Builder { get => new GetPrivateCustomAttributesInfoBuilder(); }

        public class GetPrivateCustomAttributesInfoBuilder
            : OperationBuilder<GetPrivateCustomAttributesInfoBuilder>
        {





            internal GetPrivateCustomAttributesInfoBuilder() { }

            internal GetPrivateCustomAttributesInfoBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetPrivateCustomAttributesInfo Build(
                string namespace_,
                string userId
            )
            {
                GetPrivateCustomAttributesInfo op = new GetPrivateCustomAttributesInfo(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Dictionary<string, object>? Execute(
                string namespace_,
                string userId
            )
            {
                GetPrivateCustomAttributesInfo op = Build(
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

        private GetPrivateCustomAttributesInfo(GetPrivateCustomAttributesInfoBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetPrivateCustomAttributesInfo(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/users/{userId}/profiles/privateCustomAttributes";

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
                return JsonSerializer.Deserialize<Dictionary<string, object>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Dictionary<string, object>>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
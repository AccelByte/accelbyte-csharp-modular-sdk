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
    /// getMyPrivateCustomAttributesInfo
    ///
    /// Get my private custom attributes.
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "NAMESPACE:{namespace}:PROFILE" , action=2 (READ)
    ///   *  Returns : custom attributes
    ///   *  Action code : 11403
    /// </summary>
    public class GetMyPrivateCustomAttributesInfo : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetMyPrivateCustomAttributesInfoBuilder Builder { get => new GetMyPrivateCustomAttributesInfoBuilder(); }

        public class GetMyPrivateCustomAttributesInfoBuilder
            : OperationBuilder<GetMyPrivateCustomAttributesInfoBuilder>
        {





            internal GetMyPrivateCustomAttributesInfoBuilder() { }

            internal GetMyPrivateCustomAttributesInfoBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetMyPrivateCustomAttributesInfo Build(
                string namespace_
            )
            {
                GetMyPrivateCustomAttributesInfo op = new GetMyPrivateCustomAttributesInfo(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Dictionary<string, object>? Execute(
                string namespace_
            )
            {
                GetMyPrivateCustomAttributesInfo op = Build(
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

        private GetMyPrivateCustomAttributesInfo(GetMyPrivateCustomAttributesInfoBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetMyPrivateCustomAttributesInfo(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/users/me/profiles/privateCustomAttributes";

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
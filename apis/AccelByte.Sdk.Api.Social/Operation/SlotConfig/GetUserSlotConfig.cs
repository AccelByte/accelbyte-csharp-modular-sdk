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

using AccelByte.Sdk.Api.Social.Model;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// getUserSlotConfig
    ///
    /// GetÂ a user slot configuration in given namespace. In case the user slot configuration is not set, the namespace configuration will be returned.
    /// Other detail info:
    /// 
    ///   * Required permission: resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:SLOTCONFIG", action=2 (READ)
    ///   * Returns: slot config info
    /// </summary>
    public class GetUserSlotConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserSlotConfigBuilder Builder { get => new GetUserSlotConfigBuilder(); }

        public class GetUserSlotConfigBuilder
            : OperationBuilder<GetUserSlotConfigBuilder>
        {





            internal GetUserSlotConfigBuilder() { }

            internal GetUserSlotConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetUserSlotConfig Build(
                string namespace_,
                string userId
            )
            {
                GetUserSlotConfig op = new GetUserSlotConfig(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.UserSlotConfigInfo? Execute(
                string namespace_,
                string userId
            )
            {
                GetUserSlotConfig op = Build(
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

        private GetUserSlotConfig(GetUserSlotConfigBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserSlotConfig(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/admin/namespaces/{namespace}/users/{userId}/config";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.UserSlotConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.UserSlotConfigInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UserSlotConfigInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
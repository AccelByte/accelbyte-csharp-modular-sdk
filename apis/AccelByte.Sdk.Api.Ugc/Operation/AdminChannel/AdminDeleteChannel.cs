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

using AccelByte.Sdk.Api.Ugc.Model;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// AdminDeleteChannel
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER:{userId}:CHANNEL [DELETE]
    /// </summary>
    public class AdminDeleteChannel : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteChannelBuilder Builder { get => new AdminDeleteChannelBuilder(); }

        public class AdminDeleteChannelBuilder
            : OperationBuilder<AdminDeleteChannelBuilder>
        {





            internal AdminDeleteChannelBuilder() { }

            internal AdminDeleteChannelBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeleteChannel Build(
                string channelId,
                string namespace_,
                string userId
            )
            {
                AdminDeleteChannel op = new AdminDeleteChannel(this,
                    channelId,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string channelId,
                string namespace_,
                string userId
            )
            {
                AdminDeleteChannel op = Build(
                    channelId,
                    namespace_,
                    userId
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

        private AdminDeleteChannel(AdminDeleteChannelBuilder builder,
            string channelId,
            string namespace_,
            string userId
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteChannel(
            string channelId,
            string namespace_,
            string userId
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}";

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
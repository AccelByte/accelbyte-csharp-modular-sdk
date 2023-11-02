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
    /// DeleteContentByShareCode
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER:{userId}:CONTENT [DELETE].
    /// </summary>
    public class DeleteContentByShareCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteContentByShareCodeBuilder Builder { get => new DeleteContentByShareCodeBuilder(); }

        public class DeleteContentByShareCodeBuilder
            : OperationBuilder<DeleteContentByShareCodeBuilder>
        {





            internal DeleteContentByShareCodeBuilder() { }

            internal DeleteContentByShareCodeBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteContentByShareCode Build(
                string channelId,
                string namespace_,
                string shareCode,
                string userId
            )
            {
                DeleteContentByShareCode op = new DeleteContentByShareCode(this,
                    channelId,
                    namespace_,
                    shareCode,
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
                string shareCode,
                string userId
            )
            {
                DeleteContentByShareCode op = Build(
                    channelId,
                    namespace_,
                    shareCode,
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

        private DeleteContentByShareCode(DeleteContentByShareCodeBuilder builder,
            string channelId,
            string namespace_,
            string shareCode,
            string userId
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;
            PathParams["shareCode"] = shareCode;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteContentByShareCode(
            string channelId,
            string namespace_,
            string shareCode,
            string userId
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;
            PathParams["shareCode"] = shareCode;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/sharecodes/{shareCode}";

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
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

using AccelByte.Sdk.Api.Chat.Model;

namespace AccelByte.Sdk.Api.Chat.Operation
{
    /// <summary>
    /// adminDeleteInboxMessage
    ///
    /// Delete inbox message
    /// </summary>
    public class AdminDeleteInboxMessage : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteInboxMessageBuilder Builder { get => new AdminDeleteInboxMessageBuilder(); }

        public class AdminDeleteInboxMessageBuilder
            : OperationBuilder<AdminDeleteInboxMessageBuilder>
        {

            public bool? Force { get; set; }





            internal AdminDeleteInboxMessageBuilder() { }

            internal AdminDeleteInboxMessageBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminDeleteInboxMessageBuilder SetForce(bool _force)
            {
                Force = _force;
                return this;
            }





            public AdminDeleteInboxMessage Build(
                string messageId,
                string namespace_
            )
            {
                AdminDeleteInboxMessage op = new AdminDeleteInboxMessage(this,
                    messageId,
                    namespace_
                );

                op.SetBaseFields<AdminDeleteInboxMessageBuilder>(this);
                return op;
            }

            public void Execute(
                string messageId,
                string namespace_
            )
            {
                AdminDeleteInboxMessage op = Build(
                    messageId,
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

        private AdminDeleteInboxMessage(AdminDeleteInboxMessageBuilder builder,
            string messageId,
            string namespace_
        )
        {
            PathParams["messageId"] = messageId;
            PathParams["namespace"] = namespace_;

            if (builder.Force != null) QueryParams["force"] = Convert.ToString(builder.Force)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteInboxMessage(
            string messageId,
            string namespace_,
            bool? force
        )
        {
            PathParams["messageId"] = messageId;
            PathParams["namespace"] = namespace_;

            if (force != null) QueryParams["force"] = Convert.ToString(force)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/v1/admin/inbox/namespaces/{namespace}/message/{messageId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
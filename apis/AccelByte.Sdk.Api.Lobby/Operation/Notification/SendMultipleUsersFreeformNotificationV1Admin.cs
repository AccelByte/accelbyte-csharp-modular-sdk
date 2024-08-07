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

using AccelByte.Sdk.Api.Lobby.Model;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// sendMultipleUsersFreeformNotificationV1Admin
    ///
    /// Sends notification to multiple user.
    /// Action Code: 50211
    /// </summary>
    public class SendMultipleUsersFreeformNotificationV1Admin : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SendMultipleUsersFreeformNotificationV1AdminBuilder Builder { get => new SendMultipleUsersFreeformNotificationV1AdminBuilder(); }

        public class SendMultipleUsersFreeformNotificationV1AdminBuilder
            : OperationBuilder<SendMultipleUsersFreeformNotificationV1AdminBuilder>
        {





            internal SendMultipleUsersFreeformNotificationV1AdminBuilder() { }

            internal SendMultipleUsersFreeformNotificationV1AdminBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public SendMultipleUsersFreeformNotificationV1Admin Build(
                ModelBulkUsersFreeFormNotificationRequestV1 body,
                string namespace_
            )
            {
                SendMultipleUsersFreeformNotificationV1Admin op = new SendMultipleUsersFreeformNotificationV1Admin(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<SendMultipleUsersFreeformNotificationV1AdminBuilder>(this);
                return op;
            }

            public void Execute(
                ModelBulkUsersFreeFormNotificationRequestV1 body,
                string namespace_
            )
            {
                SendMultipleUsersFreeformNotificationV1Admin op = Build(
                    body,
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
            public async Task ExecuteAsync(
                ModelBulkUsersFreeFormNotificationRequestV1 body,
                string namespace_
            )
            {
                SendMultipleUsersFreeformNotificationV1Admin op = Build(
                    body,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private SendMultipleUsersFreeformNotificationV1Admin(SendMultipleUsersFreeformNotificationV1AdminBuilder builder,
            ModelBulkUsersFreeFormNotificationRequestV1 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SendMultipleUsersFreeformNotificationV1Admin(
            string namespace_,
            Model.ModelBulkUsersFreeFormNotificationRequestV1 body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/notification/namespaces/{namespace}/bulkUsers/freeform/notify";

        public override HttpMethod Method => HttpMethod.Post;

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
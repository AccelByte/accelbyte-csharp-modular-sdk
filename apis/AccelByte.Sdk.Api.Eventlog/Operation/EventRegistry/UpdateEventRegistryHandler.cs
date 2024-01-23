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

using AccelByte.Sdk.Api.Eventlog.Model;

namespace AccelByte.Sdk.Api.Eventlog.Operation
{
    /// <summary>
    /// UpdateEventRegistryHandler
    ///
    /// Required permission `ADMIN:NAMESPACE:{namespace}:EVENT [UPDATE]`and scope `analytics`
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class UpdateEventRegistryHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateEventRegistryHandlerBuilder Builder { get => new UpdateEventRegistryHandlerBuilder(); }

        public class UpdateEventRegistryHandlerBuilder
            : OperationBuilder<UpdateEventRegistryHandlerBuilder>
        {





            internal UpdateEventRegistryHandlerBuilder() { }

            internal UpdateEventRegistryHandlerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateEventRegistryHandler Build(
                ModelsEventRegistry body,
                string eventId
            )
            {
                UpdateEventRegistryHandler op = new UpdateEventRegistryHandler(this,
                    body,
                    eventId
                );

                op.SetBaseFields<UpdateEventRegistryHandlerBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public void Execute(
                ModelsEventRegistry body,
                string eventId
            )
            {
                UpdateEventRegistryHandler op = Build(
                    body,
                    eventId
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

        private UpdateEventRegistryHandler(UpdateEventRegistryHandlerBuilder builder,
            ModelsEventRegistry body,
            string eventId
        )
        {
            PathParams["eventId"] = eventId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateEventRegistryHandler(
            string eventId,
            Model.ModelsEventRegistry body
        )
        {
            PathParams["eventId"] = eventId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/event/registry/eventIds/{eventId}";

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
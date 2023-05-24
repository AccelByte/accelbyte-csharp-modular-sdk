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
    /// EventIDDescriptionHandler
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class EventIDDescriptionHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static EventIDDescriptionHandlerBuilder Builder { get => new EventIDDescriptionHandlerBuilder(); }

        public class EventIDDescriptionHandlerBuilder
            : OperationBuilder<EventIDDescriptionHandlerBuilder>
        {





            internal EventIDDescriptionHandlerBuilder() { }

            internal EventIDDescriptionHandlerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public EventIDDescriptionHandler Build(
            )
            {
                EventIDDescriptionHandler op = new EventIDDescriptionHandler(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public Model.ModelsMultipleEventID? Execute(
            )
            {
                EventIDDescriptionHandler op = Build(
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

        private EventIDDescriptionHandler(EventIDDescriptionHandlerBuilder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public EventIDDescriptionHandler(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/event/descriptions/eventId";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsMultipleEventID? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsMultipleEventID>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsMultipleEventID>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
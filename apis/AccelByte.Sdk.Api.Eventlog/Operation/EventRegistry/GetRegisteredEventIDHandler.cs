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
    /// GetRegisteredEventIDHandler
    ///
    /// Required permission `ADMIN:NAMESPACE:{namespace}:EVENT [READ]`and scope `analytics`
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class GetRegisteredEventIDHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetRegisteredEventIDHandlerBuilder Builder { get => new GetRegisteredEventIDHandlerBuilder(); }

        public class GetRegisteredEventIDHandlerBuilder
            : OperationBuilder<GetRegisteredEventIDHandlerBuilder>
        {





            internal GetRegisteredEventIDHandlerBuilder() { }

            internal GetRegisteredEventIDHandlerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetRegisteredEventIDHandler Build(
                string eventId
            )
            {
                GetRegisteredEventIDHandler op = new GetRegisteredEventIDHandler(this,
                    eventId
                );

                op.SetBaseFields<GetRegisteredEventIDHandlerBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public Model.ModelsEventRegistry? Execute(
                string eventId
            )
            {
                GetRegisteredEventIDHandler op = Build(
                    eventId
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

        private GetRegisteredEventIDHandler(GetRegisteredEventIDHandlerBuilder builder,
            string eventId
        )
        {
            PathParams["eventId"] = eventId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetRegisteredEventIDHandler(
            string eventId
        )
        {
            PathParams["eventId"] = eventId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/event/registry/eventIds/{eventId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsEventRegistry? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsEventRegistry>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsEventRegistry>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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
    /// UnregisterEventIDHandler
    ///
    /// Required permission `ADMIN:NAMESPACE:{namespace}:EVENT [DELETE]`and scope `analytics`
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class UnregisterEventIDHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UnregisterEventIDHandlerBuilder Builder { get => new UnregisterEventIDHandlerBuilder(); }

        public class UnregisterEventIDHandlerBuilder
            : OperationBuilder<UnregisterEventIDHandlerBuilder>
        {





            internal UnregisterEventIDHandlerBuilder() { }

            internal UnregisterEventIDHandlerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UnregisterEventIDHandler Build(
                string eventId
            )
            {
                UnregisterEventIDHandler op = new UnregisterEventIDHandler(this,
                    eventId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public void Execute(
                string eventId
            )
            {
                UnregisterEventIDHandler op = Build(
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

        private UnregisterEventIDHandler(UnregisterEventIDHandlerBuilder builder,
            string eventId
        )
        {
            PathParams["eventId"] = eventId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UnregisterEventIDHandler(
            string eventId
        )
        {
            PathParams["eventId"] = eventId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/event/registry/eventIds/{eventId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { };

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
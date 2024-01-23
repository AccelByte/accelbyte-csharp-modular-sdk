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

using AccelByte.Sdk.Api.Reporting.Model;

namespace AccelByte.Sdk.Api.Reporting.Operation
{
    /// <summary>
    /// deleteTicket
    ///
    /// This endpoint will delete ticket and all its reports.
    /// </summary>
    public class DeleteTicket : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteTicketBuilder Builder { get => new DeleteTicketBuilder(); }

        public class DeleteTicketBuilder
            : OperationBuilder<DeleteTicketBuilder>
        {





            internal DeleteTicketBuilder() { }

            internal DeleteTicketBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteTicket Build(
                string namespace_,
                string ticketId
            )
            {
                DeleteTicket op = new DeleteTicket(this,
                    namespace_,
                    ticketId
                );

                op.SetBaseFields<DeleteTicketBuilder>(this);
                return op;
            }

            public void Execute(
                string namespace_,
                string ticketId
            )
            {
                DeleteTicket op = Build(
                    namespace_,
                    ticketId
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

        private DeleteTicket(DeleteTicketBuilder builder,
            string namespace_,
            string ticketId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ticketId"] = ticketId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteTicket(
            string namespace_,
            string ticketId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ticketId"] = ticketId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/admin/namespaces/{namespace}/tickets/{ticketId}";

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
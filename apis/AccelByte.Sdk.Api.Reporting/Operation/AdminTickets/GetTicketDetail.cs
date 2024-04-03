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

using AccelByte.Sdk.Api.Reporting.Model;

namespace AccelByte.Sdk.Api.Reporting.Operation
{
    /// <summary>
    /// getTicketDetail
    ///
    /// This endpoint will return ticket detail with ticket id.
    /// </summary>
    public class GetTicketDetail : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetTicketDetailBuilder Builder { get => new GetTicketDetailBuilder(); }

        public class GetTicketDetailBuilder
            : OperationBuilder<GetTicketDetailBuilder>
        {





            internal GetTicketDetailBuilder() { }

            internal GetTicketDetailBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetTicketDetail Build(
                string namespace_,
                string ticketId
            )
            {
                GetTicketDetail op = new GetTicketDetail(this,
                    namespace_,
                    ticketId
                );

                op.SetBaseFields<GetTicketDetailBuilder>(this);
                return op;
            }

            public Model.RestapiTicketResponse? Execute(
                string namespace_,
                string ticketId
            )
            {
                GetTicketDetail op = Build(
                    namespace_,
                    ticketId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.RestapiTicketResponse?> ExecuteAsync(
                string namespace_,
                string ticketId
            )
            {
                GetTicketDetail op = Build(
                    namespace_,
                    ticketId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private GetTicketDetail(GetTicketDetailBuilder builder,
            string namespace_,
            string ticketId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ticketId"] = ticketId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetTicketDetail(
            string namespace_,
            string ticketId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ticketId"] = ticketId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/admin/namespaces/{namespace}/tickets/{ticketId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.RestapiTicketResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.RestapiTicketResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RestapiTicketResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
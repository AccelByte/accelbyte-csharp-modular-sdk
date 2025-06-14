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

using AccelByte.Sdk.Api.Match2.Model;

namespace AccelByte.Sdk.Api.Match2.Operation
{
    /// <summary>
    /// DeleteMatchTicket
    ///
    /// Deletes an existing matchmaking ticket.
    /// </summary>
    public class DeleteMatchTicket : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteMatchTicketBuilder Builder { get => new DeleteMatchTicketBuilder(); }

        public class DeleteMatchTicketBuilder
            : OperationBuilder<DeleteMatchTicketBuilder>
        {





            internal DeleteMatchTicketBuilder() { }

            internal DeleteMatchTicketBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteMatchTicket Build(
                string namespace_,
                string ticketid
            )
            {
                DeleteMatchTicket op = new DeleteMatchTicket(this,
                    namespace_,                    
                    ticketid                    
                );

                op.SetBaseFields<DeleteMatchTicketBuilder>(this);
                return op;
            }

            public DeleteMatchTicket.Response Execute(
                string namespace_,
                string ticketid
            )
            {
                DeleteMatchTicket op = Build(
                    namespace_,
                    ticketid
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<DeleteMatchTicket.Response> ExecuteAsync(
                string namespace_,
                string ticketid
            )
            {
                DeleteMatchTicket op = Build(
                    namespace_,
                    ticketid
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

        private DeleteMatchTicket(DeleteMatchTicketBuilder builder,
            string namespace_,
            string ticketid
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ticketid"] = ticketid;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error406 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Match2::MatchTickets::DeleteMatchTicket";
        }

        #endregion

        public DeleteMatchTicket(
            string namespace_,            
            string ticketid            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ticketid"] = ticketid;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/namespaces/{namespace}/match-tickets/{ticketid}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public DeleteMatchTicket.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DeleteMatchTicket.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)401)
            
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)406)
            
            {
                response.Error406 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error406!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
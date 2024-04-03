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
    /// updateTicketResolutions
    ///
    /// Update ticket resolution status to either OPEN or CLOSED. It is mandatory to provide notes
    /// </summary>
    public class UpdateTicketResolutions : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateTicketResolutionsBuilder Builder { get => new UpdateTicketResolutionsBuilder(); }

        public class UpdateTicketResolutionsBuilder
            : OperationBuilder<UpdateTicketResolutionsBuilder>
        {





            internal UpdateTicketResolutionsBuilder() { }

            internal UpdateTicketResolutionsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateTicketResolutions Build(
                RestapiUpdateTicketResolutionsRequest body,
                string namespace_,
                string ticketId
            )
            {
                UpdateTicketResolutions op = new UpdateTicketResolutions(this,
                    body,
                    namespace_,
                    ticketId
                );

                op.SetBaseFields<UpdateTicketResolutionsBuilder>(this);
                return op;
            }

            public Model.RestapiTicketResponse? Execute(
                RestapiUpdateTicketResolutionsRequest body,
                string namespace_,
                string ticketId
            )
            {
                UpdateTicketResolutions op = Build(
                    body,
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
                RestapiUpdateTicketResolutionsRequest body,
                string namespace_,
                string ticketId
            )
            {
                UpdateTicketResolutions op = Build(
                    body,
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

        private UpdateTicketResolutions(UpdateTicketResolutionsBuilder builder,
            RestapiUpdateTicketResolutionsRequest body,
            string namespace_,
            string ticketId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ticketId"] = ticketId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateTicketResolutions(
            string namespace_,
            string ticketId,
            Model.RestapiUpdateTicketResolutionsRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ticketId"] = ticketId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/admin/namespaces/{namespace}/tickets/{ticketId}/resolutions";

        public override HttpMethod Method => HttpMethod.Post;

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
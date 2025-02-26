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

using AccelByte.Sdk.Api.Matchmaking.Model;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    /// <summary>
    /// BulkCreateMockTickets
    ///
    /// Create and queue mock tickets into specified game mode's pool.
    /// The tickets input will be used as is.
    /// '
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class BulkCreateMockTickets : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkCreateMockTicketsBuilder Builder { get => new BulkCreateMockTicketsBuilder(); }

        public class BulkCreateMockTicketsBuilder
            : OperationBuilder<BulkCreateMockTicketsBuilder>
        {





            internal BulkCreateMockTicketsBuilder() { }

            internal BulkCreateMockTicketsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public BulkCreateMockTickets Build(
                List<ModelsMatchingParty> body,
                string channelName,
                string namespace_
            )
            {
                BulkCreateMockTickets op = new BulkCreateMockTickets(this,
                    body,
                    channelName,
                    namespace_
                );

                op.SetBaseFields<BulkCreateMockTicketsBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public BulkCreateMockTickets.Response Execute(
                List<ModelsMatchingParty> body,
                string channelName,
                string namespace_
            )
            {
                BulkCreateMockTickets op = Build(
                    body,
                    channelName,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<BulkCreateMockTickets.Response> ExecuteAsync(
                List<ModelsMatchingParty> body,
                string channelName,
                string namespace_
            )
            {
                BulkCreateMockTickets op = Build(
                    body,
                    channelName,
                    namespace_
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

        private BulkCreateMockTickets(BulkCreateMockTicketsBuilder builder,
            List<ModelsMatchingParty> body,
            string channelName,
            string namespace_
        )
        {
            PathParams["channelName"] = channelName;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ResponseErrorV1? Error400 { get; set; } = null;

            public ResponseErrorV1? Error401 { get; set; } = null;

            public ResponseErrorV1? Error403 { get; set; } = null;

            public ResponseErrorV1? Error404 { get; set; } = null;

            public ResponseErrorV1? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Matchmaking::MockMatchmaking::BulkCreateMockTickets";
        }

        #endregion

        public BulkCreateMockTickets(
            string channelName,
            string namespace_,
            List<Model.ModelsMatchingParty> body
        )
        {
            PathParams["channelName"] = channelName;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/mocks/tickets/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public BulkCreateMockTickets.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new BulkCreateMockTickets.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)

            {
                response.Error400 = JsonSerializer.Deserialize<ResponseErrorV1>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)

            {
                response.Error401 = JsonSerializer.Deserialize<ResponseErrorV1>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)

            {
                response.Error403 = JsonSerializer.Deserialize<ResponseErrorV1>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)

            {
                response.Error404 = JsonSerializer.Deserialize<ResponseErrorV1>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)

            {
                response.Error500 = JsonSerializer.Deserialize<ResponseErrorV1>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
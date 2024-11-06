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

using AccelByte.Sdk.Api.Dsartifact.Model;

namespace AccelByte.Sdk.Api.Dsartifact.Operation
{
    /// <summary>
    /// listQueue
    ///
    /// ```
    /// Required permission: ADMIN:DSAM:ARTIFACT:QUEUE [READ]
    /// 
    /// This endpoint is used to get the list of queues on a node
    /// ```
    /// </summary>
    public class ListQueue : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListQueueBuilder Builder { get => new ListQueueBuilder(); }

        public class ListQueueBuilder
            : OperationBuilder<ListQueueBuilder>
        {

            public long? Limit { get; set; }

            public string? Next { get; set; }

            public string? Previous { get; set; }





            internal ListQueueBuilder() { }

            internal ListQueueBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public ListQueueBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public ListQueueBuilder SetNext(string _next)
            {
                Next = _next;
                return this;
            }

            public ListQueueBuilder SetPrevious(string _previous)
            {
                Previous = _previous;
                return this;
            }





            public ListQueue Build(
                string nodeIP
            )
            {
                ListQueue op = new ListQueue(this,
                    nodeIP                    
                );

                op.SetBaseFields<ListQueueBuilder>(this);
                return op;
            }

            public ListQueue.Response Execute(
                string nodeIP
            )
            {
                ListQueue op = Build(
                    nodeIP
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<ListQueue.Response> ExecuteAsync(
                string nodeIP
            )
            {
                ListQueue op = Build(
                    nodeIP
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

        private ListQueue(ListQueueBuilder builder,
            string nodeIP
        )
        {
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Next is not null) QueryParams["next"] = builder.Next;
            if (builder.Previous is not null) QueryParams["previous"] = builder.Previous;
            if (nodeIP is not null) QueryParams["nodeIP"] = nodeIP;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsListQueueResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Dsartifact::ArtifactUploadProcessQueue::ListQueue";
        }

        #endregion

        public ListQueue(
            long? limit,            
            string? next,            
            string? previous,            
            string nodeIP            
        )
        {
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (next is not null) QueryParams["next"] = next;
            if (previous is not null) QueryParams["previous"] = previous;
            if (nodeIP is not null) QueryParams["nodeIP"] = nodeIP;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsartifact/artifacts/queues";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json","text/x-log" };
        
        public ListQueue.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new ListQueue.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.ModelsListQueueResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
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
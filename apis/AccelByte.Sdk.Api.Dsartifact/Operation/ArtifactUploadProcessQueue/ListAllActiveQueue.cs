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
    /// listAllActiveQueue
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSAM:ARTIFACT:QUEUE [READ]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint will list all DSes which artifact is currently in uploading process.
    /// </summary>
    public class ListAllActiveQueue : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListAllActiveQueueBuilder Builder { get => new ListAllActiveQueueBuilder(); }

        public class ListAllActiveQueueBuilder
            : OperationBuilder<ListAllActiveQueueBuilder>
        {

            public long? Limit { get; set; }

            public string? Next { get; set; }

            public string? NodeIP { get; set; }

            public string? PodName { get; set; }

            public string? Previous { get; set; }





            internal ListAllActiveQueueBuilder() { }

            internal ListAllActiveQueueBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public ListAllActiveQueueBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public ListAllActiveQueueBuilder SetNext(string _next)
            {
                Next = _next;
                return this;
            }

            public ListAllActiveQueueBuilder SetNodeIP(string _nodeIP)
            {
                NodeIP = _nodeIP;
                return this;
            }

            public ListAllActiveQueueBuilder SetPodName(string _podName)
            {
                PodName = _podName;
                return this;
            }

            public ListAllActiveQueueBuilder SetPrevious(string _previous)
            {
                Previous = _previous;
                return this;
            }





            public ListAllActiveQueue Build(
                string namespace_
            )
            {
                ListAllActiveQueue op = new ListAllActiveQueue(this,
                    namespace_                    
                );

                op.SetBaseFields<ListAllActiveQueueBuilder>(this);
                return op;
            }

            public ListAllActiveQueue.Response Execute(
                string namespace_
            )
            {
                ListAllActiveQueue op = Build(
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
            public async Task<ListAllActiveQueue.Response> ExecuteAsync(
                string namespace_
            )
            {
                ListAllActiveQueue op = Build(
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

        private ListAllActiveQueue(ListAllActiveQueueBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Next is not null) QueryParams["next"] = builder.Next;
            if (builder.NodeIP is not null) QueryParams["nodeIP"] = builder.NodeIP;
            if (builder.PodName is not null) QueryParams["podName"] = builder.PodName;
            if (builder.Previous is not null) QueryParams["previous"] = builder.Previous;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsListAllQueueResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Dsartifact::ArtifactUploadProcessQueue::ListAllActiveQueue";
        }

        #endregion

        public ListAllActiveQueue(
            string namespace_,            
            long? limit,            
            string? next,            
            string? nodeIP,            
            string? podName,            
            string? previous            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (next is not null) QueryParams["next"] = next;
            if (nodeIP is not null) QueryParams["nodeIP"] = nodeIP;
            if (podName is not null) QueryParams["podName"] = podName;
            if (previous is not null) QueryParams["previous"] = previous;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsartifact/namespaces/{namespace}/artifacts/queues/active/all";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json","text/x-log" };
        
        public ListAllActiveQueue.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new ListAllActiveQueue.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsListAllQueueResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
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
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
    /// deleteNodeByID
    ///
    /// Required permission: ADMIN:DSAM:ARTIFACT:NODES [DELETE]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint will delete a node by IP
    /// </summary>
    public class DeleteNodeByID : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteNodeByIDBuilder Builder { get => new DeleteNodeByIDBuilder(); }

        public class DeleteNodeByIDBuilder
            : OperationBuilder<DeleteNodeByIDBuilder>
        {





            internal DeleteNodeByIDBuilder() { }

            internal DeleteNodeByIDBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteNodeByID Build(
                string nodeIP,
                string podName
            )
            {
                DeleteNodeByID op = new DeleteNodeByID(this,
                    nodeIP,                    
                    podName                    
                );

                op.SetBaseFields<DeleteNodeByIDBuilder>(this);
                return op;
            }

            public DeleteNodeByID.Response Execute(
                string nodeIP,
                string podName
            )
            {
                DeleteNodeByID op = Build(
                    nodeIP,
                    podName
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<DeleteNodeByID.Response> ExecuteAsync(
                string nodeIP,
                string podName
            )
            {
                DeleteNodeByID op = Build(
                    nodeIP,
                    podName
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

        private DeleteNodeByID(DeleteNodeByIDBuilder builder,
            string nodeIP,
            string podName
        )
        {
            
            if (nodeIP is not null) QueryParams["nodeIP"] = nodeIP;
            if (podName is not null) QueryParams["podName"] = podName;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Dsartifact::ArtifactUploadProcessQueue::DeleteNodeByID";
        }

        #endregion

        public DeleteNodeByID(
            string nodeIP,            
            string podName            
        )
        {
            
            if (nodeIP is not null) QueryParams["nodeIP"] = nodeIP;
            if (podName is not null) QueryParams["podName"] = podName;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsartifact/artifacts/nodes/ipaddresses";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json","text/x-log" };
        
        public DeleteNodeByID.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DeleteNodeByID.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)
            
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
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
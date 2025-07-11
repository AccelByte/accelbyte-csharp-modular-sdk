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

using AccelByte.Sdk.Api.Ams.Model;

namespace AccelByte.Sdk.Api.Ams.Operation
{
    /// <summary>
    /// ServerHistory
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:ARMADA:FLEET [READ]
    /// </summary>
    public class ServerHistory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ServerHistoryBuilder Builder { get => new ServerHistoryBuilder(); }

        public class ServerHistoryBuilder
            : OperationBuilder<ServerHistoryBuilder>
        {





            internal ServerHistoryBuilder() { }

            internal ServerHistoryBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public ServerHistory Build(
                string namespace_,
                string serverID
            )
            {
                ServerHistory op = new ServerHistory(this,
                    namespace_,                    
                    serverID                    
                );

                op.SetBaseFields<ServerHistoryBuilder>(this);
                return op;
            }

            public ServerHistory.Response Execute(
                string namespace_,
                string serverID
            )
            {
                ServerHistory op = Build(
                    namespace_,
                    serverID
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<ServerHistory.Response> ExecuteAsync(
                string namespace_,
                string serverID
            )
            {
                ServerHistory op = Build(
                    namespace_,
                    serverID
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

        private ServerHistory(ServerHistoryBuilder builder,
            string namespace_,
            string serverID
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["serverID"] = serverID;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ApiFleetServerHistoryResponse>
        {

            public ResponseErrorResponse? Error400 { get; set; } = null;

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Ams::Servers::ServerHistory";
        }

        #endregion

        public ServerHistory(
            string namespace_,            
            string serverID            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["serverID"] = serverID;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/admin/namespaces/{namespace}/servers/{serverID}/history";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public ServerHistory.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new ServerHistory.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ApiFleetServerHistoryResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
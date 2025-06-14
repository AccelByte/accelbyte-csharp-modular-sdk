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

using AccelByte.Sdk.Api.Dsmc.Model;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// DeleteSession
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:SESSION [DELETE]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint deletes a specified session and its corresponding match result from DB.
    /// </summary>
    public class DeleteSession : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteSessionBuilder Builder { get => new DeleteSessionBuilder(); }

        public class DeleteSessionBuilder
            : OperationBuilder<DeleteSessionBuilder>
        {





            internal DeleteSessionBuilder() { }

            internal DeleteSessionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteSession Build(
                string namespace_,
                string sessionID
            )
            {
                DeleteSession op = new DeleteSession(this,
                    namespace_,                    
                    sessionID                    
                );

                op.SetBaseFields<DeleteSessionBuilder>(this);
                return op;
            }

            public DeleteSession.Response Execute(
                string namespace_,
                string sessionID
            )
            {
                DeleteSession op = Build(
                    namespace_,
                    sessionID
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<DeleteSession.Response> ExecuteAsync(
                string namespace_,
                string sessionID
            )
            {
                DeleteSession op = Build(
                    namespace_,
                    sessionID
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

        private DeleteSession(DeleteSessionBuilder builder,
            string namespace_,
            string sessionID
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionID"] = sessionID;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Dsmc::Admin::DeleteSession";
        }

        #endregion

        public DeleteSession(
            string namespace_,            
            string sessionID            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionID"] = sessionID;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/sessions/{sessionID}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public DeleteSession.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DeleteSession.Response()
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
            else if (code == (HttpStatusCode)500)
            
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
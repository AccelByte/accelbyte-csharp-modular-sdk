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

using AccelByte.Sdk.Api.Session.Model;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// publicUpdateInsertSessionStorageLeader
    ///
    /// 
    /// Update Insert Session Storage Leader. only Leader can update or insert user session storage data Leader.
    /// can store generic json
    /// example json can store :
    /// {
    /// "leader": {
    /// "leader": 1
    /// },
    /// "data": 123
    /// }
    /// game Admin can update or insert session storage
    /// Session Storage feature only available for Gamesession
    /// </summary>
    public class PublicUpdateInsertSessionStorageLeader : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpdateInsertSessionStorageLeaderBuilder Builder { get => new PublicUpdateInsertSessionStorageLeaderBuilder(); }

        public class PublicUpdateInsertSessionStorageLeaderBuilder
            : OperationBuilder<PublicUpdateInsertSessionStorageLeaderBuilder>
        {





            internal PublicUpdateInsertSessionStorageLeaderBuilder() { }

            internal PublicUpdateInsertSessionStorageLeaderBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicUpdateInsertSessionStorageLeader Build(
                Dictionary<string, object> body,
                string namespace_,
                string sessionId
            )
            {
                PublicUpdateInsertSessionStorageLeader op = new PublicUpdateInsertSessionStorageLeader(this,
                    body,                    
                    namespace_,                    
                    sessionId                    
                );

                op.SetBaseFields<PublicUpdateInsertSessionStorageLeaderBuilder>(this);
                return op;
            }

            public PublicUpdateInsertSessionStorageLeader.Response Execute(
                Dictionary<string, object> body,
                string namespace_,
                string sessionId
            )
            {
                PublicUpdateInsertSessionStorageLeader op = Build(
                    body,
                    namespace_,
                    sessionId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<PublicUpdateInsertSessionStorageLeader.Response> ExecuteAsync(
                Dictionary<string, object> body,
                string namespace_,
                string sessionId
            )
            {
                PublicUpdateInsertSessionStorageLeader op = Build(
                    body,
                    namespace_,
                    sessionId
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

        private PublicUpdateInsertSessionStorageLeader(PublicUpdateInsertSessionStorageLeaderBuilder builder,
            Dictionary<string, object> body,
            string namespace_,
            string sessionId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Dictionary<string, object>>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Session::SessionStorage::PublicUpdateInsertSessionStorageLeader";
        }

        #endregion

        public PublicUpdateInsertSessionStorageLeader(
            string namespace_,            
            string sessionId,            
            Dictionary<string, object> body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/sessions/{sessionId}/storage/leader";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicUpdateInsertSessionStorageLeader.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicUpdateInsertSessionStorageLeader.Response()
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
                response.Data = JsonSerializer.Deserialize<Dictionary<string, object>>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
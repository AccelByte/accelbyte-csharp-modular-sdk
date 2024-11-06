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

using AccelByte.Sdk.Api.Sessionhistory.Model;

namespace AccelByte.Sdk.Api.Sessionhistory.Operation
{
    /// <summary>
    /// adminGetMatchmakingDetailBySessionID
    ///
    /// Get detail matchmaking history by session ID.
    /// </summary>
    public class AdminGetMatchmakingDetailBySessionID : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetMatchmakingDetailBySessionIDBuilder Builder { get => new AdminGetMatchmakingDetailBySessionIDBuilder(); }

        public class AdminGetMatchmakingDetailBySessionIDBuilder
            : OperationBuilder<AdminGetMatchmakingDetailBySessionIDBuilder>
        {





            internal AdminGetMatchmakingDetailBySessionIDBuilder() { }

            internal AdminGetMatchmakingDetailBySessionIDBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetMatchmakingDetailBySessionID Build(
                string namespace_,
                string sessionId
            )
            {
                AdminGetMatchmakingDetailBySessionID op = new AdminGetMatchmakingDetailBySessionID(this,
                    namespace_,                    
                    sessionId                    
                );

                op.SetBaseFields<AdminGetMatchmakingDetailBySessionIDBuilder>(this);
                return op;
            }

            public AdminGetMatchmakingDetailBySessionID.Response Execute(
                string namespace_,
                string sessionId
            )
            {
                AdminGetMatchmakingDetailBySessionID op = Build(
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
            public async Task<AdminGetMatchmakingDetailBySessionID.Response> ExecuteAsync(
                string namespace_,
                string sessionId
            )
            {
                AdminGetMatchmakingDetailBySessionID op = Build(
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

        private AdminGetMatchmakingDetailBySessionID(AdminGetMatchmakingDetailBySessionIDBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ApimodelsMatchmakingDetail>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Sessionhistory::GameSessionDetail::AdminGetMatchmakingDetailBySessionID";
        }

        #endregion

        public AdminGetMatchmakingDetailBySessionID(
            string namespace_,            
            string sessionId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionhistory/v1/admin/namespaces/{namespace}/matchmaking/session/{sessionId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminGetMatchmakingDetailBySessionID.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminGetMatchmakingDetailBySessionID.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ApimodelsMatchmakingDetail>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
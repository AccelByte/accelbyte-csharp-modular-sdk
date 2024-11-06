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
    /// adminGetMatchmakingDetailByTicketID
    ///
    /// Get detail matchmaking history by ticket ID.
    /// </summary>
    public class AdminGetMatchmakingDetailByTicketID : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetMatchmakingDetailByTicketIDBuilder Builder { get => new AdminGetMatchmakingDetailByTicketIDBuilder(); }

        public class AdminGetMatchmakingDetailByTicketIDBuilder
            : OperationBuilder<AdminGetMatchmakingDetailByTicketIDBuilder>
        {





            internal AdminGetMatchmakingDetailByTicketIDBuilder() { }

            internal AdminGetMatchmakingDetailByTicketIDBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetMatchmakingDetailByTicketID Build(
                string namespace_,
                string ticketId
            )
            {
                AdminGetMatchmakingDetailByTicketID op = new AdminGetMatchmakingDetailByTicketID(this,
                    namespace_,                    
                    ticketId                    
                );

                op.SetBaseFields<AdminGetMatchmakingDetailByTicketIDBuilder>(this);
                return op;
            }

            public AdminGetMatchmakingDetailByTicketID.Response Execute(
                string namespace_,
                string ticketId
            )
            {
                AdminGetMatchmakingDetailByTicketID op = Build(
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
            public async Task<AdminGetMatchmakingDetailByTicketID.Response> ExecuteAsync(
                string namespace_,
                string ticketId
            )
            {
                AdminGetMatchmakingDetailByTicketID op = Build(
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

        private AdminGetMatchmakingDetailByTicketID(AdminGetMatchmakingDetailByTicketIDBuilder builder,
            string namespace_,
            string ticketId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ticketId"] = ticketId;
            
            

            
            
            

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


            protected override string GetFullOperationId() => "Sessionhistory::GameSessionDetail::AdminGetMatchmakingDetailByTicketID";
        }

        #endregion

        public AdminGetMatchmakingDetailByTicketID(
            string namespace_,            
            string ticketId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ticketId"] = ticketId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionhistory/v1/admin/namespaces/{namespace}/matchmaking/ticket/{ticketId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminGetMatchmakingDetailByTicketID.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminGetMatchmakingDetailByTicketID.Response()
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
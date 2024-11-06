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

using AccelByte.Sdk.Api.Lobby.Model;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// sendPartyFreeformNotificationV1Admin
    ///
    /// Sends notification to a party.
    /// </summary>
    public class SendPartyFreeformNotificationV1Admin : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SendPartyFreeformNotificationV1AdminBuilder Builder { get => new SendPartyFreeformNotificationV1AdminBuilder(); }

        public class SendPartyFreeformNotificationV1AdminBuilder
            : OperationBuilder<SendPartyFreeformNotificationV1AdminBuilder>
        {





            internal SendPartyFreeformNotificationV1AdminBuilder() { }

            internal SendPartyFreeformNotificationV1AdminBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public SendPartyFreeformNotificationV1Admin Build(
                ModelFreeFormNotificationRequestV1 body,
                string namespace_,
                string partyId
            )
            {
                SendPartyFreeformNotificationV1Admin op = new SendPartyFreeformNotificationV1Admin(this,
                    body,                    
                    namespace_,                    
                    partyId                    
                );

                op.SetBaseFields<SendPartyFreeformNotificationV1AdminBuilder>(this);
                return op;
            }

            public SendPartyFreeformNotificationV1Admin.Response Execute(
                ModelFreeFormNotificationRequestV1 body,
                string namespace_,
                string partyId
            )
            {
                SendPartyFreeformNotificationV1Admin op = Build(
                    body,
                    namespace_,
                    partyId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<SendPartyFreeformNotificationV1Admin.Response> ExecuteAsync(
                ModelFreeFormNotificationRequestV1 body,
                string namespace_,
                string partyId
            )
            {
                SendPartyFreeformNotificationV1Admin op = Build(
                    body,
                    namespace_,
                    partyId
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

        private SendPartyFreeformNotificationV1Admin(SendPartyFreeformNotificationV1AdminBuilder builder,
            ModelFreeFormNotificationRequestV1 body,
            string namespace_,
            string partyId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public RestapiErrorResponseV1? Error400 { get; set; } = null;

            public RestapiErrorResponseV1? Error401 { get; set; } = null;

            public RestapiErrorResponseV1? Error403 { get; set; } = null;

            public RestapiErrorResponseV1? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Lobby::Notification::SendPartyFreeformNotificationV1Admin";
        }

        #endregion

        public SendPartyFreeformNotificationV1Admin(
            string namespace_,            
            string partyId,            
            Model.ModelFreeFormNotificationRequestV1 body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/notification/namespaces/{namespace}/parties/{partyId}/freeform/notify";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public SendPartyFreeformNotificationV1Admin.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new SendPartyFreeformNotificationV1Admin.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)
            
            {
                response.Error400 = JsonSerializer.Deserialize<RestapiErrorResponseV1>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            
            {
                response.Error401 = JsonSerializer.Deserialize<RestapiErrorResponseV1>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            
            {
                response.Error403 = JsonSerializer.Deserialize<RestapiErrorResponseV1>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            
            {
                response.Error404 = JsonSerializer.Deserialize<RestapiErrorResponseV1>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }

            return response;
        }
    }

}
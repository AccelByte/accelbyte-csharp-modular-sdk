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

using AccelByte.Sdk.Api.Chat.Model;

namespace AccelByte.Sdk.Api.Chat.Operation
{
    /// <summary>
    /// adminGetInboxStats
    ///
    /// Get inbox stats
    /// </summary>
    public class AdminGetInboxStats : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetInboxStatsBuilder Builder { get => new AdminGetInboxStatsBuilder(); }

        public class AdminGetInboxStatsBuilder
            : OperationBuilder<AdminGetInboxStatsBuilder>
        {

            public List<string>? MessageId { get; set; }





            internal AdminGetInboxStatsBuilder() { }

            internal AdminGetInboxStatsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminGetInboxStatsBuilder SetMessageId(List<string> _messageId)
            {
                MessageId = _messageId;
                return this;
            }





            public AdminGetInboxStats Build(
                string namespace_
            )
            {
                AdminGetInboxStats op = new AdminGetInboxStats(this,
                    namespace_                    
                );

                op.SetBaseFields<AdminGetInboxStatsBuilder>(this);
                return op;
            }

            public AdminGetInboxStats.Response Execute(
                string namespace_
            )
            {
                AdminGetInboxStats op = Build(
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
            public async Task<AdminGetInboxStats.Response> ExecuteAsync(
                string namespace_
            )
            {
                AdminGetInboxStats op = Build(
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

        private AdminGetInboxStats(AdminGetInboxStatsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.MessageId is not null) QueryParams["messageId"] = builder.MessageId;
            

            
            CollectionFormatMap["messageId"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsGetInboxStatsResponse>
        {

            public RestapiErrorResponseBody? Error400 { get; set; } = null;

            public RestapiErrorResponseBody? Error401 { get; set; } = null;

            public RestapiErrorResponseBody? Error403 { get; set; } = null;

            public RestapiErrorResponseBody? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Chat::Inbox::AdminGetInboxStats";
        }

        #endregion

        public AdminGetInboxStats(
            string namespace_,            
            List<string>? messageId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (messageId is not null) QueryParams["messageId"] = messageId;
            

            
            CollectionFormatMap["messageId"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/v1/admin/inbox/namespaces/{namespace}/stats";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminGetInboxStats.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminGetInboxStats.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsGetInboxStatsResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
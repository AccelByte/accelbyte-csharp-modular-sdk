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
    /// adminChannelTopicInfo
    ///
    /// Get chat list of topic in a namespace.
    /// </summary>
    public class AdminChannelTopicInfo : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminChannelTopicInfoBuilder Builder { get => new AdminChannelTopicInfoBuilder(); }

        public class AdminChannelTopicInfoBuilder
            : OperationBuilder<AdminChannelTopicInfoBuilder>
        {





            internal AdminChannelTopicInfoBuilder() { }

            internal AdminChannelTopicInfoBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminChannelTopicInfo Build(
                string namespace_,
                string topic
            )
            {
                AdminChannelTopicInfo op = new AdminChannelTopicInfo(this,
                    namespace_,                    
                    topic                    
                );

                op.SetBaseFields<AdminChannelTopicInfoBuilder>(this);
                return op;
            }

            public AdminChannelTopicInfo.Response Execute(
                string namespace_,
                string topic
            )
            {
                AdminChannelTopicInfo op = Build(
                    namespace_,
                    topic
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<AdminChannelTopicInfo.Response> ExecuteAsync(
                string namespace_,
                string topic
            )
            {
                AdminChannelTopicInfo op = Build(
                    namespace_,
                    topic
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

        private AdminChannelTopicInfo(AdminChannelTopicInfoBuilder builder,
            string namespace_,
            string topic
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsChannelTopicResponse>
        {

            public RestapiErrorResponseBody? Error400 { get; set; } = null;

            public RestapiErrorResponseBody? Error401 { get; set; } = null;

            public RestapiErrorResponseBody? Error403 { get; set; } = null;

            public RestapiErrorResponseBody? Error404 { get; set; } = null;

            public RestapiErrorResponseBody? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Chat::Topic::AdminChannelTopicInfo";
        }

        #endregion

        public AdminChannelTopicInfo(
            string namespace_,            
            string topic            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/admin/namespaces/{namespace}/topic/{topic}/channel";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminChannelTopicInfo.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminChannelTopicInfo.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsChannelTopicResponse>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
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
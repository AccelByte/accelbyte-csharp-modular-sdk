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
    /// getNotificationTopicV1Admin
    ///
    /// Get topic information by topic name.
    /// 
    /// Action Code: 50215
    /// </summary>
    public class GetNotificationTopicV1Admin : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetNotificationTopicV1AdminBuilder Builder { get => new GetNotificationTopicV1AdminBuilder(); }

        public class GetNotificationTopicV1AdminBuilder
            : OperationBuilder<GetNotificationTopicV1AdminBuilder>
        {





            internal GetNotificationTopicV1AdminBuilder() { }

            internal GetNotificationTopicV1AdminBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetNotificationTopicV1Admin Build(
                string namespace_,
                string topicName
            )
            {
                GetNotificationTopicV1Admin op = new GetNotificationTopicV1Admin(this,
                    namespace_,                    
                    topicName                    
                );

                op.SetBaseFields<GetNotificationTopicV1AdminBuilder>(this);
                return op;
            }

            public GetNotificationTopicV1Admin.Response Execute(
                string namespace_,
                string topicName
            )
            {
                GetNotificationTopicV1Admin op = Build(
                    namespace_,
                    topicName
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<GetNotificationTopicV1Admin.Response> ExecuteAsync(
                string namespace_,
                string topicName
            )
            {
                GetNotificationTopicV1Admin op = Build(
                    namespace_,
                    topicName
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

        private GetNotificationTopicV1Admin(GetNotificationTopicV1AdminBuilder builder,
            string namespace_,
            string topicName
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topicName"] = topicName;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelNotificationTopicResponseV1>
        {

            public RestapiErrorResponseV1? Error401 { get; set; } = null;

            public RestapiErrorResponseV1? Error403 { get; set; } = null;

            public RestapiErrorResponseV1? Error404 { get; set; } = null;

            public RestapiErrorResponseV1? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Lobby::Notification::GetNotificationTopicV1Admin";
        }

        #endregion

        public GetNotificationTopicV1Admin(
            string namespace_,            
            string topicName            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topicName"] = topicName;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/notification/namespaces/{namespace}/topics/{topicName}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public GetNotificationTopicV1Admin.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetNotificationTopicV1Admin.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelNotificationTopicResponseV1>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
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
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<RestapiErrorResponseV1>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
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
    /// deleteNotificationTemplateSlugV1Admin
    ///
    /// Delete template slug in notification template
    /// 
    /// Action Code: 50206
    /// </summary>
    public class DeleteNotificationTemplateSlugV1Admin : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteNotificationTemplateSlugV1AdminBuilder Builder { get => new DeleteNotificationTemplateSlugV1AdminBuilder(); }

        public class DeleteNotificationTemplateSlugV1AdminBuilder
            : OperationBuilder<DeleteNotificationTemplateSlugV1AdminBuilder>
        {





            internal DeleteNotificationTemplateSlugV1AdminBuilder() { }

            internal DeleteNotificationTemplateSlugV1AdminBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteNotificationTemplateSlugV1Admin Build(
                string namespace_,
                string templateSlug
            )
            {
                DeleteNotificationTemplateSlugV1Admin op = new DeleteNotificationTemplateSlugV1Admin(this,
                    namespace_,                    
                    templateSlug                    
                );

                op.SetBaseFields<DeleteNotificationTemplateSlugV1AdminBuilder>(this);
                return op;
            }

            public DeleteNotificationTemplateSlugV1Admin.Response Execute(
                string namespace_,
                string templateSlug
            )
            {
                DeleteNotificationTemplateSlugV1Admin op = Build(
                    namespace_,
                    templateSlug
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<DeleteNotificationTemplateSlugV1Admin.Response> ExecuteAsync(
                string namespace_,
                string templateSlug
            )
            {
                DeleteNotificationTemplateSlugV1Admin op = Build(
                    namespace_,
                    templateSlug
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

        private DeleteNotificationTemplateSlugV1Admin(DeleteNotificationTemplateSlugV1AdminBuilder builder,
            string namespace_,
            string templateSlug
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["templateSlug"] = templateSlug;
            
            

            
            
            

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


            protected override string GetFullOperationId() => "Lobby::Notification::DeleteNotificationTemplateSlugV1Admin";
        }

        #endregion

        public DeleteNotificationTemplateSlugV1Admin(
            string namespace_,            
            string templateSlug            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["templateSlug"] = templateSlug;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/notification/namespaces/{namespace}/templates/{templateSlug}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public DeleteNotificationTemplateSlugV1Admin.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DeleteNotificationTemplateSlugV1Admin.Response()
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
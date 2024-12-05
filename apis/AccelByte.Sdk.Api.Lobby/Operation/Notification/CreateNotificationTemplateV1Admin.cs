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
    /// createNotificationTemplateV1Admin
    ///
    /// Create new notification template. Include handlebars {{key}} for replaceable contexts. The key inside
    /// handlebars will be the key to be replaced when sending notification. Already existing template with the same
    /// slug and language can not be created.
    /// 
    /// Check model description for detailed input restrictions.
    /// 
    /// Action Code: 50204
    /// </summary>
    public class CreateNotificationTemplateV1Admin : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateNotificationTemplateV1AdminBuilder Builder { get => new CreateNotificationTemplateV1AdminBuilder(); }

        public class CreateNotificationTemplateV1AdminBuilder
            : OperationBuilder<CreateNotificationTemplateV1AdminBuilder>
        {





            internal CreateNotificationTemplateV1AdminBuilder() { }

            internal CreateNotificationTemplateV1AdminBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateNotificationTemplateV1Admin Build(
                ModelCreateTemplateRequest body,
                string namespace_
            )
            {
                CreateNotificationTemplateV1Admin op = new CreateNotificationTemplateV1Admin(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<CreateNotificationTemplateV1AdminBuilder>(this);
                return op;
            }

            public CreateNotificationTemplateV1Admin.Response Execute(
                ModelCreateTemplateRequest body,
                string namespace_
            )
            {
                CreateNotificationTemplateV1Admin op = Build(
                    body,
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
            public async Task<CreateNotificationTemplateV1Admin.Response> ExecuteAsync(
                ModelCreateTemplateRequest body,
                string namespace_
            )
            {
                CreateNotificationTemplateV1Admin op = Build(
                    body,
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

        private CreateNotificationTemplateV1Admin(CreateNotificationTemplateV1AdminBuilder builder,
            ModelCreateTemplateRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





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

            public RestapiErrorResponseV1? Error409 { get; set; } = null;


            protected override string GetFullOperationId() => "Lobby::Notification::CreateNotificationTemplateV1Admin";
        }

        #endregion

        public CreateNotificationTemplateV1Admin(
            string namespace_,
            Model.ModelCreateTemplateRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/notification/namespaces/{namespace}/templates";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public CreateNotificationTemplateV1Admin.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new CreateNotificationTemplateV1Admin.Response()
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
            else if (code == (HttpStatusCode)409)

            {
                response.Error409 = JsonSerializer.Deserialize<RestapiErrorResponseV1>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }

            return response;
        }
    }

}
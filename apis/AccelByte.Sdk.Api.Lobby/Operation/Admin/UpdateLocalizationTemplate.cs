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
    /// updateLocalizationTemplate
    ///
    /// Modify draft template
    /// </summary>
    public class UpdateLocalizationTemplate : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateLocalizationTemplateBuilder Builder { get => new UpdateLocalizationTemplateBuilder(); }

        public class UpdateLocalizationTemplateBuilder
            : OperationBuilder<UpdateLocalizationTemplateBuilder>
        {





            internal UpdateLocalizationTemplateBuilder() { }

            internal UpdateLocalizationTemplateBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateLocalizationTemplate Build(
                ModelUpdateTemplateRequest body,
                string namespace_,
                string templateLanguage,
                string templateSlug
            )
            {
                UpdateLocalizationTemplate op = new UpdateLocalizationTemplate(this,
                    body,                    
                    namespace_,                    
                    templateLanguage,                    
                    templateSlug                    
                );

                op.SetBaseFields<UpdateLocalizationTemplateBuilder>(this);
                return op;
            }

            public UpdateLocalizationTemplate.Response Execute(
                ModelUpdateTemplateRequest body,
                string namespace_,
                string templateLanguage,
                string templateSlug
            )
            {
                UpdateLocalizationTemplate op = Build(
                    body,
                    namespace_,
                    templateLanguage,
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
            public async Task<UpdateLocalizationTemplate.Response> ExecuteAsync(
                ModelUpdateTemplateRequest body,
                string namespace_,
                string templateLanguage,
                string templateSlug
            )
            {
                UpdateLocalizationTemplate op = Build(
                    body,
                    namespace_,
                    templateLanguage,
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

        private UpdateLocalizationTemplate(UpdateLocalizationTemplateBuilder builder,
            ModelUpdateTemplateRequest body,
            string namespace_,
            string templateLanguage,
            string templateSlug
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["templateLanguage"] = templateLanguage;
            PathParams["templateSlug"] = templateSlug;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public RestapiErrorResponseBody? Error400 { get; set; } = null;

            public RestapiErrorResponseBody? Error401 { get; set; } = null;

            public RestapiErrorResponseBody? Error403 { get; set; } = null;

            public RestapiErrorResponseBody? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Lobby::Admin::UpdateLocalizationTemplate";
        }

        #endregion

        public UpdateLocalizationTemplate(
            string namespace_,            
            string templateLanguage,            
            string templateSlug,            
            Model.ModelUpdateTemplateRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["templateLanguage"] = templateLanguage;
            PathParams["templateSlug"] = templateSlug;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public UpdateLocalizationTemplate.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdateLocalizationTemplate.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)
            
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

            return response;
        }
    }

}
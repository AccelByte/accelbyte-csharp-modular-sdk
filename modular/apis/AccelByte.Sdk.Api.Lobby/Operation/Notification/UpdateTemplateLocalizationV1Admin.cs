// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
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

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Lobby.Model;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// updateTemplateLocalizationV1Admin
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:NOTIFICATION [UPDATE]` with scope `social`
    /// 
    /// update template localization
    /// 
    /// Action Code: 50208
    /// </summary>
    public class UpdateTemplateLocalizationV1Admin : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateTemplateLocalizationV1AdminBuilder Builder { get => new UpdateTemplateLocalizationV1AdminBuilder(); }

        public class UpdateTemplateLocalizationV1AdminBuilder
            : OperationBuilder<UpdateTemplateLocalizationV1AdminBuilder>
        {





            internal UpdateTemplateLocalizationV1AdminBuilder() { }

            internal UpdateTemplateLocalizationV1AdminBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateTemplateLocalizationV1Admin Build(
                ModelUpdateTemplateRequest body,
                string namespace_,
                string templateLanguage,
                string templateSlug
            )
            {
                UpdateTemplateLocalizationV1Admin op = new UpdateTemplateLocalizationV1Admin(this,
                    body,                    
                    namespace_,                    
                    templateLanguage,                    
                    templateSlug                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public void Execute(
                ModelUpdateTemplateRequest body,
                string namespace_,
                string templateLanguage,
                string templateSlug
            )
            {
                UpdateTemplateLocalizationV1Admin op = Build(
                    body,
                    namespace_,
                    templateLanguage,
                    templateSlug
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private UpdateTemplateLocalizationV1Admin(UpdateTemplateLocalizationV1AdminBuilder builder,
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

        public UpdateTemplateLocalizationV1Admin(
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

        public override string Path => "/lobby/v1/admin/notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
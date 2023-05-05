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
    /// deleteNotificationTemplateSlugV1Admin
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:NOTIFICATION [DELETE]` with scope `social`
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
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public void Execute(
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
                op.ParseResponse(
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
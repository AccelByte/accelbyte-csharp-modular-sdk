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
    /// publishTemplate
    ///
    /// Required permission : `NAMESPACE:{namespace}:TEMPLATE [CREATE]` with scope `social`
    /// 
    /// Publish notification template draft. Empty draft can not be published.
    /// </summary>
    public class PublishTemplate : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublishTemplateBuilder Builder { get => new PublishTemplateBuilder(); }

        public class PublishTemplateBuilder
            : OperationBuilder<PublishTemplateBuilder>
        {





            internal PublishTemplateBuilder() { }

            internal PublishTemplateBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublishTemplate Build(
                string namespace_,
                string templateLanguage,
                string templateSlug
            )
            {
                PublishTemplate op = new PublishTemplate(this,
                    namespace_,
                    templateLanguage,
                    templateSlug
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public void Execute(
                string namespace_,
                string templateLanguage,
                string templateSlug
            )
            {
                PublishTemplate op = Build(
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

        private PublishTemplate(PublishTemplateBuilder builder,
            string namespace_,
            string templateLanguage,
            string templateSlug
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["templateLanguage"] = templateLanguage;
            PathParams["templateSlug"] = templateSlug;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublishTemplate(
            string namespace_,
            string templateLanguage,
            string templateSlug
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["templateLanguage"] = templateLanguage;
            PathParams["templateSlug"] = templateSlug;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage}/publish";

        public override HttpMethod Method => HttpMethod.Post;

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
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
    /// deleteTemplateLocalization
    ///
    /// Required permission : `NAMESPACE:{namespace}:TEMPLATE [DELETE]` with scope `social`
    /// 
    /// Delete all template in a slug
    /// </summary>
    public class DeleteTemplateLocalization : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteTemplateLocalizationBuilder Builder { get => new DeleteTemplateLocalizationBuilder(); }

        public class DeleteTemplateLocalizationBuilder
            : OperationBuilder<DeleteTemplateLocalizationBuilder>
        {





            internal DeleteTemplateLocalizationBuilder() { }

            internal DeleteTemplateLocalizationBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteTemplateLocalization Build(
                string namespace_,
                string templateLanguage,
                string templateSlug
            )
            {
                DeleteTemplateLocalization op = new DeleteTemplateLocalization(this,
                    namespace_,
                    templateLanguage,
                    templateSlug
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string namespace_,
                string templateLanguage,
                string templateSlug
            )
            {
                DeleteTemplateLocalization op = Build(
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

        private DeleteTemplateLocalization(DeleteTemplateLocalizationBuilder builder,
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

        public DeleteTemplateLocalization(
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

        public override string Path => "/notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage}";

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
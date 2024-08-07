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
    /// deleteTemplateLocalizationV1Admin
    ///
    /// Delete template localization
    /// 
    /// Action Code: 50209
    /// </summary>
    public class DeleteTemplateLocalizationV1Admin : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteTemplateLocalizationV1AdminBuilder Builder { get => new DeleteTemplateLocalizationV1AdminBuilder(); }

        public class DeleteTemplateLocalizationV1AdminBuilder
            : OperationBuilder<DeleteTemplateLocalizationV1AdminBuilder>
        {





            internal DeleteTemplateLocalizationV1AdminBuilder() { }

            internal DeleteTemplateLocalizationV1AdminBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteTemplateLocalizationV1Admin Build(
                string namespace_,
                string templateLanguage,
                string templateSlug
            )
            {
                DeleteTemplateLocalizationV1Admin op = new DeleteTemplateLocalizationV1Admin(this,
                    namespace_,
                    templateLanguage,
                    templateSlug
                );

                op.SetBaseFields<DeleteTemplateLocalizationV1AdminBuilder>(this);
                return op;
            }

            public void Execute(
                string namespace_,
                string templateLanguage,
                string templateSlug
            )
            {
                DeleteTemplateLocalizationV1Admin op = Build(
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
            public async Task ExecuteAsync(
                string namespace_,
                string templateLanguage,
                string templateSlug
            )
            {
                DeleteTemplateLocalizationV1Admin op = Build(
                    namespace_,
                    templateLanguage,
                    templateSlug
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private DeleteTemplateLocalizationV1Admin(DeleteTemplateLocalizationV1AdminBuilder builder,
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

        public DeleteTemplateLocalizationV1Admin(
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

        public override string Path => "/lobby/v1/admin/notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage}";

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
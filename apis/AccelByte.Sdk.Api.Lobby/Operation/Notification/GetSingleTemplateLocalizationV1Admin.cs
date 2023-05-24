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
    /// getSingleTemplateLocalizationV1Admin
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:NOTIFICATION [READ]` with scope `social`
    /// 
    /// Get a template localization
    /// 
    /// Action Code: 50207
    /// </summary>
    public class GetSingleTemplateLocalizationV1Admin : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetSingleTemplateLocalizationV1AdminBuilder Builder { get => new GetSingleTemplateLocalizationV1AdminBuilder(); }

        public class GetSingleTemplateLocalizationV1AdminBuilder
            : OperationBuilder<GetSingleTemplateLocalizationV1AdminBuilder>
        {





            internal GetSingleTemplateLocalizationV1AdminBuilder() { }

            internal GetSingleTemplateLocalizationV1AdminBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetSingleTemplateLocalizationV1Admin Build(
                string namespace_,
                string templateLanguage,
                string templateSlug
            )
            {
                GetSingleTemplateLocalizationV1Admin op = new GetSingleTemplateLocalizationV1Admin(this,
                    namespace_,
                    templateLanguage,
                    templateSlug
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelLocalization? Execute(
                string namespace_,
                string templateLanguage,
                string templateSlug
            )
            {
                GetSingleTemplateLocalizationV1Admin op = Build(
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
        }

        private GetSingleTemplateLocalizationV1Admin(GetSingleTemplateLocalizationV1AdminBuilder builder,
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

        public GetSingleTemplateLocalizationV1Admin(
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

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelLocalization? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelLocalization>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelLocalization>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
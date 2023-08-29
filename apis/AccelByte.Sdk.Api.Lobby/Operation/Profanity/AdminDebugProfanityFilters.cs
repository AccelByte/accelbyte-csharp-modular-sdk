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
    /// adminDebugProfanityFilters
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:PROFANITY [READ]` with scope `social`
    /// 
    /// get the list of filters that would modify the phrase
    /// </summary>
    public class AdminDebugProfanityFilters : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDebugProfanityFiltersBuilder Builder { get => new AdminDebugProfanityFiltersBuilder(); }

        public class AdminDebugProfanityFiltersBuilder
            : OperationBuilder<AdminDebugProfanityFiltersBuilder>
        {





            internal AdminDebugProfanityFiltersBuilder() { }

            internal AdminDebugProfanityFiltersBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDebugProfanityFilters Build(
                ModelsDebugProfanityFilterRequest body,
                string namespace_
            )
            {
                AdminDebugProfanityFilters op = new AdminDebugProfanityFilters(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public List<Model.ModelsProfanityFilter>? Execute(
                ModelsDebugProfanityFilterRequest body,
                string namespace_
            )
            {
                AdminDebugProfanityFilters op = Build(
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
        }

        private AdminDebugProfanityFilters(AdminDebugProfanityFiltersBuilder builder,
            ModelsDebugProfanityFilterRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDebugProfanityFilters(
            string namespace_,
            Model.ModelsDebugProfanityFilterRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/profanity/namespaces/{namespace}/filters/debug";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.ModelsProfanityFilter>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsProfanityFilter>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsProfanityFilter>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
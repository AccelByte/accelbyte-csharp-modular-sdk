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
    /// getSlugTemplate
    ///
    /// Get all templates in a namespace
    /// </summary>
    public class GetSlugTemplate : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetSlugTemplateBuilder Builder { get => new GetSlugTemplateBuilder(); }

        public class GetSlugTemplateBuilder
            : OperationBuilder<GetSlugTemplateBuilder>
        {

            public string? After { get; set; }

            public string? Before { get; set; }

            public long? Limit { get; set; }





            internal GetSlugTemplateBuilder() { }

            internal GetSlugTemplateBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetSlugTemplateBuilder SetAfter(string _after)
            {
                After = _after;
                return this;
            }

            public GetSlugTemplateBuilder SetBefore(string _before)
            {
                Before = _before;
                return this;
            }

            public GetSlugTemplateBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }





            public GetSlugTemplate Build(
                string namespace_,
                string templateSlug
            )
            {
                GetSlugTemplate op = new GetSlugTemplate(this,
                    namespace_,
                    templateSlug
                );

                op.SetBaseFields<GetSlugTemplateBuilder>(this);
                return op;
            }

            public Model.ModelTemplateLocalizationResponse? Execute(
                string namespace_,
                string templateSlug
            )
            {
                GetSlugTemplate op = Build(
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
            public async Task<Model.ModelTemplateLocalizationResponse?> ExecuteAsync(
                string namespace_,
                string templateSlug
            )
            {
                GetSlugTemplate op = Build(
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

        private GetSlugTemplate(GetSlugTemplateBuilder builder,
            string namespace_,
            string templateSlug
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["templateSlug"] = templateSlug;

            if (builder.After is not null) QueryParams["after"] = builder.After;
            if (builder.Before is not null) QueryParams["before"] = builder.Before;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetSlugTemplate(
            string namespace_,
            string templateSlug,
            string? after,
            string? before,
            long? limit
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["templateSlug"] = templateSlug;

            if (after is not null) QueryParams["after"] = after;
            if (before is not null) QueryParams["before"] = before;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/notification/namespaces/{namespace}/templates/{templateSlug}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelTemplateLocalizationResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelTemplateLocalizationResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelTemplateLocalizationResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
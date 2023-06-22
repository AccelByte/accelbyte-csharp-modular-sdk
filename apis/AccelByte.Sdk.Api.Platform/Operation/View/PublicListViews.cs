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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// publicListViews
    ///
    /// This API is used to get all views.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource=NAMESPACE:{namespace}:USER:{userId}:STORE, action=2 (READ)
    ///   *  Optional permission : resource="PREVIEW", action=1(CREATE) (user with this permission can view draft store views)
    ///   *  Optional permission : resource="SANDBOX", action=1(CREATE) (user with this permission can view draft store views)
    ///   *  Returns : all views
    /// </summary>
    public class PublicListViews : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicListViewsBuilder Builder { get => new PublicListViewsBuilder(); }

        public class PublicListViewsBuilder
            : OperationBuilder<PublicListViewsBuilder>
        {

            public string? Language { get; set; }

            public string? StoreId { get; set; }





            internal PublicListViewsBuilder() { }

            internal PublicListViewsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicListViewsBuilder SetLanguage(string _language)
            {
                Language = _language;
                return this;
            }

            public PublicListViewsBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }





            public PublicListViews Build(
                string namespace_,
                string userId
            )
            {
                PublicListViews op = new PublicListViews(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public List<Model.ViewInfo>? Execute(
                string namespace_,
                string userId
            )
            {
                PublicListViews op = Build(
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }

            public List<Model.ViewInfo<T1>>? Execute<T1>(
                string namespace_,
                string userId
            )
            {
                PublicListViews op = Build(
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private PublicListViews(PublicListViewsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.Language is not null) QueryParams["language"] = builder.Language;
            if (builder.StoreId is not null) QueryParams["storeId"] = builder.StoreId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicListViews(
            string namespace_,
            string userId,
            string? language,
            string? storeId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (language is not null) QueryParams["language"] = language;
            if (storeId is not null) QueryParams["storeId"] = storeId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/views";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.ViewInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ViewInfo>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ViewInfo>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public List<Model.ViewInfo<T1>>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ViewInfo<T1>>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ViewInfo<T1>>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}
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
    /// publicListActiveSections
    ///
    /// This API is used to list active section contents.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource=NAMESPACE:{namespace}:USER:{userId}:STORE, action=2 (READ)
    ///   *  Optional permission : resource="PREVIEW", action=1(CREATE) (user with this permission can view draft store sections)
    ///   *  Optional permission : resource="SANDBOX", action=1(CREATE) (user with this permission can view draft store sections)
    ///   *  Returns : active section contents
    /// </summary>
    public class PublicListActiveSections : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicListActiveSectionsBuilder Builder { get => new PublicListActiveSectionsBuilder(); }

        public class PublicListActiveSectionsBuilder
            : OperationBuilder<PublicListActiveSectionsBuilder>
        {

            public string? Language { get; set; }

            public string? Region { get; set; }

            public string? StoreId { get; set; }

            public string? ViewId { get; set; }





            internal PublicListActiveSectionsBuilder() { }

            internal PublicListActiveSectionsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicListActiveSectionsBuilder SetLanguage(string _language)
            {
                Language = _language;
                return this;
            }

            public PublicListActiveSectionsBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }

            public PublicListActiveSectionsBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }

            public PublicListActiveSectionsBuilder SetViewId(string _viewId)
            {
                ViewId = _viewId;
                return this;
            }





            public PublicListActiveSections Build(
                string namespace_,
                string userId
            )
            {
                PublicListActiveSections op = new PublicListActiveSections(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public List<Model.SectionInfo>? Execute(
                string namespace_,
                string userId
            )
            {
                PublicListActiveSections op = Build(
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

            public List<Model.SectionInfo<T1, T2>>? Execute<T1, T2>(
                string namespace_,
                string userId
            )
            {
                PublicListActiveSections op = Build(
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private PublicListActiveSections(PublicListActiveSectionsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.Language is not null) QueryParams["language"] = builder.Language;
            if (builder.Region is not null) QueryParams["region"] = builder.Region;
            if (builder.StoreId is not null) QueryParams["storeId"] = builder.StoreId;
            if (builder.ViewId is not null) QueryParams["viewId"] = builder.ViewId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicListActiveSections(
            string namespace_,
            string userId,
            string? language,
            string? region,
            string? storeId,
            string? viewId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (language is not null) QueryParams["language"] = language;
            if (region is not null) QueryParams["region"] = region;
            if (storeId is not null) QueryParams["storeId"] = storeId;
            if (viewId is not null) QueryParams["viewId"] = viewId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/sections";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.SectionInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.SectionInfo>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.SectionInfo>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public List<Model.SectionInfo<T1, T2>>? ParseResponse<T1, T2>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.SectionInfo<T1, T2>>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.SectionInfo<T1, T2>>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}
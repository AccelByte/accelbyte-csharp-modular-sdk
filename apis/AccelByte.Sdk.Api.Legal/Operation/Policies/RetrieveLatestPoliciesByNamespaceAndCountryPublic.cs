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

using AccelByte.Sdk.Api.Legal.Model;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// retrieveLatestPoliciesByNamespaceAndCountryPublic
    ///
    /// Retrieve all active latest policies based on a namespace and country.
    /// Other detail info:
    /// 
    ///   * Leave the policyType empty if you want to be responded with all policy type
    ///   *  Fill the tags if you want to filter the responded policy by tags
    ///   *  Fill the defaultOnEmpty with true if you want to be responded with default country-specific policy if your requested country is not exist
    ///   *  Fill the alwaysIncludeDefault with true if you want to be responded with always include default policy. If there are duplicate policies (default policies and country specific policies with same base policy) it'll include policy with same country code, for example:
    ///     * Document 1 (default): Region US (default), UA
    ///     * Document 2 (default): Region US (default)
    ///     * Document 3 (default): Region US (default)
    ///     * User: Region UA
    ///     * Query: alwaysIncludeDefault: true
    ///     * Response: Document 1 (UA), Document 2 (US), Document 3 (US)
    /// </summary>
    public class RetrieveLatestPoliciesByNamespaceAndCountryPublic : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveLatestPoliciesByNamespaceAndCountryPublicBuilder Builder { get => new RetrieveLatestPoliciesByNamespaceAndCountryPublicBuilder(); }

        public class RetrieveLatestPoliciesByNamespaceAndCountryPublicBuilder
            : OperationBuilder<RetrieveLatestPoliciesByNamespaceAndCountryPublicBuilder>
        {

            public bool? AlwaysIncludeDefault { get; set; }

            public bool? DefaultOnEmpty { get; set; }

            public RetrieveLatestPoliciesByNamespaceAndCountryPublicPolicyType? PolicyType { get; set; }

            public string? Tags { get; set; }





            internal RetrieveLatestPoliciesByNamespaceAndCountryPublicBuilder() { }

            internal RetrieveLatestPoliciesByNamespaceAndCountryPublicBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public RetrieveLatestPoliciesByNamespaceAndCountryPublicBuilder SetAlwaysIncludeDefault(bool _alwaysIncludeDefault)
            {
                AlwaysIncludeDefault = _alwaysIncludeDefault;
                return this;
            }

            public RetrieveLatestPoliciesByNamespaceAndCountryPublicBuilder SetDefaultOnEmpty(bool _defaultOnEmpty)
            {
                DefaultOnEmpty = _defaultOnEmpty;
                return this;
            }

            public RetrieveLatestPoliciesByNamespaceAndCountryPublicBuilder SetPolicyType(RetrieveLatestPoliciesByNamespaceAndCountryPublicPolicyType _policyType)
            {
                PolicyType = _policyType;
                return this;
            }

            public RetrieveLatestPoliciesByNamespaceAndCountryPublicBuilder SetTags(string _tags)
            {
                Tags = _tags;
                return this;
            }





            public RetrieveLatestPoliciesByNamespaceAndCountryPublic Build(
                string countryCode,
                string namespace_
            )
            {
                RetrieveLatestPoliciesByNamespaceAndCountryPublic op = new RetrieveLatestPoliciesByNamespaceAndCountryPublic(this,
                    countryCode,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public List<Model.RetrievePolicyPublicResponse>? Execute(
                string countryCode,
                string namespace_
            )
            {
                RetrieveLatestPoliciesByNamespaceAndCountryPublic op = Build(
                    countryCode,
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

        private RetrieveLatestPoliciesByNamespaceAndCountryPublic(RetrieveLatestPoliciesByNamespaceAndCountryPublicBuilder builder,
            string countryCode,
            string namespace_
        )
        {
            PathParams["countryCode"] = countryCode;
            PathParams["namespace"] = namespace_;

            if (builder.AlwaysIncludeDefault != null) QueryParams["alwaysIncludeDefault"] = Convert.ToString(builder.AlwaysIncludeDefault)!;
            if (builder.DefaultOnEmpty != null) QueryParams["defaultOnEmpty"] = Convert.ToString(builder.DefaultOnEmpty)!;
            if (builder.PolicyType is not null) QueryParams["policyType"] = builder.PolicyType.Value;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;






        }
        #endregion

        public RetrieveLatestPoliciesByNamespaceAndCountryPublic(
            string countryCode,
            string namespace_,
            bool? alwaysIncludeDefault,
            bool? defaultOnEmpty,
            RetrieveLatestPoliciesByNamespaceAndCountryPublicPolicyType? policyType,
            string? tags
        )
        {
            PathParams["countryCode"] = countryCode;
            PathParams["namespace"] = namespace_;

            if (alwaysIncludeDefault != null) QueryParams["alwaysIncludeDefault"] = Convert.ToString(alwaysIncludeDefault)!;
            if (defaultOnEmpty != null) QueryParams["defaultOnEmpty"] = Convert.ToString(defaultOnEmpty)!;
            if (policyType is not null) QueryParams["policyType"] = policyType.Value;
            if (tags is not null) QueryParams["tags"] = tags;






        }

        public override string Path => "/agreement/public/policies/namespaces/{namespace}/countries/{countryCode}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.RetrievePolicyPublicResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.RetrievePolicyPublicResponse>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.RetrievePolicyPublicResponse>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class RetrieveLatestPoliciesByNamespaceAndCountryPublicPolicyType : StringEnum<RetrieveLatestPoliciesByNamespaceAndCountryPublicPolicyType>
    {
        public static readonly RetrieveLatestPoliciesByNamespaceAndCountryPublicPolicyType LEGALDOCUMENTTYPE
            = new RetrieveLatestPoliciesByNamespaceAndCountryPublicPolicyType("LEGAL_DOCUMENT_TYPE");

        public static readonly RetrieveLatestPoliciesByNamespaceAndCountryPublicPolicyType MARKETINGPREFERENCETYPE
            = new RetrieveLatestPoliciesByNamespaceAndCountryPublicPolicyType("MARKETING_PREFERENCE_TYPE");


        public static implicit operator RetrieveLatestPoliciesByNamespaceAndCountryPublicPolicyType(string value)
        {
            return NewValue(value);
        }

        public RetrieveLatestPoliciesByNamespaceAndCountryPublicPolicyType(string enumValue)
            : base(enumValue)
        {

        }
    }

}
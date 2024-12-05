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

using AccelByte.Sdk.Api.Legal.Model;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// retrieveLatestPolicies
    ///
    /// Retrieve all active latest policies based on a country.
    /// Other detail info:
    /// 
    ///   * Leave the policyType empty if you want to be responded with all policy type
    ///   *  Fill the tags if you want to filter the responded policy by tags
    ///   *  Fill the defaultOnEmpty with true if you want to be responded with default country-specific policy if your requested country is not exist
    /// </summary>
    public class RetrieveLatestPolicies : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveLatestPoliciesBuilder Builder { get => new RetrieveLatestPoliciesBuilder(); }

        public class RetrieveLatestPoliciesBuilder
            : OperationBuilder<RetrieveLatestPoliciesBuilder>
        {

            public bool? DefaultOnEmpty { get; set; }

            public RetrieveLatestPoliciesPolicyType? PolicyType { get; set; }

            public string? Tags { get; set; }

            public bool? VisibleOnly { get; set; }





            internal RetrieveLatestPoliciesBuilder() { }

            internal RetrieveLatestPoliciesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public RetrieveLatestPoliciesBuilder SetDefaultOnEmpty(bool _defaultOnEmpty)
            {
                DefaultOnEmpty = _defaultOnEmpty;
                return this;
            }

            public RetrieveLatestPoliciesBuilder SetPolicyType(RetrieveLatestPoliciesPolicyType _policyType)
            {
                PolicyType = _policyType;
                return this;
            }

            public RetrieveLatestPoliciesBuilder SetTags(string _tags)
            {
                Tags = _tags;
                return this;
            }

            public RetrieveLatestPoliciesBuilder SetVisibleOnly(bool _visibleOnly)
            {
                VisibleOnly = _visibleOnly;
                return this;
            }





            public RetrieveLatestPolicies Build(
                string countryCode
            )
            {
                RetrieveLatestPolicies op = new RetrieveLatestPolicies(this,
                    countryCode
                );

                op.SetBaseFields<RetrieveLatestPoliciesBuilder>(this);
                return op;
            }

            public RetrieveLatestPolicies.Response Execute(
                string countryCode
            )
            {
                RetrieveLatestPolicies op = Build(
                    countryCode
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<RetrieveLatestPolicies.Response> ExecuteAsync(
                string countryCode
            )
            {
                RetrieveLatestPolicies op = Build(
                    countryCode
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

        private RetrieveLatestPolicies(RetrieveLatestPoliciesBuilder builder,
            string countryCode
        )
        {
            PathParams["countryCode"] = countryCode;

            if (builder.DefaultOnEmpty != null) QueryParams["defaultOnEmpty"] = Convert.ToString(builder.DefaultOnEmpty)!;
            if (builder.PolicyType is not null) QueryParams["policyType"] = builder.PolicyType.Value;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;
            if (builder.VisibleOnly != null) QueryParams["visibleOnly"] = Convert.ToString(builder.VisibleOnly)!;






        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<List<Model.RetrievePolicyPublicResponse>>
        {


            protected override string GetFullOperationId() => "Legal::Policies::RetrieveLatestPolicies";
        }

        #endregion

        public RetrieveLatestPolicies(
            string countryCode,
            bool? defaultOnEmpty,
            RetrieveLatestPoliciesPolicyType? policyType,
            string? tags,
            bool? visibleOnly
        )
        {
            PathParams["countryCode"] = countryCode;

            if (defaultOnEmpty != null) QueryParams["defaultOnEmpty"] = Convert.ToString(defaultOnEmpty)!;
            if (policyType is not null) QueryParams["policyType"] = policyType.Value;
            if (tags is not null) QueryParams["tags"] = tags;
            if (visibleOnly != null) QueryParams["visibleOnly"] = Convert.ToString(visibleOnly)!;






        }

        public override string Path => "/agreement/public/policies/countries/{countryCode}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public RetrieveLatestPolicies.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new RetrieveLatestPolicies.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<List<Model.RetrievePolicyPublicResponse>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

    public class RetrieveLatestPoliciesPolicyType : StringEnum<RetrieveLatestPoliciesPolicyType>
    {
        public static readonly RetrieveLatestPoliciesPolicyType LEGALDOCUMENTTYPE
            = new RetrieveLatestPoliciesPolicyType("LEGAL_DOCUMENT_TYPE");

        public static readonly RetrieveLatestPoliciesPolicyType MARKETINGPREFERENCETYPE
            = new RetrieveLatestPoliciesPolicyType("MARKETING_PREFERENCE_TYPE");


        public static implicit operator RetrieveLatestPoliciesPolicyType(string value)
        {
            return NewValue(value);
        }

        public RetrieveLatestPoliciesPolicyType(string enumValue)
            : base(enumValue)
        {

        }
    }

}
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
    /// retrieveLatestPoliciesPublic
    ///
    /// Retrieve all active latest policies based on a namespace and country. The country will be read from user token.
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
    public class RetrieveLatestPoliciesPublic : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveLatestPoliciesPublicBuilder Builder { get => new RetrieveLatestPoliciesPublicBuilder(); }

        public class RetrieveLatestPoliciesPublicBuilder
            : OperationBuilder<RetrieveLatestPoliciesPublicBuilder>
        {

            public bool? AlwaysIncludeDefault { get; set; }

            public bool? DefaultOnEmpty { get; set; }

            public RetrieveLatestPoliciesPublicPolicyType? PolicyType { get; set; }

            public string? Tags { get; set; }

            public bool? VisibleOnly { get; set; }





            internal RetrieveLatestPoliciesPublicBuilder() { }

            internal RetrieveLatestPoliciesPublicBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public RetrieveLatestPoliciesPublicBuilder SetAlwaysIncludeDefault(bool _alwaysIncludeDefault)
            {
                AlwaysIncludeDefault = _alwaysIncludeDefault;
                return this;
            }

            public RetrieveLatestPoliciesPublicBuilder SetDefaultOnEmpty(bool _defaultOnEmpty)
            {
                DefaultOnEmpty = _defaultOnEmpty;
                return this;
            }

            public RetrieveLatestPoliciesPublicBuilder SetPolicyType(RetrieveLatestPoliciesPublicPolicyType _policyType)
            {
                PolicyType = _policyType;
                return this;
            }

            public RetrieveLatestPoliciesPublicBuilder SetTags(string _tags)
            {
                Tags = _tags;
                return this;
            }

            public RetrieveLatestPoliciesPublicBuilder SetVisibleOnly(bool _visibleOnly)
            {
                VisibleOnly = _visibleOnly;
                return this;
            }





            public RetrieveLatestPoliciesPublic Build(
                string namespace_
            )
            {
                RetrieveLatestPoliciesPublic op = new RetrieveLatestPoliciesPublic(this,
                    namespace_
                );

                op.SetBaseFields<RetrieveLatestPoliciesPublicBuilder>(this);
                return op;
            }

            public RetrieveLatestPoliciesPublic.Response Execute(
                string namespace_
            )
            {
                RetrieveLatestPoliciesPublic op = Build(
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
            public async Task<RetrieveLatestPoliciesPublic.Response> ExecuteAsync(
                string namespace_
            )
            {
                RetrieveLatestPoliciesPublic op = Build(
                    namespace_
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

        private RetrieveLatestPoliciesPublic(RetrieveLatestPoliciesPublicBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.AlwaysIncludeDefault != null) QueryParams["alwaysIncludeDefault"] = Convert.ToString(builder.AlwaysIncludeDefault)!;
            if (builder.DefaultOnEmpty != null) QueryParams["defaultOnEmpty"] = Convert.ToString(builder.DefaultOnEmpty)!;
            if (builder.PolicyType is not null) QueryParams["policyType"] = builder.PolicyType.Value;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;
            if (builder.VisibleOnly != null) QueryParams["visibleOnly"] = Convert.ToString(builder.VisibleOnly)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<List<Model.RetrievePolicyPublicResponse>>
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Legal::Policies::RetrieveLatestPoliciesPublic";
        }

        #endregion

        public RetrieveLatestPoliciesPublic(
            string namespace_,
            bool? alwaysIncludeDefault,
            bool? defaultOnEmpty,
            RetrieveLatestPoliciesPublicPolicyType? policyType,
            string? tags,
            bool? visibleOnly
        )
        {
            PathParams["namespace"] = namespace_;

            if (alwaysIncludeDefault != null) QueryParams["alwaysIncludeDefault"] = Convert.ToString(alwaysIncludeDefault)!;
            if (defaultOnEmpty != null) QueryParams["defaultOnEmpty"] = Convert.ToString(defaultOnEmpty)!;
            if (policyType is not null) QueryParams["policyType"] = policyType.Value;
            if (tags is not null) QueryParams["tags"] = tags;
            if (visibleOnly != null) QueryParams["visibleOnly"] = Convert.ToString(visibleOnly)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/public/policies/namespaces/{namespace}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public RetrieveLatestPoliciesPublic.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new RetrieveLatestPoliciesPublic.Response()
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
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }

            return response;
        }
    }

    public class RetrieveLatestPoliciesPublicPolicyType : StringEnum<RetrieveLatestPoliciesPublicPolicyType>
    {
        public static readonly RetrieveLatestPoliciesPublicPolicyType LEGALDOCUMENTTYPE
            = new RetrieveLatestPoliciesPublicPolicyType("LEGAL_DOCUMENT_TYPE");

        public static readonly RetrieveLatestPoliciesPublicPolicyType MARKETINGPREFERENCETYPE
            = new RetrieveLatestPoliciesPublicPolicyType("MARKETING_PREFERENCE_TYPE");


        public static implicit operator RetrieveLatestPoliciesPublicPolicyType(string value)
        {
            return NewValue(value);
        }

        public RetrieveLatestPoliciesPublicPolicyType(string enumValue)
            : base(enumValue)
        {

        }
    }

}
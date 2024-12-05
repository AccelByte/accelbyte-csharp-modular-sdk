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
    /// retrieveSinglePolicyVersion
    ///
    /// Retrieve a version of a particular country specific policy. If version is not provided, the Legal Service will assume caller requesting all versions from country-specific policy.
    /// </summary>
    public class RetrieveSinglePolicyVersion : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveSinglePolicyVersionBuilder Builder { get => new RetrieveSinglePolicyVersionBuilder(); }

        public class RetrieveSinglePolicyVersionBuilder
            : OperationBuilder<RetrieveSinglePolicyVersionBuilder>
        {

            public string? VersionId { get; set; }





            internal RetrieveSinglePolicyVersionBuilder() { }

            internal RetrieveSinglePolicyVersionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public RetrieveSinglePolicyVersionBuilder SetVersionId(string _versionId)
            {
                VersionId = _versionId;
                return this;
            }





            public RetrieveSinglePolicyVersion Build(
                string policyId
            )
            {
                RetrieveSinglePolicyVersion op = new RetrieveSinglePolicyVersion(this,
                    policyId
                );

                op.SetBaseFields<RetrieveSinglePolicyVersionBuilder>(this);
                return op;
            }

            public RetrieveSinglePolicyVersion.Response Execute(
                string policyId
            )
            {
                RetrieveSinglePolicyVersion op = Build(
                    policyId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<RetrieveSinglePolicyVersion.Response> ExecuteAsync(
                string policyId
            )
            {
                RetrieveSinglePolicyVersion op = Build(
                    policyId
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

        private RetrieveSinglePolicyVersion(RetrieveSinglePolicyVersionBuilder builder,
            string policyId
        )
        {
            PathParams["policyId"] = policyId;

            if (builder.VersionId is not null) QueryParams["versionId"] = builder.VersionId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<List<Model.RetrievePolicyVersionResponse>>
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Legal::PolicyVersions::RetrieveSinglePolicyVersion";
        }

        #endregion

        public RetrieveSinglePolicyVersion(
            string policyId,
            string? versionId
        )
        {
            PathParams["policyId"] = policyId;

            if (versionId is not null) QueryParams["versionId"] = versionId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/policies/{policyId}/versions";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public RetrieveSinglePolicyVersion.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new RetrieveSinglePolicyVersion.Response()
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
                response.Data = JsonSerializer.Deserialize<List<Model.RetrievePolicyVersionResponse>>(payload, ResponseJsonOptions);
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

}
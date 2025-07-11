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
    /// retrieveSinglePolicyVersion_1
    ///
    /// Retrieve a version of a particular country specific policy. If version is not provided, the Legal Service will assume caller requesting all versions from country-specific policy.
    /// </summary>
    public class RetrieveSinglePolicyVersion1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveSinglePolicyVersion1Builder Builder { get => new RetrieveSinglePolicyVersion1Builder(); }

        public class RetrieveSinglePolicyVersion1Builder
            : OperationBuilder<RetrieveSinglePolicyVersion1Builder>
        {

            public string? VersionId { get; set; }





            internal RetrieveSinglePolicyVersion1Builder() { }

            internal RetrieveSinglePolicyVersion1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public RetrieveSinglePolicyVersion1Builder SetVersionId(string _versionId)
            {
                VersionId = _versionId;
                return this;
            }





            public RetrieveSinglePolicyVersion1 Build(
                string namespace_,
                string policyId
            )
            {
                RetrieveSinglePolicyVersion1 op = new RetrieveSinglePolicyVersion1(this,
                    namespace_,                    
                    policyId                    
                );

                op.SetBaseFields<RetrieveSinglePolicyVersion1Builder>(this);
                return op;
            }

            public RetrieveSinglePolicyVersion1.Response Execute(
                string namespace_,
                string policyId
            )
            {
                RetrieveSinglePolicyVersion1 op = Build(
                    namespace_,
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
            public async Task<RetrieveSinglePolicyVersion1.Response> ExecuteAsync(
                string namespace_,
                string policyId
            )
            {
                RetrieveSinglePolicyVersion1 op = Build(
                    namespace_,
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

        private RetrieveSinglePolicyVersion1(RetrieveSinglePolicyVersion1Builder builder,
            string namespace_,
            string policyId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["policyId"] = policyId;
            
            if (builder.VersionId is not null) QueryParams["versionId"] = builder.VersionId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<List<Model.RetrievePolicyVersionResponse>>
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Legal::PolicyVersionsWithNamespace::RetrieveSinglePolicyVersion1";
        }

        #endregion

        public RetrieveSinglePolicyVersion1(
            string namespace_,            
            string policyId,            
            string? versionId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["policyId"] = policyId;
            
            if (versionId is not null) QueryParams["versionId"] = versionId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/namespaces/{namespace}/policies/{policyId}/versions";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public RetrieveSinglePolicyVersion1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new RetrieveSinglePolicyVersion1.Response()
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
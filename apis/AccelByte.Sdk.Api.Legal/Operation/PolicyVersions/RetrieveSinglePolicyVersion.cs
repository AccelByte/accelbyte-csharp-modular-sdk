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
    /// retrieveSinglePolicyVersion
    ///
    /// Retrieve a version of a particular country specific policy. If version is not provided, the Legal Service will assume caller requesting all versions from country-specific policy.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=2 (READ)
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
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public List<Model.RetrievePolicyVersionResponse>? Execute(
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

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public List<Model.RetrievePolicyVersionResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.RetrievePolicyVersionResponse>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.RetrievePolicyVersionResponse>>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
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
    /// retrieveSingleLocalizedPolicyVersion_1
    ///
    /// Retrieve a version of a particular country-specific policy.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:LEGAL", action=2 (READ)
    /// </summary>
    public class RetrieveSingleLocalizedPolicyVersion1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveSingleLocalizedPolicyVersion1Builder Builder { get => new RetrieveSingleLocalizedPolicyVersion1Builder(); }

        public class RetrieveSingleLocalizedPolicyVersion1Builder
            : OperationBuilder<RetrieveSingleLocalizedPolicyVersion1Builder>
        {





            internal RetrieveSingleLocalizedPolicyVersion1Builder() { }

            internal RetrieveSingleLocalizedPolicyVersion1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public RetrieveSingleLocalizedPolicyVersion1 Build(
                string localizedPolicyVersionId,
                string namespace_
            )
            {
                RetrieveSingleLocalizedPolicyVersion1 op = new RetrieveSingleLocalizedPolicyVersion1(this,
                    localizedPolicyVersionId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.RetrieveLocalizedPolicyVersionResponse? Execute(
                string localizedPolicyVersionId,
                string namespace_
            )
            {
                RetrieveSingleLocalizedPolicyVersion1 op = Build(
                    localizedPolicyVersionId,
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

        private RetrieveSingleLocalizedPolicyVersion1(RetrieveSingleLocalizedPolicyVersion1Builder builder,
            string localizedPolicyVersionId,
            string namespace_
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RetrieveSingleLocalizedPolicyVersion1(
            string localizedPolicyVersionId,            
            string namespace_            
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/namespaces/{namespace}/localized-policy-versions/{localizedPolicyVersionId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.RetrieveLocalizedPolicyVersionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.RetrieveLocalizedPolicyVersionResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RetrieveLocalizedPolicyVersionResponse>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
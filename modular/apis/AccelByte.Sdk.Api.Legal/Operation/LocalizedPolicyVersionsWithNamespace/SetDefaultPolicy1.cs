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
    /// setDefaultPolicy_1
    ///
    /// Update a localized version policy to be the default.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:LEGAL", action=4 (UPDATE)
    /// </summary>
    public class SetDefaultPolicy1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SetDefaultPolicy1Builder Builder { get => new SetDefaultPolicy1Builder(); }

        public class SetDefaultPolicy1Builder
            : OperationBuilder<SetDefaultPolicy1Builder>
        {





            internal SetDefaultPolicy1Builder() { }

            internal SetDefaultPolicy1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public SetDefaultPolicy1 Build(
                string localizedPolicyVersionId,
                string namespace_
            )
            {
                SetDefaultPolicy1 op = new SetDefaultPolicy1(this,
                    localizedPolicyVersionId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public void Execute(
                string localizedPolicyVersionId,
                string namespace_
            )
            {
                SetDefaultPolicy1 op = Build(
                    localizedPolicyVersionId,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private SetDefaultPolicy1(SetDefaultPolicy1Builder builder,
            string localizedPolicyVersionId,
            string namespace_
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SetDefaultPolicy1(
            string localizedPolicyVersionId,            
            string namespace_            
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/namespaces/{namespace}/localized-policy-versions/{localizedPolicyVersionId}/default";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
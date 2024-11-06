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
    /// setDefaultPolicy_2
    ///
    /// Update a policy to be the default.
    /// </summary>
    public class SetDefaultPolicy2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SetDefaultPolicy2Builder Builder { get => new SetDefaultPolicy2Builder(); }

        public class SetDefaultPolicy2Builder
            : OperationBuilder<SetDefaultPolicy2Builder>
        {





            internal SetDefaultPolicy2Builder() { }

            internal SetDefaultPolicy2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public SetDefaultPolicy2 Build(
                string policyId
            )
            {
                SetDefaultPolicy2 op = new SetDefaultPolicy2(this,
                    policyId                    
                );

                op.SetBaseFields<SetDefaultPolicy2Builder>(this);
                return op;
            }

            public SetDefaultPolicy2.Response Execute(
                string policyId
            )
            {
                SetDefaultPolicy2 op = Build(
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
            public async Task<SetDefaultPolicy2.Response> ExecuteAsync(
                string policyId
            )
            {
                SetDefaultPolicy2 op = Build(
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

        private SetDefaultPolicy2(SetDefaultPolicy2Builder builder,
            string policyId
        )
        {
            PathParams["policyId"] = policyId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ErrorEntity? Error400 { get; set; } = null;


            protected override string GetFullOperationId() => "Legal::Policies::SetDefaultPolicy2";
        }

        #endregion

        public SetDefaultPolicy2(
            string policyId            
        )
        {
            PathParams["policyId"] = policyId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/policies/{policyId}/default";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public SetDefaultPolicy2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new SetDefaultPolicy2.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)
            
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }

            return response;
        }
    }

}
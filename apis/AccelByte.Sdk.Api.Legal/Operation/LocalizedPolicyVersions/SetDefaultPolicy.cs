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
    /// setDefaultPolicy
    ///
    /// Update a localized version policy to be the default.
    /// </summary>
    public class SetDefaultPolicy : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SetDefaultPolicyBuilder Builder { get => new SetDefaultPolicyBuilder(); }

        public class SetDefaultPolicyBuilder
            : OperationBuilder<SetDefaultPolicyBuilder>
        {





            internal SetDefaultPolicyBuilder() { }

            internal SetDefaultPolicyBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public SetDefaultPolicy Build(
                string localizedPolicyVersionId
            )
            {
                SetDefaultPolicy op = new SetDefaultPolicy(this,
                    localizedPolicyVersionId                    
                );

                op.SetBaseFields<SetDefaultPolicyBuilder>(this);
                return op;
            }

            public SetDefaultPolicy.Response Execute(
                string localizedPolicyVersionId
            )
            {
                SetDefaultPolicy op = Build(
                    localizedPolicyVersionId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<SetDefaultPolicy.Response> ExecuteAsync(
                string localizedPolicyVersionId
            )
            {
                SetDefaultPolicy op = Build(
                    localizedPolicyVersionId
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

        private SetDefaultPolicy(SetDefaultPolicyBuilder builder,
            string localizedPolicyVersionId
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ErrorEntity? Error400 { get; set; } = null;


            protected override string GetFullOperationId() => "Legal::LocalizedPolicyVersions::SetDefaultPolicy";
        }

        #endregion

        public SetDefaultPolicy(
            string localizedPolicyVersionId            
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/localized-policy-versions/{localizedPolicyVersionId}/default";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public SetDefaultPolicy.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new SetDefaultPolicy.Response()
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
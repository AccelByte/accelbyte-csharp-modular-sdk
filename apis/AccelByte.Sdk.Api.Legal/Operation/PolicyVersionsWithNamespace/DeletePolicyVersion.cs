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
    /// deletePolicyVersion
    ///
    /// Delete a policy version from policy.Can only be deleted if match these criteria:
    /// 
    /// 
    ///   * Policy version is not published
    ///   * Policy version has never been accepted by any user
    /// </summary>
    public class DeletePolicyVersion : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeletePolicyVersionBuilder Builder { get => new DeletePolicyVersionBuilder(); }

        public class DeletePolicyVersionBuilder
            : OperationBuilder<DeletePolicyVersionBuilder>
        {





            internal DeletePolicyVersionBuilder() { }

            internal DeletePolicyVersionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeletePolicyVersion Build(
                string namespace_,
                string policyVersionId
            )
            {
                DeletePolicyVersion op = new DeletePolicyVersion(this,
                    namespace_,                    
                    policyVersionId                    
                );

                op.SetBaseFields<DeletePolicyVersionBuilder>(this);
                return op;
            }

            public DeletePolicyVersion.Response Execute(
                string namespace_,
                string policyVersionId
            )
            {
                DeletePolicyVersion op = Build(
                    namespace_,
                    policyVersionId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<DeletePolicyVersion.Response> ExecuteAsync(
                string namespace_,
                string policyVersionId
            )
            {
                DeletePolicyVersion op = Build(
                    namespace_,
                    policyVersionId
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

        private DeletePolicyVersion(DeletePolicyVersionBuilder builder,
            string namespace_,
            string policyVersionId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["policyVersionId"] = policyVersionId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ErrorEntity? Error400 { get; set; } = null;


            protected override string GetFullOperationId() => "Legal::PolicyVersionsWithNamespace::DeletePolicyVersion";
        }

        #endregion

        public DeletePolicyVersion(
            string namespace_,            
            string policyVersionId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["policyVersionId"] = policyVersionId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/namespaces/{namespace}/policies/versions/{policyVersionId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public DeletePolicyVersion.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DeletePolicyVersion.Response()
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
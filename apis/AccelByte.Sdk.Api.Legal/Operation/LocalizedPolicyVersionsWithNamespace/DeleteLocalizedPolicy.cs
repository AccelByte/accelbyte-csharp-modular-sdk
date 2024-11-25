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
    /// deleteLocalizedPolicy
    ///
    /// Delete localized version policy.
    /// Can only be deleted if match these criteria:
    /// 
    /// 
    ///   * Policy Version that this localized policy version belongs to is not active
    ///   * Has never been accepted by any user
    /// </summary>
    public class DeleteLocalizedPolicy : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteLocalizedPolicyBuilder Builder { get => new DeleteLocalizedPolicyBuilder(); }

        public class DeleteLocalizedPolicyBuilder
            : OperationBuilder<DeleteLocalizedPolicyBuilder>
        {





            internal DeleteLocalizedPolicyBuilder() { }

            internal DeleteLocalizedPolicyBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteLocalizedPolicy Build(
                string localizedPolicyVersionId,
                string namespace_
            )
            {
                DeleteLocalizedPolicy op = new DeleteLocalizedPolicy(this,
                    localizedPolicyVersionId,                    
                    namespace_                    
                );

                op.SetBaseFields<DeleteLocalizedPolicyBuilder>(this);
                return op;
            }

            public DeleteLocalizedPolicy.Response Execute(
                string localizedPolicyVersionId,
                string namespace_
            )
            {
                DeleteLocalizedPolicy op = Build(
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
            public async Task<DeleteLocalizedPolicy.Response> ExecuteAsync(
                string localizedPolicyVersionId,
                string namespace_
            )
            {
                DeleteLocalizedPolicy op = Build(
                    localizedPolicyVersionId,
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

        private DeleteLocalizedPolicy(DeleteLocalizedPolicyBuilder builder,
            string localizedPolicyVersionId,
            string namespace_
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ErrorEntity? Error400 { get; set; } = null;


            protected override string GetFullOperationId() => "Legal::LocalizedPolicyVersionsWithNamespace::DeleteLocalizedPolicy";
        }

        #endregion

        public DeleteLocalizedPolicy(
            string localizedPolicyVersionId,            
            string namespace_            
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/namespaces/{namespace}/localized-policy-versions/versions/{localizedPolicyVersionId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public DeleteLocalizedPolicy.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DeleteLocalizedPolicy.Response()
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
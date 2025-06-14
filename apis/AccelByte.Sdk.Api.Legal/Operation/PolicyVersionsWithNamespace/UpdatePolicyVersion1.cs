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
    /// updatePolicyVersion_1
    ///
    /// Update a particular policy version.
    /// </summary>
    public class UpdatePolicyVersion1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdatePolicyVersion1Builder Builder { get => new UpdatePolicyVersion1Builder(); }

        public class UpdatePolicyVersion1Builder
            : OperationBuilder<UpdatePolicyVersion1Builder>
        {


            public Model.UpdatePolicyVersionRequest? Body { get; set; }




            internal UpdatePolicyVersion1Builder() { }

            internal UpdatePolicyVersion1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdatePolicyVersion1Builder SetBody(Model.UpdatePolicyVersionRequest _body)
            {
                Body = _body;
                return this;
            }




            public UpdatePolicyVersion1 Build(
                string namespace_,
                string policyVersionId
            )
            {
                UpdatePolicyVersion1 op = new UpdatePolicyVersion1(this,
                    namespace_,                    
                    policyVersionId                    
                );

                op.SetBaseFields<UpdatePolicyVersion1Builder>(this);
                return op;
            }

            public UpdatePolicyVersion1.Response Execute(
                string namespace_,
                string policyVersionId
            )
            {
                UpdatePolicyVersion1 op = Build(
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
            public async Task<UpdatePolicyVersion1.Response> ExecuteAsync(
                string namespace_,
                string policyVersionId
            )
            {
                UpdatePolicyVersion1 op = Build(
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

        private UpdatePolicyVersion1(UpdatePolicyVersion1Builder builder,
            string namespace_,
            string policyVersionId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["policyVersionId"] = policyVersionId;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.UpdatePolicyVersionResponse>
        {

            public ErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error409 { get; set; } = null;


            protected override string GetFullOperationId() => "Legal::PolicyVersionsWithNamespace::UpdatePolicyVersion1";
        }

        #endregion

        public UpdatePolicyVersion1(
            string namespace_,            
            string policyVersionId,            
            Model.UpdatePolicyVersionRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["policyVersionId"] = policyVersionId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/namespaces/{namespace}/policies/versions/{policyVersionId}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public UpdatePolicyVersion1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdatePolicyVersion1.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.UpdatePolicyVersionResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }

            return response;
        }
    }

}
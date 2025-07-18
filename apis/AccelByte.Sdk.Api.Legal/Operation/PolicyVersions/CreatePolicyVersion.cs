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
    /// createPolicyVersion
    ///
    /// Create a version of a particular country-specific policy.
    /// </summary>
    public class CreatePolicyVersion : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreatePolicyVersionBuilder Builder { get => new CreatePolicyVersionBuilder(); }

        public class CreatePolicyVersionBuilder
            : OperationBuilder<CreatePolicyVersionBuilder>
        {


            public Model.CreatePolicyVersionRequest? Body { get; set; }




            internal CreatePolicyVersionBuilder() { }

            internal CreatePolicyVersionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public CreatePolicyVersionBuilder SetBody(Model.CreatePolicyVersionRequest _body)
            {
                Body = _body;
                return this;
            }




            public CreatePolicyVersion Build(
                string policyId
            )
            {
                CreatePolicyVersion op = new CreatePolicyVersion(this,
                    policyId                    
                );

                op.SetBaseFields<CreatePolicyVersionBuilder>(this);
                return op;
            }

            public CreatePolicyVersion.Response Execute(
                string policyId
            )
            {
                CreatePolicyVersion op = Build(
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
            public async Task<CreatePolicyVersion.Response> ExecuteAsync(
                string policyId
            )
            {
                CreatePolicyVersion op = Build(
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

        private CreatePolicyVersion(CreatePolicyVersionBuilder builder,
            string policyId
        )
        {
            PathParams["policyId"] = policyId;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.CreatePolicyVersionResponse>
        {

            public ErrorEntity? Error400 { get; set; } = null;


            protected override string GetFullOperationId() => "Legal::PolicyVersions::CreatePolicyVersion";
        }

        #endregion

        public CreatePolicyVersion(
            string policyId,            
            Model.CreatePolicyVersionRequest body            
        )
        {
            PathParams["policyId"] = policyId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/policies/{policyId}/versions";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public CreatePolicyVersion.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new CreatePolicyVersion.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.CreatePolicyVersionResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }

            return response;
        }
    }

}
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

using AccelByte.Sdk.Api.Dsmc.Model;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// CreateRepository
    ///
    /// ```
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [CREATE]
    /// Required scope: social
    /// 
    /// This endpoint will create image repository.
    /// 
    /// Sample repository:
    /// {
    /// "namespace":"testing",
    /// "repository":"ds-testing-924623",
    /// }
    /// ```
    /// </summary>
    public class CreateRepository : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateRepositoryBuilder Builder { get => new CreateRepositoryBuilder(); }

        public class CreateRepositoryBuilder
            : OperationBuilder<CreateRepositoryBuilder>
        {





            internal CreateRepositoryBuilder() { }

            internal CreateRepositoryBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateRepository Build(
                ModelsCreateRepositoryRequest body
            )
            {
                CreateRepository op = new CreateRepository(this,
                    body                    
                );

                op.SetBaseFields<CreateRepositoryBuilder>(this);
                return op;
            }

            public CreateRepository.Response Execute(
                ModelsCreateRepositoryRequest body
            )
            {
                CreateRepository op = Build(
                    body
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<CreateRepository.Response> ExecuteAsync(
                ModelsCreateRepositoryRequest body
            )
            {
                CreateRepository op = Build(
                    body
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

        private CreateRepository(CreateRepositoryBuilder builder,
            ModelsCreateRepositoryRequest body
        )
        {
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Dsmc::ImageConfig::CreateRepository";
        }

        #endregion

        public CreateRepository(
            Model.ModelsCreateRepositoryRequest body            
        )
        {
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/repository";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public CreateRepository.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new CreateRepository.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)
            
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
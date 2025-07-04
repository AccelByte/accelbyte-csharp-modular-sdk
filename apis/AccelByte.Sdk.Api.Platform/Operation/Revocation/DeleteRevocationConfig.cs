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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// deleteRevocationConfig
    ///
    /// Delete revocation config.
    /// </summary>
    public class DeleteRevocationConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteRevocationConfigBuilder Builder { get => new DeleteRevocationConfigBuilder(); }

        public class DeleteRevocationConfigBuilder
            : OperationBuilder<DeleteRevocationConfigBuilder>
        {





            internal DeleteRevocationConfigBuilder() { }

            internal DeleteRevocationConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteRevocationConfig Build(
                string namespace_
            )
            {
                DeleteRevocationConfig op = new DeleteRevocationConfig(this,
                    namespace_                    
                );

                op.SetBaseFields<DeleteRevocationConfigBuilder>(this);
                return op;
            }

            public DeleteRevocationConfig.Response Execute(
                string namespace_
            )
            {
                DeleteRevocationConfig op = Build(
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
            public async Task<DeleteRevocationConfig.Response> ExecuteAsync(
                string namespace_
            )
            {
                DeleteRevocationConfig op = Build(
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

        private DeleteRevocationConfig(DeleteRevocationConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {


            protected override string GetFullOperationId() => "Platform::Revocation::DeleteRevocationConfig";
        }

        #endregion

        public DeleteRevocationConfig(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/revocation/config";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public DeleteRevocationConfig.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DeleteRevocationConfig.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };


            return response;
        }
    }

}
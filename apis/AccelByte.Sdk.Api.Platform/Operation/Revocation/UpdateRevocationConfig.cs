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
    /// updateRevocationConfig
    ///
    /// Update revocation configuration.
    /// Other detail info:
    /// 
    ///   * Returns : Revocation config
    /// </summary>
    public class UpdateRevocationConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateRevocationConfigBuilder Builder { get => new UpdateRevocationConfigBuilder(); }

        public class UpdateRevocationConfigBuilder
            : OperationBuilder<UpdateRevocationConfigBuilder>
        {





            internal UpdateRevocationConfigBuilder() { }

            internal UpdateRevocationConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateRevocationConfig Build(
                RevocationConfigUpdate body,
                string namespace_
            )
            {
                UpdateRevocationConfig op = new UpdateRevocationConfig(this,
                    body,                    
                    namespace_                    
                );

                op.SetBaseFields<UpdateRevocationConfigBuilder>(this);
                return op;
            }

            public UpdateRevocationConfig.Response Execute(
                RevocationConfigUpdate body,
                string namespace_
            )
            {
                UpdateRevocationConfig op = Build(
                    body,
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
            public async Task<UpdateRevocationConfig.Response> ExecuteAsync(
                RevocationConfigUpdate body,
                string namespace_
            )
            {
                UpdateRevocationConfig op = Build(
                    body,
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

        private UpdateRevocationConfig(UpdateRevocationConfigBuilder builder,
            RevocationConfigUpdate body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.RevocationConfigInfo>
        {


            protected override string GetFullOperationId() => "Platform::Revocation::UpdateRevocationConfig";
        }

        #endregion

        public UpdateRevocationConfig(
            string namespace_,            
            Model.RevocationConfigUpdate body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/revocation/config";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public UpdateRevocationConfig.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdateRevocationConfig.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.RevocationConfigInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}
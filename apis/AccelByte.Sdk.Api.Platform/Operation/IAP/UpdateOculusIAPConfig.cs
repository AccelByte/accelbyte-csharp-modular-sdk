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
    /// updateOculusIAPConfig
    ///
    /// Update oculus iap config. Other detail info:
    ///   * Returns : updated steam iap config
    /// </summary>
    public class UpdateOculusIAPConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateOculusIAPConfigBuilder Builder { get => new UpdateOculusIAPConfigBuilder(); }

        public class UpdateOculusIAPConfigBuilder
            : OperationBuilder<UpdateOculusIAPConfigBuilder>
        {





            internal UpdateOculusIAPConfigBuilder() { }

            internal UpdateOculusIAPConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateOculusIAPConfig Build(
                OculusIAPConfigRequest body,
                string namespace_
            )
            {
                UpdateOculusIAPConfig op = new UpdateOculusIAPConfig(this,
                    body,                    
                    namespace_                    
                );

                op.SetBaseFields<UpdateOculusIAPConfigBuilder>(this);
                return op;
            }

            public UpdateOculusIAPConfig.Response Execute(
                OculusIAPConfigRequest body,
                string namespace_
            )
            {
                UpdateOculusIAPConfig op = Build(
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
            public async Task<UpdateOculusIAPConfig.Response> ExecuteAsync(
                OculusIAPConfigRequest body,
                string namespace_
            )
            {
                UpdateOculusIAPConfig op = Build(
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

        private UpdateOculusIAPConfig(UpdateOculusIAPConfigBuilder builder,
            OculusIAPConfigRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.OculusIAPConfigInfo>
        {


            protected override string GetFullOperationId() => "Platform::IAP::UpdateOculusIAPConfig";
        }

        #endregion

        public UpdateOculusIAPConfig(
            string namespace_,            
            Model.OculusIAPConfigRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/oculus";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public UpdateOculusIAPConfig.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdateOculusIAPConfig.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.OculusIAPConfigInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}
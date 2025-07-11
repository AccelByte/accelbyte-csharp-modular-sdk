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
    /// updateXblIAPConfig
    ///
    /// Update xbl iap config. Other detail info:
    ///   * Returns : updated xbl iap config
    /// </summary>
    public class UpdateXblIAPConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateXblIAPConfigBuilder Builder { get => new UpdateXblIAPConfigBuilder(); }

        public class UpdateXblIAPConfigBuilder
            : OperationBuilder<UpdateXblIAPConfigBuilder>
        {





            internal UpdateXblIAPConfigBuilder() { }

            internal UpdateXblIAPConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateXblIAPConfig Build(
                XblIAPConfigRequest body,
                string namespace_
            )
            {
                UpdateXblIAPConfig op = new UpdateXblIAPConfig(this,
                    body,                    
                    namespace_                    
                );

                op.SetBaseFields<UpdateXblIAPConfigBuilder>(this);
                return op;
            }

            public UpdateXblIAPConfig.Response Execute(
                XblIAPConfigRequest body,
                string namespace_
            )
            {
                UpdateXblIAPConfig op = Build(
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
            public async Task<UpdateXblIAPConfig.Response> ExecuteAsync(
                XblIAPConfigRequest body,
                string namespace_
            )
            {
                UpdateXblIAPConfig op = Build(
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

        private UpdateXblIAPConfig(UpdateXblIAPConfigBuilder builder,
            XblIAPConfigRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.XblIAPConfigInfo>
        {


            protected override string GetFullOperationId() => "Platform::IAP::UpdateXblIAPConfig";
        }

        #endregion

        public UpdateXblIAPConfig(
            string namespace_,            
            Model.XblIAPConfigRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/xbl";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public UpdateXblIAPConfig.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdateXblIAPConfig.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.XblIAPConfigInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}
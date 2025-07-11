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
    /// updateIAPItemConfig
    ///
    /// Update iap item config. Other detail info:
    ///   * Returns : updated iap item config
    /// </summary>
    public class UpdateIAPItemConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateIAPItemConfigBuilder Builder { get => new UpdateIAPItemConfigBuilder(); }

        public class UpdateIAPItemConfigBuilder
            : OperationBuilder<UpdateIAPItemConfigBuilder>
        {





            internal UpdateIAPItemConfigBuilder() { }

            internal UpdateIAPItemConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateIAPItemConfig Build(
                IAPItemConfigUpdate body,
                string namespace_
            )
            {
                UpdateIAPItemConfig op = new UpdateIAPItemConfig(this,
                    body,                    
                    namespace_                    
                );

                op.SetBaseFields<UpdateIAPItemConfigBuilder>(this);
                return op;
            }

            public UpdateIAPItemConfig.Response Execute(
                IAPItemConfigUpdate body,
                string namespace_
            )
            {
                UpdateIAPItemConfig op = Build(
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
            public async Task<UpdateIAPItemConfig.Response> ExecuteAsync(
                IAPItemConfigUpdate body,
                string namespace_
            )
            {
                UpdateIAPItemConfig op = Build(
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

        private UpdateIAPItemConfig(UpdateIAPItemConfigBuilder builder,
            IAPItemConfigUpdate body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.IAPItemConfigInfo>
        {

            public ErrorEntity? Error400 { get; set; } = null;

            public ValidationErrorEntity? Error409 { get; set; } = null;

            public ValidationErrorEntity? Error422 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::IAP::UpdateIAPItemConfig";
        }

        #endregion

        public UpdateIAPItemConfig(
            string namespace_,            
            Model.IAPItemConfigUpdate body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/item";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public UpdateIAPItemConfig.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdateIAPItemConfig.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.IAPItemConfigInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<ValidationErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)422)
            {
                response.Error422 = JsonSerializer.Deserialize<ValidationErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error422!.TranslateToApiError();
            }

            return response;
        }
    }

}
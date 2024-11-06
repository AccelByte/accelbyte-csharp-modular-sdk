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
    /// updateAppleIAPConfig
    ///
    /// Update apple iap config. Other detail info:
    ///   * Returns : updated apple iap config
    /// </summary>
    public class UpdateAppleIAPConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateAppleIAPConfigBuilder Builder { get => new UpdateAppleIAPConfigBuilder(); }

        public class UpdateAppleIAPConfigBuilder
            : OperationBuilder<UpdateAppleIAPConfigBuilder>
        {





            internal UpdateAppleIAPConfigBuilder() { }

            internal UpdateAppleIAPConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateAppleIAPConfig Build(
                AppleIAPConfigRequest body,
                string namespace_
            )
            {
                UpdateAppleIAPConfig op = new UpdateAppleIAPConfig(this,
                    body,                    
                    namespace_                    
                );

                op.SetBaseFields<UpdateAppleIAPConfigBuilder>(this);
                return op;
            }

            public UpdateAppleIAPConfig.Response Execute(
                AppleIAPConfigRequest body,
                string namespace_
            )
            {
                UpdateAppleIAPConfig op = Build(
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
            public async Task<UpdateAppleIAPConfig.Response> ExecuteAsync(
                AppleIAPConfigRequest body,
                string namespace_
            )
            {
                UpdateAppleIAPConfig op = Build(
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

        private UpdateAppleIAPConfig(UpdateAppleIAPConfigBuilder builder,
            AppleIAPConfigRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.AppleIAPConfigInfo>
        {


            protected override string GetFullOperationId() => "Platform::IAP::UpdateAppleIAPConfig";
        }

        #endregion

        public UpdateAppleIAPConfig(
            string namespace_,            
            Model.AppleIAPConfigRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/apple";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public UpdateAppleIAPConfig.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdateAppleIAPConfig.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.AppleIAPConfigInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}
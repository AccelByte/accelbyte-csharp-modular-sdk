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
    /// getAppleIAPConfig
    ///
    /// Get apple iap config.
    /// Other detail info:
    /// 
    ///   * Returns : apple iap config
    /// </summary>
    public class GetAppleIAPConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetAppleIAPConfigBuilder Builder { get => new GetAppleIAPConfigBuilder(); }

        public class GetAppleIAPConfigBuilder
            : OperationBuilder<GetAppleIAPConfigBuilder>
        {





            internal GetAppleIAPConfigBuilder() { }

            internal GetAppleIAPConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetAppleIAPConfig Build(
                string namespace_
            )
            {
                GetAppleIAPConfig op = new GetAppleIAPConfig(this,
                    namespace_                    
                );

                op.SetBaseFields<GetAppleIAPConfigBuilder>(this);
                return op;
            }

            public GetAppleIAPConfig.Response Execute(
                string namespace_
            )
            {
                GetAppleIAPConfig op = Build(
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
            public async Task<GetAppleIAPConfig.Response> ExecuteAsync(
                string namespace_
            )
            {
                GetAppleIAPConfig op = Build(
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

        private GetAppleIAPConfig(GetAppleIAPConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.AppleIAPConfigInfo>
        {


            protected override string GetFullOperationId() => "Platform::IAP::GetAppleIAPConfig";
        }

        #endregion

        public GetAppleIAPConfig(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/apple";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public GetAppleIAPConfig.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetAppleIAPConfig.Response()
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
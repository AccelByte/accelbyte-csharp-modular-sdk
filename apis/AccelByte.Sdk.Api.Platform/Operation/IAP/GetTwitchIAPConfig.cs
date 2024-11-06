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
    /// getTwitchIAPConfig
    ///
    /// Get twitch iap config.
    /// Other detail info:
    /// 
    ///   * Returns : twitch iap config
    /// </summary>
    public class GetTwitchIAPConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetTwitchIAPConfigBuilder Builder { get => new GetTwitchIAPConfigBuilder(); }

        public class GetTwitchIAPConfigBuilder
            : OperationBuilder<GetTwitchIAPConfigBuilder>
        {





            internal GetTwitchIAPConfigBuilder() { }

            internal GetTwitchIAPConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetTwitchIAPConfig Build(
                string namespace_
            )
            {
                GetTwitchIAPConfig op = new GetTwitchIAPConfig(this,
                    namespace_                    
                );

                op.SetBaseFields<GetTwitchIAPConfigBuilder>(this);
                return op;
            }

            public GetTwitchIAPConfig.Response Execute(
                string namespace_
            )
            {
                GetTwitchIAPConfig op = Build(
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
            public async Task<GetTwitchIAPConfig.Response> ExecuteAsync(
                string namespace_
            )
            {
                GetTwitchIAPConfig op = Build(
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

        private GetTwitchIAPConfig(GetTwitchIAPConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.TwitchIAPConfigInfo>
        {


            protected override string GetFullOperationId() => "Platform::IAP::GetTwitchIAPConfig";
        }

        #endregion

        public GetTwitchIAPConfig(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/twitch";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public GetTwitchIAPConfig.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetTwitchIAPConfig.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.TwitchIAPConfigInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}
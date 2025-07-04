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
    /// getPlayStationIAPConfig
    ///
    /// Get playstation iap config.
    /// Other detail info:
    /// 
    ///   * Returns : playstation iap config
    /// </summary>
    public class GetPlayStationIAPConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetPlayStationIAPConfigBuilder Builder { get => new GetPlayStationIAPConfigBuilder(); }

        public class GetPlayStationIAPConfigBuilder
            : OperationBuilder<GetPlayStationIAPConfigBuilder>
        {





            internal GetPlayStationIAPConfigBuilder() { }

            internal GetPlayStationIAPConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetPlayStationIAPConfig Build(
                string namespace_
            )
            {
                GetPlayStationIAPConfig op = new GetPlayStationIAPConfig(this,
                    namespace_                    
                );

                op.SetBaseFields<GetPlayStationIAPConfigBuilder>(this);
                return op;
            }

            public GetPlayStationIAPConfig.Response Execute(
                string namespace_
            )
            {
                GetPlayStationIAPConfig op = Build(
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
            public async Task<GetPlayStationIAPConfig.Response> ExecuteAsync(
                string namespace_
            )
            {
                GetPlayStationIAPConfig op = Build(
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

        private GetPlayStationIAPConfig(GetPlayStationIAPConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.PlayStationIAPConfigInfo>
        {


            protected override string GetFullOperationId() => "Platform::IAP::GetPlayStationIAPConfig";
        }

        #endregion

        public GetPlayStationIAPConfig(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/playstation";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public GetPlayStationIAPConfig.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetPlayStationIAPConfig.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.PlayStationIAPConfigInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}
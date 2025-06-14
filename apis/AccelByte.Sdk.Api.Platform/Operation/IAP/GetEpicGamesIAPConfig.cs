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
    /// getEpicGamesIAPConfig
    ///
    /// Get epic games iap config.
    /// Other detail info:
    /// 
    ///   * Returns : epic games iap config
    /// </summary>
    public class GetEpicGamesIAPConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetEpicGamesIAPConfigBuilder Builder { get => new GetEpicGamesIAPConfigBuilder(); }

        public class GetEpicGamesIAPConfigBuilder
            : OperationBuilder<GetEpicGamesIAPConfigBuilder>
        {





            internal GetEpicGamesIAPConfigBuilder() { }

            internal GetEpicGamesIAPConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetEpicGamesIAPConfig Build(
                string namespace_
            )
            {
                GetEpicGamesIAPConfig op = new GetEpicGamesIAPConfig(this,
                    namespace_                    
                );

                op.SetBaseFields<GetEpicGamesIAPConfigBuilder>(this);
                return op;
            }

            public GetEpicGamesIAPConfig.Response Execute(
                string namespace_
            )
            {
                GetEpicGamesIAPConfig op = Build(
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
            public async Task<GetEpicGamesIAPConfig.Response> ExecuteAsync(
                string namespace_
            )
            {
                GetEpicGamesIAPConfig op = Build(
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

        private GetEpicGamesIAPConfig(GetEpicGamesIAPConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.EpicGamesIAPConfigInfo>
        {


            protected override string GetFullOperationId() => "Platform::IAP::GetEpicGamesIAPConfig";
        }

        #endregion

        public GetEpicGamesIAPConfig(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/epicgames";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public GetEpicGamesIAPConfig.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetEpicGamesIAPConfig.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.EpicGamesIAPConfigInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}
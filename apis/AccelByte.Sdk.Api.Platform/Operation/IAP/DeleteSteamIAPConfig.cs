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
    /// deleteSteamIAPConfig
    ///
    /// Delete steam iap config.
    /// </summary>
    public class DeleteSteamIAPConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteSteamIAPConfigBuilder Builder { get => new DeleteSteamIAPConfigBuilder(); }

        public class DeleteSteamIAPConfigBuilder
            : OperationBuilder<DeleteSteamIAPConfigBuilder>
        {





            internal DeleteSteamIAPConfigBuilder() { }

            internal DeleteSteamIAPConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteSteamIAPConfig Build(
                string namespace_
            )
            {
                DeleteSteamIAPConfig op = new DeleteSteamIAPConfig(this,
                    namespace_                    
                );

                op.SetBaseFields<DeleteSteamIAPConfigBuilder>(this);
                return op;
            }

            public DeleteSteamIAPConfig.Response Execute(
                string namespace_
            )
            {
                DeleteSteamIAPConfig op = Build(
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
            public async Task<DeleteSteamIAPConfig.Response> ExecuteAsync(
                string namespace_
            )
            {
                DeleteSteamIAPConfig op = Build(
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

        private DeleteSteamIAPConfig(DeleteSteamIAPConfigBuilder builder,
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


            protected override string GetFullOperationId() => "Platform::IAP::DeleteSteamIAPConfig";
        }

        #endregion

        public DeleteSteamIAPConfig(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/steam";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public DeleteSteamIAPConfig.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DeleteSteamIAPConfig.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };


            return response;
        }
    }

}
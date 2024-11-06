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
    /// deleteEpicGamesIAPConfig
    ///
    /// Delete epic games iap config.
    /// </summary>
    public class DeleteEpicGamesIAPConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteEpicGamesIAPConfigBuilder Builder { get => new DeleteEpicGamesIAPConfigBuilder(); }

        public class DeleteEpicGamesIAPConfigBuilder
            : OperationBuilder<DeleteEpicGamesIAPConfigBuilder>
        {





            internal DeleteEpicGamesIAPConfigBuilder() { }

            internal DeleteEpicGamesIAPConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteEpicGamesIAPConfig Build(
                string namespace_
            )
            {
                DeleteEpicGamesIAPConfig op = new DeleteEpicGamesIAPConfig(this,
                    namespace_                    
                );

                op.SetBaseFields<DeleteEpicGamesIAPConfigBuilder>(this);
                return op;
            }

            public DeleteEpicGamesIAPConfig.Response Execute(
                string namespace_
            )
            {
                DeleteEpicGamesIAPConfig op = Build(
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
            public async Task<DeleteEpicGamesIAPConfig.Response> ExecuteAsync(
                string namespace_
            )
            {
                DeleteEpicGamesIAPConfig op = Build(
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

        private DeleteEpicGamesIAPConfig(DeleteEpicGamesIAPConfigBuilder builder,
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


            protected override string GetFullOperationId() => "Platform::IAP::DeleteEpicGamesIAPConfig";
        }

        #endregion

        public DeleteEpicGamesIAPConfig(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/epicgames";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public DeleteEpicGamesIAPConfig.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DeleteEpicGamesIAPConfig.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };


            return response;
        }
    }

}
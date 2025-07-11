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
    /// deleteItemTypeConfig
    ///
    ///  [Not supported yet in AGS Shared Cloud] This API is used to delete an item type config permanently.
    /// </summary>
    public class DeleteItemTypeConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteItemTypeConfigBuilder Builder { get => new DeleteItemTypeConfigBuilder(); }

        public class DeleteItemTypeConfigBuilder
            : OperationBuilder<DeleteItemTypeConfigBuilder>
        {





            internal DeleteItemTypeConfigBuilder() { }

            internal DeleteItemTypeConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteItemTypeConfig Build(
                string id
            )
            {
                DeleteItemTypeConfig op = new DeleteItemTypeConfig(this,
                    id                    
                );

                op.SetBaseFields<DeleteItemTypeConfigBuilder>(this);
                return op;
            }

            public DeleteItemTypeConfig.Response Execute(
                string id
            )
            {
                DeleteItemTypeConfig op = Build(
                    id
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<DeleteItemTypeConfig.Response> ExecuteAsync(
                string id
            )
            {
                DeleteItemTypeConfig op = Build(
                    id
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

        private DeleteItemTypeConfig(DeleteItemTypeConfigBuilder builder,
            string id
        )
        {
            PathParams["id"] = id;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Item::DeleteItemTypeConfig";
        }

        #endregion

        public DeleteItemTypeConfig(
            string id            
        )
        {
            PathParams["id"] = id;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/items/configs/{id}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public DeleteItemTypeConfig.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DeleteItemTypeConfig.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)404)
            
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }

            return response;
        }
    }

}
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

using AccelByte.Sdk.Api.Inventory.Model;

namespace AccelByte.Sdk.Api.Inventory.Operation
{
    /// <summary>
    /// AdminGetInventoryConfiguration
    ///
    /// 
    /// Getting an inventory configuration info.
    /// 
    /// Permission: ADMIN:NAMESPACE:{namespace}:INVENTORY:CONFIGURATION [READ]
    /// </summary>
    public class AdminGetInventoryConfiguration : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetInventoryConfigurationBuilder Builder { get => new AdminGetInventoryConfigurationBuilder(); }

        public class AdminGetInventoryConfigurationBuilder
            : OperationBuilder<AdminGetInventoryConfigurationBuilder>
        {





            internal AdminGetInventoryConfigurationBuilder() { }

            internal AdminGetInventoryConfigurationBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetInventoryConfiguration Build(
                string inventoryConfigurationId,
                string namespace_
            )
            {
                AdminGetInventoryConfiguration op = new AdminGetInventoryConfiguration(this,
                    inventoryConfigurationId,                    
                    namespace_                    
                );

                op.SetBaseFields<AdminGetInventoryConfigurationBuilder>(this);
                return op;
            }

            public AdminGetInventoryConfiguration.Response Execute(
                string inventoryConfigurationId,
                string namespace_
            )
            {
                AdminGetInventoryConfiguration op = Build(
                    inventoryConfigurationId,
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
            public async Task<AdminGetInventoryConfiguration.Response> ExecuteAsync(
                string inventoryConfigurationId,
                string namespace_
            )
            {
                AdminGetInventoryConfiguration op = Build(
                    inventoryConfigurationId,
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

        private AdminGetInventoryConfiguration(AdminGetInventoryConfigurationBuilder builder,
            string inventoryConfigurationId,
            string namespace_
        )
        {
            PathParams["inventoryConfigurationId"] = inventoryConfigurationId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ApimodelsInventoryConfigurationResp>
        {

            public ApimodelsErrorResponse? Error400 { get; set; } = null;

            public ApimodelsErrorResponse? Error404 { get; set; } = null;

            public ApimodelsErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Inventory::AdminInventoryConfigurations::AdminGetInventoryConfiguration";
        }

        #endregion

        public AdminGetInventoryConfiguration(
            string inventoryConfigurationId,            
            string namespace_            
        )
        {
            PathParams["inventoryConfigurationId"] = inventoryConfigurationId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/inventoryConfigurations/{inventoryConfigurationId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminGetInventoryConfiguration.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminGetInventoryConfiguration.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ApimodelsInventoryConfigurationResp>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ApimodelsErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ApimodelsErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ApimodelsErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
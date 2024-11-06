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
    /// AdminCreateChainingOperations
    ///
    /// 
    /// Create chaining Operations.
    /// This process will run sequentially
    /// 1. remove item process
    /// 2. consume item process
    /// 3. update item process
    /// 4. create item process
    /// if toSpecificInventory set as true, then inventoryId field will be mandatory, vice versa
    /// 
    /// The behavior of each process is same with current admin level endpoint
    /// 
    /// requestId: Request id(Optional), client should provide a unique request id to perform at most once execution, When a request id is resubmitted,
    /// it will return original successful response
    /// replayed : replayed, if true,the response is original successful response. This will not be included in response if client have not pass request id.
    /// 
    /// Permission: ADMIN:NAMESPACE:{namespace}:USER:{userId}:INVENTORY:ITEM [CREATE]
    /// </summary>
    public class AdminCreateChainingOperations : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCreateChainingOperationsBuilder Builder { get => new AdminCreateChainingOperationsBuilder(); }

        public class AdminCreateChainingOperationsBuilder
            : OperationBuilder<AdminCreateChainingOperationsBuilder>
        {





            internal AdminCreateChainingOperationsBuilder() { }

            internal AdminCreateChainingOperationsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminCreateChainingOperations Build(
                ApimodelsChainingOperationReq body,
                string namespace_
            )
            {
                AdminCreateChainingOperations op = new AdminCreateChainingOperations(this,
                    body,                    
                    namespace_                    
                );

                op.SetBaseFields<AdminCreateChainingOperationsBuilder>(this);
                return op;
            }

            public AdminCreateChainingOperations.Response Execute(
                ApimodelsChainingOperationReq body,
                string namespace_
            )
            {
                AdminCreateChainingOperations op = Build(
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
            public async Task<AdminCreateChainingOperations.Response> ExecuteAsync(
                ApimodelsChainingOperationReq body,
                string namespace_
            )
            {
                AdminCreateChainingOperations op = Build(
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

        private AdminCreateChainingOperations(AdminCreateChainingOperationsBuilder builder,
            ApimodelsChainingOperationReq body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ApimodelsChainingOperationResp>
        {

            public ApimodelsChainingOperationResp? Error400 { get; set; } = null;

            public ApimodelsChainingOperationResp? Error401 { get; set; } = null;

            public ApimodelsChainingOperationResp? Error403 { get; set; } = null;

            public ApimodelsChainingOperationResp? Error404 { get; set; } = null;

            public ApimodelsChainingOperationResp? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Inventory::AdminChainingOperations::AdminCreateChainingOperations";
        }

        #endregion

        public AdminCreateChainingOperations(
            string namespace_,            
            Model.ApimodelsChainingOperationReq body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/chainingOperations";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminCreateChainingOperations.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminCreateChainingOperations.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ApimodelsChainingOperationResp>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ApimodelsChainingOperationResp>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ApimodelsChainingOperationResp>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ApimodelsChainingOperationResp>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ApimodelsChainingOperationResp>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ApimodelsChainingOperationResp>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
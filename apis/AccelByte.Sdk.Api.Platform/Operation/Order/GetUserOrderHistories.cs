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
    /// getUserOrderHistories
    ///
    /// Get user order history.
    /// Other detail info:
    /// 
    ///   * Returns : get order history
    /// </summary>
    public class GetUserOrderHistories : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserOrderHistoriesBuilder Builder { get => new GetUserOrderHistoriesBuilder(); }

        public class GetUserOrderHistoriesBuilder
            : OperationBuilder<GetUserOrderHistoriesBuilder>
        {





            internal GetUserOrderHistoriesBuilder() { }

            internal GetUserOrderHistoriesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetUserOrderHistories Build(
                string namespace_,
                string orderNo,
                string userId
            )
            {
                GetUserOrderHistories op = new GetUserOrderHistories(this,
                    namespace_,                    
                    orderNo,                    
                    userId                    
                );

                op.SetBaseFields<GetUserOrderHistoriesBuilder>(this);
                return op;
            }

            public GetUserOrderHistories.Response Execute(
                string namespace_,
                string orderNo,
                string userId
            )
            {
                GetUserOrderHistories op = Build(
                    namespace_,
                    orderNo,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<GetUserOrderHistories.Response> ExecuteAsync(
                string namespace_,
                string orderNo,
                string userId
            )
            {
                GetUserOrderHistories op = Build(
                    namespace_,
                    orderNo,
                    userId
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

        private GetUserOrderHistories(GetUserOrderHistoriesBuilder builder,
            string namespace_,
            string orderNo,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["orderNo"] = orderNo;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<List<Model.OrderHistoryInfo>>
        {


            protected override string GetFullOperationId() => "Platform::Order::GetUserOrderHistories";
        }

        #endregion

        public GetUserOrderHistories(
            string namespace_,            
            string orderNo,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["orderNo"] = orderNo;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo}/history";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public GetUserOrderHistories.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetUserOrderHistories.Response()
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
                response.Data = JsonSerializer.Deserialize<List<Model.OrderHistoryInfo>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}
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
    /// getIAPOrderConsumeDetails
    ///
    /// Get IAP Order Consume Details by IAP Order Number.
    /// </summary>
    public class GetIAPOrderConsumeDetails : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetIAPOrderConsumeDetailsBuilder Builder { get => new GetIAPOrderConsumeDetailsBuilder(); }

        public class GetIAPOrderConsumeDetailsBuilder
            : OperationBuilder<GetIAPOrderConsumeDetailsBuilder>
        {





            internal GetIAPOrderConsumeDetailsBuilder() { }

            internal GetIAPOrderConsumeDetailsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetIAPOrderConsumeDetails Build(
                string iapOrderNo,
                string namespace_
            )
            {
                GetIAPOrderConsumeDetails op = new GetIAPOrderConsumeDetails(this,
                    iapOrderNo,                    
                    namespace_                    
                );

                op.SetBaseFields<GetIAPOrderConsumeDetailsBuilder>(this);
                return op;
            }

            public GetIAPOrderConsumeDetails.Response Execute(
                string iapOrderNo,
                string namespace_
            )
            {
                GetIAPOrderConsumeDetails op = Build(
                    iapOrderNo,
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
            public async Task<GetIAPOrderConsumeDetails.Response> ExecuteAsync(
                string iapOrderNo,
                string namespace_
            )
            {
                GetIAPOrderConsumeDetails op = Build(
                    iapOrderNo,
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

        private GetIAPOrderConsumeDetails(GetIAPOrderConsumeDetailsBuilder builder,
            string iapOrderNo,
            string namespace_
        )
        {
            PathParams["iapOrderNo"] = iapOrderNo;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<List<Model.IAPOrderConsumeDetailInfo>>
        {


            protected override string GetFullOperationId() => "Platform::IAP::GetIAPOrderConsumeDetails";
        }

        #endregion

        public GetIAPOrderConsumeDetails(
            string iapOrderNo,            
            string namespace_            
        )
        {
            PathParams["iapOrderNo"] = iapOrderNo;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/{iapOrderNo}/consumedetails";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public GetIAPOrderConsumeDetails.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetIAPOrderConsumeDetails.Response()
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
                response.Data = JsonSerializer.Deserialize<List<Model.IAPOrderConsumeDetailInfo>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}
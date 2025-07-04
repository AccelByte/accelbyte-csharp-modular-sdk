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

using AccelByte.Sdk.Api.Basic.Model;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// publicGetCustomAttributesInfo
    ///
    /// Get custom attributes info.
    /// Other detail info:
    /// 
    ///   * Action code : 11404
    ///   *  Returns : user custom attributes
    /// </summary>
    public class PublicGetCustomAttributesInfo : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetCustomAttributesInfoBuilder Builder { get => new PublicGetCustomAttributesInfoBuilder(); }

        public class PublicGetCustomAttributesInfoBuilder
            : OperationBuilder<PublicGetCustomAttributesInfoBuilder>
        {





            internal PublicGetCustomAttributesInfoBuilder() { }

            internal PublicGetCustomAttributesInfoBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetCustomAttributesInfo Build(
                string namespace_,
                string userId
            )
            {
                PublicGetCustomAttributesInfo op = new PublicGetCustomAttributesInfo(this,
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<PublicGetCustomAttributesInfoBuilder>(this);
                return op;
            }

            public PublicGetCustomAttributesInfo.Response Execute(
                string namespace_,
                string userId
            )
            {
                PublicGetCustomAttributesInfo op = Build(
                    namespace_,
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
            public async Task<PublicGetCustomAttributesInfo.Response> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                PublicGetCustomAttributesInfo op = Build(
                    namespace_,
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

        private PublicGetCustomAttributesInfo(PublicGetCustomAttributesInfoBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Dictionary<string, object>>
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Basic::UserProfile::PublicGetCustomAttributesInfo";
        }

        #endregion

        public PublicGetCustomAttributesInfo(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/users/{userId}/profiles/customAttributes";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicGetCustomAttributesInfo.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicGetCustomAttributesInfo.Response()
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
                response.Data = JsonSerializer.Deserialize<Dictionary<string, object>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }

            return response;
        }
    }

}
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
    /// getMyPrivateCustomAttributesInfo
    ///
    /// Get my private custom attributes.
    /// Other detail info:
    /// 
    ///   * Returns : custom attributes
    ///   *  Action code : 11403
    /// </summary>
    public class GetMyPrivateCustomAttributesInfo : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetMyPrivateCustomAttributesInfoBuilder Builder { get => new GetMyPrivateCustomAttributesInfoBuilder(); }

        public class GetMyPrivateCustomAttributesInfoBuilder
            : OperationBuilder<GetMyPrivateCustomAttributesInfoBuilder>
        {





            internal GetMyPrivateCustomAttributesInfoBuilder() { }

            internal GetMyPrivateCustomAttributesInfoBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetMyPrivateCustomAttributesInfo Build(
                string namespace_
            )
            {
                GetMyPrivateCustomAttributesInfo op = new GetMyPrivateCustomAttributesInfo(this,
                    namespace_                    
                );

                op.SetBaseFields<GetMyPrivateCustomAttributesInfoBuilder>(this);
                return op;
            }

            public GetMyPrivateCustomAttributesInfo.Response Execute(
                string namespace_
            )
            {
                GetMyPrivateCustomAttributesInfo op = Build(
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
            public async Task<GetMyPrivateCustomAttributesInfo.Response> ExecuteAsync(
                string namespace_
            )
            {
                GetMyPrivateCustomAttributesInfo op = Build(
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

        private GetMyPrivateCustomAttributesInfo(GetMyPrivateCustomAttributesInfoBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Dictionary<string, object>>
        {

            public ErrorEntity? Error401 { get; set; } = null;

            public ErrorEntity? Error403 { get; set; } = null;

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Basic::UserProfile::GetMyPrivateCustomAttributesInfo";
        }

        #endregion

        public GetMyPrivateCustomAttributesInfo(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/users/me/profiles/privateCustomAttributes";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public GetMyPrivateCustomAttributesInfo.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetMyPrivateCustomAttributesInfo.Response()
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
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
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
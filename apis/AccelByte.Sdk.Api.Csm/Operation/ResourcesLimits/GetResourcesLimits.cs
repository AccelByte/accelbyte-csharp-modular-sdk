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

using AccelByte.Sdk.Api.Csm.Model;

namespace AccelByte.Sdk.Api.Csm.Operation
{
    /// <summary>
    /// GetResourcesLimits
    ///
    /// This endpoint return the Extend Apps Configurable Limits for front end to use for initial validation before app creation
    /// e.g.
    /// Replica Limit will be used to check max replica that can be created for the said environment by default
    /// CPU Limit will be used to validate max allowed CPU for the extend app that hasn't been created
    /// Memory Limit will be used to validate max allowed Memory for the extend app that hasn't been created
    /// MaxAppNotificationSubscription will be used to validate the maximum number of subscriber for an app status notification
    /// </summary>
    public class GetResourcesLimits : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetResourcesLimitsBuilder Builder { get => new GetResourcesLimitsBuilder(); }

        public class GetResourcesLimitsBuilder
            : OperationBuilder<GetResourcesLimitsBuilder>
        {





            internal GetResourcesLimitsBuilder() { }

            internal GetResourcesLimitsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetResourcesLimits Build(
                string namespace_
            )
            {
                GetResourcesLimits op = new GetResourcesLimits(this,
                    namespace_                    
                );

                op.SetBaseFields<GetResourcesLimitsBuilder>(this);
                return op;
            }

            public GetResourcesLimits.Response Execute(
                string namespace_
            )
            {
                GetResourcesLimits op = Build(
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
            public async Task<GetResourcesLimits.Response> ExecuteAsync(
                string namespace_
            )
            {
                GetResourcesLimits op = Build(
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

        private GetResourcesLimits(GetResourcesLimitsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ApimodelCSMAppLimitsResponse>
        {

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error402 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Csm::ResourcesLimits::GetResourcesLimits";
        }

        #endregion

        public GetResourcesLimits(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/csm/v2/admin/namespaces/{namespace}/resources/limits";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public GetResourcesLimits.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetResourcesLimits.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ApimodelCSMAppLimitsResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)402)
            {
                response.Error402 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error402!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
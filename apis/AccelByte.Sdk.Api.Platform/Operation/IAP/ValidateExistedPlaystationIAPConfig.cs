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
    /// validateExistedPlaystationIAPConfig
    ///
    /// Validate playstation iap config. Other detail info:
    ///   * Returns : Test Results
    /// </summary>
    public class ValidateExistedPlaystationIAPConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ValidateExistedPlaystationIAPConfigBuilder Builder { get => new ValidateExistedPlaystationIAPConfigBuilder(); }

        public class ValidateExistedPlaystationIAPConfigBuilder
            : OperationBuilder<ValidateExistedPlaystationIAPConfigBuilder>
        {





            internal ValidateExistedPlaystationIAPConfigBuilder() { }

            internal ValidateExistedPlaystationIAPConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public ValidateExistedPlaystationIAPConfig Build(
                string namespace_
            )
            {
                ValidateExistedPlaystationIAPConfig op = new ValidateExistedPlaystationIAPConfig(this,
                    namespace_                    
                );

                op.SetBaseFields<ValidateExistedPlaystationIAPConfigBuilder>(this);
                return op;
            }

            public ValidateExistedPlaystationIAPConfig.Response Execute(
                string namespace_
            )
            {
                ValidateExistedPlaystationIAPConfig op = Build(
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
            public async Task<ValidateExistedPlaystationIAPConfig.Response> ExecuteAsync(
                string namespace_
            )
            {
                ValidateExistedPlaystationIAPConfig op = Build(
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

        private ValidateExistedPlaystationIAPConfig(ValidateExistedPlaystationIAPConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.TestResult>
        {


            protected override string GetFullOperationId() => "Platform::IAP::ValidateExistedPlaystationIAPConfig";
        }

        #endregion

        public ValidateExistedPlaystationIAPConfig(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/playstation/validate";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public ValidateExistedPlaystationIAPConfig.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new ValidateExistedPlaystationIAPConfig.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.TestResult>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}
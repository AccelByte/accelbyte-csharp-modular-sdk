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
    /// updateGoogleIAPConfig
    ///
    /// Update google iap config. Other detail info:
    ///   * Returns : updated google iap config
    /// </summary>
    public class UpdateGoogleIAPConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateGoogleIAPConfigBuilder Builder { get => new UpdateGoogleIAPConfigBuilder(); }

        public class UpdateGoogleIAPConfigBuilder
            : OperationBuilder<UpdateGoogleIAPConfigBuilder>
        {





            internal UpdateGoogleIAPConfigBuilder() { }

            internal UpdateGoogleIAPConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateGoogleIAPConfig Build(
                GoogleIAPConfigRequest body,
                string namespace_
            )
            {
                UpdateGoogleIAPConfig op = new UpdateGoogleIAPConfig(this,
                    body,                    
                    namespace_                    
                );

                op.SetBaseFields<UpdateGoogleIAPConfigBuilder>(this);
                return op;
            }

            public UpdateGoogleIAPConfig.Response Execute(
                GoogleIAPConfigRequest body,
                string namespace_
            )
            {
                UpdateGoogleIAPConfig op = Build(
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
            public async Task<UpdateGoogleIAPConfig.Response> ExecuteAsync(
                GoogleIAPConfigRequest body,
                string namespace_
            )
            {
                UpdateGoogleIAPConfig op = Build(
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

        private UpdateGoogleIAPConfig(UpdateGoogleIAPConfigBuilder builder,
            GoogleIAPConfigRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.GoogleIAPConfigInfo>
        {


            protected override string GetFullOperationId() => "Platform::IAP::UpdateGoogleIAPConfig";
        }

        #endregion

        public UpdateGoogleIAPConfig(
            string namespace_,            
            Model.GoogleIAPConfigRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/google";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public UpdateGoogleIAPConfig.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdateGoogleIAPConfig.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.GoogleIAPConfigInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}
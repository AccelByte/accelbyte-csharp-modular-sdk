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
    /// enableEntitlementOriginFeature
    ///
    /// Enable Entitlement origin feature.
    /// Other detail info:
    /// 
    ///   * Returns : entitlement info
    /// </summary>
    public class EnableEntitlementOriginFeature : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static EnableEntitlementOriginFeatureBuilder Builder { get => new EnableEntitlementOriginFeatureBuilder(); }

        public class EnableEntitlementOriginFeatureBuilder
            : OperationBuilder<EnableEntitlementOriginFeatureBuilder>
        {





            internal EnableEntitlementOriginFeatureBuilder() { }

            internal EnableEntitlementOriginFeatureBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public EnableEntitlementOriginFeature Build(
                string namespace_
            )
            {
                EnableEntitlementOriginFeature op = new EnableEntitlementOriginFeature(this,
                    namespace_                    
                );

                op.SetBaseFields<EnableEntitlementOriginFeatureBuilder>(this);
                return op;
            }

            public EnableEntitlementOriginFeature.Response Execute(
                string namespace_
            )
            {
                EnableEntitlementOriginFeature op = Build(
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
            public async Task<EnableEntitlementOriginFeature.Response> ExecuteAsync(
                string namespace_
            )
            {
                EnableEntitlementOriginFeature op = Build(
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

        private EnableEntitlementOriginFeature(EnableEntitlementOriginFeatureBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.EntitlementConfigInfo>
        {


            protected override string GetFullOperationId() => "Platform::Entitlement::EnableEntitlementOriginFeature";
        }

        #endregion

        public EnableEntitlementOriginFeature(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/entitlements/config/entitlementOrigin/enable";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public EnableEntitlementOriginFeature.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new EnableEntitlementOriginFeature.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.EntitlementConfigInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}
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
    /// getPsnEntitlementOwnership
    ///
    /// Get user psn entitlement ownership by entitlement label.
    /// </summary>
    public class GetPsnEntitlementOwnership : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetPsnEntitlementOwnershipBuilder Builder { get => new GetPsnEntitlementOwnershipBuilder(); }

        public class GetPsnEntitlementOwnershipBuilder
            : OperationBuilder<GetPsnEntitlementOwnershipBuilder>
        {





            internal GetPsnEntitlementOwnershipBuilder() { }

            internal GetPsnEntitlementOwnershipBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetPsnEntitlementOwnership Build(
                PsnEntitlementOwnershipRequest body,
                string entitlementLabel,
                string namespace_
            )
            {
                GetPsnEntitlementOwnership op = new GetPsnEntitlementOwnership(this,
                    body,                    
                    entitlementLabel,                    
                    namespace_                    
                );

                op.SetBaseFields<GetPsnEntitlementOwnershipBuilder>(this);
                return op;
            }

            public GetPsnEntitlementOwnership.Response Execute(
                PsnEntitlementOwnershipRequest body,
                string entitlementLabel,
                string namespace_
            )
            {
                GetPsnEntitlementOwnership op = Build(
                    body,
                    entitlementLabel,
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
            public async Task<GetPsnEntitlementOwnership.Response> ExecuteAsync(
                PsnEntitlementOwnershipRequest body,
                string entitlementLabel,
                string namespace_
            )
            {
                GetPsnEntitlementOwnership op = Build(
                    body,
                    entitlementLabel,
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

        private GetPsnEntitlementOwnership(GetPsnEntitlementOwnershipBuilder builder,
            PsnEntitlementOwnershipRequest body,
            string entitlementLabel,
            string namespace_
        )
        {
            PathParams["entitlementLabel"] = entitlementLabel;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.Ownership>
        {


            protected override string GetFullOperationId() => "Platform::Platform::GetPsnEntitlementOwnership";
        }

        #endregion

        public GetPsnEntitlementOwnership(
            string entitlementLabel,            
            string namespace_,            
            Model.PsnEntitlementOwnershipRequest body            
        )
        {
            PathParams["entitlementLabel"] = entitlementLabel;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/platforms/psn/entitlements/{entitlementLabel}/ownership";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public GetPsnEntitlementOwnership.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetPsnEntitlementOwnership.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.Ownership>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}
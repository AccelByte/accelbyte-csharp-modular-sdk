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
    /// getUserEntitlementsByIds
    ///
    /// Get user entitlements by ids. This will return all entitlements regardless of its status
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : entitlement list
    /// </summary>
    public class GetUserEntitlementsByIds : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserEntitlementsByIdsBuilder Builder { get => new GetUserEntitlementsByIdsBuilder(); }

        public class GetUserEntitlementsByIdsBuilder
            : OperationBuilder<GetUserEntitlementsByIdsBuilder>
        {

            public List<string>? Ids { get; set; }





            internal GetUserEntitlementsByIdsBuilder() { }

            internal GetUserEntitlementsByIdsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetUserEntitlementsByIdsBuilder SetIds(List<string> _ids)
            {
                Ids = _ids;
                return this;
            }





            public GetUserEntitlementsByIds Build(
                string namespace_,
                string userId
            )
            {
                GetUserEntitlementsByIds op = new GetUserEntitlementsByIds(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<GetUserEntitlementsByIdsBuilder>(this);
                return op;
            }

            public GetUserEntitlementsByIds.Response Execute(
                string namespace_,
                string userId
            )
            {
                GetUserEntitlementsByIds op = Build(
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
            public async Task<GetUserEntitlementsByIds.Response> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                GetUserEntitlementsByIds op = Build(
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

        private GetUserEntitlementsByIds(GetUserEntitlementsByIdsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.Ids is not null) QueryParams["ids"] = builder.Ids;



            CollectionFormatMap["ids"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<List<Model.EntitlementInfo>>
        {


            protected override string GetFullOperationId() => "Platform::Entitlement::GetUserEntitlementsByIds";
        }

        #endregion

        public GetUserEntitlementsByIds(
            string namespace_,
            string userId,
            List<string>? ids
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (ids is not null) QueryParams["ids"] = ids;



            CollectionFormatMap["ids"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/byIds";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public GetUserEntitlementsByIds.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetUserEntitlementsByIds.Response()
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
                response.Data = JsonSerializer.Deserialize<List<Model.EntitlementInfo>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}
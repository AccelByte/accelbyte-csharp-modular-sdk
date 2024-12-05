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

using AccelByte.Sdk.Api.Inventory.Model;

namespace AccelByte.Sdk.Api.Inventory.Operation
{
    /// <summary>
    /// AdminSyncUserEntitlements
    ///
    /// 
    /// Sync user's entitlement from e-commerce service to inventory for non exist item at user inventory.
    /// will skip the item if already exist at user inventory.
    /// Permission: ADMIN:NAMESPACE:{namespace}:USER:{userId}:INVENTORY:ITEM [UPDATE]
    /// </summary>
    public class AdminSyncUserEntitlements : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminSyncUserEntitlementsBuilder Builder { get => new AdminSyncUserEntitlementsBuilder(); }

        public class AdminSyncUserEntitlementsBuilder
            : OperationBuilder<AdminSyncUserEntitlementsBuilder>
        {





            internal AdminSyncUserEntitlementsBuilder() { }

            internal AdminSyncUserEntitlementsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminSyncUserEntitlements Build(
                string namespace_,
                string userId
            )
            {
                AdminSyncUserEntitlements op = new AdminSyncUserEntitlements(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AdminSyncUserEntitlementsBuilder>(this);
                return op;
            }

            public AdminSyncUserEntitlements.Response Execute(
                string namespace_,
                string userId
            )
            {
                AdminSyncUserEntitlements op = Build(
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
            public async Task<AdminSyncUserEntitlements.Response> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                AdminSyncUserEntitlements op = Build(
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

        private AdminSyncUserEntitlements(AdminSyncUserEntitlementsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ApimodelsErrorResponse? Error400 { get; set; } = null;

            public ApimodelsErrorResponse? Error401 { get; set; } = null;

            public ApimodelsErrorResponse? Error403 { get; set; } = null;

            public ApimodelsErrorResponse? Error404 { get; set; } = null;

            public ApimodelsErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Inventory::AdminItems::AdminSyncUserEntitlements";
        }

        #endregion

        public AdminSyncUserEntitlements(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/users/{userId}/items/entitlements/sync";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public AdminSyncUserEntitlements.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminSyncUserEntitlements.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)

            {
                response.Error400 = JsonSerializer.Deserialize<ApimodelsErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)

            {
                response.Error401 = JsonSerializer.Deserialize<ApimodelsErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)

            {
                response.Error403 = JsonSerializer.Deserialize<ApimodelsErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)

            {
                response.Error404 = JsonSerializer.Deserialize<ApimodelsErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)

            {
                response.Error500 = JsonSerializer.Deserialize<ApimodelsErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
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
    /// AdminDeleteItemType
    ///
    /// 
    /// This endpoint will delete a item type by itemtypeName in a specified namespace.
    /// If the itemtypeName doesn't exist in a namespace, it'll return not found.
    /// 
    /// Permission: ADMIN:NAMESPACE:{namespace}:INVENTORY:ITEMTYPE [DELETE]
    /// </summary>
    public class AdminDeleteItemType : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteItemTypeBuilder Builder { get => new AdminDeleteItemTypeBuilder(); }

        public class AdminDeleteItemTypeBuilder
            : OperationBuilder<AdminDeleteItemTypeBuilder>
        {





            internal AdminDeleteItemTypeBuilder() { }

            internal AdminDeleteItemTypeBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeleteItemType Build(
                string itemTypeName,
                string namespace_
            )
            {
                AdminDeleteItemType op = new AdminDeleteItemType(this,
                    itemTypeName,
                    namespace_
                );

                op.SetBaseFields<AdminDeleteItemTypeBuilder>(this);
                return op;
            }

            public AdminDeleteItemType.Response Execute(
                string itemTypeName,
                string namespace_
            )
            {
                AdminDeleteItemType op = Build(
                    itemTypeName,
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
            public async Task<AdminDeleteItemType.Response> ExecuteAsync(
                string itemTypeName,
                string namespace_
            )
            {
                AdminDeleteItemType op = Build(
                    itemTypeName,
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

        private AdminDeleteItemType(AdminDeleteItemTypeBuilder builder,
            string itemTypeName,
            string namespace_
        )
        {
            PathParams["itemTypeName"] = itemTypeName;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ApimodelsErrorResponse? Error404 { get; set; } = null;

            public ApimodelsErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Inventory::AdminItemTypes::AdminDeleteItemType";
        }

        #endregion

        public AdminDeleteItemType(
            string itemTypeName,
            string namespace_
        )
        {
            PathParams["itemTypeName"] = itemTypeName;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/itemtypes/{itemTypeName}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public AdminDeleteItemType.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminDeleteItemType.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)404)

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
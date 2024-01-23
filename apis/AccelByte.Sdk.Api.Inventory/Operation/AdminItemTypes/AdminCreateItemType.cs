// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
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

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Inventory.Model;

namespace AccelByte.Sdk.Api.Inventory.Operation
{
    /// <summary>
    /// AdminCreateItemType
    ///
    /// 
    /// This endpoint will create a new itemtype.
    /// The itemtype name must be unique per namespace.
    /// It is safe to call this endpoint even if the itemtype already exists.
    /// 
    /// Permission: ADMIN:NAMESPACE:{namespace}:INVENTORY:ITEMTYPE [CREATE]
    /// </summary>
    public class AdminCreateItemType : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCreateItemTypeBuilder Builder { get => new AdminCreateItemTypeBuilder(); }

        public class AdminCreateItemTypeBuilder
            : OperationBuilder<AdminCreateItemTypeBuilder>
        {





            internal AdminCreateItemTypeBuilder() { }

            internal AdminCreateItemTypeBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminCreateItemType Build(
                ApimodelsCreateItemTypeReq body,
                string namespace_
            )
            {
                AdminCreateItemType op = new AdminCreateItemType(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<AdminCreateItemTypeBuilder>(this);
                return op;
            }

            public Model.ApimodelsCreateItemTypeResp? Execute(
                ApimodelsCreateItemTypeReq body,
                string namespace_
            )
            {
                AdminCreateItemType op = Build(
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
        }

        private AdminCreateItemType(AdminCreateItemTypeBuilder builder,
            ApimodelsCreateItemTypeReq body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminCreateItemType(
            string namespace_,
            Model.ApimodelsCreateItemTypeReq body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/itemtypes";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApimodelsCreateItemTypeResp? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsCreateItemTypeResp>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsCreateItemTypeResp>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
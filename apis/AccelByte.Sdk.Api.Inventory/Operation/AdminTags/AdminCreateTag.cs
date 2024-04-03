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
    /// AdminCreateTag
    ///
    /// 
    /// This endpoint will create a new tag.
    /// The tag name must be unique per namespace.
    /// It is safe to call this endpoint even if the tag already exists.
    /// 
    /// Permission: ADMIN:NAMESPACE:{namespace}:INVENTORY:TAG [CREATE]
    /// </summary>
    public class AdminCreateTag : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCreateTagBuilder Builder { get => new AdminCreateTagBuilder(); }

        public class AdminCreateTagBuilder
            : OperationBuilder<AdminCreateTagBuilder>
        {





            internal AdminCreateTagBuilder() { }

            internal AdminCreateTagBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminCreateTag Build(
                ApimodelsCreateTagReq body,
                string namespace_
            )
            {
                AdminCreateTag op = new AdminCreateTag(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<AdminCreateTagBuilder>(this);
                return op;
            }

            public Model.ApimodelsCreateTagResp? Execute(
                ApimodelsCreateTagReq body,
                string namespace_
            )
            {
                AdminCreateTag op = Build(
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
            public async Task<Model.ApimodelsCreateTagResp?> ExecuteAsync(
                ApimodelsCreateTagReq body,
                string namespace_
            )
            {
                AdminCreateTag op = Build(
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

        private AdminCreateTag(AdminCreateTagBuilder builder,
            ApimodelsCreateTagReq body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminCreateTag(
            string namespace_,
            Model.ApimodelsCreateTagReq body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/tags";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApimodelsCreateTagResp? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsCreateTagResp>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsCreateTagResp>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
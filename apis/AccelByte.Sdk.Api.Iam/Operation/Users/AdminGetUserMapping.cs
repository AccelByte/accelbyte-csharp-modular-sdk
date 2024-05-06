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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminGetUserMapping
    ///
    /// This endpoint requires the client access token as the bearer token
    /// This endpoint will support publisher access to game and game access to publisher
    /// If targetNamespace filled with publisher namespace then this endpoint will return its publisher user id and publisher namespace.
    /// If targetNamespace filled with game namespace then this endpoint will return its game user id and game namespace.
    /// </summary>
    public class AdminGetUserMapping : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetUserMappingBuilder Builder { get => new AdminGetUserMappingBuilder(); }

        public class AdminGetUserMappingBuilder
            : OperationBuilder<AdminGetUserMappingBuilder>
        {





            internal AdminGetUserMappingBuilder() { }

            internal AdminGetUserMappingBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetUserMapping Build(
                string namespace_,
                string targetNamespace,
                string userId
            )
            {
                AdminGetUserMapping op = new AdminGetUserMapping(this,
                    namespace_,
                    targetNamespace,
                    userId
                );

                op.SetBaseFields<AdminGetUserMappingBuilder>(this);
                return op;
            }

            public Model.ModelGetUserMappingV3? Execute(
                string namespace_,
                string targetNamespace,
                string userId
            )
            {
                AdminGetUserMapping op = Build(
                    namespace_,
                    targetNamespace,
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
            public async Task<Model.ModelGetUserMappingV3?> ExecuteAsync(
                string namespace_,
                string targetNamespace,
                string userId
            )
            {
                AdminGetUserMapping op = Build(
                    namespace_,
                    targetNamespace,
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

        private AdminGetUserMapping(AdminGetUserMappingBuilder builder,
            string namespace_,
            string targetNamespace,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["targetNamespace"] = targetNamespace;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetUserMapping(
            string namespace_,
            string targetNamespace,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["targetNamespace"] = targetNamespace;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/platforms/justice/{targetNamespace}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelGetUserMappingV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelGetUserMappingV3>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelGetUserMappingV3>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
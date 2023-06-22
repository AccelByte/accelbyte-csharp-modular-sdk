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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminGetUserDeletionStatusV3
    ///
    /// Required permissions 'ADMIN:NAMESPACE:{namespace}:DELETIONSTATUS:USER:{userId} [READ]'
    /// action code : 10145
    /// </summary>
    public class AdminGetUserDeletionStatusV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetUserDeletionStatusV3Builder Builder { get => new AdminGetUserDeletionStatusV3Builder(); }

        public class AdminGetUserDeletionStatusV3Builder
            : OperationBuilder<AdminGetUserDeletionStatusV3Builder>
        {





            internal AdminGetUserDeletionStatusV3Builder() { }

            internal AdminGetUserDeletionStatusV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetUserDeletionStatusV3 Build(
                string namespace_,
                string userId
            )
            {
                AdminGetUserDeletionStatusV3 op = new AdminGetUserDeletionStatusV3(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelUserDeletionStatusResponse? Execute(
                string namespace_,
                string userId
            )
            {
                AdminGetUserDeletionStatusV3 op = Build(
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
        }

        private AdminGetUserDeletionStatusV3(AdminGetUserDeletionStatusV3Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetUserDeletionStatusV3(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/deletion/status";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelUserDeletionStatusResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserDeletionStatusResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserDeletionStatusResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
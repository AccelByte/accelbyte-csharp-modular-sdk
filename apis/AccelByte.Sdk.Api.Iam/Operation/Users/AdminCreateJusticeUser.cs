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
    /// AdminCreateJusticeUser
    ///
    /// Create Justice User from Publisher User information. It will check first if Justice User on target namespace already exist.
    /// </summary>
    public class AdminCreateJusticeUser : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCreateJusticeUserBuilder Builder { get => new AdminCreateJusticeUserBuilder(); }

        public class AdminCreateJusticeUserBuilder
            : OperationBuilder<AdminCreateJusticeUserBuilder>
        {





            internal AdminCreateJusticeUserBuilder() { }

            internal AdminCreateJusticeUserBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminCreateJusticeUser Build(
                string namespace_,
                string targetNamespace,
                string userId
            )
            {
                AdminCreateJusticeUser op = new AdminCreateJusticeUser(this,
                    namespace_,
                    targetNamespace,
                    userId
                );

                op.SetBaseFields<AdminCreateJusticeUserBuilder>(this);
                return op;
            }

            public Model.ModelCreateJusticeUserResponse? Execute(
                string namespace_,
                string targetNamespace,
                string userId
            )
            {
                AdminCreateJusticeUser op = Build(
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
            public async Task<Model.ModelCreateJusticeUserResponse?> ExecuteAsync(
                string namespace_,
                string targetNamespace,
                string userId
            )
            {
                AdminCreateJusticeUser op = Build(
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

        private AdminCreateJusticeUser(AdminCreateJusticeUserBuilder builder,
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

        public AdminCreateJusticeUser(
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

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelCreateJusticeUserResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelCreateJusticeUserResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelCreateJusticeUserResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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
    /// AdminBanUserV3
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:BAN:USER:{userId} [CREATE]'.
    /// 
    /// 
    /// 
    /// 
    /// Bans a user with specific type of ban. Ban types and reason can be queried.
    /// 
    /// 
    /// 
    /// 
    /// action code : 10141
    /// </summary>
    public class AdminBanUserV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminBanUserV3Builder Builder { get => new AdminBanUserV3Builder(); }

        public class AdminBanUserV3Builder
            : OperationBuilder<AdminBanUserV3Builder>
        {





            internal AdminBanUserV3Builder() { }

            internal AdminBanUserV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminBanUserV3 Build(
                ModelBanCreateRequest body,
                string namespace_,
                string userId
            )
            {
                AdminBanUserV3 op = new AdminBanUserV3(this,
                    body,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelUserBanResponseV3? Execute(
                ModelBanCreateRequest body,
                string namespace_,
                string userId
            )
            {
                AdminBanUserV3 op = Build(
                    body,
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

        private AdminBanUserV3(AdminBanUserV3Builder builder,
            ModelBanCreateRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminBanUserV3(
            string namespace_,
            string userId,
            Model.ModelBanCreateRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/bans";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelUserBanResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserBanResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserBanResponseV3>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
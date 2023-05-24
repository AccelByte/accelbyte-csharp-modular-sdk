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
    /// AdminGetListJusticePlatformAccounts
    ///
    /// This endpoint gets list justice platform account by providing publisher namespace and publisher userID.
    /// </summary>
    public class AdminGetListJusticePlatformAccounts : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetListJusticePlatformAccountsBuilder Builder { get => new AdminGetListJusticePlatformAccountsBuilder(); }

        public class AdminGetListJusticePlatformAccountsBuilder
            : OperationBuilder<AdminGetListJusticePlatformAccountsBuilder>
        {





            internal AdminGetListJusticePlatformAccountsBuilder() { }

            internal AdminGetListJusticePlatformAccountsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetListJusticePlatformAccounts Build(
                string namespace_,
                string userId
            )
            {
                AdminGetListJusticePlatformAccounts op = new AdminGetListJusticePlatformAccounts(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public List<Model.ModelGetUserMapping>? Execute(
                string namespace_,
                string userId
            )
            {
                AdminGetListJusticePlatformAccounts op = Build(
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

        private AdminGetListJusticePlatformAccounts(AdminGetListJusticePlatformAccountsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetListJusticePlatformAccounts(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/platforms/justice";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.ModelGetUserMapping>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelGetUserMapping>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelGetUserMapping>>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
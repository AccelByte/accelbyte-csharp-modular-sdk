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
    /// AdminBanUserBulkV3
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:BAN [CREATE]'.
    /// 
    /// 
    /// 
    /// 
    /// Bulk ban user with specific type of ban. Ban types and reason can be queried. The maximum limit value is 100 userIDs
    /// 
    /// 
    /// 
    /// 
    /// action code : 10141
    /// </summary>
    public class AdminBanUserBulkV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminBanUserBulkV3Builder Builder { get => new AdminBanUserBulkV3Builder(); }

        public class AdminBanUserBulkV3Builder
            : OperationBuilder<AdminBanUserBulkV3Builder>
        {





            internal AdminBanUserBulkV3Builder() { }

            internal AdminBanUserBulkV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminBanUserBulkV3 Build(
                ModelBulkBanCreateRequestV3 body,
                string namespace_
            )
            {
                AdminBanUserBulkV3 op = new AdminBanUserBulkV3(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelListBulkUserBanResponseV3? Execute(
                ModelBulkBanCreateRequestV3 body,
                string namespace_
            )
            {
                AdminBanUserBulkV3 op = Build(
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

        private AdminBanUserBulkV3(AdminBanUserBulkV3Builder builder,
            ModelBulkBanCreateRequestV3 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminBanUserBulkV3(
            string namespace_,
            Model.ModelBulkBanCreateRequestV3 body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/bans/users";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelListBulkUserBanResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelListBulkUserBanResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelListBulkUserBanResponseV3>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
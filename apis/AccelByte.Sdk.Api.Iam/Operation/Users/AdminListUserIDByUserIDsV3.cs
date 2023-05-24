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
    /// AdminListUserIDByUserIDsV3
    ///
    /// List User By User ID
    /// This endpoint requires ADMIN:NAMESPACE:{namespace}:USER [READ] permission.
    /// This endpoint intended to list user information from the given list of userID and namespace
    /// </summary>
    public class AdminListUserIDByUserIDsV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListUserIDByUserIDsV3Builder Builder { get => new AdminListUserIDByUserIDsV3Builder(); }

        public class AdminListUserIDByUserIDsV3Builder
            : OperationBuilder<AdminListUserIDByUserIDsV3Builder>
        {





            internal AdminListUserIDByUserIDsV3Builder() { }

            internal AdminListUserIDByUserIDsV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminListUserIDByUserIDsV3 Build(
                ModelUserIDsRequest body,
                string namespace_
            )
            {
                AdminListUserIDByUserIDsV3 op = new AdminListUserIDByUserIDsV3(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelListUserInformationResult? Execute(
                ModelUserIDsRequest body,
                string namespace_
            )
            {
                AdminListUserIDByUserIDsV3 op = Build(
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

        private AdminListUserIDByUserIDsV3(AdminListUserIDByUserIDsV3Builder builder,
            ModelUserIDsRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminListUserIDByUserIDsV3(
            string namespace_,
            Model.ModelUserIDsRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelListUserInformationResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelListUserInformationResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelListUserInformationResult>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
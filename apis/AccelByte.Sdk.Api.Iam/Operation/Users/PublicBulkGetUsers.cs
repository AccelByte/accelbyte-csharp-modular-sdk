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
    /// PublicBulkGetUsers
    ///
    /// 
    /// 
    /// Notes:
    /// 
    /// 
    /// 
    /// 
    ///                   * This endpoint bulk get users' basic info by userId, max allowed 100 at a time
    /// 
    /// 
    ///                   * If namespace is game, will search by game user Id, other wise will search by publisher namespace
    /// 
    /// 
    ///                   * Result will include displayName(if it exists)
    /// </summary>
    public class PublicBulkGetUsers : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicBulkGetUsersBuilder Builder { get => new PublicBulkGetUsersBuilder(); }

        public class PublicBulkGetUsersBuilder
            : OperationBuilder<PublicBulkGetUsersBuilder>
        {





            internal PublicBulkGetUsersBuilder() { }

            internal PublicBulkGetUsersBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicBulkGetUsers Build(
                ModelUserIDsRequest body,
                string namespace_
            )
            {
                PublicBulkGetUsers op = new PublicBulkGetUsers(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelListBulkUserResponse? Execute(
                ModelUserIDsRequest body,
                string namespace_
            )
            {
                PublicBulkGetUsers op = Build(
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

        private PublicBulkGetUsers(PublicBulkGetUsersBuilder builder,
            ModelUserIDsRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicBulkGetUsers(
            string namespace_,
            Model.ModelUserIDsRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/bulk/basic";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelListBulkUserResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelListBulkUserResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelListBulkUserResponse>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
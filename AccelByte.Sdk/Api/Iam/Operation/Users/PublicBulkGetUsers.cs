// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

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

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
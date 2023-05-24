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

using AccelByte.Sdk.Api.Basic.Model;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// getBannedUsers
    ///
    /// Get banned status.
    /// Unbanned users will not return, for example: request has 8 userIds, only 5 of then were banned, then the api will these 5 user status.Other detail info:
    /// 
    ///   * Required permission : resource= "ADMIN:NAMESPACE:{namespace}:ACTION" , action=2 (READ)
    /// </summary>
    public class GetBannedUsers : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetBannedUsersBuilder Builder { get => new GetBannedUsersBuilder(); }

        public class GetBannedUsersBuilder
            : OperationBuilder<GetBannedUsersBuilder>
        {





            internal GetBannedUsersBuilder() { }

            internal GetBannedUsersBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetBannedUsers Build(
                string namespace_,
                List<string> userIds
            )
            {
                GetBannedUsers op = new GetBannedUsers(this,
                    namespace_,
                    userIds
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public List<Model.ADTOObjectForEqu8UserBanStatus>? Execute(
                string namespace_,
                List<string> userIds
            )
            {
                GetBannedUsers op = Build(
                    namespace_,
                    userIds
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

        private GetBannedUsers(GetBannedUsersBuilder builder,
            string namespace_,
            List<string> userIds
        )
        {
            PathParams["namespace"] = namespace_;

            if (userIds is not null) QueryParams["userIds"] = userIds;



            CollectionFormatMap["userIds"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetBannedUsers(
            string namespace_,
            List<string> userIds
        )
        {
            PathParams["namespace"] = namespace_;

            if (userIds is not null) QueryParams["userIds"] = userIds;



            CollectionFormatMap["userIds"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/actions/banned";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.ADTOObjectForEqu8UserBanStatus>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ADTOObjectForEqu8UserBanStatus>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ADTOObjectForEqu8UserBanStatus>>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
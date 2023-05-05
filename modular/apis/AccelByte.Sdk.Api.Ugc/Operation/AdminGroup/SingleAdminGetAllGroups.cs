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

using AccelByte.Sdk.Api.Ugc.Model;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// SingleAdminGetAllGroups
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER:{userId}:CONTENTGROUP [READ].
    /// </summary>
    public class SingleAdminGetAllGroups : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SingleAdminGetAllGroupsBuilder Builder { get => new SingleAdminGetAllGroupsBuilder(); }

        public class SingleAdminGetAllGroupsBuilder
            : OperationBuilder<SingleAdminGetAllGroupsBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal SingleAdminGetAllGroupsBuilder() { }

            internal SingleAdminGetAllGroupsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public SingleAdminGetAllGroupsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public SingleAdminGetAllGroupsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public SingleAdminGetAllGroups Build(
                string namespace_
            )
            {
                SingleAdminGetAllGroups op = new SingleAdminGetAllGroups(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelsPaginatedGroupResponse? Execute(
                string namespace_
            )
            {
                SingleAdminGetAllGroups op = Build(
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

        private SingleAdminGetAllGroups(SingleAdminGetAllGroupsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SingleAdminGetAllGroups(
            string namespace_,            
            long? limit,            
            long? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/groups";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelsPaginatedGroupResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedGroupResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedGroupResponse>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
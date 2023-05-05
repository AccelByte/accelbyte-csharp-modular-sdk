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

using AccelByte.Sdk.Api.Gdpr.Model;

namespace AccelByte.Sdk.Api.Gdpr.Operation
{
    /// <summary>
    /// AdminGetUserPersonalDataRequests
    ///
    /// 
    /// 
    /// Required permission `ADMIN:NAMESPACE:{namespace}:INFORMATION:USER:{userId} [READ]` and scope `account`
    /// </summary>
    public class AdminGetUserPersonalDataRequests : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetUserPersonalDataRequestsBuilder Builder { get => new AdminGetUserPersonalDataRequestsBuilder(); }

        public class AdminGetUserPersonalDataRequestsBuilder
            : OperationBuilder<AdminGetUserPersonalDataRequestsBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal AdminGetUserPersonalDataRequestsBuilder() { }

            internal AdminGetUserPersonalDataRequestsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminGetUserPersonalDataRequestsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminGetUserPersonalDataRequestsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public AdminGetUserPersonalDataRequests Build(
                string namespace_,
                string userId
            )
            {
                AdminGetUserPersonalDataRequests op = new AdminGetUserPersonalDataRequests(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelsUserPersonalDataResponse? Execute(
                string namespace_,
                string userId
            )
            {
                AdminGetUserPersonalDataRequests op = Build(
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

        private AdminGetUserPersonalDataRequests(AdminGetUserPersonalDataRequestsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetUserPersonalDataRequests(
            string namespace_,            
            string userId,            
            long? limit,            
            long? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/admin/namespaces/{namespace}/users/{userId}/requests";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelsUserPersonalDataResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsUserPersonalDataResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsUserPersonalDataResponse>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
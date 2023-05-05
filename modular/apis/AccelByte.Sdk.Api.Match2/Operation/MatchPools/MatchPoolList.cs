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

using AccelByte.Sdk.Api.Match2.Model;

namespace AccelByte.Sdk.Api.Match2.Operation
{
    /// <summary>
    /// MatchPoolList
    ///
    /// Required Permission: NAMESPACE:{namespace}:MATCHMAKING:POOL [READ]
    /// 
    /// Required Scope: social
    /// 
    /// List matchmaking pools.
    /// </summary>
    public class MatchPoolList : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static MatchPoolListBuilder Builder { get => new MatchPoolListBuilder(); }

        public class MatchPoolListBuilder
            : OperationBuilder<MatchPoolListBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal MatchPoolListBuilder() { }

            internal MatchPoolListBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public MatchPoolListBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public MatchPoolListBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public MatchPoolList Build(
                string namespace_
            )
            {
                MatchPoolList op = new MatchPoolList(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ApiListMatchPoolsResponse? Execute(
                string namespace_
            )
            {
                MatchPoolList op = Build(
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

        private MatchPoolList(MatchPoolListBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public MatchPoolList(
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

        public override string Path => "/match2/v1/namespaces/{namespace}/match-pools";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ApiListMatchPoolsResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApiListMatchPoolsResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiListMatchPoolsResponse>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
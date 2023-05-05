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

using AccelByte.Sdk.Api.Reporting.Model;

namespace AccelByte.Sdk.Api.Reporting.Operation
{
    /// <summary>
    /// getModerationRules
    ///
    /// 
    /// 
    /// This endpoint get moderation rules.
    /// 
    /// 
    /// 
    /// 
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:RULE [READ]
    /// </summary>
    public class GetModerationRules : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetModerationRulesBuilder Builder { get => new GetModerationRulesBuilder(); }

        public class GetModerationRulesBuilder
            : OperationBuilder<GetModerationRulesBuilder>
        {

            public string? Category { get; set; }

            public string? ExtensionCategory { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal GetModerationRulesBuilder() { }

            internal GetModerationRulesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetModerationRulesBuilder SetCategory(string _category)
            {
                Category = _category;
                return this;
            }

            public GetModerationRulesBuilder SetExtensionCategory(string _extensionCategory)
            {
                ExtensionCategory = _extensionCategory;
                return this;
            }

            public GetModerationRulesBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetModerationRulesBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetModerationRules Build(
                string namespace_
            )
            {
                GetModerationRules op = new GetModerationRules(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.RestapiModerationRulesList? Execute(
                string namespace_
            )
            {
                GetModerationRules op = Build(
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

        private GetModerationRules(GetModerationRulesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Category is not null) QueryParams["category"] = builder.Category;
            if (builder.ExtensionCategory is not null) QueryParams["extensionCategory"] = builder.ExtensionCategory;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetModerationRules(
            string namespace_,            
            string? category,            
            string? extensionCategory,            
            long? limit,            
            long? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (category is not null) QueryParams["category"] = category;
            if (extensionCategory is not null) QueryParams["extensionCategory"] = extensionCategory;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/admin/namespaces/{namespace}/rules";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.RestapiModerationRulesList? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.RestapiModerationRulesList>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RestapiModerationRulesList>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}
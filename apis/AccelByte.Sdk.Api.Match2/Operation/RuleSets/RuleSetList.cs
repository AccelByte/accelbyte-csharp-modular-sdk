// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
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
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Match2.Model;

namespace AccelByte.Sdk.Api.Match2.Operation
{
    /// <summary>
    /// RuleSetList
    ///
    /// List rule sets.
    /// </summary>
    public class RuleSetList : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RuleSetListBuilder Builder { get => new RuleSetListBuilder(); }

        public class RuleSetListBuilder
            : OperationBuilder<RuleSetListBuilder>
        {

            public long? Limit { get; set; }

            public string? Name { get; set; }

            public long? Offset { get; set; }





            internal RuleSetListBuilder() { }

            internal RuleSetListBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public RuleSetListBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public RuleSetListBuilder SetName(string _name)
            {
                Name = _name;
                return this;
            }

            public RuleSetListBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public RuleSetList Build(
                string namespace_
            )
            {
                RuleSetList op = new RuleSetList(this,
                    namespace_
                );

                op.SetBaseFields<RuleSetListBuilder>(this);
                return op;
            }

            public Model.ApiListRuleSetsResponse? Execute(
                string namespace_
            )
            {
                RuleSetList op = Build(
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
            public async Task<Model.ApiListRuleSetsResponse?> ExecuteAsync(
                string namespace_
            )
            {
                RuleSetList op = Build(
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private RuleSetList(RuleSetListBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Name is not null) QueryParams["name"] = builder.Name;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RuleSetList(
            string namespace_,
            long? limit,
            string? name,
            long? offset
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (name is not null) QueryParams["name"] = name;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/namespaces/{namespace}/rulesets";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApiListRuleSetsResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApiListRuleSetsResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiListRuleSetsResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// commit
    ///
    /// This API is used to create a chained operations
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : chain action history
    ///   *  FULFILL_ITEM operation supported item type : INGAMEITEM,LOOTBOX,OPTIONBOX
    /// 
    /// 
    /// 
    /// ## Restrictions for metadata
    /// 
    /// 
    /// 1. Cannot use "." as the key name
    /// -
    /// 
    /// 
    ///     { "data.2": "value" }
    /// 
    /// 
    /// 2. Cannot use "$" as the prefix in key names
    /// -
    /// 
    /// 
    ///     { "$data": "value" }
    /// </summary>
    public class Commit : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CommitBuilder Builder { get => new CommitBuilder(); }

        public class CommitBuilder
            : OperationBuilder<CommitBuilder>
        {





            internal CommitBuilder() { }

            internal CommitBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public Commit Build(
                TradeChainedActionCommitRequest body,
                string namespace_
            )
            {
                Commit op = new Commit(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<CommitBuilder>(this);
                return op;
            }

            public Model.TradeChainActionHistoryInfo? Execute(
                TradeChainedActionCommitRequest body,
                string namespace_
            )
            {
                Commit op = Build(
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
            public async Task<Model.TradeChainActionHistoryInfo?> ExecuteAsync(
                TradeChainedActionCommitRequest body,
                string namespace_
            )
            {
                Commit op = Build(
                    body,
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

            public Model.TradeChainActionHistoryInfo<T1>? Execute<T1>(
                TradeChainedActionCommitRequest body,
                string namespace_
            )
            {
                Commit op = Build(
                    body,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.TradeChainActionHistoryInfo<T1>?> ExecuteAsync<T1>(
                TradeChainedActionCommitRequest body,
                string namespace_
            )
            {
                Commit op = Build(
                    body,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private Commit(CommitBuilder builder,
            TradeChainedActionCommitRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public Commit(
            string namespace_,
            Model.TradeChainedActionCommitRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/trade/commit";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.TradeChainActionHistoryInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.TradeChainActionHistoryInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.TradeChainActionHistoryInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.TradeChainActionHistoryInfo<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.TradeChainActionHistoryInfo<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.TradeChainActionHistoryInfo<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}
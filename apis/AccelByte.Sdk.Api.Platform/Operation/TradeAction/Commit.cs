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

            public Commit.Response Execute(
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
            public async Task<Commit.Response> ExecuteAsync(
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

            public Commit.Response<T1> Execute<T1>(
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
            public async Task<Commit.Response<T1>> ExecuteAsync<T1>(
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

        #region Response Part        
        public class Response : ApiResponse<Model.TradeChainActionHistoryInfo>
        {


            protected override string GetFullOperationId() => "Platform::TradeAction::Commit";
        }

        public class Response<T1> : ApiResponse<Model.TradeChainActionHistoryInfo<T1>>
        {

            protected override string GetFullOperationId() => "Platform::TradeAction::Commit";
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

        public Commit.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new Commit.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.TradeChainActionHistoryInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }

        public Commit.Response<T1> ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new Commit.Response<T1>()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.TradeChainActionHistoryInfo<T1>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}
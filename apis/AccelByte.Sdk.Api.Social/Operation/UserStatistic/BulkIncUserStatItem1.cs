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

using AccelByte.Sdk.Api.Social.Model;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// bulkIncUserStatItem_1
    ///
    /// Bulk update user's statitems value.
    /// Other detail info:
    ///           *  Returns : bulk updated result
    /// </summary>
    public class BulkIncUserStatItem1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkIncUserStatItem1Builder Builder { get => new BulkIncUserStatItem1Builder(); }

        public class BulkIncUserStatItem1Builder
            : OperationBuilder<BulkIncUserStatItem1Builder>
        {


            public List<Model.BulkStatItemInc>? Body { get; set; }




            internal BulkIncUserStatItem1Builder() { }

            internal BulkIncUserStatItem1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public BulkIncUserStatItem1Builder SetBody(List<Model.BulkStatItemInc> _body)
            {
                Body = _body;
                return this;
            }




            public BulkIncUserStatItem1 Build(
                string namespace_,
                string userId
            )
            {
                BulkIncUserStatItem1 op = new BulkIncUserStatItem1(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<BulkIncUserStatItem1Builder>(this);
                return op;
            }

            public List<Model.BulkStatOperationResult>? Execute(
                string namespace_,
                string userId
            )
            {
                BulkIncUserStatItem1 op = Build(
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
            public async Task<List<Model.BulkStatOperationResult>?> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                BulkIncUserStatItem1 op = Build(
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }

            public List<Model.BulkStatOperationResult<T1>>? Execute<T1>(
                string namespace_,
                string userId
            )
            {
                BulkIncUserStatItem1 op = Build(
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<List<Model.BulkStatOperationResult<T1>>?> ExecuteAsync<T1>(
                string namespace_,
                string userId
            )
            {
                BulkIncUserStatItem1 op = Build(
                    namespace_,
                    userId
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

        private BulkIncUserStatItem1(BulkIncUserStatItem1Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public BulkIncUserStatItem1(
            string namespace_,
            string userId,
            List<Model.BulkStatItemInc> body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/users/{userId}/statitems/value/bulk";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.BulkStatOperationResult>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.BulkStatOperationResult>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.BulkStatOperationResult>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public List<Model.BulkStatOperationResult<T1>>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.BulkStatOperationResult<T1>>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.BulkStatOperationResult<T1>>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}
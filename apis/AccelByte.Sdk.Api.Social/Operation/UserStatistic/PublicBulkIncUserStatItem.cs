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
    /// publicBulkIncUserStatItem
    ///
    /// Public bulk update multiple user's statitems value.
    /// Other detail info:
    ///             *  Required permission : resource="NAMESPACE:{namespace}:STATITEM", action=4 (UPDATE)
    ///             *  Returns : bulk updated result
    /// </summary>
    public class PublicBulkIncUserStatItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicBulkIncUserStatItemBuilder Builder { get => new PublicBulkIncUserStatItemBuilder(); }

        public class PublicBulkIncUserStatItemBuilder
            : OperationBuilder<PublicBulkIncUserStatItemBuilder>
        {


            public List<Model.BulkUserStatItemInc>? Body { get; set; }




            internal PublicBulkIncUserStatItemBuilder() { }

            internal PublicBulkIncUserStatItemBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public PublicBulkIncUserStatItemBuilder SetBody(List<Model.BulkUserStatItemInc> _body)
            {
                Body = _body;
                return this;
            }




            public PublicBulkIncUserStatItem Build(
                string namespace_
            )
            {
                PublicBulkIncUserStatItem op = new PublicBulkIncUserStatItem(this,
                    namespace_
                );

                op.SetBaseFields<PublicBulkIncUserStatItemBuilder>(this);
                return op;
            }

            public List<Model.BulkStatOperationResult>? Execute(
                string namespace_
            )
            {
                PublicBulkIncUserStatItem op = Build(
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
            public async Task<List<Model.BulkStatOperationResult>?> ExecuteAsync(
                string namespace_
            )
            {
                PublicBulkIncUserStatItem op = Build(
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

            public List<Model.BulkStatOperationResult<T1>>? Execute<T1>(
                string namespace_
            )
            {
                PublicBulkIncUserStatItem op = Build(
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
            public async Task<List<Model.BulkStatOperationResult<T1>>?> ExecuteAsync<T1>(
                string namespace_
            )
            {
                PublicBulkIncUserStatItem op = Build(
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

        private PublicBulkIncUserStatItem(PublicBulkIncUserStatItemBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicBulkIncUserStatItem(
            string namespace_,
            List<Model.BulkUserStatItemInc> body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/public/namespaces/{namespace}/statitems/value/bulk";

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
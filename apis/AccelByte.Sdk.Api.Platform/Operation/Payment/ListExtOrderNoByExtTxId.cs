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
    /// listExtOrderNoByExtTxId
    ///
    ///  [Not Supported Yet In Starter] List external order No by external transaction id.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:PAYMENT", action=2 (READ)
    ///   *  Returns : payment orders
    /// </summary>
    public class ListExtOrderNoByExtTxId : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListExtOrderNoByExtTxIdBuilder Builder { get => new ListExtOrderNoByExtTxIdBuilder(); }

        public class ListExtOrderNoByExtTxIdBuilder
            : OperationBuilder<ListExtOrderNoByExtTxIdBuilder>
        {





            internal ListExtOrderNoByExtTxIdBuilder() { }

            internal ListExtOrderNoByExtTxIdBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public ListExtOrderNoByExtTxId Build(
                string namespace_,
                string extTxId
            )
            {
                ListExtOrderNoByExtTxId op = new ListExtOrderNoByExtTxId(this,
                    namespace_,
                    extTxId
                );

                op.SetBaseFields<ListExtOrderNoByExtTxIdBuilder>(this);
                return op;
            }

            public List<string>? Execute(
                string namespace_,
                string extTxId
            )
            {
                ListExtOrderNoByExtTxId op = Build(
                    namespace_,
                    extTxId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<List<string>?> ExecuteAsync(
                string namespace_,
                string extTxId
            )
            {
                ListExtOrderNoByExtTxId op = Build(
                    namespace_,
                    extTxId
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

        private ListExtOrderNoByExtTxId(ListExtOrderNoByExtTxIdBuilder builder,
            string namespace_,
            string extTxId
        )
        {
            PathParams["namespace"] = namespace_;

            if (extTxId is not null) QueryParams["extTxId"] = extTxId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ListExtOrderNoByExtTxId(
            string namespace_,
            string extTxId
        )
        {
            PathParams["namespace"] = namespace_;

            if (extTxId is not null) QueryParams["extTxId"] = extTxId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/payment/orders/byExtTxId";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<string>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<string>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<string>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
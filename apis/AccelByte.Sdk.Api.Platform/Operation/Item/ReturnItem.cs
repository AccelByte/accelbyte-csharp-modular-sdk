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
    /// returnItem
    ///
    ///  [SERVICE COMMUNICATION ONLY] This api is used for returning a published item while the item is maxCount limited, it will increase the sale available count if orderNo already acquired.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ITEM", action=4 (UPDATE)
    /// </summary>
    public class ReturnItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ReturnItemBuilder Builder { get => new ReturnItemBuilder(); }

        public class ReturnItemBuilder
            : OperationBuilder<ReturnItemBuilder>
        {


            public Model.ItemReturnRequest? Body { get; set; }




            internal ReturnItemBuilder() { }

            internal ReturnItemBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public ReturnItemBuilder SetBody(Model.ItemReturnRequest _body)
            {
                Body = _body;
                return this;
            }




            public ReturnItem Build(
                string itemId,
                string namespace_
            )
            {
                ReturnItem op = new ReturnItem(this,
                    itemId,
                    namespace_
                );

                op.SetBaseFields<ReturnItemBuilder>(this);
                return op;
            }

            public void Execute(
                string itemId,
                string namespace_
            )
            {
                ReturnItem op = Build(
                    itemId,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task ExecuteAsync(
                string itemId,
                string namespace_
            )
            {
                ReturnItem op = Build(
                    itemId,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private ReturnItem(ReturnItemBuilder builder,
            string itemId,
            string namespace_
        )
        {
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ReturnItem(
            string itemId,
            string namespace_,
            Model.ItemReturnRequest body
        )
        {
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/{itemId}/return";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
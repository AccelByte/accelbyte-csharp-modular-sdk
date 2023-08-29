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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// exportStore_1
    ///
    /// This API is used to export a whole or partial store.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:STORE", action=2 (READ)
    /// </summary>
    public class ExportStore1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ExportStore1Builder Builder { get => new ExportStore1Builder(); }

        public class ExportStore1Builder
            : OperationBuilder<ExportStore1Builder>
        {


            public Model.ExportStoreRequest? Body { get; set; }




            internal ExportStore1Builder() { }

            internal ExportStore1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public ExportStore1Builder SetBody(Model.ExportStoreRequest _body)
            {
                Body = _body;
                return this;
            }




            public ExportStore1 Build(
                string namespace_,
                string storeId
            )
            {
                ExportStore1 op = new ExportStore1(this,
                    namespace_,
                    storeId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Stream? Execute(
                string namespace_,
                string storeId
            )
            {
                ExportStore1 op = Build(
                    namespace_,
                    storeId
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

        private ExportStore1(ExportStore1Builder builder,
            string namespace_,
            string storeId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ExportStore1(
            string namespace_,
            string storeId,
            Model.ExportStoreRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/v2/admin/namespaces/{namespace}/stores/{storeId}/export";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/zip" };

        public Stream? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return payload;
            }
            else if (code == (HttpStatusCode)200)
            {
                return payload;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
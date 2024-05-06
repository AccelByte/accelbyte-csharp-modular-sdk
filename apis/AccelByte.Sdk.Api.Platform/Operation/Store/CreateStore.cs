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
    /// createStore
    ///
    /// This API is used to create a non published store in a namespace.
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : created store data
    /// </summary>
    public class CreateStore : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateStoreBuilder Builder { get => new CreateStoreBuilder(); }

        public class CreateStoreBuilder
            : OperationBuilder<CreateStoreBuilder>
        {


            public Model.StoreCreate? Body { get; set; }




            internal CreateStoreBuilder() { }

            internal CreateStoreBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public CreateStoreBuilder SetBody(Model.StoreCreate _body)
            {
                Body = _body;
                return this;
            }




            public CreateStore Build(
                string namespace_
            )
            {
                CreateStore op = new CreateStore(this,
                    namespace_
                );

                op.SetBaseFields<CreateStoreBuilder>(this);
                return op;
            }

            public Model.StoreInfo? Execute(
                string namespace_
            )
            {
                CreateStore op = Build(
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
            public async Task<Model.StoreInfo?> ExecuteAsync(
                string namespace_
            )
            {
                CreateStore op = Build(
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

        private CreateStore(CreateStoreBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateStore(
            string namespace_,
            Model.StoreCreate body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/stores";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.StoreInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.StoreInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StoreInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
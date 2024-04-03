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

using AccelByte.Sdk.Api.Basic.Model;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// createNamespace
    ///
    /// Create a namespace.
    /// By default the namespace is enabled.
    /// In multi tenant mode, parentNamespace will be automatically filled with requester namespace if the requester is using studio or publisher token, and it will be filled with studio namespace if the requester uses game token. An oauth client will also be created and the id will be returned.
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "ADMIN:NAMESPACE" , action=1 (CREATE)
    ///   *  Action code : 11301
    ///   *  Returns : created namespace
    /// </summary>
    public class CreateNamespace : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateNamespaceBuilder Builder { get => new CreateNamespaceBuilder(); }

        public class CreateNamespaceBuilder
            : OperationBuilder<CreateNamespaceBuilder>
        {


            public Model.NamespaceCreate? Body { get; set; }




            internal CreateNamespaceBuilder() { }

            internal CreateNamespaceBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public CreateNamespaceBuilder SetBody(Model.NamespaceCreate _body)
            {
                Body = _body;
                return this;
            }




            public CreateNamespace Build(
            )
            {
                CreateNamespace op = new CreateNamespace(this
                );

                op.SetBaseFields<CreateNamespaceBuilder>(this);
                return op;
            }

            public Model.NamespaceInfo? Execute(
            )
            {
                CreateNamespace op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.NamespaceInfo?> ExecuteAsync(
            )
            {
                CreateNamespace op = Build(
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

        private CreateNamespace(CreateNamespaceBuilder builder
        )
        {





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateNamespace(
            Model.NamespaceCreate body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/admin/namespaces";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.NamespaceInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.NamespaceInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.NamespaceInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
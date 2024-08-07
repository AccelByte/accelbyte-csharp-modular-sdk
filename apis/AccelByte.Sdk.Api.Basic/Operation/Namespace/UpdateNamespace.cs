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
    /// updateNamespace
    ///
    /// Update namespace basic info.
    /// Other detail info:
    /// 
    ///   * Action code : 11302
    ///   *  Returns : updated namespace
    /// </summary>
    public class UpdateNamespace : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateNamespaceBuilder Builder { get => new UpdateNamespaceBuilder(); }

        public class UpdateNamespaceBuilder
            : OperationBuilder<UpdateNamespaceBuilder>
        {


            public Model.NamespaceUpdate? Body { get; set; }




            internal UpdateNamespaceBuilder() { }

            internal UpdateNamespaceBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdateNamespaceBuilder SetBody(Model.NamespaceUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdateNamespace Build(
                string namespace_
            )
            {
                UpdateNamespace op = new UpdateNamespace(this,
                    namespace_
                );

                op.SetBaseFields<UpdateNamespaceBuilder>(this);
                return op;
            }

            public Model.NamespaceInfo? Execute(
                string namespace_
            )
            {
                UpdateNamespace op = Build(
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
            public async Task<Model.NamespaceInfo?> ExecuteAsync(
                string namespace_
            )
            {
                UpdateNamespace op = Build(
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

        private UpdateNamespace(UpdateNamespaceBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateNamespace(
            string namespace_,
            Model.NamespaceUpdate body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/basic";

        public override HttpMethod Method => HttpMethod.Patch;

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
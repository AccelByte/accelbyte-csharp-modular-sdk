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
    /// deleteNamespace
    ///
    /// Delete a namespace.
    /// Other detail info:
    /// 
    ///   * Action code : 11307
    ///   *  Returns : deleted namespace
    /// </summary>
    public class DeleteNamespace : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteNamespaceBuilder Builder { get => new DeleteNamespaceBuilder(); }

        public class DeleteNamespaceBuilder
            : OperationBuilder<DeleteNamespaceBuilder>
        {





            internal DeleteNamespaceBuilder() { }

            internal DeleteNamespaceBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteNamespace Build(
                string namespace_
            )
            {
                DeleteNamespace op = new DeleteNamespace(this,
                    namespace_
                );

                op.SetBaseFields<DeleteNamespaceBuilder>(this);
                return op;
            }

            public Model.NamespaceInfo? Execute(
                string namespace_
            )
            {
                DeleteNamespace op = Build(
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
                DeleteNamespace op = Build(
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

        private DeleteNamespace(DeleteNamespaceBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteNamespace(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { };

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
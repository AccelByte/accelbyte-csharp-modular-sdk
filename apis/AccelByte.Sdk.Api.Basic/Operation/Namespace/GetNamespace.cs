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

using AccelByte.Sdk.Api.Basic.Model;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// getNamespace
    ///
    /// Get a namespace.
    /// In multi tenant mode, parentNamespace will be returned.
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "ADMIN:NAMESPACE:{namespace}:NAMESPACE" , action=2 (READ)
    ///   *  Action code : 11304
    ///   *  Returns : namespace
    /// </summary>
    public class GetNamespace : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetNamespaceBuilder Builder { get => new GetNamespaceBuilder(); }

        public class GetNamespaceBuilder
            : OperationBuilder<GetNamespaceBuilder>
        {

            public bool? ActiveOnly { get; set; }





            internal GetNamespaceBuilder() { }

            internal GetNamespaceBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetNamespaceBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }





            public GetNamespace Build(
                string namespace_
            )
            {
                GetNamespace op = new GetNamespace(this,
                    namespace_
                );

                op.SetBaseFields<GetNamespaceBuilder>(this);
                return op;
            }

            public Model.NamespaceInfo? Execute(
                string namespace_
            )
            {
                GetNamespace op = Build(
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
        }

        private GetNamespace(GetNamespaceBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetNamespace(
            string namespace_,
            bool? activeOnly
        )
        {
            PathParams["namespace"] = namespace_;

            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}";

        public override HttpMethod Method => HttpMethod.Get;

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
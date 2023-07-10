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
    /// getNamespaces
    ///
    /// Get all namespaces.
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "ADMIN:NAMESPACE" , action=2 (READ)
    ///   *  Action code : 11303
    ///   *  Returns : list of namespaces
    /// </summary>
    public class GetNamespaces : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetNamespacesBuilder Builder { get => new GetNamespacesBuilder(); }

        public class GetNamespacesBuilder
            : OperationBuilder<GetNamespacesBuilder>
        {

            public bool? ActiveOnly { get; set; }





            internal GetNamespacesBuilder() { }

            internal GetNamespacesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetNamespacesBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }





            public GetNamespaces Build(
            )
            {
                GetNamespaces op = new GetNamespaces(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public List<Model.NamespaceInfo>? Execute(
            )
            {
                GetNamespaces op = Build(
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

        private GetNamespaces(GetNamespacesBuilder builder
        )
        {

            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetNamespaces(
            bool? activeOnly
        )
        {

            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/admin/namespaces";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.NamespaceInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.NamespaceInfo>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.NamespaceInfo>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
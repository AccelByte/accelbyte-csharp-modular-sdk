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
    /// publicGetNamespacePublisher
    ///
    /// Get namespace info related publisher namespace.
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "NAMESPACE:{namespace}:NAMESPACE" , action=2 (READ)
    ///   *  Action code : 11305
    ///   *  Returns : Namespace info related publisher namespace
    /// </summary>
    public class PublicGetNamespacePublisher : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetNamespacePublisherBuilder Builder { get => new PublicGetNamespacePublisherBuilder(); }

        public class PublicGetNamespacePublisherBuilder
            : OperationBuilder<PublicGetNamespacePublisherBuilder>
        {





            internal PublicGetNamespacePublisherBuilder() { }

            internal PublicGetNamespacePublisherBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetNamespacePublisher Build(
                string namespace_
            )
            {
                PublicGetNamespacePublisher op = new PublicGetNamespacePublisher(this,
                    namespace_
                );

                op.SetBaseFields<PublicGetNamespacePublisherBuilder>(this);
                return op;
            }

            public Model.NamespacePublisherInfo? Execute(
                string namespace_
            )
            {
                PublicGetNamespacePublisher op = Build(
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

        private PublicGetNamespacePublisher(PublicGetNamespacePublisherBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetNamespacePublisher(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/publisher";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.NamespacePublisherInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.NamespacePublisherInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.NamespacePublisherInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
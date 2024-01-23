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
    /// changeNamespaceStatus
    ///
    /// Change a namespace status.
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "ADMIN:NAMESPACE:{namespace}:NAMESPACE" , action=4 (UPDATE)
    ///   * Action code : 11306
    ///   *  Returns : updated namespace
    /// </summary>
    public class ChangeNamespaceStatus : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ChangeNamespaceStatusBuilder Builder { get => new ChangeNamespaceStatusBuilder(); }

        public class ChangeNamespaceStatusBuilder
            : OperationBuilder<ChangeNamespaceStatusBuilder>
        {


            public Model.NamespaceStatusUpdate? Body { get; set; }




            internal ChangeNamespaceStatusBuilder() { }

            internal ChangeNamespaceStatusBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public ChangeNamespaceStatusBuilder SetBody(Model.NamespaceStatusUpdate _body)
            {
                Body = _body;
                return this;
            }




            public ChangeNamespaceStatus Build(
                string namespace_
            )
            {
                ChangeNamespaceStatus op = new ChangeNamespaceStatus(this,
                    namespace_
                );

                op.SetBaseFields<ChangeNamespaceStatusBuilder>(this);
                return op;
            }

            public Model.NamespaceInfo? Execute(
                string namespace_
            )
            {
                ChangeNamespaceStatus op = Build(
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

        private ChangeNamespaceStatus(ChangeNamespaceStatusBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ChangeNamespaceStatus(
            string namespace_,
            Model.NamespaceStatusUpdate body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/status";

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
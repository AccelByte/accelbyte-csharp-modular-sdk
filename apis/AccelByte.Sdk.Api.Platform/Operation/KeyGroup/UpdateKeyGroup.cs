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
    /// updateKeyGroup
    ///
    /// Update key group.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:KEYGROUP", action=4 (UPDATE)
    ///   *  Returns : updated key group
    /// </summary>
    public class UpdateKeyGroup : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateKeyGroupBuilder Builder { get => new UpdateKeyGroupBuilder(); }

        public class UpdateKeyGroupBuilder
            : OperationBuilder<UpdateKeyGroupBuilder>
        {


            public Model.KeyGroupUpdate? Body { get; set; }




            internal UpdateKeyGroupBuilder() { }

            internal UpdateKeyGroupBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdateKeyGroupBuilder SetBody(Model.KeyGroupUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdateKeyGroup Build(
                string keyGroupId,
                string namespace_
            )
            {
                UpdateKeyGroup op = new UpdateKeyGroup(this,
                    keyGroupId,
                    namespace_
                );

                op.SetBaseFields<UpdateKeyGroupBuilder>(this);
                return op;
            }

            public Model.KeyGroupInfo? Execute(
                string keyGroupId,
                string namespace_
            )
            {
                UpdateKeyGroup op = Build(
                    keyGroupId,
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

        private UpdateKeyGroup(UpdateKeyGroupBuilder builder,
            string keyGroupId,
            string namespace_
        )
        {
            PathParams["keyGroupId"] = keyGroupId;
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateKeyGroup(
            string keyGroupId,
            string namespace_,
            Model.KeyGroupUpdate body
        )
        {
            PathParams["keyGroupId"] = keyGroupId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/keygroups/{keyGroupId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.KeyGroupInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.KeyGroupInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.KeyGroupInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
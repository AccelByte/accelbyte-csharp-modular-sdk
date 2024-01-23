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

using AccelByte.Sdk.Api.Lobby.Model;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// createTemplate
    ///
    /// Create new notification template. Include handlebars {{key}} for replaceable contexts. The the key inside
    /// handlebars will be the key to be replaced when sending notification. Already existing template with the same
    /// slug and language can not be created.
    /// 
    /// Check model description for detailed input restrictions.
    /// </summary>
    public class CreateTemplate : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateTemplateBuilder Builder { get => new CreateTemplateBuilder(); }

        public class CreateTemplateBuilder
            : OperationBuilder<CreateTemplateBuilder>
        {





            internal CreateTemplateBuilder() { }

            internal CreateTemplateBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateTemplate Build(
                ModelCreateTemplateRequest body,
                string namespace_
            )
            {
                CreateTemplate op = new CreateTemplate(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<CreateTemplateBuilder>(this);
                return op;
            }

            public void Execute(
                ModelCreateTemplateRequest body,
                string namespace_
            )
            {
                CreateTemplate op = Build(
                    body,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private CreateTemplate(CreateTemplateBuilder builder,
            ModelCreateTemplateRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateTemplate(
            string namespace_,
            Model.ModelCreateTemplateRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/notification/namespaces/{namespace}/templates";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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

using AccelByte.Sdk.Api.Dsmc.Model;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// CreateImage
    ///
    /// ```
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [CREATE]
    /// Required scope: social
    /// 
    /// This endpoint will create image.
    /// 
    /// Sample image:
    /// {
    /// "namespace":"dewa",
    /// "version":"1.0.0",
    /// "image":"144436415367.dkr.ecr.us-west-2.amazonaws.com/dewa:1.0.0",
    /// "persistent":false
    /// }
    /// ```
    /// </summary>
    public class CreateImage : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateImageBuilder Builder { get => new CreateImageBuilder(); }

        public class CreateImageBuilder
            : OperationBuilder<CreateImageBuilder>
        {





            internal CreateImageBuilder() { }

            internal CreateImageBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateImage Build(
                ModelsCreateImageRequest body
            )
            {
                CreateImage op = new CreateImage(this,
                    body
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                ModelsCreateImageRequest body
            )
            {
                CreateImage op = Build(
                    body
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

        private CreateImage(CreateImageBuilder builder,
            ModelsCreateImageRequest body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateImage(
            Model.ModelsCreateImageRequest body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/images";

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
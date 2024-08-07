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

using AccelByte.Sdk.Api.Dsmc.Model;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// CreateImagePatch
    ///
    /// ```
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [CREATE]
    /// Required scope: social
    /// 
    /// This endpoint will create image patch.
    /// 
    /// Sample image:
    /// {
    /// "namespace":"dewa",
    /// "version":"1.0.0",
    /// "patchVersion":"1.0.0-patch",
    /// "image":"144436415367.dkr.ecr.us-west-2.amazonaws.com/dewa:1.0.0-patch",
    /// "persistent":false
    /// }
    /// ```
    /// </summary>
    public class CreateImagePatch : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateImagePatchBuilder Builder { get => new CreateImagePatchBuilder(); }

        public class CreateImagePatchBuilder
            : OperationBuilder<CreateImagePatchBuilder>
        {





            internal CreateImagePatchBuilder() { }

            internal CreateImagePatchBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateImagePatch Build(
                ModelsCreateImagePatchRequest body
            )
            {
                CreateImagePatch op = new CreateImagePatch(this,
                    body
                );

                op.SetBaseFields<CreateImagePatchBuilder>(this);
                return op;
            }

            public void Execute(
                ModelsCreateImagePatchRequest body
            )
            {
                CreateImagePatch op = Build(
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
            public async Task ExecuteAsync(
                ModelsCreateImagePatchRequest body
            )
            {
                CreateImagePatch op = Build(
                    body
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private CreateImagePatch(CreateImagePatchBuilder builder,
            ModelsCreateImagePatchRequest body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateImagePatch(
            Model.ModelsCreateImagePatchRequest body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/images/patches";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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

using AccelByte.Sdk.Api.Ams.Model;

namespace AccelByte.Sdk.Api.Ams.Operation
{
    /// <summary>
    /// ImageGet
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:ARMADA:ACCOUNT [READ]
    /// </summary>
    public class ImageGet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ImageGetBuilder Builder { get => new ImageGetBuilder(); }

        public class ImageGetBuilder
            : OperationBuilder<ImageGetBuilder>
        {





            internal ImageGetBuilder() { }

            internal ImageGetBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public ImageGet Build(
                string imageID,
                string namespace_
            )
            {
                ImageGet op = new ImageGet(this,
                    imageID,
                    namespace_
                );

                op.SetBaseFields<ImageGetBuilder>(this);
                return op;
            }

            public Model.ApiImageDetails? Execute(
                string imageID,
                string namespace_
            )
            {
                ImageGet op = Build(
                    imageID,
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

        private ImageGet(ImageGetBuilder builder,
            string imageID,
            string namespace_
        )
        {
            PathParams["imageID"] = imageID;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ImageGet(
            string imageID,
            string namespace_
        )
        {
            PathParams["imageID"] = imageID;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/admin/namespaces/{namespace}/images/{imageID}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApiImageDetails? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApiImageDetails>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiImageDetails>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
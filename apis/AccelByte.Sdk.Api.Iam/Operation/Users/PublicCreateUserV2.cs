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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// PublicCreateUserV2
    ///
    /// ## The endpoint is going to be deprecated
    /// **Endpoint migration guide**
    /// - **Substitute endpoint: _/iam/v3/public/namespaces/{namespace}/users [POST]_**
    /// - **Substitute endpoint: _/iam/v4/public/namespaces/{namespace}/users [POST]_**
    /// - **Note:**
    /// 1. v3 & v4 introduce optional verification code
    /// 2. format differenceï¼Pascal case => Camel case)
    /// 
    /// Available Authentication Types:
    /// 1. *EMAILPASSWD*: an authentication type used for new user registration through email.
    /// Country use ISO3166-1 alpha-2 two letter, e.g. US.
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class PublicCreateUserV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicCreateUserV2Builder Builder { get => new PublicCreateUserV2Builder(); }

        public class PublicCreateUserV2Builder
            : OperationBuilder<PublicCreateUserV2Builder>
        {





            internal PublicCreateUserV2Builder() { }

            internal PublicCreateUserV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicCreateUserV2 Build(
                ModelUserCreateRequest body,
                string namespace_
            )
            {
                PublicCreateUserV2 op = new PublicCreateUserV2(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<PublicCreateUserV2Builder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public Model.ModelUserCreateResponse? Execute(
                ModelUserCreateRequest body,
                string namespace_
            )
            {
                PublicCreateUserV2 op = Build(
                    body,
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

        private PublicCreateUserV2(PublicCreateUserV2Builder builder,
            ModelUserCreateRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicCreateUserV2(
            string namespace_,
            Model.ModelUserCreateRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v2/public/namespaces/{namespace}/users";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelUserCreateResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserCreateResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserCreateResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
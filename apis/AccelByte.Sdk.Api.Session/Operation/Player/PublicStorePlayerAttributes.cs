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

using AccelByte.Sdk.Api.Session.Model;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// publicStorePlayerAttributes
    ///
    /// This API behaves to upsert player's attributes.
    /// 
    /// Field descriptions:
    /// - userID : user who owns the attributes.
    /// - crossplayEnabled : set to true if the player wants to enable crossplay to their session (default: false).
    /// - platforms : list of the player's 3rd party platform account information.
    /// - name : platform name. supported platforms: STEAM, XBOX, PSN
    /// - userID : platform userID
    /// - data : other data that the player wants to store.
    /// - PSN_PUSH_CONTEXT_ID: if provided, session will refer to this when performing session sync with PSN, otherwise will populate from session attributes
    /// - currentPlatform : latest user game platform.
    /// - roles : user role for matchmaking role base support.
    /// </summary>
    public class PublicStorePlayerAttributes : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicStorePlayerAttributesBuilder Builder { get => new PublicStorePlayerAttributesBuilder(); }

        public class PublicStorePlayerAttributesBuilder
            : OperationBuilder<PublicStorePlayerAttributesBuilder>
        {





            internal PublicStorePlayerAttributesBuilder() { }

            internal PublicStorePlayerAttributesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicStorePlayerAttributes Build(
                ApimodelsPlayerAttributesRequestBody body,
                string namespace_
            )
            {
                PublicStorePlayerAttributes op = new PublicStorePlayerAttributes(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<PublicStorePlayerAttributesBuilder>(this);
                return op;
            }

            public Model.ApimodelsPlayerAttributesResponseBody? Execute(
                ApimodelsPlayerAttributesRequestBody body,
                string namespace_
            )
            {
                PublicStorePlayerAttributes op = Build(
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

            public Model.ApimodelsPlayerAttributesResponseBody<T1>? Execute<T1>(
                ApimodelsPlayerAttributesRequestBody body,
                string namespace_
            )
            {
                PublicStorePlayerAttributes op = Build(
                    body,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private PublicStorePlayerAttributes(PublicStorePlayerAttributesBuilder builder,
            ApimodelsPlayerAttributesRequestBody body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicStorePlayerAttributes(
            string namespace_,
            Model.ApimodelsPlayerAttributesRequestBody body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/users/me/attributes";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApimodelsPlayerAttributesResponseBody? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsPlayerAttributesResponseBody>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsPlayerAttributesResponseBody>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ApimodelsPlayerAttributesResponseBody<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsPlayerAttributesResponseBody<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsPlayerAttributesResponseBody<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}
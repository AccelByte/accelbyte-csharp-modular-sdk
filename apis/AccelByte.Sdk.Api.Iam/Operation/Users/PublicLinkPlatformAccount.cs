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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// PublicLinkPlatformAccount
    ///
    /// It is going to be **DEPRECATED**.
    /// Update Platform Account relation to current User Account.
    /// 
    /// Note: Game progression data (statistics, reward, etc) associated with previous User Account will not be
    /// transferred. If the data is tight to game user ID, the user will have the game progression data.
    /// 
    /// 
    /// **Authentication:**
    /// The _**userId**_ parameter should match the one in the access token.
    /// </summary>
    public class PublicLinkPlatformAccount : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicLinkPlatformAccountBuilder Builder { get => new PublicLinkPlatformAccountBuilder(); }

        public class PublicLinkPlatformAccountBuilder
            : OperationBuilder<PublicLinkPlatformAccountBuilder>
        {





            internal PublicLinkPlatformAccountBuilder() { }

            internal PublicLinkPlatformAccountBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicLinkPlatformAccount Build(
                ModelLinkPlatformAccountRequest body,
                string namespace_,
                string userId
            )
            {
                PublicLinkPlatformAccount op = new PublicLinkPlatformAccount(this,
                    body,
                    namespace_,
                    userId
                );

                op.SetBaseFields<PublicLinkPlatformAccountBuilder>(this);
                return op;
            }

            public void Execute(
                ModelLinkPlatformAccountRequest body,
                string namespace_,
                string userId
            )
            {
                PublicLinkPlatformAccount op = Build(
                    body,
                    namespace_,
                    userId
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
                ModelLinkPlatformAccountRequest body,
                string namespace_,
                string userId
            )
            {
                PublicLinkPlatformAccount op = Build(
                    body,
                    namespace_,
                    userId
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

        private PublicLinkPlatformAccount(PublicLinkPlatformAccountBuilder builder,
            ModelLinkPlatformAccountRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicLinkPlatformAccount(
            string namespace_,
            string userId,
            Model.ModelLinkPlatformAccountRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/{userId}/platforms/link";

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
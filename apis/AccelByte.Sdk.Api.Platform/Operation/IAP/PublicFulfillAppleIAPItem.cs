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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// publicFulfillAppleIAPItem
    ///
    /// Verify apple iap receipt and fulfill item. don't support subscriptionOther detail info:
    ///   * Returns :
    /// </summary>
    public class PublicFulfillAppleIAPItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicFulfillAppleIAPItemBuilder Builder { get => new PublicFulfillAppleIAPItemBuilder(); }

        public class PublicFulfillAppleIAPItemBuilder
            : OperationBuilder<PublicFulfillAppleIAPItemBuilder>
        {





            internal PublicFulfillAppleIAPItemBuilder() { }

            internal PublicFulfillAppleIAPItemBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicFulfillAppleIAPItem Build(
                AppleIAPReceipt body,
                string namespace_,
                string userId
            )
            {
                PublicFulfillAppleIAPItem op = new PublicFulfillAppleIAPItem(this,
                    body,
                    namespace_,
                    userId
                );

                op.SetBaseFields<PublicFulfillAppleIAPItemBuilder>(this);
                return op;
            }

            public void Execute(
                AppleIAPReceipt body,
                string namespace_,
                string userId
            )
            {
                PublicFulfillAppleIAPItem op = Build(
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
                AppleIAPReceipt body,
                string namespace_,
                string userId
            )
            {
                PublicFulfillAppleIAPItem op = Build(
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

        private PublicFulfillAppleIAPItem(PublicFulfillAppleIAPItemBuilder builder,
            AppleIAPReceipt body,
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

        public PublicFulfillAppleIAPItem(
            string namespace_,
            string userId,
            Model.AppleIAPReceipt body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/iap/apple/receipt";

        public override HttpMethod Method => HttpMethod.Put;

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
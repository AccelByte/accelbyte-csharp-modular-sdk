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
    /// publicDeletePaymentAccount
    ///
    /// Delete payment account.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:PAYMENT:ACCOUNT", action=8 (DELETE)
    ///   *  Returns :
    /// </summary>
    public class PublicDeletePaymentAccount : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicDeletePaymentAccountBuilder Builder { get => new PublicDeletePaymentAccountBuilder(); }

        public class PublicDeletePaymentAccountBuilder
            : OperationBuilder<PublicDeletePaymentAccountBuilder>
        {





            internal PublicDeletePaymentAccountBuilder() { }

            internal PublicDeletePaymentAccountBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicDeletePaymentAccount Build(
                string id,
                string namespace_,
                PublicDeletePaymentAccountType type,
                string userId
            )
            {
                PublicDeletePaymentAccount op = new PublicDeletePaymentAccount(this,
                    id,
                    namespace_,
                    type,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string id,
                string namespace_,
                string type,
                string userId
            )
            {
                PublicDeletePaymentAccount op = Build(
                    id,
                    namespace_,
                    type,
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
        }

        private PublicDeletePaymentAccount(PublicDeletePaymentAccountBuilder builder,
            string id,
            string namespace_,
            PublicDeletePaymentAccountType type,
            string userId
        )
        {
            PathParams["id"] = id;
            PathParams["namespace"] = namespace_;
            PathParams["type"] = type.Value;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicDeletePaymentAccount(
            string id,
            string namespace_,
            PublicDeletePaymentAccountType type,
            string userId
        )
        {
            PathParams["id"] = id;
            PathParams["namespace"] = namespace_;
            PathParams["type"] = type.Value;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/payment/accounts/{type}/{id}";

        public override HttpMethod Method => HttpMethod.Delete;

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

    public class PublicDeletePaymentAccountType : StringEnum<PublicDeletePaymentAccountType>
    {
        public static readonly PublicDeletePaymentAccountType Card
            = new PublicDeletePaymentAccountType("card");

        public static readonly PublicDeletePaymentAccountType Paypal
            = new PublicDeletePaymentAccountType("paypal");


        public static implicit operator PublicDeletePaymentAccountType(string value)
        {
            return NewValue(value);
        }

        public PublicDeletePaymentAccountType(string enumValue)
            : base(enumValue)
        {

        }
    }

}
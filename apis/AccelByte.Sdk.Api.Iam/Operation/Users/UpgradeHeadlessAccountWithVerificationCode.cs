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
    /// UpgradeHeadlessAccountWithVerificationCode
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Endpoint migration guide
    /// 
    /// 
    ///           * Substitute endpoint: /iam/v3/public/namespaces/{namespace}/users/me/headless/code/verify [POST]
    /// 
    /// 
    /// 
    /// 
    /// Required permission 'NAMESPACE:{namespace}:USER:{userId} [UPDATE]'
    /// 
    /// 
    /// The endpoint upgrades a headless account by linking the headless account with the email address and the password. By upgrading the headless account into a full account, the user could use the email address and password for using Justice IAM.
    /// The endpoint is a shortcut for upgrading a headless account and verifying the email address in one call. In order to get a verification code for the endpoint, please check the send verification code endpoint.
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class UpgradeHeadlessAccountWithVerificationCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpgradeHeadlessAccountWithVerificationCodeBuilder Builder { get => new UpgradeHeadlessAccountWithVerificationCodeBuilder(); }

        public class UpgradeHeadlessAccountWithVerificationCodeBuilder
            : OperationBuilder<UpgradeHeadlessAccountWithVerificationCodeBuilder>
        {





            internal UpgradeHeadlessAccountWithVerificationCodeBuilder() { }

            internal UpgradeHeadlessAccountWithVerificationCodeBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpgradeHeadlessAccountWithVerificationCode Build(
                ModelUpgradeHeadlessAccountWithVerificationCodeRequest body,
                string namespace_,
                string userId
            )
            {
                UpgradeHeadlessAccountWithVerificationCode op = new UpgradeHeadlessAccountWithVerificationCode(this,
                    body,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public Model.ModelUserResponse? Execute(
                ModelUpgradeHeadlessAccountWithVerificationCodeRequest body,
                string namespace_,
                string userId
            )
            {
                UpgradeHeadlessAccountWithVerificationCode op = Build(
                    body,
                    namespace_,
                    userId
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

        private UpgradeHeadlessAccountWithVerificationCode(UpgradeHeadlessAccountWithVerificationCodeBuilder builder,
            ModelUpgradeHeadlessAccountWithVerificationCodeRequest body,
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

        public UpgradeHeadlessAccountWithVerificationCode(
            string namespace_,
            string userId,
            Model.ModelUpgradeHeadlessAccountWithVerificationCodeRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/upgradeHeadlessAccountWithVerificationCode";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelUserResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
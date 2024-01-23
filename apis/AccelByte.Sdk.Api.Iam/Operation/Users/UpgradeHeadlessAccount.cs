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
    /// upgradeHeadlessAccount
    ///
    /// ## The endpoint is going to be deprecated
    /// 
    /// ### Endpoint migration guide
    /// - **Substitute endpoint: _/iam/v3/public/namespaces/{namespace}/users/me/headless/verify [POST]_**
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class UpgradeHeadlessAccount : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpgradeHeadlessAccountBuilder Builder { get => new UpgradeHeadlessAccountBuilder(); }

        public class UpgradeHeadlessAccountBuilder
            : OperationBuilder<UpgradeHeadlessAccountBuilder>
        {





            internal UpgradeHeadlessAccountBuilder() { }

            internal UpgradeHeadlessAccountBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpgradeHeadlessAccount Build(
                ModelUpgradeHeadlessAccountRequest body,
                string namespace_,
                string userId
            )
            {
                UpgradeHeadlessAccount op = new UpgradeHeadlessAccount(this,
                    body,
                    namespace_,
                    userId
                );

                op.SetBaseFields<UpgradeHeadlessAccountBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public Model.ModelUserResponse? Execute(
                ModelUpgradeHeadlessAccountRequest body,
                string namespace_,
                string userId
            )
            {
                UpgradeHeadlessAccount op = Build(
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

        private UpgradeHeadlessAccount(UpgradeHeadlessAccountBuilder builder,
            ModelUpgradeHeadlessAccountRequest body,
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

        public UpgradeHeadlessAccount(
            string namespace_,
            string userId,
            Model.ModelUpgradeHeadlessAccountRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/upgradeHeadlessAccount";

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
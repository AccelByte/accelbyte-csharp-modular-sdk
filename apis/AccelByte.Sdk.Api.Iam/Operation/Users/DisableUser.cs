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
    /// DisableUser
    ///
    /// ## The endpoint is going to be deprecated
    /// ### Endpoint migration guide
    /// - **Substitute endpoint: _/iam/v3/admin/namespaces/{namespace}/users/{userId}/status [PATCH]_**
    /// 
    /// For **Deletion Account** purpose fill the reason with:
    /// - **DeactivateAccount** : if your deletion request comes from user
    /// - **AdminDeactivateAccount** : if your deletion request comes from admin
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class DisableUser : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DisableUserBuilder Builder { get => new DisableUserBuilder(); }

        public class DisableUserBuilder
            : OperationBuilder<DisableUserBuilder>
        {





            internal DisableUserBuilder() { }

            internal DisableUserBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DisableUser Build(
                ModelDisableUserRequest body,
                string namespace_,
                string userId
            )
            {
                DisableUser op = new DisableUser(this,
                    body,
                    namespace_,
                    userId
                );

                op.SetBaseFields<DisableUserBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public void Execute(
                ModelDisableUserRequest body,
                string namespace_,
                string userId
            )
            {
                DisableUser op = Build(
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
        }

        private DisableUser(DisableUserBuilder builder,
            ModelDisableUserRequest body,
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

        public DisableUser(
            string namespace_,
            string userId,
            Model.ModelDisableUserRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/disable";

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
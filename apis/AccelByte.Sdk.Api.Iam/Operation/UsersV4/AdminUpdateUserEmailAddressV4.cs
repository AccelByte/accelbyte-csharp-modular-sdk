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
    /// AdminUpdateUserEmailAddressV4
    ///
    /// This is the endpoint for an admin to update a user email address.
    /// This endpoint need a valid user token from an admin to verify its identity (email) before updating a user.
    /// </summary>
    public class AdminUpdateUserEmailAddressV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateUserEmailAddressV4Builder Builder { get => new AdminUpdateUserEmailAddressV4Builder(); }

        public class AdminUpdateUserEmailAddressV4Builder
            : OperationBuilder<AdminUpdateUserEmailAddressV4Builder>
        {





            internal AdminUpdateUserEmailAddressV4Builder() { }

            internal AdminUpdateUserEmailAddressV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpdateUserEmailAddressV4 Build(
                ModelEmailUpdateRequestV4 body,
                string namespace_,
                string userId
            )
            {
                AdminUpdateUserEmailAddressV4 op = new AdminUpdateUserEmailAddressV4(this,
                    body,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AdminUpdateUserEmailAddressV4Builder>(this);
                return op;
            }

            public void Execute(
                ModelEmailUpdateRequestV4 body,
                string namespace_,
                string userId
            )
            {
                AdminUpdateUserEmailAddressV4 op = Build(
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

        private AdminUpdateUserEmailAddressV4(AdminUpdateUserEmailAddressV4Builder builder,
            ModelEmailUpdateRequestV4 body,
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

        public AdminUpdateUserEmailAddressV4(
            string namespace_,
            string userId,
            Model.ModelEmailUpdateRequestV4 body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/namespaces/{namespace}/users/{userId}/email";

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
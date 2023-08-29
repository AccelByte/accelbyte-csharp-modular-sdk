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
    /// GetAdminInvitationV3
    ///
    /// Endpoint to validate user invitation. When not found, it could also means the invitation has expired.
    /// </summary>
    public class GetAdminInvitationV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetAdminInvitationV3Builder Builder { get => new GetAdminInvitationV3Builder(); }

        public class GetAdminInvitationV3Builder
            : OperationBuilder<GetAdminInvitationV3Builder>
        {





            internal GetAdminInvitationV3Builder() { }

            internal GetAdminInvitationV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetAdminInvitationV3 Build(
                string invitationId,
                string namespace_
            )
            {
                GetAdminInvitationV3 op = new GetAdminInvitationV3(this,
                    invitationId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelUserInvitationV3? Execute(
                string invitationId,
                string namespace_
            )
            {
                GetAdminInvitationV3 op = Build(
                    invitationId,
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

        private GetAdminInvitationV3(GetAdminInvitationV3Builder builder,
            string invitationId,
            string namespace_
        )
        {
            PathParams["invitationId"] = invitationId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetAdminInvitationV3(
            string invitationId,
            string namespace_
        )
        {
            PathParams["invitationId"] = invitationId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/invite/{invitationId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelUserInvitationV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserInvitationV3>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserInvitationV3>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
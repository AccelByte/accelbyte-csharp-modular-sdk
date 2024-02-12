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
    /// CreateUserFromInvitationV3
    ///
    /// This endpoint create user from saved roles when creating invitation and submitted data.
    /// User will be able to login after completing submitting the data through this endpoint.
    /// Available Authentication Types:
    /// EMAILPASSWD: an authentication type used for new user registration through email.
    /// 
    /// **Note**:
    /// * **uniqueDisplayName**: this is required when uniqueDisplayNameEnabled/UNIQUE_DISPLAY_NAME_ENABLED is true.
    /// 
    /// Country use ISO3166-1 alpha-2 two letter, e.g. US.
    /// Date of Birth format : YYYY-MM-DD, e.g. 2019-04-29.
    /// </summary>
    public class CreateUserFromInvitationV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateUserFromInvitationV3Builder Builder { get => new CreateUserFromInvitationV3Builder(); }

        public class CreateUserFromInvitationV3Builder
            : OperationBuilder<CreateUserFromInvitationV3Builder>
        {





            internal CreateUserFromInvitationV3Builder() { }

            internal CreateUserFromInvitationV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateUserFromInvitationV3 Build(
                ModelUserCreateRequestV3 body,
                string invitationId,
                string namespace_
            )
            {
                CreateUserFromInvitationV3 op = new CreateUserFromInvitationV3(this,
                    body,
                    invitationId,
                    namespace_
                );

                op.SetBaseFields<CreateUserFromInvitationV3Builder>(this);
                return op;
            }

            public Model.ModelUserCreateResponseV3? Execute(
                ModelUserCreateRequestV3 body,
                string invitationId,
                string namespace_
            )
            {
                CreateUserFromInvitationV3 op = Build(
                    body,
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

        private CreateUserFromInvitationV3(CreateUserFromInvitationV3Builder builder,
            ModelUserCreateRequestV3 body,
            string invitationId,
            string namespace_
        )
        {
            PathParams["invitationId"] = invitationId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateUserFromInvitationV3(
            string invitationId,
            string namespace_,
            Model.ModelUserCreateRequestV3 body
        )
        {
            PathParams["invitationId"] = invitationId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/invite/{invitationId}";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelUserCreateResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserCreateResponseV3>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserCreateResponseV3>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
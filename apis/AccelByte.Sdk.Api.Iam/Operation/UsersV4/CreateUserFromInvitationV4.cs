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
    /// CreateUserFromInvitationV4
    ///
    /// This endpoint create user from saved roles when creating invitation and submitted data.
    /// User will be able to login after completing submitting the data through this endpoint.
    /// Available Authentication Types:
    /// 
    /// EMAILPASSWD: an authentication type used for new user registration through email.
    /// 
    /// Country use ISO3166-1 alpha-2 two letter, e.g. US.
    /// 
    /// Date of Birth format : YYYY-MM-DD, e.g. 2019-04-29.
    /// 
    /// Required attributes:
    /// - authType: possible value is EMAILPASSWD (see above)
    /// - country: ISO3166-1 alpha-2 two letter, e.g. US.
    /// - dateOfBirth: YYYY-MM-DD, e.g. 1990-01-01. valid values are between 1905-01-01 until current date.
    /// - displayName: Please refer to the rule from /v3/public/inputValidations API.
    /// - password: Please refer to the rule from /v3/public/inputValidations API.
    /// - username: Please refer to the rule from /v3/public/inputValidations API.
    /// </summary>
    public class CreateUserFromInvitationV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateUserFromInvitationV4Builder Builder { get => new CreateUserFromInvitationV4Builder(); }

        public class CreateUserFromInvitationV4Builder
            : OperationBuilder<CreateUserFromInvitationV4Builder>
        {





            internal CreateUserFromInvitationV4Builder() { }

            internal CreateUserFromInvitationV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateUserFromInvitationV4 Build(
                ModelUserCreateFromInvitationRequestV4 body,
                string invitationId,
                string namespace_
            )
            {
                CreateUserFromInvitationV4 op = new CreateUserFromInvitationV4(this,
                    body,
                    invitationId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.AccountCreateUserResponseV4? Execute(
                ModelUserCreateFromInvitationRequestV4 body,
                string invitationId,
                string namespace_
            )
            {
                CreateUserFromInvitationV4 op = Build(
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

        private CreateUserFromInvitationV4(CreateUserFromInvitationV4Builder builder,
            ModelUserCreateFromInvitationRequestV4 body,
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

        public CreateUserFromInvitationV4(
            string invitationId,
            string namespace_,
            Model.ModelUserCreateFromInvitationRequestV4 body
        )
        {
            PathParams["invitationId"] = invitationId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/public/namespaces/{namespace}/users/invite/{invitationId}";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.AccountCreateUserResponseV4? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AccountCreateUserResponseV4>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AccountCreateUserResponseV4>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
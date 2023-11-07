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
    /// PublicInviteUserV4
    ///
    /// This endpoint is used to invite a game studio admin user with new namespace in multi tenant mode.
    /// It will return error if the service multi tenant mode is set to false.
    /// 
    /// Request body details:
    /// - emailAddress: email address of the user to be invited
    /// - namespace: new namespace of the user to be created
    /// - namespaceDisplayName: display name of the new namespace
    /// - additionalData(optional): for utm parameter data
    /// 
    /// The invited users will also be assigned with "User" role by default.
    /// </summary>
    public class PublicInviteUserV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicInviteUserV4Builder Builder { get => new PublicInviteUserV4Builder(); }

        public class PublicInviteUserV4Builder
            : OperationBuilder<PublicInviteUserV4Builder>
        {





            internal PublicInviteUserV4Builder() { }

            internal PublicInviteUserV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicInviteUserV4 Build(
                ModelPublicInviteUserRequestV4 body
            )
            {
                PublicInviteUserV4 op = new PublicInviteUserV4(this,
                    body
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelInviteUserResponseV3? Execute(
                ModelPublicInviteUserRequestV4 body
            )
            {
                PublicInviteUserV4 op = Build(
                    body
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

        private PublicInviteUserV4(PublicInviteUserV4Builder builder,
            ModelPublicInviteUserRequestV4 body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicInviteUserV4(
            Model.ModelPublicInviteUserRequestV4 body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/public/users/invite";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelInviteUserResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelInviteUserResponseV3>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelInviteUserResponseV3>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
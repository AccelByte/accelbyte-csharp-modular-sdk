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
    /// AdminTrustlyUpdateUserIdentity
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:IDENTITY [UPDATE]'
    /// 
    /// 
    /// 
    /// 
    /// 
    /// This endpoint ONLY accept Client Token
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is utilized for specific scenarios where email notifications are disabled
    /// 
    /// 
    /// 
    /// 
    /// The user's email will be marked as verified
    /// 
    /// 
    /// 
    /// 
    /// action code : 10103
    /// </summary>
    public class AdminTrustlyUpdateUserIdentity : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminTrustlyUpdateUserIdentityBuilder Builder { get => new AdminTrustlyUpdateUserIdentityBuilder(); }

        public class AdminTrustlyUpdateUserIdentityBuilder
            : OperationBuilder<AdminTrustlyUpdateUserIdentityBuilder>
        {





            internal AdminTrustlyUpdateUserIdentityBuilder() { }

            internal AdminTrustlyUpdateUserIdentityBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminTrustlyUpdateUserIdentity Build(
                ModelUserIdentityUpdateRequestV3 body,
                string namespace_,
                string userId
            )
            {
                AdminTrustlyUpdateUserIdentity op = new AdminTrustlyUpdateUserIdentity(this,
                    body,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                ModelUserIdentityUpdateRequestV3 body,
                string namespace_,
                string userId
            )
            {
                AdminTrustlyUpdateUserIdentity op = Build(
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

        private AdminTrustlyUpdateUserIdentity(AdminTrustlyUpdateUserIdentityBuilder builder,
            ModelUserIdentityUpdateRequestV3 body,
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

        public AdminTrustlyUpdateUserIdentity(
            string namespace_,
            string userId,
            Model.ModelUserIdentityUpdateRequestV3 body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/trustly/identity";

        public override HttpMethod Method => HttpMethod.Patch;

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
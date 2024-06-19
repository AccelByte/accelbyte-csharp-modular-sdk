// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
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
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// PublicSendMyMFAEmailCodeV4
    ///
    /// This endpoint is used to send email code.
    /// ----------------
    /// Supported values of action:
    /// * ChangePassword
    /// * DisableMFAEmail
    /// </summary>
    public class PublicSendMyMFAEmailCodeV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicSendMyMFAEmailCodeV4Builder Builder { get => new PublicSendMyMFAEmailCodeV4Builder(); }

        public class PublicSendMyMFAEmailCodeV4Builder
            : OperationBuilder<PublicSendMyMFAEmailCodeV4Builder>
        {



            public string? Action { get; set; }



            internal PublicSendMyMFAEmailCodeV4Builder() { }

            internal PublicSendMyMFAEmailCodeV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }




            public PublicSendMyMFAEmailCodeV4Builder SetAction(string _action)
            {
                Action = _action;
                return this;
            }



            public PublicSendMyMFAEmailCodeV4 Build(
                string namespace_
            )
            {
                PublicSendMyMFAEmailCodeV4 op = new PublicSendMyMFAEmailCodeV4(this,
                    namespace_
                );

                op.SetBaseFields<PublicSendMyMFAEmailCodeV4Builder>(this);
                return op;
            }

            public void Execute(
                string namespace_
            )
            {
                PublicSendMyMFAEmailCodeV4 op = Build(
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task ExecuteAsync(
                string namespace_
            )
            {
                PublicSendMyMFAEmailCodeV4 op = Build(
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private PublicSendMyMFAEmailCodeV4(PublicSendMyMFAEmailCodeV4Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;


            if (builder.Action is not null) FormParams["action"] = builder.Action;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicSendMyMFAEmailCodeV4(
            string namespace_,
            string? action
        )
        {
            PathParams["namespace"] = namespace_;


            if (action is not null) FormParams["action"] = action;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/public/namespaces/{namespace}/users/me/mfa/email/code";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

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
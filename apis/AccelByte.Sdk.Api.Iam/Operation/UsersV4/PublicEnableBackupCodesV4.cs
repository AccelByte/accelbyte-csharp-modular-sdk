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
    /// PublicEnableBackupCodesV4
    ///
    /// This endpoint is used to enable 2FA backup codes.
    /// </summary>
    public class PublicEnableBackupCodesV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicEnableBackupCodesV4Builder Builder { get => new PublicEnableBackupCodesV4Builder(); }

        public class PublicEnableBackupCodesV4Builder
            : OperationBuilder<PublicEnableBackupCodesV4Builder>
        {





            internal PublicEnableBackupCodesV4Builder() { }

            internal PublicEnableBackupCodesV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicEnableBackupCodesV4 Build(
                string namespace_
            )
            {
                PublicEnableBackupCodesV4 op = new PublicEnableBackupCodesV4(this,
                    namespace_
                );

                op.SetBaseFields<PublicEnableBackupCodesV4Builder>(this);
                return op;
            }

            public void Execute(
                string namespace_
            )
            {
                PublicEnableBackupCodesV4 op = Build(
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
        }

        private PublicEnableBackupCodesV4(PublicEnableBackupCodesV4Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicEnableBackupCodesV4(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/public/namespaces/{namespace}/users/me/mfa/backupCodes/enable";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { };

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
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
    /// AdminEnableBackupCodesV4
    ///
    /// This endpoint is used to enable 2FA backup codes.
    /// </summary>
    public class AdminEnableBackupCodesV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminEnableBackupCodesV4Builder Builder { get => new AdminEnableBackupCodesV4Builder(); }

        public class AdminEnableBackupCodesV4Builder
            : OperationBuilder<AdminEnableBackupCodesV4Builder>
        {





            internal AdminEnableBackupCodesV4Builder() { }

            internal AdminEnableBackupCodesV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminEnableBackupCodesV4 Build(
            )
            {
                AdminEnableBackupCodesV4 op = new AdminEnableBackupCodesV4(this
                );

                op.SetBaseFields<AdminEnableBackupCodesV4Builder>(this);
                return op;
            }

            public void Execute(
            )
            {
                AdminEnableBackupCodesV4 op = Build(
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

        private AdminEnableBackupCodesV4(AdminEnableBackupCodesV4Builder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminEnableBackupCodesV4(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/users/me/mfa/backupCodes/enable";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
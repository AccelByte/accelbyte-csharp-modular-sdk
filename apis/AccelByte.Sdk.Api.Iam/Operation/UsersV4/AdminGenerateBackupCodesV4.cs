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
    /// AdminGenerateBackupCodesV4
    ///
    /// This endpoint is used to generate 8-digits backup codes.
    /// Each code is a one-time code and will be deleted once used.
    /// </summary>
    public class AdminGenerateBackupCodesV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGenerateBackupCodesV4Builder Builder { get => new AdminGenerateBackupCodesV4Builder(); }

        public class AdminGenerateBackupCodesV4Builder
            : OperationBuilder<AdminGenerateBackupCodesV4Builder>
        {





            internal AdminGenerateBackupCodesV4Builder() { }

            internal AdminGenerateBackupCodesV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGenerateBackupCodesV4 Build(
            )
            {
                AdminGenerateBackupCodesV4 op = new AdminGenerateBackupCodesV4(this
                );

                op.SetBaseFields<AdminGenerateBackupCodesV4Builder>(this);
                return op;
            }

            public void Execute(
            )
            {
                AdminGenerateBackupCodesV4 op = Build(
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

        private AdminGenerateBackupCodesV4(AdminGenerateBackupCodesV4Builder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGenerateBackupCodesV4(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/users/me/mfa/backupCodes";

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
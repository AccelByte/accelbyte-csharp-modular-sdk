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
    /// AdminGetMyBackupCodesV4
    ///
    /// 
    /// 
    /// This endpoint is used to get 8-digits backup codes.
    /// Each code is a one-time code and will be deleted once used.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint Requires valid user access token
    /// </summary>
    public class AdminGetMyBackupCodesV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetMyBackupCodesV4Builder Builder { get => new AdminGetMyBackupCodesV4Builder(); }

        public class AdminGetMyBackupCodesV4Builder
            : OperationBuilder<AdminGetMyBackupCodesV4Builder>
        {





            internal AdminGetMyBackupCodesV4Builder() { }

            internal AdminGetMyBackupCodesV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetMyBackupCodesV4 Build(
            )
            {
                AdminGetMyBackupCodesV4 op = new AdminGetMyBackupCodesV4(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelBackupCodesResponseV4? Execute(
            )
            {
                AdminGetMyBackupCodesV4 op = Build(
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

        private AdminGetMyBackupCodesV4(AdminGetMyBackupCodesV4Builder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetMyBackupCodesV4(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/users/me/mfa/backupCode";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelBackupCodesResponseV4? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelBackupCodesResponseV4>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelBackupCodesResponseV4>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
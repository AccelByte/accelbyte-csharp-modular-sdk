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
    /// AdminEnableMyEmailV4
    ///
    /// 
    /// 
    /// This endpoint is used to enable 2FA email.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint Requires valid user access token
    /// </summary>
    public class AdminEnableMyEmailV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminEnableMyEmailV4Builder Builder { get => new AdminEnableMyEmailV4Builder(); }

        public class AdminEnableMyEmailV4Builder
            : OperationBuilder<AdminEnableMyEmailV4Builder>
        {





            internal AdminEnableMyEmailV4Builder() { }

            internal AdminEnableMyEmailV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminEnableMyEmailV4 Build(
                string code
            )
            {
                AdminEnableMyEmailV4 op = new AdminEnableMyEmailV4(this,
                    code
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string code
            )
            {
                AdminEnableMyEmailV4 op = Build(
                    code
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

        private AdminEnableMyEmailV4(AdminEnableMyEmailV4Builder builder,
            string code
        )
        {


            if (code is not null) FormParams["code"] = code;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminEnableMyEmailV4(
            string code
        )
        {


            if (code is not null) FormParams["code"] = code;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/users/me/mfa/email/enable";

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
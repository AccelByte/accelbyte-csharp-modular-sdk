// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;

namespace AccelByte.Sdk.Api.Session.Wrapper
{
    public class Certificate
    {
        private readonly IAccelByteSdk _sdk;

        public Certificate(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public HandleUploadXboxPFXCertificate.HandleUploadXboxPFXCertificateBuilder HandleUploadXboxPFXCertificateOp
        {
            get { return new Operation.HandleUploadXboxPFXCertificate.HandleUploadXboxPFXCertificateBuilder(_sdk); }
        }
        #endregion

        public Model.ModelsPlatformCredentials? HandleUploadXboxPFXCertificate(HandleUploadXboxPFXCertificate input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}
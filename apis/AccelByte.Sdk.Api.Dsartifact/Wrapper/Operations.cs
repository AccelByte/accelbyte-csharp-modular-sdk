// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Dsartifact.Model;
using AccelByte.Sdk.Api.Dsartifact.Operation;

namespace AccelByte.Sdk.Api.Dsartifact.Wrapper
{
    public class Operations
    {
        private readonly IAccelByteSdk _sdk;

        public Operations(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public PublicGetMessages.PublicGetMessagesBuilder PublicGetMessagesOp
        {
            get { return new Operation.PublicGetMessages.PublicGetMessagesBuilder(_sdk); }
        }
        #endregion

        public List<Model.LogAppMessageDeclaration>? PublicGetMessages(PublicGetMessages input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.LogAppMessageDeclaration>?> PublicGetMessagesAsync(PublicGetMessages input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}
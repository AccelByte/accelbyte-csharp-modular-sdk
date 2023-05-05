﻿// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Lobby.Model;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class LobbyTests : BaseServiceTests
    {
        public LobbyTests() : base(true) { }

        [Test]
        public void LobbyAPIServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            #region Send free form notification
            ModelFreeFormNotificationRequest notifBody = new ModelFreeFormNotificationRequest()
            {
                Topic = "csharp_sdk_test",
                Message = "This is integration test for CSharp Server SDK."
            };

            _Sdk.GetLobbyApi().Admin.FreeFormNotificationOp
                .Execute(notifBody, _Sdk.Namespace);
            #endregion
        }
    }
}

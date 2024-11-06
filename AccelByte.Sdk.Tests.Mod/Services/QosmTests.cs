// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Globalization;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Qosm.Model;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ArmadaIntegration")]
    [Explicit]
    public class QosmTests : BaseServiceTests
    {
        public QosmTests() : base(true) { }

        [Test]
        public void ListServerTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            if (IsUsingAGSStarter())
            {
                bool isLogoutOk = _Sdk.Logout();
                if (!isLogoutOk)
                {
                    Assert.Inconclusive("Failed to run in AGS Starter environment.");
                    return;
                }
                bool isLoginOk = _Sdk.LoginClient();
                if (!isLoginOk)
                {
                    Assert.Inconclusive("Failed to run in AGS Starter environment.");
                    return;
                }
                Assert.AreEqual(true, isLoginOk);
                Assert.AreEqual(LoginType.Client, _Sdk.Configuration.TokenRepository.LoginType);
            }

            _ = _Sdk.GetQosmApi().Public.ListServerOp
                .Execute()
                .Ok();
        }

        [Test]
        public void HeartbeatTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            if (IsUsingAGSStarter())
            {
                bool isLogoutOk = _Sdk.Logout();
                if (!isLogoutOk)
                {
                    Assert.Inconclusive("Failed to run in AGS Starter environment.");
                    return;
                }
                bool isLoginOk = _Sdk.LoginClient();
                if (!isLoginOk)
                {
                    Assert.Inconclusive("Failed to run in AGS Starter environment.");
                    return;
                }
                Assert.AreEqual(true, isLoginOk);
                Assert.AreEqual(LoginType.Client, _Sdk.Configuration.TokenRepository.LoginType);
            }

            ModelsListServerResponse listServers = _Sdk.GetQosmApi().Public.ListServerOp
                .Execute()
                .Ok();

            var servers = listServers.Servers!;
            string? respIp = string.Empty;
            string? respRegion = string.Empty;
            int? respPort = 0;

            if (listServers != null && servers.Count > 0)
            {
                var resp = servers[0];
                respIp = resp.Ip;
                respRegion = resp.Region;
                respPort = resp.Port;
            }
            else
            {
                Assert.Ignore("response 'Servers' is empty");
            }

            ModelsHeartbeatRequest createHeartbeat = new ModelsHeartbeatRequest()
            {
                Ip = respIp,
                Region = respRegion,
                Port = respPort,
            };

            _Sdk.GetQosmApi().Server.HeartbeatOp
                .Execute(createHeartbeat)
                .Ok();
        }
    }
}

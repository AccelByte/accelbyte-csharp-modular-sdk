// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class LobbyTests : BaseServiceTests
    {
        public const string LOBBY_PRESENCE_ONLINE = "online";
        public const string LOBBY_PRESENCE_OFFLINE = "offline";

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
                Message = "This is integration test for CSharp Extend SDK."
            };

            _Sdk.GetLobbyApi().Admin.FreeFormNotificationOp
                .Execute(notifBody, _Sdk.Namespace)
                .EnsureSuccess();
            #endregion

            #region Export config
            var exportStream = _Sdk.GetLobbyApi().Config.AdminExportConfigV1Op
                .Execute(_Sdk.Namespace)
                .EnsureSuccess();
            #endregion
            Assert.IsNotNull(exportStream);
        }

        [Test]
        [Ignore("Due to unstable response")]
        public void LobbyConnectAndCheckPresenceTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            DisableRetry();

            int maxCheckRetry = 10;
            int checkRetryCount = 0;

            if (_Sdk.Configuration.Credential == null)
                throw new Exception("Credential object is null. Please use User Login for this test.");

            string currentUserId = _Sdk.Configuration.Credential.UserId;

            LobbyService lobby = new LobbyService(_Sdk.Configuration);
            lobby.RedirectAllReceivedMessagesToMessageReceivedEvent = true;
            lobby.OnMessageReceived = (aMsg) =>
            {
                //dump
            };

            Task connectTak = lobby.Connect(false);
            connectTak.Wait();

            Thread.Sleep(500); //wait 0.5 second to make sure backend has updated status.

            HandlersGetUsersPresenceResponse? userPresence = null;
            while (checkRetryCount < maxCheckRetry)
            {
                userPresence = _Sdk.GetLobbyApi().Presence.UsersPresenceHandlerV1Op
                    .Execute(_Sdk.Namespace, currentUserId)
                    .EnsureSuccess();

                string userStatus = "";
                if ((userPresence.Data != null) && (userPresence.Data.Count > 0))
                    userStatus = userPresence.Data[0].Availability!;
                if (userStatus == LOBBY_PRESENCE_ONLINE)
                    break;

                Thread.Sleep(500);
            }

            if (userPresence != null)
            {
                if ((userPresence.Data != null) && (userPresence.Data.Count > 0))
                {
                    HandlersUserPresence upItem = userPresence.Data[0];
                    Assert.AreEqual(LOBBY_PRESENCE_ONLINE, upItem.Availability);
                }
                else
                    Assert.Fail("No user presence data");
            }

            Task disconnectTask = lobby.Disconnect();
            disconnectTask.Wait();

            Thread.Sleep(500); //wait 0.5 second to make sure backend has updated status.

            userPresence = null;
            checkRetryCount = 0;
            while (checkRetryCount < maxCheckRetry)
            {
                userPresence = _Sdk.GetLobbyApi().Presence.UsersPresenceHandlerV1Op
                    .Execute(_Sdk.Namespace, currentUserId)
                    .EnsureSuccess();

                string userStatus = "";
                if ((userPresence.Data != null) && (userPresence.Data.Count > 0))
                    userStatus = userPresence.Data[0].Availability!;
                if (userStatus == LOBBY_PRESENCE_OFFLINE)
                    break;

                Thread.Sleep(500);
            }

            if (userPresence != null)
            {
                if ((userPresence.Data != null) && (userPresence.Data.Count > 0))
                {
                    HandlersUserPresence upItem = userPresence.Data[0];
                    Assert.AreEqual(LOBBY_PRESENCE_OFFLINE, upItem.Availability);
                }
                else
                    Assert.Fail("No user presence data");
            }

            ResetPolicy();
        }
    }
}

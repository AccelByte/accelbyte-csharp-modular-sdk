// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Sessionbrowser.Model;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class SessionBrowserTests : BaseServiceTests
    {
        public SessionBrowserTests() : base(true) { }

        [Test]
        public void SessionBrowserServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            if (IsUsingAGSStarter())
            {
                Assert.Inconclusive("Test does not apply to AGS Starter environment.");
                return;
            }

            DisableRetry();

            string usernameToTest = "dummy@example.com";
            if (_Sdk.Configuration.Credential != null)
                usernameToTest = _Sdk.Configuration.Credential.Username;
            string session_id = String.Empty;

            #region Create a session
            ModelsCreateSessionRequest createSession = new ModelsCreateSessionRequest()
            {
                SessionType = "dedicated",
                GameVersion = "0.3.0",
                Namespace = _Sdk.Namespace,
                Username = usernameToTest,
                GameSessionSetting = new ModelsGameSessionSetting()
                {
                    Mode = "deathmatch",
                    AllowJoinInProgress = true,
                    MapName = "CSharp SDK Integration Test",
                    MaxPlayer = 100
                }
            };

            ModelsSessionResponse? cResp = _Sdk.GetSessionbrowserApi().Session.CreateSessionOp
                .Execute(createSession, _Sdk.Namespace);
            #endregion
            Assert.IsNotNull(cResp);
            if (cResp != null)
            {
                Assert.AreEqual(usernameToTest, cResp.Username!);
                session_id = cResp.SessionId!;
            }

            #region Get a session
            ModelsSessionResponse? gResp = _Sdk.GetSessionbrowserApi().Session.GetSessionOp
                .Execute(_Sdk.Namespace, session_id);
            #endregion
            Assert.IsNotNull(gResp);
            if (gResp != null)
                Assert.AreEqual("0.3.0", gResp.GameVersion!);

            #region Update a session
            ModelsUpdateSessionRequest updateSession = new ModelsUpdateSessionRequest()
            {
                GameMaxPlayer = 150
            };
            ModelsSessionResponse? uResp = _Sdk.GetSessionbrowserApi().Session.UpdateSessionOp
                .Execute(updateSession, _Sdk.Namespace, session_id);
            #endregion
            Assert.IsNotNull(uResp);
            if (uResp != null)
                Assert.AreEqual(150, uResp.GameSessionSetting!.MaxPlayer!);

            #region Delete a session
            ModelsAdminSessionResponse? dResp = _Sdk.GetSessionbrowserApi().Session.AdminDeleteSessionOp
                .Execute(_Sdk.Namespace, session_id);
            Assert.IsNotNull(dResp);
            #endregion

            ResetPolicy();
        }
    }
}

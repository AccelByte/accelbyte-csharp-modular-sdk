// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Dsmc.Model;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ArmadaIntegration")]
    [Explicit]
    public class DsmcTests : BaseServiceTests
    {
        public DsmcTests() : base(true) { }

        [Test]
        public void DSMCListLocalServerTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            if (IsUsingAGSStarter())
            {
                Assert.Inconclusive("Test does not apply to AGS Starter environment.");
                return;
            }

            _ = _Sdk.GetDsmcApi().Admin.ListLocalServerOp
                .Execute(_Sdk.Namespace)
                .EnsureSuccess();
        }

        [Test]
        [Ignore("temporary disabled")]
        public void DSMCServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            if (IsUsingAGSStarter())
            {
                Assert.Inconclusive("Test does not apply to AGS Starter environment.");
                return;
            }

            string usernameToTest = "dummy@example.com";
            if (_Sdk.Configuration.Credential != null)
                usernameToTest = _Sdk.Configuration.Credential.Username;

            string target_deployment = "default";
            string game_mode = "GAME_MODE";
            string party_id = "PARTY_ID";
            string party_user_id = _Sdk.Configuration.Credential!.UserId;
            string session_id;

            //Create a session
            Api.Sessionbrowser.Model.ModelsCreateSessionRequest createSession = new Api.Sessionbrowser.Model.ModelsCreateSessionRequest()
            {
                SessionType = "p2p",
                GameVersion = "0.3.0",
                Namespace = _Sdk.Namespace,
                Username = usernameToTest,
                GameSessionSetting = new Api.Sessionbrowser.Model.ModelsGameSessionSetting()
                {
                    Mode = game_mode,
                    AllowJoinInProgress = true,
                    MapName = "CSharp SDK Integration Test",
                    MaxPlayer = 100
                }
            };

            Api.Sessionbrowser.Model.ModelsSessionResponse cResp = _Sdk.GetSessionbrowserApi().Session.CreateSessionOp
                .Execute(createSession, _Sdk.Namespace)
                .EnsureSuccess();

            Assert.AreEqual(usernameToTest, cResp.Username!);
            session_id = cResp.SessionId!;

            ModelsCreateSessionRequest sessionRequest = new ModelsCreateSessionRequest()
            {
                ClientVersion = "0.3.0",
                Configuration = "",
                Deployment = target_deployment,
                GameMode = game_mode,
                MatchingAllies = new List<ModelsRequestMatchingAlly>()
                {
                    new ModelsRequestMatchingAlly()
                    {
                        MatchingParties = new List<ModelsRequestMatchParty>()
                        {
                            new ModelsRequestMatchParty()
                            {
                                PartyAttributes = new Dictionary<string, object>(),
                                PartyId = party_id,
                                PartyMembers = new List<ModelsRequestMatchMember>()
                                {
                                    new ModelsRequestMatchMember()
                                    {
                                        UserId = party_user_id
                                    }
                                }
                            }
                        }
                    }
                },
                Region = "",
                PodName = "",
                SessionId = session_id,
                Namespace = _Sdk.Namespace,
            };

            _ = _Sdk.GetDsmcApi().Session.CreateSessionOp
                .Execute(sessionRequest, _Sdk.Namespace)
                .EnsureSuccess();

            _ = _Sdk.GetDsmcApi().Session.GetSessionOp
                .Execute(_Sdk.Namespace, session_id)
                .EnsureSuccess();

            //Waiting for the server to be ready
            Thread.Sleep(5000);

            ModelsClaimSessionRequest claimServer = new ModelsClaimSessionRequest()
            {
                SessionId = session_id
            };
            _Sdk.GetDsmcApi().Session.ClaimServerOp
                .Execute(claimServer, _Sdk.Namespace)
                .EnsureSuccess();

            _Sdk.GetDsmcApi().Admin.DeleteSessionOp
                .Execute(_Sdk.Namespace, session_id)
                .EnsureSuccess();

            _ = _Sdk.GetSessionbrowserApi().Session.DeleteSessionOp
                .Execute(_Sdk.Namespace, session_id)
                .EnsureSuccess();

            Assert.True(true);
        }
    }
}

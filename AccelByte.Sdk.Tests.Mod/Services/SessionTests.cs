// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Linq;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Session.Model;

using AccelByte.Sdk.Tests.Mod.Scenario;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class SessionTests : BaseServiceTests
    {
        private ITestPlayer? _Player1 = null;

        private ITestPlayer? _Player2 = null;

        public SessionTests() : base(false) { }

        protected override void OnStartup(IAccelByteSdk sdk)
        {
            DisableRetry();

            _Player1 = new NewTestPlayer(sdk, true);
            _Player2 = new NewTestPlayer(sdk, true);

            ResetPolicy();
        }

        protected override void OnBeforeEnd()
        {
            _Player1?.Logout();
            _Player2?.Logout();
        }

        [Test]
        public void ConfigurationTemplateTests()
        {
            if (IsUsingAGSStarter())
            {
                Assert.Inconclusive("Temporarily disabled in AGS Starter due to issue in session service.");
                return;
            }

            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;
            Random random = new Random();

            DisableRetry();

            string cfgTemplateName = $"csharp_sdk_template_{random.GenerateRandomId(4)}";

            #region Create session configuration template
            ApimodelsCreateConfigurationTemplateRequest cTemplateBody = new ApimodelsCreateConfigurationTemplateRequest()
            {
                Name = cfgTemplateName,
                Type = "P2P",
                MinPlayers = 2,
                MaxPlayers = 2,
                InviteTimeout = 60,
                InactiveTimeout = 60,
                Joinability = "OPEN",
                ClientVersion = "1.0.0",
                RequestedRegions = new List<string>()
                {
                    "us-west-2"
                }
            };

            _Sdk.GetSessionApi().ConfigurationTemplate.AdminCreateConfigurationTemplateV1Op
                .Execute(cTemplateBody, _Sdk.Namespace)
                .EnsureSuccess();

            ApimodelsConfigurationTemplateResponse cfgTemplate = _Sdk.GetSessionApi().ConfigurationTemplate.AdminGetConfigurationTemplateV1Op
                .Execute(cfgTemplateName, _Sdk.Namespace)
                .EnsureSuccess();
            #endregion
            Assert.AreEqual("P2P", cfgTemplate.Type!);
            Assert.AreEqual("OPEN", cfgTemplate.Joinability!);
            Assert.AreEqual(2, cfgTemplate.MaxPlayers!);

            #region Update session configuration template
            ApimodelsUpdateConfigurationTemplateRequest uTemplateBody = new ApimodelsUpdateConfigurationTemplateRequest()
            {
                Name = cfgTemplateName,
                Type = "P2P",
                Joinability = "OPEN",
                MaxPlayers = 4
            };

            ApimodelsConfigurationTemplateResponse uptTemplate = _Sdk.GetSessionApi().ConfigurationTemplate.AdminUpdateConfigurationTemplateV1Op
                .Execute(uTemplateBody, cfgTemplateName, _Sdk.Namespace)
                .EnsureSuccess();
            #endregion
            Assert.AreEqual(4, uptTemplate.MaxPlayers!);

            #region Delete session configuration template
            _Sdk.GetSessionApi().ConfigurationTemplate.AdminDeleteConfigurationTemplateV1Op
                .Execute(cfgTemplateName, _Sdk.Namespace)
                .EnsureSuccess();
            #endregion

            ResetPolicy();
        }

        [Test]
        public void GameSessionTests()
        {
            if (IsUsingAGSStarter())
            {
                Assert.Inconclusive("Temporarily disabled in AGS Starter due to issue in session service.");
                return;
            }

            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            Assert.IsNotNull(_Player1);
            if (_Player1 == null)
                return;

            Assert.IsNotNull(_Player2);
            if (_Player2 == null)
                return;

            Random random = new Random();
            DisableRetry();

            string cfgTemplateName = $"csharp_sdk_template_{random.GenerateRandomId(4)}";
            _Sdk.GetSessionApi().ConfigurationTemplate.AdminCreateConfigurationTemplateV1Op
                .Execute(new()
                {
                    Name = cfgTemplateName,
                    Type = "P2P",
                    MinPlayers = 2,
                    MaxPlayers = 2,
                    InviteTimeout = 60,
                    InactiveTimeout = 60,
                    Joinability = "OPEN",
                    ClientVersion = "1.0.0",
                    RequestedRegions = new List<string>()
                    {
                        "us-west-2"
                    }
                }, _Sdk.Namespace);

            string gameSessionId = String.Empty;
            _Player1.Run((sdk, player) =>
            {
                #region Create a game session
                ApimodelsCreateGameSessionRequest newGSRequest = new ApimodelsCreateGameSessionRequest()
                {
                    ConfigurationName = cfgTemplateName,
                };

                ApimodelsGameSessionResponse newGSResponse = sdk.GetSessionApi().GameSession.CreateGameSessionOp
                    .Execute(newGSRequest, sdk.Namespace)
                    .EnsureSuccess();
                #endregion
                gameSessionId = newGSResponse.Id!;
            });

            Wait();

            if (gameSessionId == String.Empty)
                Assert.Fail("No game session id");

            _Player2.Run((sdk, player) =>
            {
                #region Join a game session
                ApimodelsGameSessionResponse p2GsJoin = sdk.GetSessionApi().GameSession.JoinGameSessionOp
                    .Execute(sdk.Namespace, gameSessionId)
                    .EnsureSuccess();
                #endregion
                Assert.IsNotNull(p2GsJoin);
            });

            Wait();

            ApimodelsGameSessionResponse gsCheck = _Sdk.GetSessionApi().GameSession.GetGameSessionOp
                .Execute(_Sdk.Namespace, gameSessionId)
                .EnsureSuccess();
            Assert.AreEqual(2, gsCheck.Members!.Count);
            List<string> userIds = gsCheck.Members!.Select(item => item.Id!).ToList();
            Assert.Contains(_Player1.UserId, userIds);
            Assert.Contains(_Player2.UserId, userIds);

            _Player2.Run((sdk, player) =>
            {
                #region Leave a game session
                sdk.GetSessionApi().GameSession.LeaveGameSessionOp
                    .Execute(sdk.Namespace, gameSessionId)
                    .EnsureSuccess();
                #endregion
            });

            _Player1.Run((sdk, player) =>
            {
                #region Delete a game session
                sdk.GetSessionApi().GameSession.DeleteGameSessionOp
                    .Execute(sdk.Namespace, gameSessionId)
                    .EnsureSuccess();
                #endregion
            });

            // Create another new game session
            string newGameSessionId = "";
            _Player1.Run((sdk, player) =>
            {
                var newGSResponse = sdk.GetSessionApi().GameSession.CreateGameSessionOp
                    .Execute(new ApimodelsCreateGameSessionRequest()
                    {
                        ConfigurationName = cfgTemplateName,
                    }, sdk.Namespace)
                    .EnsureSuccess();
                Assert.IsNotNull(newGSResponse);
                if (newGSResponse != null)
                    newGameSessionId = newGSResponse.Id!;
            });

            #region Admin delete bulk game session
            var deleteResponse = _Sdk.GetSessionApi().GameSession.AdminDeleteBulkGameSessionsOp
                .Execute(new ApimodelsDeleteBulkGameSessionRequest()
                {
                    Ids = [newGameSessionId]
                }, _Sdk.Namespace)
                .EnsureSuccess();
            #endregion
            Assert.IsNotNull(deleteResponse);

            _Sdk.GetSessionApi().ConfigurationTemplate.AdminDeleteConfigurationTemplateV1Op
                .Execute(cfgTemplateName, _Sdk.Namespace)
                .EnsureSuccess();

            ResetPolicy();
        }

        [Test]
        public void QueryGameSessions()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            #region Query game sessions
            var response = _Sdk.GetSessionApi().GameSession.PublicQueryGameSessionsByAttributesOp
                .Execute(new Dictionary<string, object>() { }, _Sdk.Namespace)
                .EnsureSuccess();
            #endregion
            Assert.IsNotNull(response);
        }

        [Test]
        public void PartyTests()
        {
            if (IsUsingAGSStarter())
            {
                Assert.Inconclusive("Temporarily disabled in AGS Starter due to issue in session service.");
                return;
            }

            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            Assert.IsNotNull(_Player1);
            if (_Player1 == null)
                return;

            Assert.IsNotNull(_Player2);
            if (_Player2 == null)
                return;

            Random random = new Random();
            DisableRetry();

            string cfgTemplateName = $"csharp_sdk_template_{random.GenerateRandomId(4)}";
            _Sdk.GetSessionApi().ConfigurationTemplate.AdminCreateConfigurationTemplateV1Op
                .Execute(new()
                {
                    Name = cfgTemplateName,
                    Type = "P2P",
                    MinPlayers = 2,
                    MaxPlayers = 2,
                    InviteTimeout = 60,
                    InactiveTimeout = 60,
                    Joinability = "OPEN",
                    ClientVersion = "1.0.0",
                    RequestedRegions = new List<string>()
                    {
                        "us-west-2"
                    }
                }, _Sdk.Namespace);

            string partyId = String.Empty;
            string joinCode = String.Empty;

            Wait();

            _Player1.Run((sdk, player) =>
            {
                #region User create a party
                ApimodelsCreatePartyRequest partyRequest = new ApimodelsCreatePartyRequest()
                {
                    ConfigurationName = cfgTemplateName,
                    Members = new List<ApimodelsRequestMember>()
                    {
                        new ApimodelsRequestMember()
                        {
                            ID = player.UserId
                        }
                    }
                };

                ApimodelsPartySessionResponse partyResponse = sdk.GetSessionApi().Party.PublicCreatePartyOp
                    .Execute(partyRequest, sdk.Namespace)
                    .EnsureSuccess();
                #endregion
                partyId = partyResponse.Id!;
                joinCode = partyResponse.Code!;
            });

            Wait();

            if (partyId == String.Empty)
                Assert.Fail("No party id");
            if (joinCode == String.Empty)
                Assert.Fail("No join code");

            _Player2.Run((sdk, player) =>
            {
                #region User join a party with code
                ApimodelsJoinByCodeRequest joinRequest = new ApimodelsJoinByCodeRequest()
                {
                    Code = joinCode
                };

                ApimodelsPartySessionResponse joinResponse = sdk.GetSessionApi().Party.PublicPartyJoinCodeOp
                    .Execute(joinRequest, sdk.Namespace)
                    .EnsureSuccess();
                #endregion
                Assert.IsNotNull(joinResponse);
            });

            Wait();

            #region Get party detail
            ApimodelsPartySessionResponse partyData = _Sdk.GetSessionApi().Party.PublicGetPartyOp
                .Execute(_Sdk.Namespace, partyId)
                .EnsureSuccess();
            #endregion
            
            Assert.AreEqual(2, partyData.Members!.Count);
            List<string> userIds = partyData.Members!.Select(item => item.Id!).ToList();
            Assert.Contains(_Player1.UserId, userIds);
            Assert.Contains(_Player2.UserId, userIds);

            #region Admin query parties
            var adminPartyData = _Sdk.GetSessionApi().Party.AdminQueryPartiesOp
                .SetOffset(0)
                .SetLimit(10)
                .Execute(_Sdk.Namespace)
                .EnsureSuccess();
            #endregion
            Assert.IsNotNull(adminPartyData);

            _Player2.Run((sdk, player) =>
            {
                #region User leave a party
                sdk.GetSessionApi().Party.PublicPartyLeaveOp
                    .Execute(sdk.Namespace, partyId)
                    .EnsureSuccess();
                #endregion
            });

            Wait();

            ApimodelsPartySessionResponse uPartyData = _Sdk.GetSessionApi().Party.PublicGetPartyOp
                .Execute(_Sdk.Namespace, partyId)
                .EnsureSuccess();

            Assert.AreEqual(2, uPartyData.Members!.Count);

            //Get id of members who are still in party.
            userIds = uPartyData.Members!
                .Where(item => item.Status! != "LEFT")
                .Select(item => item.Id!).ToList();

            Assert.Contains(_Player1.UserId, userIds);
            Assert.That(userIds, Has.No.Member(_Player2.UserId));

            _Sdk.GetSessionApi().ConfigurationTemplate.AdminDeleteConfigurationTemplateV1Op
                .Execute(cfgTemplateName, _Sdk.Namespace)
                .EnsureSuccess();

            ResetPolicy();
        }
    }
}
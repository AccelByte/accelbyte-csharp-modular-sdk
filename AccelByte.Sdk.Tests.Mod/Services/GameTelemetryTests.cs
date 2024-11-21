// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Gametelemetry.Model;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class GameTelemetryTests : BaseServiceTests
    {
        public GameTelemetryTests() : base(true) { }

        [Test]
        public void GametelemetryServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string steamId = "76561199259217491";
            string playTime = "4";

            #region Save game telemetry event
            _Sdk.GetGametelemetryApi().GametelemetryOperations.ProtectedSaveEventsGameTelemetryV1ProtectedEventsPostOp
                .Execute(new List<TelemetryBody>
                {
                    new TelemetryBody
                    {
                        EventName = "CsharpEvent",
                        EventNamespace = "test",
                        Payload = new Dictionary<string, object>
                        {
                            {"foo", "bar"}
                        }
                    }
                })
                .EnsureSuccess();
            #endregion

            DisableRetry();
            #region Update steam's playtime
            try
            {
                _Sdk.GetGametelemetryApi().GametelemetryOperations.ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePutOp
                    .Execute(playTime, steamId)
                    .EnsureSuccess();
            }
            catch (Exception e)
            {
                if (e.Message.ToLower().Contains("user not found"))
                {
                    Assert.Ignore("User not found.");
                }
            }
            #endregion

            #region Get steam's playtime
            PlayTimeResponse resGet = _Sdk.GetGametelemetryApi().GametelemetryOperations
                .ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGetOp
                .Execute(steamId)
                .EnsureSuccess();
            #endregion
            Assert.Equals(playTime, resGet.TotalPlaytime!);
        }
    }
}

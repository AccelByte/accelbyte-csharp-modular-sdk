// Copyright (c) 2022-2026 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Api;

using AccelByte.Sdk.Api.Gametelemetry.Model;
using AccelByte.Sdk.Tests.Mod.Repository;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class GameTelemetryTests : BaseServiceTests
    {
        public GameTelemetryTests() : base(true, IntegrationTestConfigRepository.Admin) { }

        [Test]
        public void GametelemetryServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            if (IsUsingAGSStarter())
            {
                Assert.Inconclusive("Test does not apply to AGS Starter environment.");
                return;
            }

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
        }
    }
}

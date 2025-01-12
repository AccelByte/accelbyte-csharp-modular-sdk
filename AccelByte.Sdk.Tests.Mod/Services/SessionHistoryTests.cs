﻿// Copyright (c) 2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class SessionHistoryTests : BaseServiceTests
    {
        public SessionHistoryTests() : base(false) { }

        [Test]
        public void GameSessionTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            DisableRetry();

            #region Get all game sessions history
            var response = _Sdk.GetSessionhistoryApi().GameSessionDetail.AdminQueryGameSessionDetailOp
                .SetOffset(0)
                .SetLimit(20)
                .Execute(_Sdk.Namespace)
                .EnsureSuccess();
            #endregion
            if (response.Data != null)
                Assert.GreaterOrEqual(response.Data.Count, 0);

            #region Get all matchmaking history
            var mResponse = _Sdk.GetSessionhistoryApi().GameSessionDetail.AdminQueryMatchmakingDetailOp
                .SetOffset(0)
                .SetLimit(20)
                .Execute(_Sdk.Namespace)
                .EnsureSuccess();
            #endregion
            if (mResponse.Data != null)
                Assert.GreaterOrEqual(mResponse.Data.Count, 0);

            #region Query party details
            var partyDetails = _Sdk.GetSessionhistoryApi().GameSessionDetail.AdminQueryPartyDetailOp
                .SetOffset(0)
                .SetLimit(50)
                .Execute(_Sdk.Namespace)
                .EnsureSuccess();
            #endregion
            Assert.IsNotNull(partyDetails);

            string startDate = DateTime.Now.AddDays(-2).ToString("u").Replace(" ", "T");
            string endDate = DateTime.Now.ToString("u").Replace(" ", "T");

            #region Query total matchmaking match
            var mmData = _Sdk.GetSessionhistoryApi().XRay.QueryTotalMatchmakingMatchOp
                .Execute(_Sdk.Namespace, endDate, startDate)
                .EnsureSuccess();
            #endregion
            Assert.IsNotNull(mmData);

            ResetPolicy();
        }
    }
}

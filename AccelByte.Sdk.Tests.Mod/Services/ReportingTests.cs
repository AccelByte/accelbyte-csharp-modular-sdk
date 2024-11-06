// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Reporting.Model;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class ReportingTests : BaseServiceTests
    {
        public ReportingTests() : base(true) { }

        [Test]
        public void ReportingServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            if (IsUsingAGSStarter())
            {
                Assert.Inconclusive("Test does not apply to AGS Starter environment.");
                return;
            }

            Random random = new Random();
            string title = random.GenerateRandomId(32);
            string reasonId = "";

            Api.Reporting.Wrapper.AdminReasons wAdminReasons = new Api.Reporting.Wrapper.AdminReasons(_Sdk);

            #region Create a Reason
            RestapiCreateReasonRequest createReason = new RestapiCreateReasonRequest()
            {
                Description = title,
                GroupIds = new List<string>(),
                Title = title,
            };

            RestapiAdminReasonResponse cReason = _Sdk.GetReportingApi().AdminReasons.CreateReasonOp
                .Execute(createReason, _Sdk.Namespace)
                .Ok();
            #endregion

            Assert.IsNotNull(cReason.Id);
            if (cReason.Id != null)
                reasonId = cReason.Id;

            Assert.AreEqual(title, cReason.Title);
            Assert.True(reasonId != String.Empty);

            #region Get single Reason
            RestapiAdminReasonResponse cReason2 = _Sdk.GetReportingApi().AdminReasons.AdminGetReasonOp
                .Execute(_Sdk.Namespace, reasonId)
                .Ok();
            #endregion
            Assert.IsNotNull(cReason2.Id);
            Assert.AreEqual(title, cReason2.Title);

            #region Delete a Reporting
            _Sdk.GetReportingApi().AdminReasons.DeleteReasonOp
                .Execute(_Sdk.Namespace, reasonId)
                .Ok();
            #endregion

            //Finally, recheck if the data is truly deleted.
            Exception? hrx = Assert.Throws<Exception>(() =>
            {
                DisableRetry();
                _ = _Sdk.GetReportingApi().AdminReasons.AdminGetReasonOp
                    .Execute(_Sdk.Namespace, reasonId)
                    .Ok();
            });
        }
    }
}

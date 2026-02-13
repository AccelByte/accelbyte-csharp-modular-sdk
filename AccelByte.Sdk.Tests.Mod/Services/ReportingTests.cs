// Copyright (c) 2022-2026 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Reporting.Model;
using AccelByte.Sdk.Tests.Mod.Scenario;
using AccelByte.Sdk.Tests.Mod.Repository;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class ReportingTests : BaseServiceTests
    {
        public ReportingTests() : base(true, IntegrationTestConfigRepository.Reporting) { }

        [Test]
        public void ReportingServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            Random random = new Random();

            string reasonTitle = random.GenerateRandomId(32);
            string reasonId = "";

            Api.Reporting.Wrapper.AdminReasons wAdminReasons = new Api.Reporting.Wrapper.AdminReasons(_Sdk);

            #region Create a Reason
            RestapiCreateReasonRequest createReason = new RestapiCreateReasonRequest()
            {
                Description = reasonTitle,
                GroupIds = new List<string>(),
                Title = reasonTitle,
            };

            RestapiAdminReasonResponse cReason = _Sdk.GetReportingApi().AdminReasons.CreateReasonOp
                .Execute(createReason, _Sdk.Namespace)
                .EnsureSuccess();
            #endregion

            Assert.IsNotNull(cReason.Id);
            if (cReason.Id != null)
                reasonId = cReason.Id;

            Assert.AreEqual(reasonTitle, cReason.Title);
            Assert.True(reasonId != String.Empty);

            #region Get single Reason
            RestapiAdminReasonResponse cReason2 = _Sdk.GetReportingApi().AdminReasons.AdminGetReasonOp
                .Execute(_Sdk.Namespace, reasonId)
                .EnsureSuccess();
            #endregion
            Assert.IsNotNull(cReason2.Id);
            Assert.AreEqual(reasonTitle, cReason2.Title);

            ITestPlayer player1 = new NewTestPlayer(_Sdk, true);
            try
            {
                #region Submit report
                var reportResponse = _Sdk.GetReportingApi().PublicReports.SubmitReportOp
                .Execute(new RestapiSubmitReportRequest()
                {
                    UserId = player1.UserId,
                    Category = RestapiSubmitReportRequestCategory.UGC,
                    Reason = reasonTitle,
                    AdditionalInfo = [],
                    Comment = reasonTitle,
                    ExtensionCategory = "UGC",
                    ObjectId = Guid.NewGuid().ToString().Replace("-", ""),
                    ObjectType = "file"
                }, _Sdk.Namespace);
                #endregion
                Assert.IsNotNull(reportResponse);
            }
            finally
            {
                player1.Logout();
            }

            #region Delete a reason
            _Sdk.GetReportingApi().AdminReasons.DeleteReasonOp
                .Execute(_Sdk.Namespace, reasonId)
                .EnsureSuccess();
            #endregion

            //Finally, recheck if the data is truly deleted.
            ApiResponseException? hrx = Assert.Throws<ApiResponseException>(() =>
            {
                DisableRetry();
                _ = _Sdk.GetReportingApi().AdminReasons.AdminGetReasonOp
                    .Execute(_Sdk.Namespace, reasonId)
                    .EnsureSuccess();
            });
        }
    }
}

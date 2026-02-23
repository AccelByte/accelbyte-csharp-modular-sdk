// Copyright (c) 2022-2026 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Reporting.Model;

using AccelByte.Sdk.Tests.Model;

namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
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

            string title = Helper.GenerateRandomId(32);
            string reasonId = "";

            Api.Reporting.Wrapper.AdminReasons wAdminReasons = new Api.Reporting.Wrapper.AdminReasons(_Sdk);

            #region Create a Reason
            RestapiCreateReasonRequest createReason = new RestapiCreateReasonRequest()
            {
                Description = title,
                GroupIds = new List<string>(),
                Title = title,
            };

            var cReason = _Sdk.Reporting.AdminReasons.CreateReasonOp
                .Execute(createReason, _Sdk.Namespace);
            Assert.IsNotNull(cReason);
            if (cReason != null)
            {
                Assert.IsNotNull(cReason.Id);
                if (cReason.Id != null)
                    reasonId = cReason.Id;

                Assert.AreEqual(title, cReason.Title);
            }
            #endregion

            Assert.True(reasonId != "");

            #region Get single Reason
            var cReason2 = _Sdk.Reporting.AdminReasons.AdminGetReasonOp
                    .Execute(_Sdk.Namespace, reasonId);
            Assert.IsNotNull(cReason2);
            if (cReason2 != null)
            {
                Assert.IsNotNull(cReason2.Id);
                Assert.AreEqual(title, cReason2.Title);
            }
            #endregion

            #region Delete a Reporting
            _Sdk.Reporting.AdminReasons.DeleteReasonOp
                .Execute(_Sdk.Namespace, reasonId);
            #endregion

            //Finally, recheck if the data is truly deleted.
            HttpResponseException? hrx = Assert.Throws<HttpResponseException>(() =>
            {
                DisableRetry();
                var cReason3 = _Sdk.Reporting.AdminReasons.AdminGetReasonOp
                    .Execute(_Sdk.Namespace, reasonId);
            });
        }
    }
}

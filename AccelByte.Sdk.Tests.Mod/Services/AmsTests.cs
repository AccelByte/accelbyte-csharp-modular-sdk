// Copyright (c) 2023-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core.Net.Http;
using AccelByte.Sdk.Api.Ams.Model;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class AmsTests : BaseServiceTests
    {
        public AmsTests() : base(false) { }

        [Test]
        public void InfoTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            DisableRetry();

            ApiAMSRegionsResponse regions = _Sdk.GetAmsApi().AMSInfo.InfoRegionsOp
                .Execute(_Sdk.Namespace).EnsureSuccess();
            Assert.GreaterOrEqual(regions!.Regions!.Count, 1);            

            ResetPolicy();
        }

        [Test]
        [Ignore("Need to upload image before creating a fleet.")]
        public void FleetTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string fleetName = "CSharpSdkFleet";
            string fleetNameUpdate = "CSharpSdkFleetUpdate";
            string fleetId = "";

            DisableRetry();

            // get readily available instance type
            var instances = _Sdk.GetAmsApi().AMSInfo.InfoSupportedInstancesOp
                .Execute(_Sdk.Namespace)
                .EnsureSuccess();            
            string instanceId = "";
            if (instances != null && instances.AvailableInstanceTypes != null && instances.AvailableInstanceTypes.Count > 0)
                instanceId = instances.AvailableInstanceTypes[0].Id!;

            // get readily available images
            #region Get images
            var imageList = _Sdk.GetAmsApi().Images.ImageListOp
                .Execute(_Sdk.Namespace)
                .EnsureSuccess();
            #endregion
            Assert.IsNotNull(imageList);

            string imageId = "";
            if (imageList != null && imageList.Images != null && imageList.Images.Count > 0)
                imageId = imageList.Images[0].Id!;

            #region Create new fleet
            var newFleet = _Sdk.GetAmsApi().Fleets.FleetCreateOp
                .Execute(new ApiFleetParameters()
                {
                    Active = false,
                    Name = fleetName,
                    ClaimKeys = ["beta"],
                    Regions = [
                       new ApiRegionConfig()
                       {
                           BufferSize = 10,
                           Region = "us-west-1"
                       }
                    ],
                    ImageDeploymentProfile = new ApiImageDeploymentProfile()
                    {
                        ImageId = imageId
                    },
                    DsHostConfiguration = new ApiDSHostConfigurationParameters()
                    {
                        InstanceId = instanceId,
                        ServersPerVm = 1
                    }
                }, _Sdk.Namespace)
                .EnsureSuccess();
            #endregion
            if (newFleet != null)
                fleetId = newFleet.Id!;

            try
            {
                #region Get fleet
                var getFleet = _Sdk.GetAmsApi().Fleets.FleetGetOp
                    .Execute(fleetId, _Sdk.Namespace)
                    .EnsureSuccess();
                #endregion
                if (getFleet != null)
                    Assert.AreEqual(fleetName, getFleet.Name!);

                #region Update fleet data
                _Sdk.GetAmsApi().Fleets.FleetUpdateOp
                    .Execute(new ApiFleetParameters()
                    {
                        Name = fleetNameUpdate
                    }, fleetId, _Sdk.Namespace)
                    .EnsureSuccess();
                #endregion
            }
            finally
            {
                #region Delete fleet
                _Sdk.GetAmsApi().Fleets.FleetDeleteOp
                    .Execute(fleetId, _Sdk.Namespace)
                    .EnsureSuccess();
                #endregion
            }

            ResetPolicy();
        }
    }
}

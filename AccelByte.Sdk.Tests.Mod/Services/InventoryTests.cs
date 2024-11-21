// Copyright (c) 2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using NUnit.Framework;
using System.Collections.Generic;
using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api;

using AccelByte.Sdk.Api.Inventory.Model;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class InventoryTests : BaseServiceTests
    {
        /// <summary>
        /// Store the created inventory config for teardown
        /// </summary>
        private ApimodelsInventoryConfigurationResp? _ConfigInventory = null;

        public InventoryTests() : base(true) { }

        [Test]
        public void InventoryTest()
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
            DisableRetry();

            string codeInventory = "csharp-sdk-code-" + random.GenerateRandomId(4);

            #region Create an inventory configuration
            ApimodelsCreateInventoryConfigurationReq cInventoryConfigBody = new ApimodelsCreateInventoryConfigurationReq()
            {
                Code = codeInventory,
                Description = "testing",
                InitialMaxSlots = 3,
                MaxInstancesPerUser = 2,
                MaxUpgradeSlots = 5,
                Name = codeInventory
            };

            _ConfigInventory = _Sdk.GetInventoryApi().AdminInventoryConfigurations.AdminCreateInventoryConfigurationOp
                .Execute(cInventoryConfigBody, _Sdk.Namespace)
                .EnsureSuccess();
            #endregion

            #region Create an inventory
            string userId = _Sdk.Configuration.Credential!.UserId;
            ApimodelsCreateInventoryReq cInventoryBody = new ApimodelsCreateInventoryReq()
            {
                InventoryConfigurationCode = codeInventory,
                UserId = userId,
            };

            string inventoryId = "";
            ApimodelsInventoryResp cInventory = _Sdk.GetInventoryApi().AdminInventories.AdminCreateInventoryOp
                .Execute(cInventoryBody, _Sdk.Namespace)
                .EnsureSuccess();
            #endregion
            if (cInventory.Id != null)
                inventoryId = cInventory.Id;

            #region Get an inventory
            ApimodelsInventoryResp gInventory = _Sdk.GetInventoryApi().AdminInventories.AdminGetInventoryOp
                .Execute(inventoryId, _Sdk.Namespace)
                .EnsureSuccess();
            #endregion

            #region Update an inventory
            var uInventoryBody = new ApimodelsUpdateInventoryReq()
            {
                IncMaxSlots = 2,
            };

            ApimodelsInventoryResp uInventory = _Sdk.GetInventoryApi().AdminInventories.AdminUpdateInventoryOp
                .Execute(uInventoryBody, inventoryId, _Sdk.Namespace)
                .EnsureSuccess();
            #endregion

            #region Delete an inventory
            var dInventoryBody = new ApimodelsDeleteInventoryReq()
            {
                Message = "delete",
            };
            _Sdk.GetInventoryApi().AdminInventories.DeleteInventoryOp
                .Execute(dInventoryBody, inventoryId, _Sdk.Namespace)
                .EnsureSuccess();
            #endregion
        }

        [TearDown]
        public void TearDown()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null || _ConfigInventory == null)
                return;

            // Clean up Inventory configuration
            _Sdk.GetInventoryApi().AdminInventoryConfigurations.AdminDeleteInventoryConfigurationOp
                .Execute(_ConfigInventory.Id!, _Sdk.Namespace)
                .EnsureSuccess();
        }
    }
}

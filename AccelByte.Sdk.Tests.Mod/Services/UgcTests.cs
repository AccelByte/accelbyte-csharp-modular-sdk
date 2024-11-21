// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;

using AccelByte.Sdk.Api.Ugc.Model;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class UgcTests : BaseServiceTests
    {
        public UgcTests() : base(true) { }

        [Test]
        public void UGCServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string tag_name = "csharp_extend_sdk_test";
            string tag_name_u = "csharp_extend_sdk_test_update";
            string tag_id = String.Empty;

            #region Create a tag
            ModelsCreateTagRequest createTag = new ModelsCreateTagRequest()
            {
                Tag = tag_name
            };
            ModelsCreateTagResponse cTag = _Sdk.GetUgcApi().AdminTag.AdminCreateTagOp
                .Execute(createTag, _Sdk.Namespace)
                .EnsureSuccess();
            #endregion
            Assert.AreEqual(tag_name, cTag.Tag);
            tag_id = cTag.Id!;

            #region Get tags
            ModelsPaginatedGetTagResponse gTag = _Sdk.GetUgcApi().AdminTag.AdminGetTagOp
                .SetOffset(0)
                .SetLimit(10)
                .Execute(_Sdk.Namespace)
                .EnsureSuccess();
            #endregion
            Assert.IsNotNull(gTag);

            #region Update a tag
            ModelsCreateTagRequest updateTag = new ModelsCreateTagRequest()
            {
                Tag = tag_name_u
            };
            ModelsCreateTagResponse uTag = _Sdk.GetUgcApi().AdminTag.AdminUpdateTagOp
                .Execute(updateTag, _Sdk.Namespace, tag_id)
                .EnsureSuccess();
            #endregion
            Assert.AreEqual(tag_name_u, uTag.Tag);

            #region Delete a tag
            _Sdk.GetUgcApi().AdminTag.AdminDeleteTagOp
                .Execute(_Sdk.Namespace, tag_id)
                .EnsureSuccess();
            #endregion
        }
    }
}

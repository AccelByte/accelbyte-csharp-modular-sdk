// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class Category
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public Category(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public Category(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public GetRootCategories.GetRootCategoriesBuilder GetRootCategoriesOp
        {
            get
            {
                var opBuilder = new Operation.GetRootCategories.GetRootCategoriesBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CreateCategory.CreateCategoryBuilder CreateCategoryOp
        {
            get
            {
                var opBuilder = new Operation.CreateCategory.CreateCategoryBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public ListCategoriesBasic.ListCategoriesBasicBuilder ListCategoriesBasicOp
        {
            get
            {
                var opBuilder = new Operation.ListCategoriesBasic.ListCategoriesBasicBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetCategory.GetCategoryBuilder GetCategoryOp
        {
            get
            {
                var opBuilder = new Operation.GetCategory.GetCategoryBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateCategory.UpdateCategoryBuilder UpdateCategoryOp
        {
            get
            {
                var opBuilder = new Operation.UpdateCategory.UpdateCategoryBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteCategory.DeleteCategoryBuilder DeleteCategoryOp
        {
            get
            {
                var opBuilder = new Operation.DeleteCategory.DeleteCategoryBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetChildCategories.GetChildCategoriesBuilder GetChildCategoriesOp
        {
            get
            {
                var opBuilder = new Operation.GetChildCategories.GetChildCategoriesBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetDescendantCategories.GetDescendantCategoriesBuilder GetDescendantCategoriesOp
        {
            get
            {
                var opBuilder = new Operation.GetDescendantCategories.GetDescendantCategoriesBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicGetRootCategories.PublicGetRootCategoriesBuilder PublicGetRootCategoriesOp
        {
            get
            {
                var opBuilder = new Operation.PublicGetRootCategories.PublicGetRootCategoriesBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DownloadCategories.DownloadCategoriesBuilder DownloadCategoriesOp
        {
            get
            {
                var opBuilder = new Operation.DownloadCategories.DownloadCategoriesBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicGetCategory.PublicGetCategoryBuilder PublicGetCategoryOp
        {
            get
            {
                var opBuilder = new Operation.PublicGetCategory.PublicGetCategoryBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicGetChildCategories.PublicGetChildCategoriesBuilder PublicGetChildCategoriesOp
        {
            get
            {
                var opBuilder = new Operation.PublicGetChildCategories.PublicGetChildCategoriesBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicGetDescendantCategories.PublicGetDescendantCategoriesBuilder PublicGetDescendantCategoriesOp
        {
            get
            {
                var opBuilder = new Operation.PublicGetDescendantCategories.PublicGetDescendantCategoriesBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public List<Model.FullCategoryInfo>? GetRootCategories(GetRootCategories input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.FullCategoryInfo>?> GetRootCategoriesAsync(GetRootCategories input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullCategoryInfo? CreateCategory(CreateCategory input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.FullCategoryInfo?> CreateCategoryAsync(CreateCategory input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BasicCategoryInfo>? ListCategoriesBasic(ListCategoriesBasic input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.BasicCategoryInfo>?> ListCategoriesBasicAsync(ListCategoriesBasic input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullCategoryInfo? GetCategory(GetCategory input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.FullCategoryInfo?> GetCategoryAsync(GetCategory input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullCategoryInfo? UpdateCategory(UpdateCategory input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.FullCategoryInfo?> UpdateCategoryAsync(UpdateCategory input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullCategoryInfo? DeleteCategory(DeleteCategory input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.FullCategoryInfo?> DeleteCategoryAsync(DeleteCategory input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.FullCategoryInfo>? GetChildCategories(GetChildCategories input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.FullCategoryInfo>?> GetChildCategoriesAsync(GetChildCategories input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.FullCategoryInfo>? GetDescendantCategories(GetDescendantCategories input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.FullCategoryInfo>?> GetDescendantCategoriesAsync(GetDescendantCategories input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.CategoryInfo>? PublicGetRootCategories(PublicGetRootCategories input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.CategoryInfo>?> PublicGetRootCategoriesAsync(PublicGetRootCategories input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.HierarchicalCategoryInfo>? DownloadCategories(DownloadCategories input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.HierarchicalCategoryInfo>?> DownloadCategoriesAsync(DownloadCategories input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.CategoryInfo? PublicGetCategory(PublicGetCategory input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.CategoryInfo?> PublicGetCategoryAsync(PublicGetCategory input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.CategoryInfo>? PublicGetChildCategories(PublicGetChildCategories input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.CategoryInfo>?> PublicGetChildCategoriesAsync(PublicGetChildCategories input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.CategoryInfo>? PublicGetDescendantCategories(PublicGetDescendantCategories input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.CategoryInfo>?> PublicGetDescendantCategoriesAsync(PublicGetDescendantCategories input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}
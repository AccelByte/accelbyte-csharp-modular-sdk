// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class Category
    {
        private readonly IAccelByteSdk _sdk;

        public Category(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetRootCategories.GetRootCategoriesBuilder GetRootCategoriesOp
        {
            get { return new Operation.GetRootCategories.GetRootCategoriesBuilder(_sdk); }
        }
        public CreateCategory.CreateCategoryBuilder CreateCategoryOp
        {
            get { return new Operation.CreateCategory.CreateCategoryBuilder(_sdk); }
        }
        public ListCategoriesBasic.ListCategoriesBasicBuilder ListCategoriesBasicOp
        {
            get { return new Operation.ListCategoriesBasic.ListCategoriesBasicBuilder(_sdk); }
        }
        public GetCategory.GetCategoryBuilder GetCategoryOp
        {
            get { return new Operation.GetCategory.GetCategoryBuilder(_sdk); }
        }
        public UpdateCategory.UpdateCategoryBuilder UpdateCategoryOp
        {
            get { return new Operation.UpdateCategory.UpdateCategoryBuilder(_sdk); }
        }
        public DeleteCategory.DeleteCategoryBuilder DeleteCategoryOp
        {
            get { return new Operation.DeleteCategory.DeleteCategoryBuilder(_sdk); }
        }
        public GetChildCategories.GetChildCategoriesBuilder GetChildCategoriesOp
        {
            get { return new Operation.GetChildCategories.GetChildCategoriesBuilder(_sdk); }
        }
        public GetDescendantCategories.GetDescendantCategoriesBuilder GetDescendantCategoriesOp
        {
            get { return new Operation.GetDescendantCategories.GetDescendantCategoriesBuilder(_sdk); }
        }
        public PublicGetRootCategories.PublicGetRootCategoriesBuilder PublicGetRootCategoriesOp
        {
            get { return new Operation.PublicGetRootCategories.PublicGetRootCategoriesBuilder(_sdk); }
        }
        public DownloadCategories.DownloadCategoriesBuilder DownloadCategoriesOp
        {
            get { return new Operation.DownloadCategories.DownloadCategoriesBuilder(_sdk); }
        }
        public PublicGetCategory.PublicGetCategoryBuilder PublicGetCategoryOp
        {
            get { return new Operation.PublicGetCategory.PublicGetCategoryBuilder(_sdk); }
        }
        public PublicGetChildCategories.PublicGetChildCategoriesBuilder PublicGetChildCategoriesOp
        {
            get { return new Operation.PublicGetChildCategories.PublicGetChildCategoriesBuilder(_sdk); }
        }
        public PublicGetDescendantCategories.PublicGetDescendantCategoriesBuilder PublicGetDescendantCategoriesOp
        {
            get { return new Operation.PublicGetDescendantCategories.PublicGetDescendantCategoriesBuilder(_sdk); }
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
        public Model.FullCategoryInfo? CreateCategory(CreateCategory input)
        {
            var response = _sdk.RunRequest(input);

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
        public Model.FullCategoryInfo? GetCategory(GetCategory input)
        {
            var response = _sdk.RunRequest(input);

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
        public Model.FullCategoryInfo? DeleteCategory(DeleteCategory input)
        {
            var response = _sdk.RunRequest(input);

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
        public List<Model.FullCategoryInfo>? GetDescendantCategories(GetDescendantCategories input)
        {
            var response = _sdk.RunRequest(input);

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
        public List<Model.HierarchicalCategoryInfo>? DownloadCategories(DownloadCategories input)
        {
            var response = _sdk.RunRequest(input);

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
        public List<Model.CategoryInfo>? PublicGetChildCategories(PublicGetChildCategories input)
        {
            var response = _sdk.RunRequest(input);

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
    }
}
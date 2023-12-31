// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;

namespace AccelByte.Sdk.Api.Basic.Wrapper
{
    public class UserProfile
    {
        private readonly IAccelByteSdk _sdk;

        public UserProfile(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetUserProfileInfoByPublicId.GetUserProfileInfoByPublicIdBuilder GetUserProfileInfoByPublicIdOp
        {
            get { return new Operation.GetUserProfileInfoByPublicId.GetUserProfileInfoByPublicIdBuilder(_sdk); }
        }
        public AdminGetUserProfilePublicInfoByIds.AdminGetUserProfilePublicInfoByIdsBuilder AdminGetUserProfilePublicInfoByIdsOp
        {
            get { return new Operation.AdminGetUserProfilePublicInfoByIds.AdminGetUserProfilePublicInfoByIdsBuilder(_sdk); }
        }
        public GetUserProfileInfo.GetUserProfileInfoBuilder GetUserProfileInfoOp
        {
            get { return new Operation.GetUserProfileInfo.GetUserProfileInfoBuilder(_sdk); }
        }
        public UpdateUserProfile.UpdateUserProfileBuilder UpdateUserProfileOp
        {
            get { return new Operation.UpdateUserProfile.UpdateUserProfileBuilder(_sdk); }
        }
        public DeleteUserProfile.DeleteUserProfileBuilder DeleteUserProfileOp
        {
            get { return new Operation.DeleteUserProfile.DeleteUserProfileBuilder(_sdk); }
        }
        public GetCustomAttributesInfo.GetCustomAttributesInfoBuilder GetCustomAttributesInfoOp
        {
            get { return new Operation.GetCustomAttributesInfo.GetCustomAttributesInfoBuilder(_sdk); }
        }
        public UpdateCustomAttributesPartially.UpdateCustomAttributesPartiallyBuilder UpdateCustomAttributesPartiallyOp
        {
            get { return new Operation.UpdateCustomAttributesPartially.UpdateCustomAttributesPartiallyBuilder(_sdk); }
        }
        public GetPrivateCustomAttributesInfo.GetPrivateCustomAttributesInfoBuilder GetPrivateCustomAttributesInfoOp
        {
            get { return new Operation.GetPrivateCustomAttributesInfo.GetPrivateCustomAttributesInfoBuilder(_sdk); }
        }
        public UpdatePrivateCustomAttributesPartially.UpdatePrivateCustomAttributesPartiallyBuilder UpdatePrivateCustomAttributesPartiallyOp
        {
            get { return new Operation.UpdatePrivateCustomAttributesPartially.UpdatePrivateCustomAttributesPartiallyBuilder(_sdk); }
        }
        public UpdateUserProfileStatus.UpdateUserProfileStatusBuilder UpdateUserProfileStatusOp
        {
            get { return new Operation.UpdateUserProfileStatus.UpdateUserProfileStatusBuilder(_sdk); }
        }
        public PublicGetUserProfilePublicInfoByIds.PublicGetUserProfilePublicInfoByIdsBuilder PublicGetUserProfilePublicInfoByIdsOp
        {
            get { return new Operation.PublicGetUserProfilePublicInfoByIds.PublicGetUserProfilePublicInfoByIdsBuilder(_sdk); }
        }
        public PublicGetUserProfileInfoByPublicId.PublicGetUserProfileInfoByPublicIdBuilder PublicGetUserProfileInfoByPublicIdOp
        {
            get { return new Operation.PublicGetUserProfileInfoByPublicId.PublicGetUserProfileInfoByPublicIdBuilder(_sdk); }
        }
        public GetMyProfileInfo.GetMyProfileInfoBuilder GetMyProfileInfoOp
        {
            get { return new Operation.GetMyProfileInfo.GetMyProfileInfoBuilder(_sdk); }
        }
        public UpdateMyProfile.UpdateMyProfileBuilder UpdateMyProfileOp
        {
            get { return new Operation.UpdateMyProfile.UpdateMyProfileBuilder(_sdk); }
        }
        public CreateMyProfile.CreateMyProfileBuilder CreateMyProfileOp
        {
            get { return new Operation.CreateMyProfile.CreateMyProfileBuilder(_sdk); }
        }
        public GetMyPrivateCustomAttributesInfo.GetMyPrivateCustomAttributesInfoBuilder GetMyPrivateCustomAttributesInfoOp
        {
            get { return new Operation.GetMyPrivateCustomAttributesInfo.GetMyPrivateCustomAttributesInfoBuilder(_sdk); }
        }
        public UpdateMyPrivateCustomAttributesPartially.UpdateMyPrivateCustomAttributesPartiallyBuilder UpdateMyPrivateCustomAttributesPartiallyOp
        {
            get { return new Operation.UpdateMyPrivateCustomAttributesPartially.UpdateMyPrivateCustomAttributesPartiallyBuilder(_sdk); }
        }
        public GetMyZipCode.GetMyZipCodeBuilder GetMyZipCodeOp
        {
            get { return new Operation.GetMyZipCode.GetMyZipCodeBuilder(_sdk); }
        }
        public UpdateMyZipCode.UpdateMyZipCodeBuilder UpdateMyZipCodeOp
        {
            get { return new Operation.UpdateMyZipCode.UpdateMyZipCodeBuilder(_sdk); }
        }
        public PublicGetUserProfileInfo.PublicGetUserProfileInfoBuilder PublicGetUserProfileInfoOp
        {
            get { return new Operation.PublicGetUserProfileInfo.PublicGetUserProfileInfoBuilder(_sdk); }
        }
        public PublicUpdateUserProfile.PublicUpdateUserProfileBuilder PublicUpdateUserProfileOp
        {
            get { return new Operation.PublicUpdateUserProfile.PublicUpdateUserProfileBuilder(_sdk); }
        }
        public PublicCreateUserProfile.PublicCreateUserProfileBuilder PublicCreateUserProfileOp
        {
            get { return new Operation.PublicCreateUserProfile.PublicCreateUserProfileBuilder(_sdk); }
        }
        public PublicGetCustomAttributesInfo.PublicGetCustomAttributesInfoBuilder PublicGetCustomAttributesInfoOp
        {
            get { return new Operation.PublicGetCustomAttributesInfo.PublicGetCustomAttributesInfoBuilder(_sdk); }
        }
        public PublicUpdateCustomAttributesPartially.PublicUpdateCustomAttributesPartiallyBuilder PublicUpdateCustomAttributesPartiallyOp
        {
            get { return new Operation.PublicUpdateCustomAttributesPartially.PublicUpdateCustomAttributesPartiallyBuilder(_sdk); }
        }
        public PublicGetUserProfilePublicInfo.PublicGetUserProfilePublicInfoBuilder PublicGetUserProfilePublicInfoOp
        {
            get { return new Operation.PublicGetUserProfilePublicInfo.PublicGetUserProfilePublicInfoBuilder(_sdk); }
        }
        public PublicUpdateUserProfileStatus.PublicUpdateUserProfileStatusBuilder PublicUpdateUserProfileStatusOp
        {
            get { return new Operation.PublicUpdateUserProfileStatus.PublicUpdateUserProfileStatusBuilder(_sdk); }
        }
        #endregion

        public Model.UserProfileInfo? GetUserProfileInfoByPublicId(GetUserProfileInfoByPublicId input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.UserProfileInfo<T1>? GetUserProfileInfoByPublicId<T1>(GetUserProfileInfoByPublicId input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.UserProfilePublicInfo>? AdminGetUserProfilePublicInfoByIds(AdminGetUserProfilePublicInfoByIds input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public List<Model.UserProfilePublicInfo<T1>>? AdminGetUserProfilePublicInfoByIds<T1>(AdminGetUserProfilePublicInfoByIds input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserProfilePrivateInfo? GetUserProfileInfo(GetUserProfileInfo input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.UserProfilePrivateInfo<T1, T2>? GetUserProfileInfo<T1, T2>(GetUserProfileInfo input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserProfilePrivateInfo? UpdateUserProfile(UpdateUserProfile input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.UserProfilePrivateInfo<T1, T2>? UpdateUserProfile<T1, T2>(UpdateUserProfile input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserProfilePrivateInfo? DeleteUserProfile(DeleteUserProfile input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.UserProfilePrivateInfo<T1, T2>? DeleteUserProfile<T1, T2>(DeleteUserProfile input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Dictionary<string, object>? GetCustomAttributesInfo(GetCustomAttributesInfo input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Dictionary<string, object>? UpdateCustomAttributesPartially(UpdateCustomAttributesPartially input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Dictionary<string, object>? GetPrivateCustomAttributesInfo(GetPrivateCustomAttributesInfo input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Dictionary<string, object>? UpdatePrivateCustomAttributesPartially(UpdatePrivateCustomAttributesPartially input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserProfilePrivateInfo? UpdateUserProfileStatus(UpdateUserProfileStatus input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.UserProfilePrivateInfo<T1, T2>? UpdateUserProfileStatus<T1, T2>(UpdateUserProfileStatus input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.UserProfilePublicInfo>? PublicGetUserProfilePublicInfoByIds(PublicGetUserProfilePublicInfoByIds input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public List<Model.UserProfilePublicInfo<T1>>? PublicGetUserProfilePublicInfoByIds<T1>(PublicGetUserProfilePublicInfoByIds input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserProfilePublicInfo? PublicGetUserProfileInfoByPublicId(PublicGetUserProfileInfoByPublicId input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.UserProfilePublicInfo<T1>? PublicGetUserProfileInfoByPublicId<T1>(PublicGetUserProfileInfoByPublicId input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserProfilePrivateInfo? GetMyProfileInfo(GetMyProfileInfo input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.UserProfilePrivateInfo<T1, T2>? GetMyProfileInfo<T1, T2>(GetMyProfileInfo input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserProfilePrivateInfo? UpdateMyProfile(UpdateMyProfile input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.UserProfilePrivateInfo<T1, T2>? UpdateMyProfile<T1, T2>(UpdateMyProfile input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserProfilePrivateInfo? CreateMyProfile(CreateMyProfile input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.UserProfilePrivateInfo<T1, T2>? CreateMyProfile<T1, T2>(CreateMyProfile input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Dictionary<string, object>? GetMyPrivateCustomAttributesInfo(GetMyPrivateCustomAttributesInfo input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Dictionary<string, object>? UpdateMyPrivateCustomAttributesPartially(UpdateMyPrivateCustomAttributesPartially input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserZipCode? GetMyZipCode(GetMyZipCode input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserZipCode? UpdateMyZipCode(UpdateMyZipCode input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserProfileInfo? PublicGetUserProfileInfo(PublicGetUserProfileInfo input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.UserProfileInfo<T1>? PublicGetUserProfileInfo<T1>(PublicGetUserProfileInfo input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserProfileInfo? PublicUpdateUserProfile(PublicUpdateUserProfile input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.UserProfileInfo<T1>? PublicUpdateUserProfile<T1>(PublicUpdateUserProfile input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserProfileInfo? PublicCreateUserProfile(PublicCreateUserProfile input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.UserProfileInfo<T1>? PublicCreateUserProfile<T1>(PublicCreateUserProfile input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Dictionary<string, object>? PublicGetCustomAttributesInfo(PublicGetCustomAttributesInfo input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Dictionary<string, object>? PublicUpdateCustomAttributesPartially(PublicUpdateCustomAttributesPartially input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserProfilePublicInfo? PublicGetUserProfilePublicInfo(PublicGetUserProfilePublicInfo input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.UserProfilePublicInfo<T1>? PublicGetUserProfilePublicInfo<T1>(PublicGetUserProfilePublicInfo input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserProfileInfo? PublicUpdateUserProfileStatus(PublicUpdateUserProfileStatus input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.UserProfileInfo<T1>? PublicUpdateUserProfileStatus<T1>(PublicUpdateUserProfileStatus input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}
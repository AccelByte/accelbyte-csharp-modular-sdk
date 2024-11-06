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

using AccelByte.Sdk.Api.Achievement.Model;
using AccelByte.Sdk.Api.Achievement.Operation;

namespace AccelByte.Sdk.Api.Achievement.Wrapper
{
    public class Achievements
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public Achievements(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public Achievements(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public AdminListAchievements.AdminListAchievementsBuilder AdminListAchievementsOp
        {
            get
            {
                var opBuilder = new Operation.AdminListAchievements.AdminListAchievementsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminCreateNewAchievement.AdminCreateNewAchievementBuilder AdminCreateNewAchievementOp
        {
            get
            {
                var opBuilder = new Operation.AdminCreateNewAchievement.AdminCreateNewAchievementBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public ExportAchievements.ExportAchievementsBuilder ExportAchievementsOp
        {
            get
            {
                var opBuilder = new Operation.ExportAchievements.ExportAchievementsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public ImportAchievements.ImportAchievementsBuilder ImportAchievementsOp
        {
            get
            {
                var opBuilder = new Operation.ImportAchievements.ImportAchievementsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminGetAchievement.AdminGetAchievementBuilder AdminGetAchievementOp
        {
            get
            {
                var opBuilder = new Operation.AdminGetAchievement.AdminGetAchievementBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminUpdateAchievement.AdminUpdateAchievementBuilder AdminUpdateAchievementOp
        {
            get
            {
                var opBuilder = new Operation.AdminUpdateAchievement.AdminUpdateAchievementBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminDeleteAchievement.AdminDeleteAchievementBuilder AdminDeleteAchievementOp
        {
            get
            {
                var opBuilder = new Operation.AdminDeleteAchievement.AdminDeleteAchievementBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminUpdateAchievementListOrder.AdminUpdateAchievementListOrderBuilder AdminUpdateAchievementListOrderOp
        {
            get
            {
                var opBuilder = new Operation.AdminUpdateAchievementListOrder.AdminUpdateAchievementListOrderBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicListAchievements.PublicListAchievementsBuilder PublicListAchievementsOp
        {
            get
            {
                var opBuilder = new Operation.PublicListAchievements.PublicListAchievementsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicGetAchievement.PublicGetAchievementBuilder PublicGetAchievementOp
        {
            get
            {
                var opBuilder = new Operation.PublicGetAchievement.PublicGetAchievementBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public AdminListAchievements.Response AdminListAchievements(AdminListAchievements input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminListAchievements.Response> AdminListAchievementsAsync(AdminListAchievements input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminCreateNewAchievement.Response AdminCreateNewAchievement(AdminCreateNewAchievement input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminCreateNewAchievement.Response> AdminCreateNewAchievementAsync(AdminCreateNewAchievement input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public AdminCreateNewAchievement.Response<T1> AdminCreateNewAchievement<T1>(AdminCreateNewAchievement input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminCreateNewAchievement.Response<T1>> AdminCreateNewAchievementAsync<T1>(AdminCreateNewAchievement input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public ExportAchievements.Response ExportAchievements(ExportAchievements input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<ExportAchievements.Response> ExportAchievementsAsync(ExportAchievements input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public ImportAchievements.Response ImportAchievements(ImportAchievements input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<ImportAchievements.Response> ImportAchievementsAsync(ImportAchievements input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminGetAchievement.Response AdminGetAchievement(AdminGetAchievement input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminGetAchievement.Response> AdminGetAchievementAsync(AdminGetAchievement input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public AdminGetAchievement.Response<T1> AdminGetAchievement<T1>(AdminGetAchievement input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminGetAchievement.Response<T1>> AdminGetAchievementAsync<T1>(AdminGetAchievement input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminUpdateAchievement.Response AdminUpdateAchievement(AdminUpdateAchievement input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminUpdateAchievement.Response> AdminUpdateAchievementAsync(AdminUpdateAchievement input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public AdminUpdateAchievement.Response<T1> AdminUpdateAchievement<T1>(AdminUpdateAchievement input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminUpdateAchievement.Response<T1>> AdminUpdateAchievementAsync<T1>(AdminUpdateAchievement input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminDeleteAchievement.Response AdminDeleteAchievement(AdminDeleteAchievement input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminDeleteAchievement.Response> AdminDeleteAchievementAsync(AdminDeleteAchievement input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminUpdateAchievementListOrder.Response AdminUpdateAchievementListOrder(AdminUpdateAchievementListOrder input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminUpdateAchievementListOrder.Response> AdminUpdateAchievementListOrderAsync(AdminUpdateAchievementListOrder input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicListAchievements.Response PublicListAchievements(PublicListAchievements input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicListAchievements.Response> PublicListAchievementsAsync(PublicListAchievements input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicGetAchievement.Response PublicGetAchievement(PublicGetAchievement input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetAchievement.Response> PublicGetAchievementAsync(PublicGetAchievement input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public PublicGetAchievement.Response<T1> PublicGetAchievement<T1>(PublicGetAchievement input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetAchievement.Response<T1>> PublicGetAchievementAsync<T1>(PublicGetAchievement input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}
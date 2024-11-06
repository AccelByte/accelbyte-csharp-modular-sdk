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

using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Api.Seasonpass.Operation;

namespace AccelByte.Sdk.Api.Seasonpass.Wrapper
{
    public class Season
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public Season(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public Season(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public QuerySeasons.QuerySeasonsBuilder QuerySeasonsOp
        {
            get
            {
                var opBuilder = new Operation.QuerySeasons.QuerySeasonsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CreateSeason.CreateSeasonBuilder CreateSeasonOp
        {
            get
            {
                var opBuilder = new Operation.CreateSeason.CreateSeasonBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetCurrentSeason.GetCurrentSeasonBuilder GetCurrentSeasonOp
        {
            get
            {
                var opBuilder = new Operation.GetCurrentSeason.GetCurrentSeasonBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public BulkGetUserSeasonProgression.BulkGetUserSeasonProgressionBuilder BulkGetUserSeasonProgressionOp
        {
            get
            {
                var opBuilder = new Operation.BulkGetUserSeasonProgression.BulkGetUserSeasonProgressionBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetSeason.GetSeasonBuilder GetSeasonOp
        {
            get
            {
                var opBuilder = new Operation.GetSeason.GetSeasonBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteSeason.DeleteSeasonBuilder DeleteSeasonOp
        {
            get
            {
                var opBuilder = new Operation.DeleteSeason.DeleteSeasonBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateSeason.UpdateSeasonBuilder UpdateSeasonOp
        {
            get
            {
                var opBuilder = new Operation.UpdateSeason.UpdateSeasonBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CloneSeason.CloneSeasonBuilder CloneSeasonOp
        {
            get
            {
                var opBuilder = new Operation.CloneSeason.CloneSeasonBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetFullSeason.GetFullSeasonBuilder GetFullSeasonOp
        {
            get
            {
                var opBuilder = new Operation.GetFullSeason.GetFullSeasonBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublishSeason.PublishSeasonBuilder PublishSeasonOp
        {
            get
            {
                var opBuilder = new Operation.PublishSeason.PublishSeasonBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public RetireSeason.RetireSeasonBuilder RetireSeasonOp
        {
            get
            {
                var opBuilder = new Operation.RetireSeason.RetireSeasonBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UnpublishSeason.UnpublishSeasonBuilder UnpublishSeasonOp
        {
            get
            {
                var opBuilder = new Operation.UnpublishSeason.UnpublishSeasonBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetUserParticipatedSeasons.GetUserParticipatedSeasonsBuilder GetUserParticipatedSeasonsOp
        {
            get
            {
                var opBuilder = new Operation.GetUserParticipatedSeasons.GetUserParticipatedSeasonsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public ExistsAnyPassByPassCodes.ExistsAnyPassByPassCodesBuilder ExistsAnyPassByPassCodesOp
        {
            get
            {
                var opBuilder = new Operation.ExistsAnyPassByPassCodes.ExistsAnyPassByPassCodesBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetCurrentUserSeasonProgression.GetCurrentUserSeasonProgressionBuilder GetCurrentUserSeasonProgressionOp
        {
            get
            {
                var opBuilder = new Operation.GetCurrentUserSeasonProgression.GetCurrentUserSeasonProgressionBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CheckSeasonPurchasable.CheckSeasonPurchasableBuilder CheckSeasonPurchasableOp
        {
            get
            {
                var opBuilder = new Operation.CheckSeasonPurchasable.CheckSeasonPurchasableBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public ResetUserSeason.ResetUserSeasonBuilder ResetUserSeasonOp
        {
            get
            {
                var opBuilder = new Operation.ResetUserSeason.ResetUserSeasonBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public QueryUserExpGrantHistory.QueryUserExpGrantHistoryBuilder QueryUserExpGrantHistoryOp
        {
            get
            {
                var opBuilder = new Operation.QueryUserExpGrantHistory.QueryUserExpGrantHistoryBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public QueryUserExpGrantHistoryTag.QueryUserExpGrantHistoryTagBuilder QueryUserExpGrantHistoryTagOp
        {
            get
            {
                var opBuilder = new Operation.QueryUserExpGrantHistoryTag.QueryUserExpGrantHistoryTagBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetUserSeason.GetUserSeasonBuilder GetUserSeasonOp
        {
            get
            {
                var opBuilder = new Operation.GetUserSeason.GetUserSeasonBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicGetCurrentSeason.PublicGetCurrentSeasonBuilder PublicGetCurrentSeasonOp
        {
            get
            {
                var opBuilder = new Operation.PublicGetCurrentSeason.PublicGetCurrentSeasonBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicGetCurrentUserSeason.PublicGetCurrentUserSeasonBuilder PublicGetCurrentUserSeasonOp
        {
            get
            {
                var opBuilder = new Operation.PublicGetCurrentUserSeason.PublicGetCurrentUserSeasonBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicGetUserSeason.PublicGetUserSeasonBuilder PublicGetUserSeasonOp
        {
            get
            {
                var opBuilder = new Operation.PublicGetUserSeason.PublicGetUserSeasonBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public QuerySeasons.Response QuerySeasons(QuerySeasons input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<QuerySeasons.Response> QuerySeasonsAsync(QuerySeasons input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public CreateSeason.Response CreateSeason(CreateSeason input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<CreateSeason.Response> CreateSeasonAsync(CreateSeason input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetCurrentSeason.Response GetCurrentSeason(GetCurrentSeason input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetCurrentSeason.Response> GetCurrentSeasonAsync(GetCurrentSeason input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public BulkGetUserSeasonProgression.Response BulkGetUserSeasonProgression(BulkGetUserSeasonProgression input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<BulkGetUserSeasonProgression.Response> BulkGetUserSeasonProgressionAsync(BulkGetUserSeasonProgression input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetSeason.Response GetSeason(GetSeason input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetSeason.Response> GetSeasonAsync(GetSeason input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public DeleteSeason.Response DeleteSeason(DeleteSeason input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DeleteSeason.Response> DeleteSeasonAsync(DeleteSeason input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public UpdateSeason.Response UpdateSeason(UpdateSeason input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<UpdateSeason.Response> UpdateSeasonAsync(UpdateSeason input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public CloneSeason.Response CloneSeason(CloneSeason input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<CloneSeason.Response> CloneSeasonAsync(CloneSeason input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetFullSeason.Response GetFullSeason(GetFullSeason input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetFullSeason.Response> GetFullSeasonAsync(GetFullSeason input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublishSeason.Response PublishSeason(PublishSeason input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublishSeason.Response> PublishSeasonAsync(PublishSeason input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public RetireSeason.Response RetireSeason(RetireSeason input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<RetireSeason.Response> RetireSeasonAsync(RetireSeason input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public UnpublishSeason.Response UnpublishSeason(UnpublishSeason input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<UnpublishSeason.Response> UnpublishSeasonAsync(UnpublishSeason input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetUserParticipatedSeasons.Response GetUserParticipatedSeasons(GetUserParticipatedSeasons input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetUserParticipatedSeasons.Response> GetUserParticipatedSeasonsAsync(GetUserParticipatedSeasons input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public ExistsAnyPassByPassCodes.Response ExistsAnyPassByPassCodes(ExistsAnyPassByPassCodes input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<ExistsAnyPassByPassCodes.Response> ExistsAnyPassByPassCodesAsync(ExistsAnyPassByPassCodes input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetCurrentUserSeasonProgression.Response GetCurrentUserSeasonProgression(GetCurrentUserSeasonProgression input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetCurrentUserSeasonProgression.Response> GetCurrentUserSeasonProgressionAsync(GetCurrentUserSeasonProgression input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public CheckSeasonPurchasable.Response CheckSeasonPurchasable(CheckSeasonPurchasable input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<CheckSeasonPurchasable.Response> CheckSeasonPurchasableAsync(CheckSeasonPurchasable input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public ResetUserSeason.Response ResetUserSeason(ResetUserSeason input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<ResetUserSeason.Response> ResetUserSeasonAsync(ResetUserSeason input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public QueryUserExpGrantHistory.Response QueryUserExpGrantHistory(QueryUserExpGrantHistory input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<QueryUserExpGrantHistory.Response> QueryUserExpGrantHistoryAsync(QueryUserExpGrantHistory input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public QueryUserExpGrantHistoryTag.Response QueryUserExpGrantHistoryTag(QueryUserExpGrantHistoryTag input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<QueryUserExpGrantHistoryTag.Response> QueryUserExpGrantHistoryTagAsync(QueryUserExpGrantHistoryTag input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetUserSeason.Response GetUserSeason(GetUserSeason input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetUserSeason.Response> GetUserSeasonAsync(GetUserSeason input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public GetUserSeason.Response<T1, T2> GetUserSeason<T1, T2>(GetUserSeason input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetUserSeason.Response<T1, T2>> GetUserSeasonAsync<T1, T2>(GetUserSeason input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicGetCurrentSeason.Response PublicGetCurrentSeason(PublicGetCurrentSeason input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetCurrentSeason.Response> PublicGetCurrentSeasonAsync(PublicGetCurrentSeason input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicGetCurrentUserSeason.Response PublicGetCurrentUserSeason(PublicGetCurrentUserSeason input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetCurrentUserSeason.Response> PublicGetCurrentUserSeasonAsync(PublicGetCurrentUserSeason input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public PublicGetCurrentUserSeason.Response<T1, T2> PublicGetCurrentUserSeason<T1, T2>(PublicGetCurrentUserSeason input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetCurrentUserSeason.Response<T1, T2>> PublicGetCurrentUserSeasonAsync<T1, T2>(PublicGetCurrentUserSeason input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicGetUserSeason.Response PublicGetUserSeason(PublicGetUserSeason input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetUserSeason.Response> PublicGetUserSeasonAsync(PublicGetUserSeason input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public PublicGetUserSeason.Response<T1, T2> PublicGetUserSeason<T1, T2>(PublicGetUserSeason input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetUserSeason.Response<T1, T2>> PublicGetUserSeasonAsync<T1, T2>(PublicGetUserSeason input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}
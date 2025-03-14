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
    public class Reward
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public Reward(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public Reward(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public CreateReward.CreateRewardBuilder CreateRewardOp
        {
            get
            {
                var opBuilder = new Operation.CreateReward.CreateRewardBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public QueryRewards.QueryRewardsBuilder QueryRewardsOp
        {
            get
            {
                var opBuilder = new Operation.QueryRewards.QueryRewardsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public ExportRewards.ExportRewardsBuilder ExportRewardsOp
        {
            get
            {
                var opBuilder = new Operation.ExportRewards.ExportRewardsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public ImportRewards.ImportRewardsBuilder ImportRewardsOp
        {
            get
            {
                var opBuilder = new Operation.ImportRewards.ImportRewardsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetReward.GetRewardBuilder GetRewardOp
        {
            get
            {
                var opBuilder = new Operation.GetReward.GetRewardBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateReward.UpdateRewardBuilder UpdateRewardOp
        {
            get
            {
                var opBuilder = new Operation.UpdateReward.UpdateRewardBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteReward.DeleteRewardBuilder DeleteRewardOp
        {
            get
            {
                var opBuilder = new Operation.DeleteReward.DeleteRewardBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CheckEventCondition.CheckEventConditionBuilder CheckEventConditionOp
        {
            get
            {
                var opBuilder = new Operation.CheckEventCondition.CheckEventConditionBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteRewardConditionRecord.DeleteRewardConditionRecordBuilder DeleteRewardConditionRecordOp
        {
            get
            {
                var opBuilder = new Operation.DeleteRewardConditionRecord.DeleteRewardConditionRecordBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetRewardByCode.GetRewardByCodeBuilder GetRewardByCodeOp
        {
            get
            {
                var opBuilder = new Operation.GetRewardByCode.GetRewardByCodeBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public QueryRewards1.QueryRewards1Builder QueryRewards1Op
        {
            get
            {
                var opBuilder = new Operation.QueryRewards1.QueryRewards1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetReward1.GetReward1Builder GetReward1Op
        {
            get
            {
                var opBuilder = new Operation.GetReward1.GetReward1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public CreateReward.Response CreateReward(CreateReward input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<CreateReward.Response> CreateRewardAsync(CreateReward input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public QueryRewards.Response QueryRewards(QueryRewards input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<QueryRewards.Response> QueryRewardsAsync(QueryRewards input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public ExportRewards.Response ExportRewards(ExportRewards input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<ExportRewards.Response> ExportRewardsAsync(ExportRewards input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public ImportRewards.Response ImportRewards(ImportRewards input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<ImportRewards.Response> ImportRewardsAsync(ImportRewards input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetReward.Response GetReward(GetReward input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetReward.Response> GetRewardAsync(GetReward input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public UpdateReward.Response UpdateReward(UpdateReward input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<UpdateReward.Response> UpdateRewardAsync(UpdateReward input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public DeleteReward.Response DeleteReward(DeleteReward input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DeleteReward.Response> DeleteRewardAsync(DeleteReward input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public CheckEventCondition.Response CheckEventCondition(CheckEventCondition input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<CheckEventCondition.Response> CheckEventConditionAsync(CheckEventCondition input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public DeleteRewardConditionRecord.Response DeleteRewardConditionRecord(DeleteRewardConditionRecord input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DeleteRewardConditionRecord.Response> DeleteRewardConditionRecordAsync(DeleteRewardConditionRecord input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetRewardByCode.Response GetRewardByCode(GetRewardByCode input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetRewardByCode.Response> GetRewardByCodeAsync(GetRewardByCode input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public QueryRewards1.Response QueryRewards1(QueryRewards1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<QueryRewards1.Response> QueryRewards1Async(QueryRewards1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetReward1.Response GetReward1(GetReward1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetReward1.Response> GetReward1Async(GetReward1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}
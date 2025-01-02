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

using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Api.Matchmaking.Operation;

namespace AccelByte.Sdk.Api.Matchmaking.Wrapper
{
    public class Matchmaking
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public Matchmaking(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public Matchmaking(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetAllChannelsHandler.GetAllChannelsHandlerBuilder GetAllChannelsHandlerOp
        {
            get
            {
                var opBuilder = new Operation.GetAllChannelsHandler.GetAllChannelsHandlerBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public CreateChannelHandler.CreateChannelHandlerBuilder CreateChannelHandlerOp
        {
            get
            {
                var opBuilder = new Operation.CreateChannelHandler.CreateChannelHandlerBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetMatchPoolMetric.GetMatchPoolMetricBuilder GetMatchPoolMetricOp
        {
            get
            {
                var opBuilder = new Operation.GetMatchPoolMetric.GetMatchPoolMetricBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public DeleteChannelHandler.DeleteChannelHandlerBuilder DeleteChannelHandlerOp
        {
            get
            {
                var opBuilder = new Operation.DeleteChannelHandler.DeleteChannelHandlerBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public StoreMatchResults.StoreMatchResultsBuilder StoreMatchResultsOp
        {
            get
            {
                var opBuilder = new Operation.StoreMatchResults.StoreMatchResultsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Rebalance.RebalanceBuilder RebalanceOp
        {
            get
            {
                var opBuilder = new Operation.Rebalance.RebalanceBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public QueueSessionHandler.QueueSessionHandlerBuilder QueueSessionHandlerOp
        {
            get
            {
                var opBuilder = new Operation.QueueSessionHandler.QueueSessionHandlerBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public DequeueSessionHandler.DequeueSessionHandlerBuilder DequeueSessionHandlerOp
        {
            get
            {
                var opBuilder = new Operation.DequeueSessionHandler.DequeueSessionHandlerBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public QuerySessionHandler.QuerySessionHandlerBuilder QuerySessionHandlerOp
        {
            get
            {
                var opBuilder = new Operation.QuerySessionHandler.QuerySessionHandlerBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetAllPartyInAllChannel.GetAllPartyInAllChannelBuilder GetAllPartyInAllChannelOp
        {
            get
            {
                var opBuilder = new Operation.GetAllPartyInAllChannel.GetAllPartyInAllChannelBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public BulkGetSessions.BulkGetSessionsBuilder BulkGetSessionsOp
        {
            get
            {
                var opBuilder = new Operation.BulkGetSessions.BulkGetSessionsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public ExportChannels.ExportChannelsBuilder ExportChannelsOp
        {
            get
            {
                var opBuilder = new Operation.ExportChannels.ExportChannelsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public ImportChannels.ImportChannelsBuilder ImportChannelsOp
        {
            get
            {
                var opBuilder = new Operation.ImportChannels.ImportChannelsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetSingleMatchmakingChannel.GetSingleMatchmakingChannelBuilder GetSingleMatchmakingChannelOp
        {
            get
            {
                var opBuilder = new Operation.GetSingleMatchmakingChannel.GetSingleMatchmakingChannelBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public UpdateMatchmakingChannel.UpdateMatchmakingChannelBuilder UpdateMatchmakingChannelOp
        {
            get
            {
                var opBuilder = new Operation.UpdateMatchmakingChannel.UpdateMatchmakingChannelBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetAllPartyInChannel.GetAllPartyInChannelBuilder GetAllPartyInChannelOp
        {
            get
            {
                var opBuilder = new Operation.GetAllPartyInChannel.GetAllPartyInChannelBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetAllSessionsInChannel.GetAllSessionsInChannelBuilder GetAllSessionsInChannelOp
        {
            get
            {
                var opBuilder = new Operation.GetAllSessionsInChannel.GetAllSessionsInChannelBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public AddUserIntoSessionInChannel.AddUserIntoSessionInChannelBuilder AddUserIntoSessionInChannelOp
        {
            get
            {
                var opBuilder = new Operation.AddUserIntoSessionInChannel.AddUserIntoSessionInChannelBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public DeleteSessionInChannel.DeleteSessionInChannelBuilder DeleteSessionInChannelOp
        {
            get
            {
                var opBuilder = new Operation.DeleteSessionInChannel.DeleteSessionInChannelBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public DeleteUserFromSessionInChannel.DeleteUserFromSessionInChannelBuilder DeleteUserFromSessionInChannelOp
        {
            get
            {
                var opBuilder = new Operation.DeleteUserFromSessionInChannel.DeleteUserFromSessionInChannelBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetStatData.GetStatDataBuilder GetStatDataOp
        {
            get
            {
                var opBuilder = new Operation.GetStatData.GetStatDataBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public SearchSessions.SearchSessionsBuilder SearchSessionsOp
        {
            get
            {
                var opBuilder = new Operation.SearchSessions.SearchSessionsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetSessionHistoryDetailed.GetSessionHistoryDetailedBuilder GetSessionHistoryDetailedOp
        {
            get
            {
                var opBuilder = new Operation.GetSessionHistoryDetailed.GetSessionHistoryDetailedBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public PublicGetAllMatchmakingChannel.PublicGetAllMatchmakingChannelBuilder PublicGetAllMatchmakingChannelOp
        {
            get
            {
                var opBuilder = new Operation.PublicGetAllMatchmakingChannel.PublicGetAllMatchmakingChannelBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public PublicGetSingleMatchmakingChannel.PublicGetSingleMatchmakingChannelBuilder PublicGetSingleMatchmakingChannelOp
        {
            get
            {
                var opBuilder = new Operation.PublicGetSingleMatchmakingChannel.PublicGetSingleMatchmakingChannelBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public SearchSessionsV2.SearchSessionsV2Builder SearchSessionsV2Op
        {
            get
            {
                var opBuilder = new Operation.SearchSessionsV2.SearchSessionsV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetAllChannelsHandler.Response GetAllChannelsHandler(GetAllChannelsHandler input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetAllChannelsHandler.Response> GetAllChannelsHandlerAsync(GetAllChannelsHandler input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public CreateChannelHandler.Response CreateChannelHandler(CreateChannelHandler input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<CreateChannelHandler.Response> CreateChannelHandlerAsync(CreateChannelHandler input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetMatchPoolMetric.Response GetMatchPoolMetric(GetMatchPoolMetric input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetMatchPoolMetric.Response> GetMatchPoolMetricAsync(GetMatchPoolMetric input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public DeleteChannelHandler.Response DeleteChannelHandler(DeleteChannelHandler input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DeleteChannelHandler.Response> DeleteChannelHandlerAsync(DeleteChannelHandler input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public StoreMatchResults.Response StoreMatchResults(StoreMatchResults input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<StoreMatchResults.Response> StoreMatchResultsAsync(StoreMatchResults input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Rebalance.Response Rebalance(Rebalance input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Rebalance.Response> RebalanceAsync(Rebalance input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public QueueSessionHandler.Response QueueSessionHandler(QueueSessionHandler input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<QueueSessionHandler.Response> QueueSessionHandlerAsync(QueueSessionHandler input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public DequeueSessionHandler.Response DequeueSessionHandler(DequeueSessionHandler input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DequeueSessionHandler.Response> DequeueSessionHandlerAsync(DequeueSessionHandler input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public QuerySessionHandler.Response QuerySessionHandler(QuerySessionHandler input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<QuerySessionHandler.Response> QuerySessionHandlerAsync(QuerySessionHandler input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public QuerySessionHandler.Response<T1> QuerySessionHandler<T1>(QuerySessionHandler input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<QuerySessionHandler.Response<T1>> QuerySessionHandlerAsync<T1>(QuerySessionHandler input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetAllPartyInAllChannel.Response GetAllPartyInAllChannel(GetAllPartyInAllChannel input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetAllPartyInAllChannel.Response> GetAllPartyInAllChannelAsync(GetAllPartyInAllChannel input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public GetAllPartyInAllChannel.Response<T1> GetAllPartyInAllChannel<T1>(GetAllPartyInAllChannel input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetAllPartyInAllChannel.Response<T1>> GetAllPartyInAllChannelAsync<T1>(GetAllPartyInAllChannel input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public BulkGetSessions.Response BulkGetSessions(BulkGetSessions input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<BulkGetSessions.Response> BulkGetSessionsAsync(BulkGetSessions input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public BulkGetSessions.Response<T1> BulkGetSessions<T1>(BulkGetSessions input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<BulkGetSessions.Response<T1>> BulkGetSessionsAsync<T1>(BulkGetSessions input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public ExportChannels.Response ExportChannels(ExportChannels input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<ExportChannels.Response> ExportChannelsAsync(ExportChannels input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public ImportChannels.Response ImportChannels(ImportChannels input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<ImportChannels.Response> ImportChannelsAsync(ImportChannels input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetSingleMatchmakingChannel.Response GetSingleMatchmakingChannel(GetSingleMatchmakingChannel input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetSingleMatchmakingChannel.Response> GetSingleMatchmakingChannelAsync(GetSingleMatchmakingChannel input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public UpdateMatchmakingChannel.Response UpdateMatchmakingChannel(UpdateMatchmakingChannel input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<UpdateMatchmakingChannel.Response> UpdateMatchmakingChannelAsync(UpdateMatchmakingChannel input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetAllPartyInChannel.Response GetAllPartyInChannel(GetAllPartyInChannel input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetAllPartyInChannel.Response> GetAllPartyInChannelAsync(GetAllPartyInChannel input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public GetAllPartyInChannel.Response<T1> GetAllPartyInChannel<T1>(GetAllPartyInChannel input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetAllPartyInChannel.Response<T1>> GetAllPartyInChannelAsync<T1>(GetAllPartyInChannel input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetAllSessionsInChannel.Response GetAllSessionsInChannel(GetAllSessionsInChannel input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetAllSessionsInChannel.Response> GetAllSessionsInChannelAsync(GetAllSessionsInChannel input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public GetAllSessionsInChannel.Response<T1> GetAllSessionsInChannel<T1>(GetAllSessionsInChannel input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetAllSessionsInChannel.Response<T1>> GetAllSessionsInChannelAsync<T1>(GetAllSessionsInChannel input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public AddUserIntoSessionInChannel.Response AddUserIntoSessionInChannel(AddUserIntoSessionInChannel input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AddUserIntoSessionInChannel.Response> AddUserIntoSessionInChannelAsync(AddUserIntoSessionInChannel input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public DeleteSessionInChannel.Response DeleteSessionInChannel(DeleteSessionInChannel input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DeleteSessionInChannel.Response> DeleteSessionInChannelAsync(DeleteSessionInChannel input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public DeleteUserFromSessionInChannel.Response DeleteUserFromSessionInChannel(DeleteUserFromSessionInChannel input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DeleteUserFromSessionInChannel.Response> DeleteUserFromSessionInChannelAsync(DeleteUserFromSessionInChannel input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetStatData.Response GetStatData(GetStatData input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetStatData.Response> GetStatDataAsync(GetStatData input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public SearchSessions.Response SearchSessions(SearchSessions input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<SearchSessions.Response> SearchSessionsAsync(SearchSessions input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetSessionHistoryDetailed.Response GetSessionHistoryDetailed(GetSessionHistoryDetailed input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetSessionHistoryDetailed.Response> GetSessionHistoryDetailedAsync(GetSessionHistoryDetailed input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public PublicGetAllMatchmakingChannel.Response PublicGetAllMatchmakingChannel(PublicGetAllMatchmakingChannel input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetAllMatchmakingChannel.Response> PublicGetAllMatchmakingChannelAsync(PublicGetAllMatchmakingChannel input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public PublicGetSingleMatchmakingChannel.Response PublicGetSingleMatchmakingChannel(PublicGetSingleMatchmakingChannel input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetSingleMatchmakingChannel.Response> PublicGetSingleMatchmakingChannelAsync(PublicGetSingleMatchmakingChannel input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public SearchSessionsV2.Response SearchSessionsV2(SearchSessionsV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<SearchSessionsV2.Response> SearchSessionsV2Async(SearchSessionsV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
    }
}
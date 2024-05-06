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

using AccelByte.Sdk.Api.Chat.Model;
using AccelByte.Sdk.Api.Chat.Operation;

namespace AccelByte.Sdk.Api.Chat.Wrapper
{
    public class Topic
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public Topic(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public Topic(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public AdminFilterChatMessage.AdminFilterChatMessageBuilder AdminFilterChatMessageOp
        {
            get
            {
                var opBuilder = new Operation.AdminFilterChatMessage.AdminFilterChatMessageBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminChatHistory.AdminChatHistoryBuilder AdminChatHistoryOp
        {
            get
            {
                var opBuilder = new Operation.AdminChatHistory.AdminChatHistoryBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminCreateNamespaceTopic.AdminCreateNamespaceTopicBuilder AdminCreateNamespaceTopicOp
        {
            get
            {
                var opBuilder = new Operation.AdminCreateNamespaceTopic.AdminCreateNamespaceTopicBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminTopicList.AdminTopicListBuilder AdminTopicListOp
        {
            get
            {
                var opBuilder = new Operation.AdminTopicList.AdminTopicListBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminCreateTopic.AdminCreateTopicBuilder AdminCreateTopicOp
        {
            get
            {
                var opBuilder = new Operation.AdminCreateTopic.AdminCreateTopicBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminChannelTopicList.AdminChannelTopicListBuilder AdminChannelTopicListOp
        {
            get
            {
                var opBuilder = new Operation.AdminChannelTopicList.AdminChannelTopicListBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminChannelTopicSummary.AdminChannelTopicSummaryBuilder AdminChannelTopicSummaryOp
        {
            get
            {
                var opBuilder = new Operation.AdminChannelTopicSummary.AdminChannelTopicSummaryBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminQueryTopicLog.AdminQueryTopicLogBuilder AdminQueryTopicLogOp
        {
            get
            {
                var opBuilder = new Operation.AdminQueryTopicLog.AdminQueryTopicLogBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminUpdateTopic.AdminUpdateTopicBuilder AdminUpdateTopicOp
        {
            get
            {
                var opBuilder = new Operation.AdminUpdateTopic.AdminUpdateTopicBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminDeleteTopic.AdminDeleteTopicBuilder AdminDeleteTopicOp
        {
            get
            {
                var opBuilder = new Operation.AdminDeleteTopic.AdminDeleteTopicBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminBanTopicMembers.AdminBanTopicMembersBuilder AdminBanTopicMembersOp
        {
            get
            {
                var opBuilder = new Operation.AdminBanTopicMembers.AdminBanTopicMembersBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminChannelTopicInfo.AdminChannelTopicInfoBuilder AdminChannelTopicInfoOp
        {
            get
            {
                var opBuilder = new Operation.AdminChannelTopicInfo.AdminChannelTopicInfoBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public AdminTopicChatHistory.AdminTopicChatHistoryBuilder AdminTopicChatHistoryOp
        {
            get
            {
                var opBuilder = new Operation.AdminTopicChatHistory.AdminTopicChatHistoryBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminSendChat.AdminSendChatBuilder AdminSendChatOp
        {
            get
            {
                var opBuilder = new Operation.AdminSendChat.AdminSendChatBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminDeleteChat.AdminDeleteChatBuilder AdminDeleteChatOp
        {
            get
            {
                var opBuilder = new Operation.AdminDeleteChat.AdminDeleteChatBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminTopicMembers.AdminTopicMembersBuilder AdminTopicMembersOp
        {
            get
            {
                var opBuilder = new Operation.AdminTopicMembers.AdminTopicMembersBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminTopicShards.AdminTopicShardsBuilder AdminTopicShardsOp
        {
            get
            {
                var opBuilder = new Operation.AdminTopicShards.AdminTopicShardsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminUnbanTopicMembers.AdminUnbanTopicMembersBuilder AdminUnbanTopicMembersOp
        {
            get
            {
                var opBuilder = new Operation.AdminUnbanTopicMembers.AdminUnbanTopicMembersBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminAddTopicMember.AdminAddTopicMemberBuilder AdminAddTopicMemberOp
        {
            get
            {
                var opBuilder = new Operation.AdminAddTopicMember.AdminAddTopicMemberBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminRemoveTopicMember.AdminRemoveTopicMemberBuilder AdminRemoveTopicMemberOp
        {
            get
            {
                var opBuilder = new Operation.AdminRemoveTopicMember.AdminRemoveTopicMemberBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminQueryTopic.AdminQueryTopicBuilder AdminQueryTopicOp
        {
            get
            {
                var opBuilder = new Operation.AdminQueryTopic.AdminQueryTopicBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminQueryUsersTopic.AdminQueryUsersTopicBuilder AdminQueryUsersTopicOp
        {
            get
            {
                var opBuilder = new Operation.AdminQueryUsersTopic.AdminQueryUsersTopicBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicGetMutedTopics.PublicGetMutedTopicsBuilder PublicGetMutedTopicsOp
        {
            get
            {
                var opBuilder = new Operation.PublicGetMutedTopics.PublicGetMutedTopicsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicTopicList.PublicTopicListBuilder PublicTopicListOp
        {
            get
            {
                var opBuilder = new Operation.PublicTopicList.PublicTopicListBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicBanTopicMembers.PublicBanTopicMembersBuilder PublicBanTopicMembersOp
        {
            get
            {
                var opBuilder = new Operation.PublicBanTopicMembers.PublicBanTopicMembersBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicChatHistory.PublicChatHistoryBuilder PublicChatHistoryOp
        {
            get
            {
                var opBuilder = new Operation.PublicChatHistory.PublicChatHistoryBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicDeleteChat.PublicDeleteChatBuilder PublicDeleteChatOp
        {
            get
            {
                var opBuilder = new Operation.PublicDeleteChat.PublicDeleteChatBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicMuteUser.PublicMuteUserBuilder PublicMuteUserOp
        {
            get
            {
                var opBuilder = new Operation.PublicMuteUser.PublicMuteUserBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicUnbanTopicMembers.PublicUnbanTopicMembersBuilder PublicUnbanTopicMembersOp
        {
            get
            {
                var opBuilder = new Operation.PublicUnbanTopicMembers.PublicUnbanTopicMembersBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicUnmuteUser.PublicUnmuteUserBuilder PublicUnmuteUserOp
        {
            get
            {
                var opBuilder = new Operation.PublicUnmuteUser.PublicUnmuteUserBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public Model.ModelsMessageResultWithAttributes? AdminFilterChatMessage(AdminFilterChatMessage input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsMessageResultWithAttributes?> AdminFilterChatMessageAsync(AdminFilterChatMessage input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsMessageResultWithAttributes<T1>? AdminFilterChatMessage<T1>(AdminFilterChatMessage input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsMessageResultWithAttributes<T1>?> AdminFilterChatMessageAsync<T1>(AdminFilterChatMessage input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsChatMessageWithPaginationResponse? AdminChatHistory(AdminChatHistory input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsChatMessageWithPaginationResponse?> AdminChatHistoryAsync(AdminChatHistory input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApiCreateTopicResponse? AdminCreateNamespaceTopic(AdminCreateNamespaceTopic input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApiCreateTopicResponse?> AdminCreateNamespaceTopicAsync(AdminCreateNamespaceTopic input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsTopicResponse>? AdminTopicList(AdminTopicList input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.ModelsTopicResponse>?> AdminTopicListAsync(AdminTopicList input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApiCreateTopicResponse? AdminCreateTopic(AdminCreateTopic input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApiCreateTopicResponse?> AdminCreateTopicAsync(AdminCreateTopic input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsChannelTopicWithPaginationResponse? AdminChannelTopicList(AdminChannelTopicList input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsChannelTopicWithPaginationResponse?> AdminChannelTopicListAsync(AdminChannelTopicList input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsChannelTopicSummaryResponse? AdminChannelTopicSummary(AdminChannelTopicSummary input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsChannelTopicSummaryResponse?> AdminChannelTopicSummaryAsync(AdminChannelTopicSummary input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsTopicLogWithPaginationResponse? AdminQueryTopicLog(AdminQueryTopicLog input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsTopicLogWithPaginationResponse?> AdminQueryTopicLogAsync(AdminQueryTopicLog input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApiCreateTopicResponse? AdminUpdateTopic(AdminUpdateTopic input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApiCreateTopicResponse?> AdminUpdateTopicAsync(AdminUpdateTopic input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.MessageActionDeleteTopicResult? AdminDeleteTopic(AdminDeleteTopic input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.MessageActionDeleteTopicResult?> AdminDeleteTopicAsync(AdminDeleteTopic input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsBanTopicMemberResult? AdminBanTopicMembers(AdminBanTopicMembers input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsBanTopicMemberResult?> AdminBanTopicMembersAsync(AdminBanTopicMembers input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsChannelTopicResponse? AdminChannelTopicInfo(AdminChannelTopicInfo input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsChannelTopicResponse?> AdminChannelTopicInfoAsync(AdminChannelTopicInfo input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.ModelsChatMessageWithPaginationResponse? AdminTopicChatHistory(AdminTopicChatHistory input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsChatMessageWithPaginationResponse?> AdminTopicChatHistoryAsync(AdminTopicChatHistory input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
        public List<Model.ModelsChatMessageResponse>? AdminSendChat(AdminSendChat input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.ModelsChatMessageResponse>?> AdminSendChatAsync(AdminSendChat input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteChat(AdminDeleteChat input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AdminDeleteChatAsync(AdminDeleteChat input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsTopicMemberWithPaginationResponse? AdminTopicMembers(AdminTopicMembers input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsTopicMemberWithPaginationResponse?> AdminTopicMembersAsync(AdminTopicMembers input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<string>? AdminTopicShards(AdminTopicShards input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<string>?> AdminTopicShardsAsync(AdminTopicShards input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUnbanTopicMemberResult? AdminUnbanTopicMembers(AdminUnbanTopicMembers input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsUnbanTopicMemberResult?> AdminUnbanTopicMembersAsync(AdminUnbanTopicMembers input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.MessageActionAddUserToTopicResult? AdminAddTopicMember(AdminAddTopicMember input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.MessageActionAddUserToTopicResult?> AdminAddTopicMemberAsync(AdminAddTopicMember input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.MessageActionAddUserToTopicResult? AdminRemoveTopicMember(AdminRemoveTopicMember input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.MessageActionAddUserToTopicResult?> AdminRemoveTopicMemberAsync(AdminRemoveTopicMember input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsTopicInfo>? AdminQueryTopic(AdminQueryTopic input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.ModelsTopicInfo>?> AdminQueryTopicAsync(AdminQueryTopic input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsTopicLogWithPaginationResponse? AdminQueryUsersTopic(AdminQueryUsersTopic input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsTopicLogWithPaginationResponse?> AdminQueryUsersTopicAsync(AdminQueryUsersTopic input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ApiMutedTopicResponse>? PublicGetMutedTopics(PublicGetMutedTopics input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.ApiMutedTopicResponse>?> PublicGetMutedTopicsAsync(PublicGetMutedTopics input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsChatMessageResponse>? PublicTopicList(PublicTopicList input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.ModelsChatMessageResponse>?> PublicTopicListAsync(PublicTopicList input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPublicBanTopicMembersResponse? PublicBanTopicMembers(PublicBanTopicMembers input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPublicBanTopicMembersResponse?> PublicBanTopicMembersAsync(PublicBanTopicMembers input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsChatMessageResponse>? PublicChatHistory(PublicChatHistory input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.ModelsChatMessageResponse>?> PublicChatHistoryAsync(PublicChatHistory input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicDeleteChat(PublicDeleteChat input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task PublicDeleteChatAsync(PublicDeleteChat input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicMuteUser(PublicMuteUser input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task PublicMuteUserAsync(PublicMuteUser input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPublicUnbanTopicMembersResponse? PublicUnbanTopicMembers(PublicUnbanTopicMembers input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPublicUnbanTopicMembersResponse?> PublicUnbanTopicMembersAsync(PublicUnbanTopicMembers input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicUnmuteUser(PublicUnmuteUser input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task PublicUnmuteUserAsync(PublicUnmuteUser input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}
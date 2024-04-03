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

        public Topic(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminChatHistory.AdminChatHistoryBuilder AdminChatHistoryOp
        {
            get { return new Operation.AdminChatHistory.AdminChatHistoryBuilder(_sdk); }
        }
        public AdminCreateNamespaceTopic.AdminCreateNamespaceTopicBuilder AdminCreateNamespaceTopicOp
        {
            get { return new Operation.AdminCreateNamespaceTopic.AdminCreateNamespaceTopicBuilder(_sdk); }
        }
        public AdminTopicList.AdminTopicListBuilder AdminTopicListOp
        {
            get { return new Operation.AdminTopicList.AdminTopicListBuilder(_sdk); }
        }
        public AdminCreateTopic.AdminCreateTopicBuilder AdminCreateTopicOp
        {
            get { return new Operation.AdminCreateTopic.AdminCreateTopicBuilder(_sdk); }
        }
        public AdminChannelTopicList.AdminChannelTopicListBuilder AdminChannelTopicListOp
        {
            get { return new Operation.AdminChannelTopicList.AdminChannelTopicListBuilder(_sdk); }
        }
        public AdminChannelTopicSummary.AdminChannelTopicSummaryBuilder AdminChannelTopicSummaryOp
        {
            get { return new Operation.AdminChannelTopicSummary.AdminChannelTopicSummaryBuilder(_sdk); }
        }
        public AdminQueryTopicLog.AdminQueryTopicLogBuilder AdminQueryTopicLogOp
        {
            get { return new Operation.AdminQueryTopicLog.AdminQueryTopicLogBuilder(_sdk); }
        }
        public AdminUpdateTopic.AdminUpdateTopicBuilder AdminUpdateTopicOp
        {
            get { return new Operation.AdminUpdateTopic.AdminUpdateTopicBuilder(_sdk); }
        }
        public AdminDeleteTopic.AdminDeleteTopicBuilder AdminDeleteTopicOp
        {
            get { return new Operation.AdminDeleteTopic.AdminDeleteTopicBuilder(_sdk); }
        }
        public AdminBanTopicMembers.AdminBanTopicMembersBuilder AdminBanTopicMembersOp
        {
            get { return new Operation.AdminBanTopicMembers.AdminBanTopicMembersBuilder(_sdk); }
        }
        public AdminChannelTopicInfo.AdminChannelTopicInfoBuilder AdminChannelTopicInfoOp
        {
            get { return new Operation.AdminChannelTopicInfo.AdminChannelTopicInfoBuilder(_sdk); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public AdminTopicChatHistory.AdminTopicChatHistoryBuilder AdminTopicChatHistoryOp
        {
            get { return new Operation.AdminTopicChatHistory.AdminTopicChatHistoryBuilder(_sdk); }
        }
        public AdminSendChat.AdminSendChatBuilder AdminSendChatOp
        {
            get { return new Operation.AdminSendChat.AdminSendChatBuilder(_sdk); }
        }
        public AdminDeleteChat.AdminDeleteChatBuilder AdminDeleteChatOp
        {
            get { return new Operation.AdminDeleteChat.AdminDeleteChatBuilder(_sdk); }
        }
        public AdminTopicMembers.AdminTopicMembersBuilder AdminTopicMembersOp
        {
            get { return new Operation.AdminTopicMembers.AdminTopicMembersBuilder(_sdk); }
        }
        public AdminTopicShards.AdminTopicShardsBuilder AdminTopicShardsOp
        {
            get { return new Operation.AdminTopicShards.AdminTopicShardsBuilder(_sdk); }
        }
        public AdminUnbanTopicMembers.AdminUnbanTopicMembersBuilder AdminUnbanTopicMembersOp
        {
            get { return new Operation.AdminUnbanTopicMembers.AdminUnbanTopicMembersBuilder(_sdk); }
        }
        public AdminAddTopicMember.AdminAddTopicMemberBuilder AdminAddTopicMemberOp
        {
            get { return new Operation.AdminAddTopicMember.AdminAddTopicMemberBuilder(_sdk); }
        }
        public AdminRemoveTopicMember.AdminRemoveTopicMemberBuilder AdminRemoveTopicMemberOp
        {
            get { return new Operation.AdminRemoveTopicMember.AdminRemoveTopicMemberBuilder(_sdk); }
        }
        public AdminQueryTopic.AdminQueryTopicBuilder AdminQueryTopicOp
        {
            get { return new Operation.AdminQueryTopic.AdminQueryTopicBuilder(_sdk); }
        }
        public AdminQueryUsersTopic.AdminQueryUsersTopicBuilder AdminQueryUsersTopicOp
        {
            get { return new Operation.AdminQueryUsersTopic.AdminQueryUsersTopicBuilder(_sdk); }
        }
        public PublicGetMutedTopics.PublicGetMutedTopicsBuilder PublicGetMutedTopicsOp
        {
            get { return new Operation.PublicGetMutedTopics.PublicGetMutedTopicsBuilder(_sdk); }
        }
        public PublicTopicList.PublicTopicListBuilder PublicTopicListOp
        {
            get { return new Operation.PublicTopicList.PublicTopicListBuilder(_sdk); }
        }
        public PublicBanTopicMembers.PublicBanTopicMembersBuilder PublicBanTopicMembersOp
        {
            get { return new Operation.PublicBanTopicMembers.PublicBanTopicMembersBuilder(_sdk); }
        }
        public PublicChatHistory.PublicChatHistoryBuilder PublicChatHistoryOp
        {
            get { return new Operation.PublicChatHistory.PublicChatHistoryBuilder(_sdk); }
        }
        public PublicDeleteChat.PublicDeleteChatBuilder PublicDeleteChatOp
        {
            get { return new Operation.PublicDeleteChat.PublicDeleteChatBuilder(_sdk); }
        }
        public PublicMuteUser.PublicMuteUserBuilder PublicMuteUserOp
        {
            get { return new Operation.PublicMuteUser.PublicMuteUserBuilder(_sdk); }
        }
        public PublicUnbanTopicMembers.PublicUnbanTopicMembersBuilder PublicUnbanTopicMembersOp
        {
            get { return new Operation.PublicUnbanTopicMembers.PublicUnbanTopicMembersBuilder(_sdk); }
        }
        public PublicUnmuteUser.PublicUnmuteUserBuilder PublicUnmuteUserOp
        {
            get { return new Operation.PublicUnmuteUser.PublicUnmuteUserBuilder(_sdk); }
        }
        #endregion

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
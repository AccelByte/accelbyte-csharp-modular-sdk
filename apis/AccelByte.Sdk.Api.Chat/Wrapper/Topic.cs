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

        public AdminFilterChatMessage.Response AdminFilterChatMessage(AdminFilterChatMessage input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminFilterChatMessage.Response> AdminFilterChatMessageAsync(AdminFilterChatMessage input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public AdminFilterChatMessage.Response<T1> AdminFilterChatMessage<T1>(AdminFilterChatMessage input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminFilterChatMessage.Response<T1>> AdminFilterChatMessageAsync<T1>(AdminFilterChatMessage input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminChatHistory.Response AdminChatHistory(AdminChatHistory input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminChatHistory.Response> AdminChatHistoryAsync(AdminChatHistory input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminCreateNamespaceTopic.Response AdminCreateNamespaceTopic(AdminCreateNamespaceTopic input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminCreateNamespaceTopic.Response> AdminCreateNamespaceTopicAsync(AdminCreateNamespaceTopic input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminTopicList.Response AdminTopicList(AdminTopicList input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminTopicList.Response> AdminTopicListAsync(AdminTopicList input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminCreateTopic.Response AdminCreateTopic(AdminCreateTopic input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminCreateTopic.Response> AdminCreateTopicAsync(AdminCreateTopic input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminChannelTopicList.Response AdminChannelTopicList(AdminChannelTopicList input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminChannelTopicList.Response> AdminChannelTopicListAsync(AdminChannelTopicList input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminChannelTopicSummary.Response AdminChannelTopicSummary(AdminChannelTopicSummary input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminChannelTopicSummary.Response> AdminChannelTopicSummaryAsync(AdminChannelTopicSummary input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminQueryTopicLog.Response AdminQueryTopicLog(AdminQueryTopicLog input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminQueryTopicLog.Response> AdminQueryTopicLogAsync(AdminQueryTopicLog input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminUpdateTopic.Response AdminUpdateTopic(AdminUpdateTopic input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminUpdateTopic.Response> AdminUpdateTopicAsync(AdminUpdateTopic input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminDeleteTopic.Response AdminDeleteTopic(AdminDeleteTopic input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminDeleteTopic.Response> AdminDeleteTopicAsync(AdminDeleteTopic input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminBanTopicMembers.Response AdminBanTopicMembers(AdminBanTopicMembers input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminBanTopicMembers.Response> AdminBanTopicMembersAsync(AdminBanTopicMembers input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminChannelTopicInfo.Response AdminChannelTopicInfo(AdminChannelTopicInfo input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminChannelTopicInfo.Response> AdminChannelTopicInfoAsync(AdminChannelTopicInfo input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public AdminTopicChatHistory.Response AdminTopicChatHistory(AdminTopicChatHistory input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminTopicChatHistory.Response> AdminTopicChatHistoryAsync(AdminTopicChatHistory input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
        public AdminSendChat.Response AdminSendChat(AdminSendChat input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminSendChat.Response> AdminSendChatAsync(AdminSendChat input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminDeleteChat.Response AdminDeleteChat(AdminDeleteChat input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminDeleteChat.Response> AdminDeleteChatAsync(AdminDeleteChat input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminTopicMembers.Response AdminTopicMembers(AdminTopicMembers input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminTopicMembers.Response> AdminTopicMembersAsync(AdminTopicMembers input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminTopicShards.Response AdminTopicShards(AdminTopicShards input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminTopicShards.Response> AdminTopicShardsAsync(AdminTopicShards input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminUnbanTopicMembers.Response AdminUnbanTopicMembers(AdminUnbanTopicMembers input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminUnbanTopicMembers.Response> AdminUnbanTopicMembersAsync(AdminUnbanTopicMembers input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminAddTopicMember.Response AdminAddTopicMember(AdminAddTopicMember input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminAddTopicMember.Response> AdminAddTopicMemberAsync(AdminAddTopicMember input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminRemoveTopicMember.Response AdminRemoveTopicMember(AdminRemoveTopicMember input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminRemoveTopicMember.Response> AdminRemoveTopicMemberAsync(AdminRemoveTopicMember input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminQueryTopic.Response AdminQueryTopic(AdminQueryTopic input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminQueryTopic.Response> AdminQueryTopicAsync(AdminQueryTopic input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminQueryUsersTopic.Response AdminQueryUsersTopic(AdminQueryUsersTopic input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminQueryUsersTopic.Response> AdminQueryUsersTopicAsync(AdminQueryUsersTopic input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicGetMutedTopics.Response PublicGetMutedTopics(PublicGetMutedTopics input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetMutedTopics.Response> PublicGetMutedTopicsAsync(PublicGetMutedTopics input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicTopicList.Response PublicTopicList(PublicTopicList input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicTopicList.Response> PublicTopicListAsync(PublicTopicList input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicBanTopicMembers.Response PublicBanTopicMembers(PublicBanTopicMembers input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicBanTopicMembers.Response> PublicBanTopicMembersAsync(PublicBanTopicMembers input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicChatHistory.Response PublicChatHistory(PublicChatHistory input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicChatHistory.Response> PublicChatHistoryAsync(PublicChatHistory input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicDeleteChat.Response PublicDeleteChat(PublicDeleteChat input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicDeleteChat.Response> PublicDeleteChatAsync(PublicDeleteChat input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicMuteUser.Response PublicMuteUser(PublicMuteUser input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicMuteUser.Response> PublicMuteUserAsync(PublicMuteUser input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicUnbanTopicMembers.Response PublicUnbanTopicMembers(PublicUnbanTopicMembers input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicUnbanTopicMembers.Response> PublicUnbanTopicMembersAsync(PublicUnbanTopicMembers input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicUnmuteUser.Response PublicUnmuteUser(PublicUnmuteUser input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicUnmuteUser.Response> PublicUnmuteUserAsync(PublicUnmuteUser input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}
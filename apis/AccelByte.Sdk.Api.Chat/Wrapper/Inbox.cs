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
    public class Inbox
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public Inbox(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public Inbox(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public AdminGetInboxCategories.AdminGetInboxCategoriesBuilder AdminGetInboxCategoriesOp
        {
            get
            {
                var opBuilder = new Operation.AdminGetInboxCategories.AdminGetInboxCategoriesBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminAddInboxCategory.AdminAddInboxCategoryBuilder AdminAddInboxCategoryOp
        {
            get
            {
                var opBuilder = new Operation.AdminAddInboxCategory.AdminAddInboxCategoryBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminDeleteInboxCategory.AdminDeleteInboxCategoryBuilder AdminDeleteInboxCategoryOp
        {
            get
            {
                var opBuilder = new Operation.AdminDeleteInboxCategory.AdminDeleteInboxCategoryBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminUpdateInboxCategory.AdminUpdateInboxCategoryBuilder AdminUpdateInboxCategoryOp
        {
            get
            {
                var opBuilder = new Operation.AdminUpdateInboxCategory.AdminUpdateInboxCategoryBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminGetCategorySchema.AdminGetCategorySchemaBuilder AdminGetCategorySchemaOp
        {
            get
            {
                var opBuilder = new Operation.AdminGetCategorySchema.AdminGetCategorySchemaBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminDeleteInboxMessage.AdminDeleteInboxMessageBuilder AdminDeleteInboxMessageOp
        {
            get
            {
                var opBuilder = new Operation.AdminDeleteInboxMessage.AdminDeleteInboxMessageBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminGetInboxMessages.AdminGetInboxMessagesBuilder AdminGetInboxMessagesOp
        {
            get
            {
                var opBuilder = new Operation.AdminGetInboxMessages.AdminGetInboxMessagesBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminSaveInboxMessage.AdminSaveInboxMessageBuilder AdminSaveInboxMessageOp
        {
            get
            {
                var opBuilder = new Operation.AdminSaveInboxMessage.AdminSaveInboxMessageBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminUnsendInboxMessage.AdminUnsendInboxMessageBuilder AdminUnsendInboxMessageOp
        {
            get
            {
                var opBuilder = new Operation.AdminUnsendInboxMessage.AdminUnsendInboxMessageBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminGetInboxUsers.AdminGetInboxUsersBuilder AdminGetInboxUsersOp
        {
            get
            {
                var opBuilder = new Operation.AdminGetInboxUsers.AdminGetInboxUsersBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminUpdateInboxMessage.AdminUpdateInboxMessageBuilder AdminUpdateInboxMessageOp
        {
            get
            {
                var opBuilder = new Operation.AdminUpdateInboxMessage.AdminUpdateInboxMessageBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminSendInboxMessage.AdminSendInboxMessageBuilder AdminSendInboxMessageOp
        {
            get
            {
                var opBuilder = new Operation.AdminSendInboxMessage.AdminSendInboxMessageBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminGetInboxStats.AdminGetInboxStatsBuilder AdminGetInboxStatsOp
        {
            get
            {
                var opBuilder = new Operation.AdminGetInboxStats.AdminGetInboxStatsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public AdminGetInboxCategories.Response AdminGetInboxCategories(AdminGetInboxCategories input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminGetInboxCategories.Response> AdminGetInboxCategoriesAsync(AdminGetInboxCategories input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public AdminGetInboxCategories.Response<T1> AdminGetInboxCategories<T1>(AdminGetInboxCategories input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminGetInboxCategories.Response<T1>> AdminGetInboxCategoriesAsync<T1>(AdminGetInboxCategories input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminAddInboxCategory.Response AdminAddInboxCategory(AdminAddInboxCategory input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminAddInboxCategory.Response> AdminAddInboxCategoryAsync(AdminAddInboxCategory input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public AdminAddInboxCategory.Response<T1> AdminAddInboxCategory<T1>(AdminAddInboxCategory input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminAddInboxCategory.Response<T1>> AdminAddInboxCategoryAsync<T1>(AdminAddInboxCategory input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminDeleteInboxCategory.Response AdminDeleteInboxCategory(AdminDeleteInboxCategory input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminDeleteInboxCategory.Response> AdminDeleteInboxCategoryAsync(AdminDeleteInboxCategory input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminUpdateInboxCategory.Response AdminUpdateInboxCategory(AdminUpdateInboxCategory input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminUpdateInboxCategory.Response> AdminUpdateInboxCategoryAsync(AdminUpdateInboxCategory input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminGetCategorySchema.Response AdminGetCategorySchema(AdminGetCategorySchema input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminGetCategorySchema.Response> AdminGetCategorySchemaAsync(AdminGetCategorySchema input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminDeleteInboxMessage.Response AdminDeleteInboxMessage(AdminDeleteInboxMessage input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminDeleteInboxMessage.Response> AdminDeleteInboxMessageAsync(AdminDeleteInboxMessage input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminGetInboxMessages.Response AdminGetInboxMessages(AdminGetInboxMessages input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminGetInboxMessages.Response> AdminGetInboxMessagesAsync(AdminGetInboxMessages input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminSaveInboxMessage.Response AdminSaveInboxMessage(AdminSaveInboxMessage input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminSaveInboxMessage.Response> AdminSaveInboxMessageAsync(AdminSaveInboxMessage input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public AdminSaveInboxMessage.Response<T1> AdminSaveInboxMessage<T1>(AdminSaveInboxMessage input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminSaveInboxMessage.Response<T1>> AdminSaveInboxMessageAsync<T1>(AdminSaveInboxMessage input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminUnsendInboxMessage.Response AdminUnsendInboxMessage(AdminUnsendInboxMessage input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminUnsendInboxMessage.Response> AdminUnsendInboxMessageAsync(AdminUnsendInboxMessage input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminGetInboxUsers.Response AdminGetInboxUsers(AdminGetInboxUsers input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminGetInboxUsers.Response> AdminGetInboxUsersAsync(AdminGetInboxUsers input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminUpdateInboxMessage.Response AdminUpdateInboxMessage(AdminUpdateInboxMessage input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminUpdateInboxMessage.Response> AdminUpdateInboxMessageAsync(AdminUpdateInboxMessage input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminSendInboxMessage.Response AdminSendInboxMessage(AdminSendInboxMessage input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminSendInboxMessage.Response> AdminSendInboxMessageAsync(AdminSendInboxMessage input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminGetInboxStats.Response AdminGetInboxStats(AdminGetInboxStats input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminGetInboxStats.Response> AdminGetInboxStatsAsync(AdminGetInboxStats input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}
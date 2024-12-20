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

using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;

namespace AccelByte.Sdk.Api.Lobby.Wrapper
{
    public class Profanity
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public Profanity(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public Profanity(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public AdminDebugProfanityFilters.AdminDebugProfanityFiltersBuilder AdminDebugProfanityFiltersOp
        {
            get
            {
                var opBuilder = new Operation.AdminDebugProfanityFilters.AdminDebugProfanityFiltersBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminGetProfanityListFiltersV1.AdminGetProfanityListFiltersV1Builder AdminGetProfanityListFiltersV1Op
        {
            get
            {
                var opBuilder = new Operation.AdminGetProfanityListFiltersV1.AdminGetProfanityListFiltersV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminAddProfanityFilterIntoList.AdminAddProfanityFilterIntoListBuilder AdminAddProfanityFilterIntoListOp
        {
            get
            {
                var opBuilder = new Operation.AdminAddProfanityFilterIntoList.AdminAddProfanityFilterIntoListBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminAddProfanityFilters.AdminAddProfanityFiltersBuilder AdminAddProfanityFiltersOp
        {
            get
            {
                var opBuilder = new Operation.AdminAddProfanityFilters.AdminAddProfanityFiltersBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminImportProfanityFiltersFromFile.AdminImportProfanityFiltersFromFileBuilder AdminImportProfanityFiltersFromFileOp
        {
            get
            {
                var opBuilder = new Operation.AdminImportProfanityFiltersFromFile.AdminImportProfanityFiltersFromFileBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminDeleteProfanityFilter.AdminDeleteProfanityFilterBuilder AdminDeleteProfanityFilterOp
        {
            get
            {
                var opBuilder = new Operation.AdminDeleteProfanityFilter.AdminDeleteProfanityFilterBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminGetProfanityLists.AdminGetProfanityListsBuilder AdminGetProfanityListsOp
        {
            get
            {
                var opBuilder = new Operation.AdminGetProfanityLists.AdminGetProfanityListsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminCreateProfanityList.AdminCreateProfanityListBuilder AdminCreateProfanityListOp
        {
            get
            {
                var opBuilder = new Operation.AdminCreateProfanityList.AdminCreateProfanityListBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminUpdateProfanityList.AdminUpdateProfanityListBuilder AdminUpdateProfanityListOp
        {
            get
            {
                var opBuilder = new Operation.AdminUpdateProfanityList.AdminUpdateProfanityListBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminDeleteProfanityList.AdminDeleteProfanityListBuilder AdminDeleteProfanityListOp
        {
            get
            {
                var opBuilder = new Operation.AdminDeleteProfanityList.AdminDeleteProfanityListBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminGetProfanityRule.AdminGetProfanityRuleBuilder AdminGetProfanityRuleOp
        {
            get
            {
                var opBuilder = new Operation.AdminGetProfanityRule.AdminGetProfanityRuleBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminSetProfanityRuleForNamespace.AdminSetProfanityRuleForNamespaceBuilder AdminSetProfanityRuleForNamespaceOp
        {
            get
            {
                var opBuilder = new Operation.AdminSetProfanityRuleForNamespace.AdminSetProfanityRuleForNamespaceBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminVerifyMessageProfanityResponse.AdminVerifyMessageProfanityResponseBuilder AdminVerifyMessageProfanityResponseOp
        {
            get
            {
                var opBuilder = new Operation.AdminVerifyMessageProfanityResponse.AdminVerifyMessageProfanityResponseBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public AdminDebugProfanityFilters.Response AdminDebugProfanityFilters(AdminDebugProfanityFilters input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminDebugProfanityFilters.Response> AdminDebugProfanityFiltersAsync(AdminDebugProfanityFilters input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminGetProfanityListFiltersV1.Response AdminGetProfanityListFiltersV1(AdminGetProfanityListFiltersV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminGetProfanityListFiltersV1.Response> AdminGetProfanityListFiltersV1Async(AdminGetProfanityListFiltersV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminAddProfanityFilterIntoList.Response AdminAddProfanityFilterIntoList(AdminAddProfanityFilterIntoList input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminAddProfanityFilterIntoList.Response> AdminAddProfanityFilterIntoListAsync(AdminAddProfanityFilterIntoList input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminAddProfanityFilters.Response AdminAddProfanityFilters(AdminAddProfanityFilters input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminAddProfanityFilters.Response> AdminAddProfanityFiltersAsync(AdminAddProfanityFilters input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminImportProfanityFiltersFromFile.Response AdminImportProfanityFiltersFromFile(AdminImportProfanityFiltersFromFile input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminImportProfanityFiltersFromFile.Response> AdminImportProfanityFiltersFromFileAsync(AdminImportProfanityFiltersFromFile input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminDeleteProfanityFilter.Response AdminDeleteProfanityFilter(AdminDeleteProfanityFilter input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminDeleteProfanityFilter.Response> AdminDeleteProfanityFilterAsync(AdminDeleteProfanityFilter input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminGetProfanityLists.Response AdminGetProfanityLists(AdminGetProfanityLists input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminGetProfanityLists.Response> AdminGetProfanityListsAsync(AdminGetProfanityLists input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminCreateProfanityList.Response AdminCreateProfanityList(AdminCreateProfanityList input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminCreateProfanityList.Response> AdminCreateProfanityListAsync(AdminCreateProfanityList input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminUpdateProfanityList.Response AdminUpdateProfanityList(AdminUpdateProfanityList input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminUpdateProfanityList.Response> AdminUpdateProfanityListAsync(AdminUpdateProfanityList input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminDeleteProfanityList.Response AdminDeleteProfanityList(AdminDeleteProfanityList input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminDeleteProfanityList.Response> AdminDeleteProfanityListAsync(AdminDeleteProfanityList input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminGetProfanityRule.Response AdminGetProfanityRule(AdminGetProfanityRule input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminGetProfanityRule.Response> AdminGetProfanityRuleAsync(AdminGetProfanityRule input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminSetProfanityRuleForNamespace.Response AdminSetProfanityRuleForNamespace(AdminSetProfanityRuleForNamespace input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminSetProfanityRuleForNamespace.Response> AdminSetProfanityRuleForNamespaceAsync(AdminSetProfanityRuleForNamespace input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminVerifyMessageProfanityResponse.Response AdminVerifyMessageProfanityResponse(AdminVerifyMessageProfanityResponse input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminVerifyMessageProfanityResponse.Response> AdminVerifyMessageProfanityResponseAsync(AdminVerifyMessageProfanityResponse input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}
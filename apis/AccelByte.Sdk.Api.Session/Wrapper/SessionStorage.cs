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

using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;

namespace AccelByte.Sdk.Api.Session.Wrapper
{
    public class SessionStorage
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public SessionStorage(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public SessionStorage(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public AdminReadSessionStorage.AdminReadSessionStorageBuilder AdminReadSessionStorageOp
        {
            get
            {
                var opBuilder = new Operation.AdminReadSessionStorage.AdminReadSessionStorageBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminDeleteUserSessionStorage.AdminDeleteUserSessionStorageBuilder AdminDeleteUserSessionStorageOp
        {
            get
            {
                var opBuilder = new Operation.AdminDeleteUserSessionStorage.AdminDeleteUserSessionStorageBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminReadUserSessionStorage.AdminReadUserSessionStorageBuilder AdminReadUserSessionStorageOp
        {
            get
            {
                var opBuilder = new Operation.AdminReadUserSessionStorage.AdminReadUserSessionStorageBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicUpdateInsertSessionStorageLeader.PublicUpdateInsertSessionStorageLeaderBuilder PublicUpdateInsertSessionStorageLeaderOp
        {
            get
            {
                var opBuilder = new Operation.PublicUpdateInsertSessionStorageLeader.PublicUpdateInsertSessionStorageLeaderBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicUpdateInsertSessionStorage.PublicUpdateInsertSessionStorageBuilder PublicUpdateInsertSessionStorageOp
        {
            get
            {
                var opBuilder = new Operation.PublicUpdateInsertSessionStorage.PublicUpdateInsertSessionStorageBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public Dictionary<string, object>? AdminReadSessionStorage(AdminReadSessionStorage input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Dictionary<string, object>?> AdminReadSessionStorageAsync(AdminReadSessionStorage input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteUserSessionStorage(AdminDeleteUserSessionStorage input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AdminDeleteUserSessionStorageAsync(AdminDeleteUserSessionStorage input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Dictionary<string, object>? AdminReadUserSessionStorage(AdminReadUserSessionStorage input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Dictionary<string, object>?> AdminReadUserSessionStorageAsync(AdminReadUserSessionStorage input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Dictionary<string, object>? PublicUpdateInsertSessionStorageLeader(PublicUpdateInsertSessionStorageLeader input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Dictionary<string, object>?> PublicUpdateInsertSessionStorageLeaderAsync(PublicUpdateInsertSessionStorageLeader input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Dictionary<string, object>? PublicUpdateInsertSessionStorage(PublicUpdateInsertSessionStorage input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Dictionary<string, object>?> PublicUpdateInsertSessionStorageAsync(PublicUpdateInsertSessionStorage input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}
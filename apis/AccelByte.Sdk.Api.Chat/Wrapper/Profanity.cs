// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Chat.Model;
using AccelByte.Sdk.Api.Chat.Operation;

namespace AccelByte.Sdk.Api.Chat.Wrapper
{
    public class Profanity
    {
        private readonly IAccelByteSdk _sdk;

        public Profanity(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminProfanityQuery.AdminProfanityQueryBuilder AdminProfanityQueryOp
        {
            get { return new Operation.AdminProfanityQuery.AdminProfanityQueryBuilder(_sdk); }
        }
        public AdminProfanityCreate.AdminProfanityCreateBuilder AdminProfanityCreateOp
        {
            get { return new Operation.AdminProfanityCreate.AdminProfanityCreateBuilder(_sdk); }
        }
        public AdminProfanityCreateBulk.AdminProfanityCreateBulkBuilder AdminProfanityCreateBulkOp
        {
            get { return new Operation.AdminProfanityCreateBulk.AdminProfanityCreateBulkBuilder(_sdk); }
        }
        public AdminProfanityExport.AdminProfanityExportBuilder AdminProfanityExportOp
        {
            get { return new Operation.AdminProfanityExport.AdminProfanityExportBuilder(_sdk); }
        }
        public AdminProfanityGroup.AdminProfanityGroupBuilder AdminProfanityGroupOp
        {
            get { return new Operation.AdminProfanityGroup.AdminProfanityGroupBuilder(_sdk); }
        }
        public AdminProfanityImport.AdminProfanityImportBuilder AdminProfanityImportOp
        {
            get { return new Operation.AdminProfanityImport.AdminProfanityImportBuilder(_sdk); }
        }
        public AdminProfanityUpdate.AdminProfanityUpdateBuilder AdminProfanityUpdateOp
        {
            get { return new Operation.AdminProfanityUpdate.AdminProfanityUpdateBuilder(_sdk); }
        }
        public AdminProfanityDelete.AdminProfanityDeleteBuilder AdminProfanityDeleteOp
        {
            get { return new Operation.AdminProfanityDelete.AdminProfanityDeleteBuilder(_sdk); }
        }
        #endregion

        public Model.ModelsDictionaryQueryResult? AdminProfanityQuery(AdminProfanityQuery input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDictionary? AdminProfanityCreate(AdminProfanityCreate input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDictionary? AdminProfanityCreateBulk(AdminProfanityCreateBulk input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDictionaryExport? AdminProfanityExport(AdminProfanityExport input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsDictionaryGroup>? AdminProfanityGroup(AdminProfanityGroup input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDictionaryImportResult? AdminProfanityImport(AdminProfanityImport input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDictionary? AdminProfanityUpdate(AdminProfanityUpdate input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminProfanityDelete(AdminProfanityDelete input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}
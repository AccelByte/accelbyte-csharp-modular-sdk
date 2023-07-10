// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Api.Gdpr.Operation;

namespace AccelByte.Sdk.Api.Gdpr.Wrapper
{
    public class DataDeletion
    {
        private readonly IAccelByteSdk _sdk;

        public DataDeletion(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetListDeletionDataRequest.AdminGetListDeletionDataRequestBuilder AdminGetListDeletionDataRequestOp
        {
            get { return new Operation.AdminGetListDeletionDataRequest.AdminGetListDeletionDataRequestBuilder(_sdk); }
        }
        public AdminGetUserAccountDeletionRequest.AdminGetUserAccountDeletionRequestBuilder AdminGetUserAccountDeletionRequestOp
        {
            get { return new Operation.AdminGetUserAccountDeletionRequest.AdminGetUserAccountDeletionRequestBuilder(_sdk); }
        }
        public AdminSubmitUserAccountDeletionRequest.AdminSubmitUserAccountDeletionRequestBuilder AdminSubmitUserAccountDeletionRequestOp
        {
            get { return new Operation.AdminSubmitUserAccountDeletionRequest.AdminSubmitUserAccountDeletionRequestBuilder(_sdk); }
        }
        public AdminCancelUserAccountDeletionRequest.AdminCancelUserAccountDeletionRequestBuilder AdminCancelUserAccountDeletionRequestOp
        {
            get { return new Operation.AdminCancelUserAccountDeletionRequest.AdminCancelUserAccountDeletionRequestBuilder(_sdk); }
        }
        public PublicSubmitUserAccountDeletionRequest.PublicSubmitUserAccountDeletionRequestBuilder PublicSubmitUserAccountDeletionRequestOp
        {
            get { return new Operation.PublicSubmitUserAccountDeletionRequest.PublicSubmitUserAccountDeletionRequestBuilder(_sdk); }
        }
        public PublicCancelUserAccountDeletionRequest.PublicCancelUserAccountDeletionRequestBuilder PublicCancelUserAccountDeletionRequestOp
        {
            get { return new Operation.PublicCancelUserAccountDeletionRequest.PublicCancelUserAccountDeletionRequestBuilder(_sdk); }
        }
        public PublicGetUserAccountDeletionStatus.PublicGetUserAccountDeletionStatusBuilder PublicGetUserAccountDeletionStatusOp
        {
            get { return new Operation.PublicGetUserAccountDeletionStatus.PublicGetUserAccountDeletionStatusBuilder(_sdk); }
        }
        #endregion

        public Model.ModelsListDeletionDataResponse? AdminGetListDeletionDataRequest(AdminGetListDeletionDataRequest input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeletionData? AdminGetUserAccountDeletionRequest(AdminGetUserAccountDeletionRequest input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsRequestDeleteResponse? AdminSubmitUserAccountDeletionRequest(AdminSubmitUserAccountDeletionRequest input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminCancelUserAccountDeletionRequest(AdminCancelUserAccountDeletionRequest input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsRequestDeleteResponse? PublicSubmitUserAccountDeletionRequest(PublicSubmitUserAccountDeletionRequest input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicCancelUserAccountDeletionRequest(PublicCancelUserAccountDeletionRequest input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeletionStatus? PublicGetUserAccountDeletionStatus(PublicGetUserAccountDeletionStatus input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}
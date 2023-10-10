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
    public class DataRetrieval
    {
        private readonly IAccelByteSdk _sdk;

        public DataRetrieval(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetListPersonalDataRequest.AdminGetListPersonalDataRequestBuilder AdminGetListPersonalDataRequestOp
        {
            get { return new Operation.AdminGetListPersonalDataRequest.AdminGetListPersonalDataRequestBuilder(_sdk); }
        }
        public AdminGetUserPersonalDataRequests.AdminGetUserPersonalDataRequestsBuilder AdminGetUserPersonalDataRequestsOp
        {
            get { return new Operation.AdminGetUserPersonalDataRequests.AdminGetUserPersonalDataRequestsBuilder(_sdk); }
        }
        public AdminRequestDataRetrieval.AdminRequestDataRetrievalBuilder AdminRequestDataRetrievalOp
        {
            get { return new Operation.AdminRequestDataRetrieval.AdminRequestDataRetrievalBuilder(_sdk); }
        }
        public AdminCancelUserPersonalDataRequest.AdminCancelUserPersonalDataRequestBuilder AdminCancelUserPersonalDataRequestOp
        {
            get { return new Operation.AdminCancelUserPersonalDataRequest.AdminCancelUserPersonalDataRequestBuilder(_sdk); }
        }
        public AdminGeneratePersonalDataURL.AdminGeneratePersonalDataURLBuilder AdminGeneratePersonalDataURLOp
        {
            get { return new Operation.AdminGeneratePersonalDataURL.AdminGeneratePersonalDataURLBuilder(_sdk); }
        }
        public PublicGetUserPersonalDataRequests.PublicGetUserPersonalDataRequestsBuilder PublicGetUserPersonalDataRequestsOp
        {
            get { return new Operation.PublicGetUserPersonalDataRequests.PublicGetUserPersonalDataRequestsBuilder(_sdk); }
        }
        public PublicRequestDataRetrieval.PublicRequestDataRetrievalBuilder PublicRequestDataRetrievalOp
        {
            get { return new Operation.PublicRequestDataRetrieval.PublicRequestDataRetrievalBuilder(_sdk); }
        }
        public PublicCancelUserPersonalDataRequest.PublicCancelUserPersonalDataRequestBuilder PublicCancelUserPersonalDataRequestOp
        {
            get { return new Operation.PublicCancelUserPersonalDataRequest.PublicCancelUserPersonalDataRequestBuilder(_sdk); }
        }
        public PublicGeneratePersonalDataURL.PublicGeneratePersonalDataURLBuilder PublicGeneratePersonalDataURLOp
        {
            get { return new Operation.PublicGeneratePersonalDataURL.PublicGeneratePersonalDataURLBuilder(_sdk); }
        }
        #endregion

        public Model.ModelsListPersonalDataResponse? AdminGetListPersonalDataRequest(AdminGetListPersonalDataRequest input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUserPersonalDataResponse? AdminGetUserPersonalDataRequests(AdminGetUserPersonalDataRequests input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDataRetrievalResponse? AdminRequestDataRetrieval(AdminRequestDataRetrieval input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminCancelUserPersonalDataRequest(AdminCancelUserPersonalDataRequest input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUserDataURL? AdminGeneratePersonalDataURL(AdminGeneratePersonalDataURL input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUserPersonalDataResponse? PublicGetUserPersonalDataRequests(PublicGetUserPersonalDataRequests input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDataRetrievalResponse? PublicRequestDataRetrieval(PublicRequestDataRetrieval input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicCancelUserPersonalDataRequest(PublicCancelUserPersonalDataRequest input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUserDataURL? PublicGeneratePersonalDataURL(PublicGeneratePersonalDataURL input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}
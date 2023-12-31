// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class Section
    {
        private readonly IAccelByteSdk _sdk;

        public Section(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public QuerySections.QuerySectionsBuilder QuerySectionsOp
        {
            get { return new Operation.QuerySections.QuerySectionsBuilder(_sdk); }
        }
        public CreateSection.CreateSectionBuilder CreateSectionOp
        {
            get { return new Operation.CreateSection.CreateSectionBuilder(_sdk); }
        }
        public PurgeExpiredSection.PurgeExpiredSectionBuilder PurgeExpiredSectionOp
        {
            get { return new Operation.PurgeExpiredSection.PurgeExpiredSectionBuilder(_sdk); }
        }
        public GetSection.GetSectionBuilder GetSectionOp
        {
            get { return new Operation.GetSection.GetSectionBuilder(_sdk); }
        }
        public UpdateSection.UpdateSectionBuilder UpdateSectionOp
        {
            get { return new Operation.UpdateSection.UpdateSectionBuilder(_sdk); }
        }
        public DeleteSection.DeleteSectionBuilder DeleteSectionOp
        {
            get { return new Operation.DeleteSection.DeleteSectionBuilder(_sdk); }
        }
        public PublicListActiveSections.PublicListActiveSectionsBuilder PublicListActiveSectionsOp
        {
            get { return new Operation.PublicListActiveSections.PublicListActiveSectionsBuilder(_sdk); }
        }
        #endregion

        public Model.SectionPagingSlicedResult? QuerySections(QuerySections input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullSectionInfo? CreateSection(CreateSection input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.FullSectionInfo<T1>? CreateSection<T1>(CreateSection input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PurgeExpiredSection(PurgeExpiredSection input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullSectionInfo? GetSection(GetSection input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.FullSectionInfo<T1>? GetSection<T1>(GetSection input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullSectionInfo? UpdateSection(UpdateSection input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.FullSectionInfo<T1>? UpdateSection<T1>(UpdateSection input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteSection(DeleteSection input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.SectionInfo>? PublicListActiveSections(PublicListActiveSections input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public List<Model.SectionInfo<T1, T2>>? PublicListActiveSections<T1, T2>(PublicListActiveSections input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}
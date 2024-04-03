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

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class CatalogChanges
    {
        private readonly IAccelByteSdk _sdk;

        public CatalogChanges(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public QueryChanges.QueryChangesBuilder QueryChangesOp
        {
            get { return new Operation.QueryChanges.QueryChangesBuilder(_sdk); }
        }
        public PublishAll.PublishAllBuilder PublishAllOp
        {
            get { return new Operation.PublishAll.PublishAllBuilder(_sdk); }
        }
        public PublishSelected.PublishSelectedBuilder PublishSelectedOp
        {
            get { return new Operation.PublishSelected.PublishSelectedBuilder(_sdk); }
        }
        public SelectAllRecords.SelectAllRecordsBuilder SelectAllRecordsOp
        {
            get { return new Operation.SelectAllRecords.SelectAllRecordsBuilder(_sdk); }
        }
        public SelectAllRecordsByCriteria.SelectAllRecordsByCriteriaBuilder SelectAllRecordsByCriteriaOp
        {
            get { return new Operation.SelectAllRecordsByCriteria.SelectAllRecordsByCriteriaBuilder(_sdk); }
        }
        public GetStatistic.GetStatisticBuilder GetStatisticOp
        {
            get { return new Operation.GetStatistic.GetStatisticBuilder(_sdk); }
        }
        public UnselectAllRecords.UnselectAllRecordsBuilder UnselectAllRecordsOp
        {
            get { return new Operation.UnselectAllRecords.UnselectAllRecordsBuilder(_sdk); }
        }
        public SelectRecord.SelectRecordBuilder SelectRecordOp
        {
            get { return new Operation.SelectRecord.SelectRecordBuilder(_sdk); }
        }
        public UnselectRecord.UnselectRecordBuilder UnselectRecordOp
        {
            get { return new Operation.UnselectRecord.UnselectRecordBuilder(_sdk); }
        }
        #endregion

        public Model.CatalogChangePagingResult? QueryChanges(QueryChanges input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.CatalogChangePagingResult?> QueryChangesAsync(QueryChanges input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.StoreInfo? PublishAll(PublishAll input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.StoreInfo?> PublishAllAsync(PublishAll input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.StoreInfo? PublishSelected(PublishSelected input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.StoreInfo?> PublishSelectedAsync(PublishSelected input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void SelectAllRecords(SelectAllRecords input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task SelectAllRecordsAsync(SelectAllRecords input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void SelectAllRecordsByCriteria(SelectAllRecordsByCriteria input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task SelectAllRecordsByCriteriaAsync(SelectAllRecordsByCriteria input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.CatalogChangeStatistics? GetStatistic(GetStatistic input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.CatalogChangeStatistics?> GetStatisticAsync(GetStatistic input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void UnselectAllRecords(UnselectAllRecords input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task UnselectAllRecordsAsync(UnselectAllRecords input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void SelectRecord(SelectRecord input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task SelectRecordAsync(SelectRecord input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void UnselectRecord(UnselectRecord input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task UnselectRecordAsync(UnselectRecord input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}
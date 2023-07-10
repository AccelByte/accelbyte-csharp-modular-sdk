// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;

namespace AccelByte.Sdk.Api.Social.Wrapper
{
    public class StatCycleConfiguration
    {
        private readonly IAccelByteSdk _sdk;

        public StatCycleConfiguration(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetStatCycles.GetStatCyclesBuilder GetStatCyclesOp
        {
            get { return new Operation.GetStatCycles.GetStatCyclesBuilder(_sdk); }
        }
        public CreateStatCycle.CreateStatCycleBuilder CreateStatCycleOp
        {
            get { return new Operation.CreateStatCycle.CreateStatCycleBuilder(_sdk); }
        }
        public BulkGetStatCycle.BulkGetStatCycleBuilder BulkGetStatCycleOp
        {
            get { return new Operation.BulkGetStatCycle.BulkGetStatCycleBuilder(_sdk); }
        }
        public GetStatCycle.GetStatCycleBuilder GetStatCycleOp
        {
            get { return new Operation.GetStatCycle.GetStatCycleBuilder(_sdk); }
        }
        public UpdateStatCycle.UpdateStatCycleBuilder UpdateStatCycleOp
        {
            get { return new Operation.UpdateStatCycle.UpdateStatCycleBuilder(_sdk); }
        }
        public DeleteStatCycle.DeleteStatCycleBuilder DeleteStatCycleOp
        {
            get { return new Operation.DeleteStatCycle.DeleteStatCycleBuilder(_sdk); }
        }
        public BulkAddStats.BulkAddStatsBuilder BulkAddStatsOp
        {
            get { return new Operation.BulkAddStats.BulkAddStatsBuilder(_sdk); }
        }
        public StopStatCycle.StopStatCycleBuilder StopStatCycleOp
        {
            get { return new Operation.StopStatCycle.StopStatCycleBuilder(_sdk); }
        }
        public GetStatCycles1.GetStatCycles1Builder GetStatCycles1Op
        {
            get { return new Operation.GetStatCycles1.GetStatCycles1Builder(_sdk); }
        }
        public BulkGetStatCycle1.BulkGetStatCycle1Builder BulkGetStatCycle1Op
        {
            get { return new Operation.BulkGetStatCycle1.BulkGetStatCycle1Builder(_sdk); }
        }
        public GetStatCycle1.GetStatCycle1Builder GetStatCycle1Op
        {
            get { return new Operation.GetStatCycle1.GetStatCycle1Builder(_sdk); }
        }
        #endregion

        public Model.StatCyclePagingSlicedResult? GetStatCycles(GetStatCycles input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatCycleInfo? CreateStatCycle(CreateStatCycle input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.BulkStatCycleResult? BulkGetStatCycle(BulkGetStatCycle input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatCycleInfo? GetStatCycle(GetStatCycle input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatCycleInfo? UpdateStatCycle(UpdateStatCycle input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteStatCycle(DeleteStatCycle input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatOperationResult>? BulkAddStats(BulkAddStats input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public List<Model.BulkStatOperationResult<T1>>? BulkAddStats<T1>(BulkAddStats input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatCycleInfo? StopStatCycle(StopStatCycle input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatCyclePagingSlicedResult? GetStatCycles1(GetStatCycles1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.BulkStatCycleResult? BulkGetStatCycle1(BulkGetStatCycle1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatCycleInfo? GetStatCycle1(GetStatCycle1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}
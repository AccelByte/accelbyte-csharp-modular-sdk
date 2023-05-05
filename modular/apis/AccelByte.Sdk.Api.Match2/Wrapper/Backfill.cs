// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Match2.Model;
using AccelByte.Sdk.Api.Match2.Operation;

namespace AccelByte.Sdk.Api.Match2.Wrapper
{
    public class Backfill
    {
        private readonly IAccelByteSdk _sdk;

        public Backfill(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public CreateBackfill.CreateBackfillBuilder CreateBackfillOp
        {
            get { return new Operation.CreateBackfill.CreateBackfillBuilder(_sdk); }
        }
        public GetBackfillProposal.GetBackfillProposalBuilder GetBackfillProposalOp
        {
            get { return new Operation.GetBackfillProposal.GetBackfillProposalBuilder(_sdk); }
        }
        public GetBackfill.GetBackfillBuilder GetBackfillOp
        {
            get { return new Operation.GetBackfill.GetBackfillBuilder(_sdk); }
        }
        public DeleteBackfill.DeleteBackfillBuilder DeleteBackfillOp
        {
            get { return new Operation.DeleteBackfill.DeleteBackfillBuilder(_sdk); }
        }
        public AcceptBackfill.AcceptBackfillBuilder AcceptBackfillOp
        {
            get { return new Operation.AcceptBackfill.AcceptBackfillBuilder(_sdk); }
        }
        public RejectBackfill.RejectBackfillBuilder RejectBackfillOp
        {
            get { return new Operation.RejectBackfill.RejectBackfillBuilder(_sdk); }
        }
        #endregion
        
        public Model.ApiBackfillCreateResponse? CreateBackfill(CreateBackfill input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApiBackfillProposalResponse? GetBackfillProposal(GetBackfillProposal input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApiBackfillGetResponse? GetBackfill(GetBackfill input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteBackfill(DeleteBackfill input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AcceptBackfill(AcceptBackfill input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void RejectBackfill(RejectBackfill input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}
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

using AccelByte.Sdk.Api.Sessionhistory.Model;
using AccelByte.Sdk.Api.Sessionhistory.Operation;

namespace AccelByte.Sdk.Api.Sessionhistory.Wrapper
{
    public class XRay
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public XRay(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public XRay(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public CreateXrayTicketObservability.CreateXrayTicketObservabilityBuilder CreateXrayTicketObservabilityOp
        {
            get
            {
                var opBuilder = new Operation.CreateXrayTicketObservability.CreateXrayTicketObservabilityBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CreateXrayBulkTicketObservability.CreateXrayBulkTicketObservabilityBuilder CreateXrayBulkTicketObservabilityOp
        {
            get
            {
                var opBuilder = new Operation.CreateXrayBulkTicketObservability.CreateXrayBulkTicketObservabilityBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public CreateXrayTicketObservability.Response CreateXrayTicketObservability(CreateXrayTicketObservability input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<CreateXrayTicketObservability.Response> CreateXrayTicketObservabilityAsync(CreateXrayTicketObservability input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public CreateXrayBulkTicketObservability.Response CreateXrayBulkTicketObservability(CreateXrayBulkTicketObservability input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<CreateXrayBulkTicketObservability.Response> CreateXrayBulkTicketObservabilityAsync(CreateXrayBulkTicketObservability input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}
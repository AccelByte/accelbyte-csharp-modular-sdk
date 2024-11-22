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

using AccelByte.Sdk.Api.Csm.Model;
using AccelByte.Sdk.Api.Csm.Operation;

namespace AccelByte.Sdk.Api.Csm.Wrapper
{
    public class Deployment
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public Deployment(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public Deployment(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public CreateDeploymentV1.CreateDeploymentV1Builder CreateDeploymentV1Op
        {
            get
            {
                var opBuilder = new Operation.CreateDeploymentV1.CreateDeploymentV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public GetListOfDeploymentV1.GetListOfDeploymentV1Builder GetListOfDeploymentV1Op
        {
            get
            {
                var opBuilder = new Operation.GetListOfDeploymentV1.GetListOfDeploymentV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public GetDeploymentV1.GetDeploymentV1Builder GetDeploymentV1Op
        {
            get
            {
                var opBuilder = new Operation.GetDeploymentV1.GetDeploymentV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public DeleteDeploymentV1.DeleteDeploymentV1Builder DeleteDeploymentV1Op
        {
            get
            {
                var opBuilder = new Operation.DeleteDeploymentV1.DeleteDeploymentV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public CreateDeploymentV1.Response CreateDeploymentV1(CreateDeploymentV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<CreateDeploymentV1.Response> CreateDeploymentV1Async(CreateDeploymentV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public GetListOfDeploymentV1.Response GetListOfDeploymentV1(GetListOfDeploymentV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetListOfDeploymentV1.Response> GetListOfDeploymentV1Async(GetListOfDeploymentV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public GetDeploymentV1.Response GetDeploymentV1(GetDeploymentV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetDeploymentV1.Response> GetDeploymentV1Async(GetDeploymentV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public DeleteDeploymentV1.Response DeleteDeploymentV1(DeleteDeploymentV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DeleteDeploymentV1.Response> DeleteDeploymentV1Async(DeleteDeploymentV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
    }
}
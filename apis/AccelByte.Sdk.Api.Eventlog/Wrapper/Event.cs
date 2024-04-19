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

using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Api.Eventlog.Operation;

namespace AccelByte.Sdk.Api.Eventlog.Wrapper
{
    public class Event
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public Event(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public Event(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetEventByNamespaceHandler.GetEventByNamespaceHandlerBuilder GetEventByNamespaceHandlerOp
        {
            get
            {
                var opBuilder = new Operation.GetEventByNamespaceHandler.GetEventByNamespaceHandlerBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public PostEventHandler.PostEventHandlerBuilder PostEventHandlerOp
        {
            get
            {
                var opBuilder = new Operation.PostEventHandler.PostEventHandlerBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetEventByEventIDHandler.GetEventByEventIDHandlerBuilder GetEventByEventIDHandlerOp
        {
            get
            {
                var opBuilder = new Operation.GetEventByEventIDHandler.GetEventByEventIDHandlerBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetEventByEventTypeHandler.GetEventByEventTypeHandlerBuilder GetEventByEventTypeHandlerOp
        {
            get
            {
                var opBuilder = new Operation.GetEventByEventTypeHandler.GetEventByEventTypeHandlerBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetEventByEventTypeAndEventIDHandler.GetEventByEventTypeAndEventIDHandlerBuilder GetEventByEventTypeAndEventIDHandlerOp
        {
            get
            {
                var opBuilder = new Operation.GetEventByEventTypeAndEventIDHandler.GetEventByEventTypeAndEventIDHandlerBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetEventByUserIDHandler.GetEventByUserIDHandlerBuilder GetEventByUserIDHandlerOp
        {
            get
            {
                var opBuilder = new Operation.GetEventByUserIDHandler.GetEventByUserIDHandlerBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetEventByUserIDAndEventIDHandler.GetEventByUserIDAndEventIDHandlerBuilder GetEventByUserIDAndEventIDHandlerOp
        {
            get
            {
                var opBuilder = new Operation.GetEventByUserIDAndEventIDHandler.GetEventByUserIDAndEventIDHandlerBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetEventByUserIDAndEventTypeHandler.GetEventByUserIDAndEventTypeHandlerBuilder GetEventByUserIDAndEventTypeHandlerOp
        {
            get
            {
                var opBuilder = new Operation.GetEventByUserIDAndEventTypeHandler.GetEventByUserIDAndEventTypeHandlerBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetEventByUserEventIDAndEventTypeHandler.GetEventByUserEventIDAndEventTypeHandlerBuilder GetEventByUserEventIDAndEventTypeHandlerOp
        {
            get
            {
                var opBuilder = new Operation.GetEventByUserEventIDAndEventTypeHandler.GetEventByUserEventIDAndEventTypeHandlerBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.ModelsEventResponse? GetEventByNamespaceHandler(GetEventByNamespaceHandler input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsEventResponse?> GetEventByNamespaceHandlerAsync(GetEventByNamespaceHandler input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public void PostEventHandler(PostEventHandler input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task PostEventHandlerAsync(PostEventHandler input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.ModelsEventResponse? GetEventByEventIDHandler(GetEventByEventIDHandler input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsEventResponse?> GetEventByEventIDHandlerAsync(GetEventByEventIDHandler input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.ModelsEventResponse? GetEventByEventTypeHandler(GetEventByEventTypeHandler input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsEventResponse?> GetEventByEventTypeHandlerAsync(GetEventByEventTypeHandler input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.ModelsEventResponse? GetEventByEventTypeAndEventIDHandler(GetEventByEventTypeAndEventIDHandler input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsEventResponse?> GetEventByEventTypeAndEventIDHandlerAsync(GetEventByEventTypeAndEventIDHandler input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.ModelsEventResponse? GetEventByUserIDHandler(GetEventByUserIDHandler input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsEventResponse?> GetEventByUserIDHandlerAsync(GetEventByUserIDHandler input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.ModelsEventResponse? GetEventByUserIDAndEventIDHandler(GetEventByUserIDAndEventIDHandler input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsEventResponse?> GetEventByUserIDAndEventIDHandlerAsync(GetEventByUserIDAndEventIDHandler input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.ModelsEventResponse? GetEventByUserIDAndEventTypeHandler(GetEventByUserIDAndEventTypeHandler input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsEventResponse?> GetEventByUserIDAndEventTypeHandlerAsync(GetEventByUserIDAndEventTypeHandler input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.ModelsEventResponse? GetEventByUserEventIDAndEventTypeHandler(GetEventByUserEventIDAndEventTypeHandler input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsEventResponse?> GetEventByUserEventIDAndEventTypeHandlerAsync(GetEventByUserEventIDAndEventTypeHandler input)
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
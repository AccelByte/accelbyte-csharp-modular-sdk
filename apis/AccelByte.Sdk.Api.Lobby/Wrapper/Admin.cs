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

using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;

namespace AccelByte.Sdk.Api.Lobby.Wrapper
{
    public class Admin
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public Admin(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public Admin(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public AdminGetGlobalConfig.AdminGetGlobalConfigBuilder AdminGetGlobalConfigOp
        {
            get
            {
                var opBuilder = new Operation.AdminGetGlobalConfig.AdminGetGlobalConfigBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public AdminUpdateGlobalConfig.AdminUpdateGlobalConfigBuilder AdminUpdateGlobalConfigOp
        {
            get
            {
                var opBuilder = new Operation.AdminUpdateGlobalConfig.AdminUpdateGlobalConfigBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public AdminDeleteGlobalConfig.AdminDeleteGlobalConfigBuilder AdminDeleteGlobalConfigOp
        {
            get
            {
                var opBuilder = new Operation.AdminDeleteGlobalConfig.AdminDeleteGlobalConfigBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public FreeFormNotification.FreeFormNotificationBuilder FreeFormNotificationOp
        {
            get
            {
                var opBuilder = new Operation.FreeFormNotification.FreeFormNotificationBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public NotificationWithTemplate.NotificationWithTemplateBuilder NotificationWithTemplateOp
        {
            get
            {
                var opBuilder = new Operation.NotificationWithTemplate.NotificationWithTemplateBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetGameTemplate.GetGameTemplateBuilder GetGameTemplateOp
        {
            get
            {
                var opBuilder = new Operation.GetGameTemplate.GetGameTemplateBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CreateTemplate.CreateTemplateBuilder CreateTemplateOp
        {
            get
            {
                var opBuilder = new Operation.CreateTemplate.CreateTemplateBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetSlugTemplate.GetSlugTemplateBuilder GetSlugTemplateOp
        {
            get
            {
                var opBuilder = new Operation.GetSlugTemplate.GetSlugTemplateBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteTemplateSlug.DeleteTemplateSlugBuilder DeleteTemplateSlugOp
        {
            get
            {
                var opBuilder = new Operation.DeleteTemplateSlug.DeleteTemplateSlugBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetLocalizationTemplate.GetLocalizationTemplateBuilder GetLocalizationTemplateOp
        {
            get
            {
                var opBuilder = new Operation.GetLocalizationTemplate.GetLocalizationTemplateBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateLocalizationTemplate.UpdateLocalizationTemplateBuilder UpdateLocalizationTemplateOp
        {
            get
            {
                var opBuilder = new Operation.UpdateLocalizationTemplate.UpdateLocalizationTemplateBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteTemplateLocalization.DeleteTemplateLocalizationBuilder DeleteTemplateLocalizationOp
        {
            get
            {
                var opBuilder = new Operation.DeleteTemplateLocalization.DeleteTemplateLocalizationBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublishTemplate.PublishTemplateBuilder PublishTemplateOp
        {
            get
            {
                var opBuilder = new Operation.PublishTemplate.PublishTemplateBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public AdminGetGlobalConfig.Response AdminGetGlobalConfig(AdminGetGlobalConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminGetGlobalConfig.Response> AdminGetGlobalConfigAsync(AdminGetGlobalConfig input)
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
        public AdminUpdateGlobalConfig.Response AdminUpdateGlobalConfig(AdminUpdateGlobalConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminUpdateGlobalConfig.Response> AdminUpdateGlobalConfigAsync(AdminUpdateGlobalConfig input)
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
        public AdminDeleteGlobalConfig.Response AdminDeleteGlobalConfig(AdminDeleteGlobalConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminDeleteGlobalConfig.Response> AdminDeleteGlobalConfigAsync(AdminDeleteGlobalConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
        public FreeFormNotification.Response FreeFormNotification(FreeFormNotification input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<FreeFormNotification.Response> FreeFormNotificationAsync(FreeFormNotification input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public NotificationWithTemplate.Response NotificationWithTemplate(NotificationWithTemplate input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<NotificationWithTemplate.Response> NotificationWithTemplateAsync(NotificationWithTemplate input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetGameTemplate.Response GetGameTemplate(GetGameTemplate input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetGameTemplate.Response> GetGameTemplateAsync(GetGameTemplate input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public CreateTemplate.Response CreateTemplate(CreateTemplate input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<CreateTemplate.Response> CreateTemplateAsync(CreateTemplate input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetSlugTemplate.Response GetSlugTemplate(GetSlugTemplate input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetSlugTemplate.Response> GetSlugTemplateAsync(GetSlugTemplate input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public DeleteTemplateSlug.Response DeleteTemplateSlug(DeleteTemplateSlug input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DeleteTemplateSlug.Response> DeleteTemplateSlugAsync(DeleteTemplateSlug input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetLocalizationTemplate.Response GetLocalizationTemplate(GetLocalizationTemplate input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetLocalizationTemplate.Response> GetLocalizationTemplateAsync(GetLocalizationTemplate input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public UpdateLocalizationTemplate.Response UpdateLocalizationTemplate(UpdateLocalizationTemplate input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<UpdateLocalizationTemplate.Response> UpdateLocalizationTemplateAsync(UpdateLocalizationTemplate input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public DeleteTemplateLocalization.Response DeleteTemplateLocalization(DeleteTemplateLocalization input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DeleteTemplateLocalization.Response> DeleteTemplateLocalizationAsync(DeleteTemplateLocalization input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublishTemplate.Response PublishTemplate(PublishTemplate input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublishTemplate.Response> PublishTemplateAsync(PublishTemplate input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}
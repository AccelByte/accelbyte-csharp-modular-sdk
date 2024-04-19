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

        public Model.ModelGlobalConfiguration? AdminGetGlobalConfig(AdminGetGlobalConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelGlobalConfiguration?> AdminGetGlobalConfigAsync(AdminGetGlobalConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelGlobalConfiguration? AdminUpdateGlobalConfig(AdminUpdateGlobalConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelGlobalConfiguration?> AdminUpdateGlobalConfigAsync(AdminUpdateGlobalConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public string? AdminDeleteGlobalConfig(AdminDeleteGlobalConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<string?> AdminDeleteGlobalConfigAsync(AdminDeleteGlobalConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void FreeFormNotification(FreeFormNotification input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task FreeFormNotificationAsync(FreeFormNotification input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void NotificationWithTemplate(NotificationWithTemplate input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task NotificationWithTemplateAsync(NotificationWithTemplate input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelTemplateResponse>? GetGameTemplate(GetGameTemplate input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.ModelTemplateResponse>?> GetGameTemplateAsync(GetGameTemplate input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void CreateTemplate(CreateTemplate input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task CreateTemplateAsync(CreateTemplate input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelTemplateLocalizationResponse? GetSlugTemplate(GetSlugTemplate input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelTemplateLocalizationResponse?> GetSlugTemplateAsync(GetSlugTemplate input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteTemplateSlug(DeleteTemplateSlug input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteTemplateSlugAsync(DeleteTemplateSlug input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelTemplateLocalization? GetLocalizationTemplate(GetLocalizationTemplate input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelTemplateLocalization?> GetLocalizationTemplateAsync(GetLocalizationTemplate input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void UpdateLocalizationTemplate(UpdateLocalizationTemplate input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task UpdateLocalizationTemplateAsync(UpdateLocalizationTemplate input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteTemplateLocalization(DeleteTemplateLocalization input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteTemplateLocalizationAsync(DeleteTemplateLocalization input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublishTemplate(PublishTemplate input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task PublishTemplateAsync(PublishTemplate input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}
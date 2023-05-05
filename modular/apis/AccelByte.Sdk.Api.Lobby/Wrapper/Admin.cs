// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;

namespace AccelByte.Sdk.Api.Lobby.Wrapper
{
    public class Admin
    {
        private readonly IAccelByteSdk _sdk;

        public Admin(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public FreeFormNotification.FreeFormNotificationBuilder FreeFormNotificationOp
        {
            get { return new Operation.FreeFormNotification.FreeFormNotificationBuilder(_sdk); }
        }
        public NotificationWithTemplate.NotificationWithTemplateBuilder NotificationWithTemplateOp
        {
            get { return new Operation.NotificationWithTemplate.NotificationWithTemplateBuilder(_sdk); }
        }
        public GetGameTemplate.GetGameTemplateBuilder GetGameTemplateOp
        {
            get { return new Operation.GetGameTemplate.GetGameTemplateBuilder(_sdk); }
        }
        public CreateTemplate.CreateTemplateBuilder CreateTemplateOp
        {
            get { return new Operation.CreateTemplate.CreateTemplateBuilder(_sdk); }
        }
        public GetSlugTemplate.GetSlugTemplateBuilder GetSlugTemplateOp
        {
            get { return new Operation.GetSlugTemplate.GetSlugTemplateBuilder(_sdk); }
        }
        public DeleteTemplateSlug.DeleteTemplateSlugBuilder DeleteTemplateSlugOp
        {
            get { return new Operation.DeleteTemplateSlug.DeleteTemplateSlugBuilder(_sdk); }
        }
        public GetLocalizationTemplate.GetLocalizationTemplateBuilder GetLocalizationTemplateOp
        {
            get { return new Operation.GetLocalizationTemplate.GetLocalizationTemplateBuilder(_sdk); }
        }
        public UpdateLocalizationTemplate.UpdateLocalizationTemplateBuilder UpdateLocalizationTemplateOp
        {
            get { return new Operation.UpdateLocalizationTemplate.UpdateLocalizationTemplateBuilder(_sdk); }
        }
        public DeleteTemplateLocalization.DeleteTemplateLocalizationBuilder DeleteTemplateLocalizationOp
        {
            get { return new Operation.DeleteTemplateLocalization.DeleteTemplateLocalizationBuilder(_sdk); }
        }
        public PublishTemplate.PublishTemplateBuilder PublishTemplateOp
        {
            get { return new Operation.PublishTemplate.PublishTemplateBuilder(_sdk); }
        }
        #endregion
        
        public void FreeFormNotification(FreeFormNotification input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void NotificationWithTemplate(NotificationWithTemplate input) {
            var response = _sdk.RunRequest(input);

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
        public void CreateTemplate(CreateTemplate input) {
            var response = _sdk.RunRequest(input);

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
        public void DeleteTemplateSlug(DeleteTemplateSlug input) {
            var response = _sdk.RunRequest(input);

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
        public void UpdateLocalizationTemplate(UpdateLocalizationTemplate input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteTemplateLocalization(DeleteTemplateLocalization input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublishTemplate(PublishTemplate input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}
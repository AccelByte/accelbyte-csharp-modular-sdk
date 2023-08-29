// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class InputValidations
    {
        private readonly IAccelByteSdk _sdk;

        public InputValidations(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetInputValidations.AdminGetInputValidationsBuilder AdminGetInputValidationsOp
        {
            get { return new Operation.AdminGetInputValidations.AdminGetInputValidationsBuilder(_sdk); }
        }
        public AdminUpdateInputValidations.AdminUpdateInputValidationsBuilder AdminUpdateInputValidationsOp
        {
            get { return new Operation.AdminUpdateInputValidations.AdminUpdateInputValidationsBuilder(_sdk); }
        }
        public AdminResetInputValidations.AdminResetInputValidationsBuilder AdminResetInputValidationsOp
        {
            get { return new Operation.AdminResetInputValidations.AdminResetInputValidationsBuilder(_sdk); }
        }
        public PublicGetInputValidations.PublicGetInputValidationsBuilder PublicGetInputValidationsOp
        {
            get { return new Operation.PublicGetInputValidations.PublicGetInputValidationsBuilder(_sdk); }
        }
        public PublicGetInputValidationByField.PublicGetInputValidationByFieldBuilder PublicGetInputValidationByFieldOp
        {
            get { return new Operation.PublicGetInputValidationByField.PublicGetInputValidationByFieldBuilder(_sdk); }
        }
        #endregion
        
        public Model.ModelInputValidationsResponse? AdminGetInputValidations(AdminGetInputValidations input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminUpdateInputValidations(AdminUpdateInputValidations input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminResetInputValidations(AdminResetInputValidations input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelInputValidationsPublicResponse? PublicGetInputValidations(PublicGetInputValidations input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelInputValidationConfigVersion? PublicGetInputValidationByField(PublicGetInputValidationByField input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}
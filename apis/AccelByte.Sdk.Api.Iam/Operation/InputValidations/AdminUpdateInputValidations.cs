// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Net;
using System.Net.Http;
using System.IO;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminUpdateInputValidations
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:CONFIGURATION' [UPDATE]
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to update input validation configuration.
    /// 
    /// 
    /// Supported `field`:
    /// 
    /// 
    /// 
    ///             * displayName
    /// 
    /// 
    ///             * password
    /// 
    /// 
    ///             * username
    /// 
    /// 
    ///             * email
    /// 
    /// 
    /// 
    /// 
    /// If `isCustomRegex` is set to true, `regex` parameter will be used as input validation and the other parameters will be ignored. Otherwise, `regex` parameter will be ignored and regex for input validation will be generated based on the combination of the other parameters.
    /// 
    /// 
    /// 
    /// 
    /// If `allowUnicode` is set to true, unicode regex pattern will be use as the input validation and the other parameters will be ignored.
    /// 
    /// 
    /// Supported `letterCase`:
    /// 
    /// 
    /// 
    ///             * lowercase
    /// 
    /// 
    ///             * uppercase
    /// 
    /// 
    ///             * mixed: uppercase and lowercase
    /// 
    /// 
    ///             * mixed: uppercase and/or lowercase
    /// 
    /// 
    /// flexible special character non words with `allowAllSpecialCharacters`
    /// 
    /// 
    /// 
    /// if `allowAllSpecialCharacters` is set to true `specialCharacters` will forced to empty.
    /// 
    /// 
    /// Supported `specialCharacterLocation`:
    /// 
    /// 
    /// 
    ///             * anywhere
    /// 
    /// 
    ///             * middle
    /// 
    /// 
    /// 
    /// 
    /// If `specialCharacters` is empty, `specialCharacterLocation` and `maxRepeatingSpecialCharacter` will be ignored.
    /// 
    /// 
    /// 
    /// 
    /// `minCharType` is used to identify how many required criteria in the regex. The supported criteria are number, letter, special character, and letter case. If set to 0 or 1 means all criteria are optional. It can be set as much as the number of criteria enabled.
    /// 
    /// 
    /// 
    /// 
    /// If `blockedWord` is set by admin, any input from user which contain kind of blocked word(s) will be blocked for create/upgrade/update account
    /// </summary>
    public class AdminUpdateInputValidations : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateInputValidationsBuilder Builder { get => new AdminUpdateInputValidationsBuilder(); }

        public class AdminUpdateInputValidationsBuilder
            : OperationBuilder<AdminUpdateInputValidationsBuilder>
        {





            internal AdminUpdateInputValidationsBuilder() { }

            internal AdminUpdateInputValidationsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpdateInputValidations Build(
                List<ModelInputValidationUpdatePayload> body
            )
            {
                AdminUpdateInputValidations op = new AdminUpdateInputValidations(this,
                    body
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public void Execute(
                List<ModelInputValidationUpdatePayload> body
            )
            {
                AdminUpdateInputValidations op = Build(
                    body
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private AdminUpdateInputValidations(AdminUpdateInputValidationsBuilder builder,
            List<ModelInputValidationUpdatePayload> body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateInputValidations(
            List<Model.ModelInputValidationUpdatePayload> body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/inputValidations";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
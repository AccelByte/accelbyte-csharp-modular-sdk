// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
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
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminResetInputValidations
    ///
    /// This endpoint is used to reset input validation to the default input validation configurations
    /// </summary>
    public class AdminResetInputValidations : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminResetInputValidationsBuilder Builder { get => new AdminResetInputValidationsBuilder(); }

        public class AdminResetInputValidationsBuilder
            : OperationBuilder<AdminResetInputValidationsBuilder>
        {





            internal AdminResetInputValidationsBuilder() { }

            internal AdminResetInputValidationsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminResetInputValidations Build(
                string field
            )
            {
                AdminResetInputValidations op = new AdminResetInputValidations(this,
                    field
                );

                op.SetBaseFields<AdminResetInputValidationsBuilder>(this);
                return op;
            }

            public void Execute(
                string field
            )
            {
                AdminResetInputValidations op = Build(
                    field
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task ExecuteAsync(
                string field
            )
            {
                AdminResetInputValidations op = Build(
                    field
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private AdminResetInputValidations(AdminResetInputValidationsBuilder builder,
            string field
        )
        {
            PathParams["field"] = field;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminResetInputValidations(
            string field
        )
        {
            PathParams["field"] = field;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/inputValidations/{field}";

        public override HttpMethod Method => HttpMethod.Delete;

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
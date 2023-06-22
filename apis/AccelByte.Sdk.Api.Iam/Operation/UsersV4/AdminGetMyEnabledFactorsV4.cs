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
    /// AdminGetMyEnabledFactorsV4
    ///
    /// 
    /// 
    /// This endpoint is used to get user enabled factors.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint Requires valid user access token
    /// </summary>
    public class AdminGetMyEnabledFactorsV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetMyEnabledFactorsV4Builder Builder { get => new AdminGetMyEnabledFactorsV4Builder(); }

        public class AdminGetMyEnabledFactorsV4Builder
            : OperationBuilder<AdminGetMyEnabledFactorsV4Builder>
        {





            internal AdminGetMyEnabledFactorsV4Builder() { }

            internal AdminGetMyEnabledFactorsV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetMyEnabledFactorsV4 Build(
            )
            {
                AdminGetMyEnabledFactorsV4 op = new AdminGetMyEnabledFactorsV4(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelEnabledFactorsResponseV4? Execute(
            )
            {
                AdminGetMyEnabledFactorsV4 op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private AdminGetMyEnabledFactorsV4(AdminGetMyEnabledFactorsV4Builder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetMyEnabledFactorsV4(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/users/me/mfa/factor";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelEnabledFactorsResponseV4? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelEnabledFactorsResponseV4>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelEnabledFactorsResponseV4>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
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
    /// PublicGetOpenidUserInfoV3
    ///
    /// This API is created to match openid userinfo standard => https://openid.net/specs/openid-connect-core-1_0.html#UserInfo
    /// </summary>
    public class PublicGetOpenidUserInfoV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetOpenidUserInfoV3Builder Builder { get => new PublicGetOpenidUserInfoV3Builder(); }

        public class PublicGetOpenidUserInfoV3Builder
            : OperationBuilder<PublicGetOpenidUserInfoV3Builder>
        {





            internal PublicGetOpenidUserInfoV3Builder() { }

            internal PublicGetOpenidUserInfoV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetOpenidUserInfoV3 Build(
            )
            {
                PublicGetOpenidUserInfoV3 op = new PublicGetOpenidUserInfoV3(this
                );

                op.SetBaseFields<PublicGetOpenidUserInfoV3Builder>(this);
                return op;
            }

            public PublicGetOpenidUserInfoV3.Response Execute(
            )
            {
                PublicGetOpenidUserInfoV3 op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<PublicGetOpenidUserInfoV3.Response> ExecuteAsync(
            )
            {
                PublicGetOpenidUserInfoV3 op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private PublicGetOpenidUserInfoV3(PublicGetOpenidUserInfoV3Builder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelPublicOpenIDUserInfoResponse>
        {

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::Users::PublicGetOpenidUserInfoV3";
        }

        #endregion

        public PublicGetOpenidUserInfoV3(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/users/userinfo";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public PublicGetOpenidUserInfoV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicGetOpenidUserInfoV3.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.ModelPublicOpenIDUserInfoResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
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
    /// PublicVerifyHeadlessAccountV3
    ///
    /// action code : 10124
    /// 
    /// if set NeedVerificationCode = true, IAM will send verification code into email
    /// user can use that verification code to verify user through /iam/v3/public/namespaces/{namespace}/users/me/code/verify
    /// </summary>
    public class PublicVerifyHeadlessAccountV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicVerifyHeadlessAccountV3Builder Builder { get => new PublicVerifyHeadlessAccountV3Builder(); }

        public class PublicVerifyHeadlessAccountV3Builder
            : OperationBuilder<PublicVerifyHeadlessAccountV3Builder>
        {

            public bool? NeedVerificationCode { get; set; }





            internal PublicVerifyHeadlessAccountV3Builder() { }

            internal PublicVerifyHeadlessAccountV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicVerifyHeadlessAccountV3Builder SetNeedVerificationCode(bool _needVerificationCode)
            {
                NeedVerificationCode = _needVerificationCode;
                return this;
            }





            public PublicVerifyHeadlessAccountV3 Build(
                ModelUpgradeHeadlessAccountV3Request body,
                string namespace_
            )
            {
                PublicVerifyHeadlessAccountV3 op = new PublicVerifyHeadlessAccountV3(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<PublicVerifyHeadlessAccountV3Builder>(this);
                return op;
            }

            public PublicVerifyHeadlessAccountV3.Response Execute(
                ModelUpgradeHeadlessAccountV3Request body,
                string namespace_
            )
            {
                PublicVerifyHeadlessAccountV3 op = Build(
                    body,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<PublicVerifyHeadlessAccountV3.Response> ExecuteAsync(
                ModelUpgradeHeadlessAccountV3Request body,
                string namespace_
            )
            {
                PublicVerifyHeadlessAccountV3 op = Build(
                    body,
                    namespace_
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

        private PublicVerifyHeadlessAccountV3(PublicVerifyHeadlessAccountV3Builder builder,
            ModelUpgradeHeadlessAccountV3Request body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.NeedVerificationCode != null) QueryParams["needVerificationCode"] = Convert.ToString(builder.NeedVerificationCode)!;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelUserResponseV3>
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error404 { get; set; } = null;

            public RestErrorResponse? Error409 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::Users::PublicVerifyHeadlessAccountV3";
        }

        #endregion

        public PublicVerifyHeadlessAccountV3(
            string namespace_,
            bool? needVerificationCode,
            Model.ModelUpgradeHeadlessAccountV3Request body
        )
        {
            PathParams["namespace"] = namespace_;

            if (needVerificationCode != null) QueryParams["needVerificationCode"] = Convert.ToString(needVerificationCode)!;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/me/headless/verify";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public PublicVerifyHeadlessAccountV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicVerifyHeadlessAccountV3.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelUserResponseV3>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
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
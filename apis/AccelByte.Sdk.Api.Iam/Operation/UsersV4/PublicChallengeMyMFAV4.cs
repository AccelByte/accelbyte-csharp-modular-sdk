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
    /// PublicChallengeMyMFAV4
    ///
    /// This endpoint will verify user's' MFA code and generate a MFA token for the action.
    /// </summary>
    public class PublicChallengeMyMFAV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicChallengeMyMFAV4Builder Builder { get => new PublicChallengeMyMFAV4Builder(); }

        public class PublicChallengeMyMFAV4Builder
            : OperationBuilder<PublicChallengeMyMFAV4Builder>
        {



            public string? Code { get; set; }

            public string? Factor { get; set; }



            internal PublicChallengeMyMFAV4Builder() { }

            internal PublicChallengeMyMFAV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }




            public PublicChallengeMyMFAV4Builder SetCode(string _code)
            {
                Code = _code;
                return this;
            }

            public PublicChallengeMyMFAV4Builder SetFactor(string _factor)
            {
                Factor = _factor;
                return this;
            }



            public PublicChallengeMyMFAV4 Build(
                string namespace_
            )
            {
                PublicChallengeMyMFAV4 op = new PublicChallengeMyMFAV4(this,
                    namespace_
                );

                op.SetBaseFields<PublicChallengeMyMFAV4Builder>(this);
                return op;
            }

            public PublicChallengeMyMFAV4.Response Execute(
                string namespace_
            )
            {
                PublicChallengeMyMFAV4 op = Build(
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
            public async Task<PublicChallengeMyMFAV4.Response> ExecuteAsync(
                string namespace_
            )
            {
                PublicChallengeMyMFAV4 op = Build(
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

        private PublicChallengeMyMFAV4(PublicChallengeMyMFAV4Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;


            if (builder.Code is not null) FormParams["code"] = builder.Code;
            if (builder.Factor is not null) FormParams["factor"] = builder.Factor;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelUserMFATokenResponseV4>
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public RestErrorResponse? Error404 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::UsersV4::PublicChallengeMyMFAV4";
        }

        #endregion

        public PublicChallengeMyMFAV4(
            string namespace_,
            string? code,
            string? factor
        )
        {
            PathParams["namespace"] = namespace_;


            if (code is not null) FormParams["code"] = code;
            if (factor is not null) FormParams["factor"] = factor;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/public/namespaces/{namespace}/users/me/mfa/challenge/verify";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

        public override List<string> Produces => new() { "application/json" };

        public PublicChallengeMyMFAV4.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicChallengeMyMFAV4.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelUserMFATokenResponseV4>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
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
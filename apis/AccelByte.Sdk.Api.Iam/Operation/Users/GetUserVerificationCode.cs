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
    /// getUserVerificationCode
    ///
    /// **[WARNING] This endpoint is only for testing purpose.**
    /// 
    /// This endpoint get active user verification code.
    /// There are some scenarios of getting verification codes, all of them will be returned on this endpoint:
    /// - After account registration
    /// - After reset password request
    /// - After headless account upgrade
    /// - After update email request
    /// 
    /// This API only accept publisher/studio namespace and userId.
    /// 
    /// Action code: 10146
    /// </summary>
    public class GetUserVerificationCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserVerificationCodeBuilder Builder { get => new GetUserVerificationCodeBuilder(); }

        public class GetUserVerificationCodeBuilder
            : OperationBuilder<GetUserVerificationCodeBuilder>
        {





            internal GetUserVerificationCodeBuilder() { }

            internal GetUserVerificationCodeBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetUserVerificationCode Build(
                string namespace_,
                string userId
            )
            {
                GetUserVerificationCode op = new GetUserVerificationCode(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<GetUserVerificationCodeBuilder>(this);
                return op;
            }

            public Model.ModelVerificationCodeResponse? Execute(
                string namespace_,
                string userId
            )
            {
                GetUserVerificationCode op = Build(
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.ModelVerificationCodeResponse?> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                GetUserVerificationCode op = Build(
                    namespace_,
                    userId
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

        private GetUserVerificationCode(GetUserVerificationCodeBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserVerificationCode(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/codes";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelVerificationCodeResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelVerificationCodeResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelVerificationCodeResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}
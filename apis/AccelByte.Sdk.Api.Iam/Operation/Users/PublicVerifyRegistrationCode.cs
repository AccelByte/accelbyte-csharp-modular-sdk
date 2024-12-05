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
    /// PublicVerifyRegistrationCode
    ///
    /// Verify the registration code
    /// </summary>
    public class PublicVerifyRegistrationCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicVerifyRegistrationCodeBuilder Builder { get => new PublicVerifyRegistrationCodeBuilder(); }

        public class PublicVerifyRegistrationCodeBuilder
            : OperationBuilder<PublicVerifyRegistrationCodeBuilder>
        {





            internal PublicVerifyRegistrationCodeBuilder() { }

            internal PublicVerifyRegistrationCodeBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicVerifyRegistrationCode Build(
                ModelVerifyRegistrationCode body,
                string namespace_
            )
            {
                PublicVerifyRegistrationCode op = new PublicVerifyRegistrationCode(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<PublicVerifyRegistrationCodeBuilder>(this);
                return op;
            }

            public PublicVerifyRegistrationCode.Response Execute(
                ModelVerifyRegistrationCode body,
                string namespace_
            )
            {
                PublicVerifyRegistrationCode op = Build(
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
            public async Task<PublicVerifyRegistrationCode.Response> ExecuteAsync(
                ModelVerifyRegistrationCode body,
                string namespace_
            )
            {
                PublicVerifyRegistrationCode op = Build(
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

        private PublicVerifyRegistrationCode(PublicVerifyRegistrationCodeBuilder builder,
            ModelVerifyRegistrationCode body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public RestErrorResponse? Error400 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::Users::PublicVerifyRegistrationCode";
        }

        #endregion

        public PublicVerifyRegistrationCode(
            string namespace_,
            Model.ModelVerifyRegistrationCode body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/code/verify";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public PublicVerifyRegistrationCode.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicVerifyRegistrationCode.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)

            {
                response.Error400 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }

            return response;
        }
    }

}
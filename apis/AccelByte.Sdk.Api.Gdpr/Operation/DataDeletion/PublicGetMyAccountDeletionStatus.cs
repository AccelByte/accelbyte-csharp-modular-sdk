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

using AccelByte.Sdk.Api.Gdpr.Model;

namespace AccelByte.Sdk.Api.Gdpr.Operation
{
    /// <summary>
    /// PublicGetMyAccountDeletionStatus
    ///
    /// Retrieve my account deletion status
    /// Requires valid user access token
    /// </summary>
    public class PublicGetMyAccountDeletionStatus : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetMyAccountDeletionStatusBuilder Builder { get => new PublicGetMyAccountDeletionStatusBuilder(); }

        public class PublicGetMyAccountDeletionStatusBuilder
            : OperationBuilder<PublicGetMyAccountDeletionStatusBuilder>
        {





            internal PublicGetMyAccountDeletionStatusBuilder() { }

            internal PublicGetMyAccountDeletionStatusBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetMyAccountDeletionStatus Build(
            )
            {
                PublicGetMyAccountDeletionStatus op = new PublicGetMyAccountDeletionStatus(this
                );

                op.SetBaseFields<PublicGetMyAccountDeletionStatusBuilder>(this);
                return op;
            }

            public PublicGetMyAccountDeletionStatus.Response Execute(
            )
            {
                PublicGetMyAccountDeletionStatus op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<PublicGetMyAccountDeletionStatus.Response> ExecuteAsync(
            )
            {
                PublicGetMyAccountDeletionStatus op = Build(
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

        private PublicGetMyAccountDeletionStatus(PublicGetMyAccountDeletionStatusBuilder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsDeletionStatus>
        {

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Gdpr::DataDeletion::PublicGetMyAccountDeletionStatus";
        }

        #endregion

        public PublicGetMyAccountDeletionStatus(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/public/users/me/deletions/status";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public PublicGetMyAccountDeletionStatus.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicGetMyAccountDeletionStatus.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsDeletionStatus>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
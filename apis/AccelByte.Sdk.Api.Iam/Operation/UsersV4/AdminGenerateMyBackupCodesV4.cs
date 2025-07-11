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
    /// AdminGenerateMyBackupCodesV4
    ///
    /// This endpoint is used to generate 8-digits backup codes.
    /// Each code is a one-time code and will be deleted once used.
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class AdminGenerateMyBackupCodesV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGenerateMyBackupCodesV4Builder Builder { get => new AdminGenerateMyBackupCodesV4Builder(); }

        public class AdminGenerateMyBackupCodesV4Builder
            : OperationBuilder<AdminGenerateMyBackupCodesV4Builder>
        {





            internal AdminGenerateMyBackupCodesV4Builder() { }

            internal AdminGenerateMyBackupCodesV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGenerateMyBackupCodesV4 Build(
            )
            {
                AdminGenerateMyBackupCodesV4 op = new AdminGenerateMyBackupCodesV4(this
                );

                op.SetBaseFields<AdminGenerateMyBackupCodesV4Builder>(this);
                return op;
            }

            [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
            public AdminGenerateMyBackupCodesV4.Response Execute(
            )
            {
                AdminGenerateMyBackupCodesV4 op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<AdminGenerateMyBackupCodesV4.Response> ExecuteAsync(
            )
            {
                AdminGenerateMyBackupCodesV4 op = Build(
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

        private AdminGenerateMyBackupCodesV4(AdminGenerateMyBackupCodesV4Builder builder
        )
        {
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelBackupCodesResponseV4>
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public RestErrorResponse? Error404 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::UsersV4::AdminGenerateMyBackupCodesV4";
        }

        #endregion

        public AdminGenerateMyBackupCodesV4(
        )
        {
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/users/me/mfa/backupCode";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminGenerateMyBackupCodesV4.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminGenerateMyBackupCodesV4.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelBackupCodesResponseV4>(payload, ResponseJsonOptions);
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
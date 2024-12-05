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
    /// GetUserPlatformAccounts
    ///
    /// ## The endpoint is going to be deprecated
    /// ### Endpoint migration guide
    /// - **Substitute endpoint: _/iam/v3/public/namespaces/{namespace}/users/{userId}/platforms [GET]_**
    /// - **Substitute endpoint: _/iam/v3/admin/namespaces/{namespace}/users/{userId}/platforms [GET]_**
    /// 
    /// ## Justice Platform Account
    /// The permission âADMIN:NAMESPACE:{namespace}:JUSTICE:USER:{userId}â [READ] is required in order to read the UserID who linked with the user.
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class GetUserPlatformAccounts : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserPlatformAccountsBuilder Builder { get => new GetUserPlatformAccountsBuilder(); }

        public class GetUserPlatformAccountsBuilder
            : OperationBuilder<GetUserPlatformAccountsBuilder>
        {





            internal GetUserPlatformAccountsBuilder() { }

            internal GetUserPlatformAccountsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetUserPlatformAccounts Build(
                string namespace_,
                string userId
            )
            {
                GetUserPlatformAccounts op = new GetUserPlatformAccounts(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<GetUserPlatformAccountsBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public GetUserPlatformAccounts.Response Execute(
                string namespace_,
                string userId
            )
            {
                GetUserPlatformAccounts op = Build(
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
            public async Task<GetUserPlatformAccounts.Response> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                GetUserPlatformAccounts op = Build(
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

        private GetUserPlatformAccounts(GetUserPlatformAccountsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<List<Model.AccountcommonUserLinkedPlatform>>
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::Users::GetUserPlatformAccounts";
        }

        #endregion

        public GetUserPlatformAccounts(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/platforms";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public GetUserPlatformAccounts.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetUserPlatformAccounts.Response()
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
                response.Data = JsonSerializer.Deserialize<List<Model.AccountcommonUserLinkedPlatform>>(payload, ResponseJsonOptions);
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

            return response;
        }
    }

}
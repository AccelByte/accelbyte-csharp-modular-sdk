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
    /// AdminDeleteUserLinkingHistoryByPlatformIDV3
    ///
    /// This API is for admin to delete user's linking history with target platform id.
    /// 
    /// **Supported Platforms:**
    /// - Steam group (steamnetwork):
    /// - steam
    /// - steamopenid
    /// - PSN group (psn):
    /// - ps4web
    /// - ps4
    /// - ps5
    /// - XBOX group(xbox):
    /// - live
    /// - xblweb
    /// - Oculus group (oculusgroup):
    /// - oculus
    /// - oculusweb
    /// - Google group (google):
    /// - google
    /// - googleplaygames:
    /// - epicgames
    /// - facebook
    /// - twitch
    /// - discord
    /// - android
    /// - ios
    /// - apple
    /// - device
    /// - nintendo
    /// - awscognito
    /// - amazon
    /// - netflix
    /// - snapchat
    /// - _oidc platform id_
    /// 
    /// Note:
    /// - You can use either platform id or platform group as **platformId** parameter.
    /// - **Nintendo platform user id**: NSA ID need to be appended with Environment ID using colon as separator. e.g kmzwa8awaa:dd1
    /// 
    /// ----
    /// **Substitute endpoint**: /v3/admin/namespaces/{namespace}/users/{userId}/platforms/{platformId}/link/restrictions
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class AdminDeleteUserLinkingHistoryByPlatformIDV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteUserLinkingHistoryByPlatformIDV3Builder Builder { get => new AdminDeleteUserLinkingHistoryByPlatformIDV3Builder(); }

        public class AdminDeleteUserLinkingHistoryByPlatformIDV3Builder
            : OperationBuilder<AdminDeleteUserLinkingHistoryByPlatformIDV3Builder>
        {





            internal AdminDeleteUserLinkingHistoryByPlatformIDV3Builder() { }

            internal AdminDeleteUserLinkingHistoryByPlatformIDV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeleteUserLinkingHistoryByPlatformIDV3 Build(
                string namespace_,
                string platformId,
                string userId
            )
            {
                AdminDeleteUserLinkingHistoryByPlatformIDV3 op = new AdminDeleteUserLinkingHistoryByPlatformIDV3(this,
                    namespace_,
                    platformId,
                    userId
                );

                op.SetBaseFields<AdminDeleteUserLinkingHistoryByPlatformIDV3Builder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public AdminDeleteUserLinkingHistoryByPlatformIDV3.Response Execute(
                string namespace_,
                string platformId,
                string userId
            )
            {
                AdminDeleteUserLinkingHistoryByPlatformIDV3 op = Build(
                    namespace_,
                    platformId,
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
            public async Task<AdminDeleteUserLinkingHistoryByPlatformIDV3.Response> ExecuteAsync(
                string namespace_,
                string platformId,
                string userId
            )
            {
                AdminDeleteUserLinkingHistoryByPlatformIDV3 op = Build(
                    namespace_,
                    platformId,
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

        private AdminDeleteUserLinkingHistoryByPlatformIDV3(AdminDeleteUserLinkingHistoryByPlatformIDV3Builder builder,
            string namespace_,
            string platformId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public RestErrorResponse? Error404 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::Users::AdminDeleteUserLinkingHistoryByPlatformIDV3";
        }

        #endregion

        public AdminDeleteUserLinkingHistoryByPlatformIDV3(
            string namespace_,
            string platformId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/platforms/{platformId}/link/histories";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public AdminDeleteUserLinkingHistoryByPlatformIDV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminDeleteUserLinkingHistoryByPlatformIDV3.Response()
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
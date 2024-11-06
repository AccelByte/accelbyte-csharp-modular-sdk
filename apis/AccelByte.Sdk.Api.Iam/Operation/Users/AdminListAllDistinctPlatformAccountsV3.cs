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
    /// AdminListAllDistinctPlatformAccountsV3
    ///
    /// This endpoint only retrieves 3rd party platform accounts linked to user.
    /// It will query platform accounts and result will be distinct & grouped, same platform we will pick oldest linked one.
    /// ------
    /// Supported status:
    /// - LINKED
    /// - RESTRICTIVELY_UNLINKED
    /// - UNLINKED
    /// - ALL
    /// </summary>
    public class AdminListAllDistinctPlatformAccountsV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListAllDistinctPlatformAccountsV3Builder Builder { get => new AdminListAllDistinctPlatformAccountsV3Builder(); }

        public class AdminListAllDistinctPlatformAccountsV3Builder
            : OperationBuilder<AdminListAllDistinctPlatformAccountsV3Builder>
        {

            public string? Status { get; set; }





            internal AdminListAllDistinctPlatformAccountsV3Builder() { }

            internal AdminListAllDistinctPlatformAccountsV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminListAllDistinctPlatformAccountsV3Builder SetStatus(string _status)
            {
                Status = _status;
                return this;
            }





            public AdminListAllDistinctPlatformAccountsV3 Build(
                string namespace_,
                string userId
            )
            {
                AdminListAllDistinctPlatformAccountsV3 op = new AdminListAllDistinctPlatformAccountsV3(this,
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<AdminListAllDistinctPlatformAccountsV3Builder>(this);
                return op;
            }

            public AdminListAllDistinctPlatformAccountsV3.Response Execute(
                string namespace_,
                string userId
            )
            {
                AdminListAllDistinctPlatformAccountsV3 op = Build(
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
            public async Task<AdminListAllDistinctPlatformAccountsV3.Response> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                AdminListAllDistinctPlatformAccountsV3 op = Build(
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

        private AdminListAllDistinctPlatformAccountsV3(AdminListAllDistinctPlatformAccountsV3Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.Status is not null) QueryParams["status"] = builder.Status;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.AccountcommonDistinctPlatformResponseV3>
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public RestErrorResponse? Error404 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::Users::AdminListAllDistinctPlatformAccountsV3";
        }

        #endregion

        public AdminListAllDistinctPlatformAccountsV3(
            string namespace_,            
            string userId,            
            string? status            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (status is not null) QueryParams["status"] = status;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/platforms/distinct";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminListAllDistinctPlatformAccountsV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminListAllDistinctPlatformAccountsV3.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.AccountcommonDistinctPlatformResponseV3>(payload, ResponseJsonOptions);
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
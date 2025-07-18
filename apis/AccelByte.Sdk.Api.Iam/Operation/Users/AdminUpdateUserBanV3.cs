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
    /// AdminUpdateUserBanV3
    ///
    /// Set ban status for a single user for a specific ban. Retrieve
    /// user ban and choose the ban ID. Set the form parameter to true/false to enable
    /// or disable the ban.
    /// action code : 10142'
    /// </summary>
    public class AdminUpdateUserBanV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateUserBanV3Builder Builder { get => new AdminUpdateUserBanV3Builder(); }

        public class AdminUpdateUserBanV3Builder
            : OperationBuilder<AdminUpdateUserBanV3Builder>
        {





            internal AdminUpdateUserBanV3Builder() { }

            internal AdminUpdateUserBanV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpdateUserBanV3 Build(
                ModelBanUpdateRequest body,
                string banId,
                string namespace_,
                string userId
            )
            {
                AdminUpdateUserBanV3 op = new AdminUpdateUserBanV3(this,
                    body,                    
                    banId,                    
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<AdminUpdateUserBanV3Builder>(this);
                return op;
            }

            public AdminUpdateUserBanV3.Response Execute(
                ModelBanUpdateRequest body,
                string banId,
                string namespace_,
                string userId
            )
            {
                AdminUpdateUserBanV3 op = Build(
                    body,
                    banId,
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
            public async Task<AdminUpdateUserBanV3.Response> ExecuteAsync(
                ModelBanUpdateRequest body,
                string banId,
                string namespace_,
                string userId
            )
            {
                AdminUpdateUserBanV3 op = Build(
                    body,
                    banId,
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

        private AdminUpdateUserBanV3(AdminUpdateUserBanV3Builder builder,
            ModelBanUpdateRequest body,
            string banId,
            string namespace_,
            string userId
        )
        {
            PathParams["banId"] = banId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelUserBanResponseV3>
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public RestErrorResponse? Error404 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::Users::AdminUpdateUserBanV3";
        }

        #endregion

        public AdminUpdateUserBanV3(
            string banId,            
            string namespace_,            
            string userId,            
            Model.ModelBanUpdateRequest body            
        )
        {
            PathParams["banId"] = banId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/bans/{banId}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminUpdateUserBanV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminUpdateUserBanV3.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelUserBanResponseV3>(payload, ResponseJsonOptions);
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
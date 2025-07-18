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
    /// AdminCreateTestUsersV4
    ///
    /// Create test users and not send verification code email.
    /// Note:
    /// - count : Enter the number of test users you want to create in the count field. The maximum value of the user count is 100.
    /// - userInfo(optional) :
    /// - country: you can specify country for the test user. Country use ISO3166-1 alpha-2 two letter, e.g. US
    /// </summary>
    public class AdminCreateTestUsersV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCreateTestUsersV4Builder Builder { get => new AdminCreateTestUsersV4Builder(); }

        public class AdminCreateTestUsersV4Builder
            : OperationBuilder<AdminCreateTestUsersV4Builder>
        {





            internal AdminCreateTestUsersV4Builder() { }

            internal AdminCreateTestUsersV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminCreateTestUsersV4 Build(
                AccountCreateTestUsersRequestV4 body,
                string namespace_
            )
            {
                AdminCreateTestUsersV4 op = new AdminCreateTestUsersV4(this,
                    body,                    
                    namespace_                    
                );

                op.SetBaseFields<AdminCreateTestUsersV4Builder>(this);
                return op;
            }

            public AdminCreateTestUsersV4.Response Execute(
                AccountCreateTestUsersRequestV4 body,
                string namespace_
            )
            {
                AdminCreateTestUsersV4 op = Build(
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
            public async Task<AdminCreateTestUsersV4.Response> ExecuteAsync(
                AccountCreateTestUsersRequestV4 body,
                string namespace_
            )
            {
                AdminCreateTestUsersV4 op = Build(
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

        private AdminCreateTestUsersV4(AdminCreateTestUsersV4Builder builder,
            AccountCreateTestUsersRequestV4 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.AccountCreateTestUsersResponseV4>
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;

            public RestErrorResponse? Error501 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::UsersV4::AdminCreateTestUsersV4";
        }

        #endregion

        public AdminCreateTestUsersV4(
            string namespace_,            
            Model.AccountCreateTestUsersRequestV4 body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/namespaces/{namespace}/test_users";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminCreateTestUsersV4.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminCreateTestUsersV4.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.AccountCreateTestUsersResponseV4>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)501)
            {
                response.Error501 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error501!.TranslateToApiError();
            }

            return response;
        }
    }

}
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
    /// AdminGetDevicesByUserV4
    ///
    /// This is the endpoint for an admin to get devices a user ever used to login
    /// </summary>
    public class AdminGetDevicesByUserV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetDevicesByUserV4Builder Builder { get => new AdminGetDevicesByUserV4Builder(); }

        public class AdminGetDevicesByUserV4Builder
            : OperationBuilder<AdminGetDevicesByUserV4Builder>
        {

            public string? UserId { get; set; }





            internal AdminGetDevicesByUserV4Builder() { }

            internal AdminGetDevicesByUserV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminGetDevicesByUserV4Builder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }





            public AdminGetDevicesByUserV4 Build(
                string namespace_
            )
            {
                AdminGetDevicesByUserV4 op = new AdminGetDevicesByUserV4(this,
                    namespace_                    
                );

                op.SetBaseFields<AdminGetDevicesByUserV4Builder>(this);
                return op;
            }

            public AdminGetDevicesByUserV4.Response Execute(
                string namespace_
            )
            {
                AdminGetDevicesByUserV4 op = Build(
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
            public async Task<AdminGetDevicesByUserV4.Response> ExecuteAsync(
                string namespace_
            )
            {
                AdminGetDevicesByUserV4 op = Build(
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

        private AdminGetDevicesByUserV4(AdminGetDevicesByUserV4Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.UserId is not null) QueryParams["userId"] = builder.UserId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelDevicesResponseV4>
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public RestErrorResponse? Error404 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::DevicesV4::AdminGetDevicesByUserV4";
        }

        #endregion

        public AdminGetDevicesByUserV4(
            string namespace_,            
            string? userId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (userId is not null) QueryParams["userId"] = userId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/namespaces/{namespace}/devices";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminGetDevicesByUserV4.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminGetDevicesByUserV4.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelDevicesResponseV4>(payload, ResponseJsonOptions);
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
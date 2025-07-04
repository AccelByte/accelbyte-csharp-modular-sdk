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
    /// AdminAddCountryBlacklistV3
    ///
    /// Admin update country blacklist
    /// </summary>
    public class AdminAddCountryBlacklistV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminAddCountryBlacklistV3Builder Builder { get => new AdminAddCountryBlacklistV3Builder(); }

        public class AdminAddCountryBlacklistV3Builder
            : OperationBuilder<AdminAddCountryBlacklistV3Builder>
        {





            internal AdminAddCountryBlacklistV3Builder() { }

            internal AdminAddCountryBlacklistV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminAddCountryBlacklistV3 Build(
                ModelCountryBlacklistRequest body,
                string namespace_
            )
            {
                AdminAddCountryBlacklistV3 op = new AdminAddCountryBlacklistV3(this,
                    body,                    
                    namespace_                    
                );

                op.SetBaseFields<AdminAddCountryBlacklistV3Builder>(this);
                return op;
            }

            public AdminAddCountryBlacklistV3.Response Execute(
                ModelCountryBlacklistRequest body,
                string namespace_
            )
            {
                AdminAddCountryBlacklistV3 op = Build(
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
            public async Task<AdminAddCountryBlacklistV3.Response> ExecuteAsync(
                ModelCountryBlacklistRequest body,
                string namespace_
            )
            {
                AdminAddCountryBlacklistV3 op = Build(
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

        private AdminAddCountryBlacklistV3(AdminAddCountryBlacklistV3Builder builder,
            ModelCountryBlacklistRequest body,
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

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::Country::AdminAddCountryBlacklistV3";
        }

        #endregion

        public AdminAddCountryBlacklistV3(
            string namespace_,            
            Model.ModelCountryBlacklistRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/countries/blacklist";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminAddCountryBlacklistV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminAddCountryBlacklistV3.Response()
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
            else if (code == (HttpStatusCode)500)
            
            {
                response.Error500 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}
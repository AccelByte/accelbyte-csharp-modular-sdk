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
    /// PublicGetMyProfileAllowUpdateStatusV3
    ///
    /// This API is for user to get self profile update allow status.
    /// Note: If the config is not found, this API will return a config with unlimited.
    /// </summary>
    public class PublicGetMyProfileAllowUpdateStatusV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetMyProfileAllowUpdateStatusV3Builder Builder { get => new PublicGetMyProfileAllowUpdateStatusV3Builder(); }

        public class PublicGetMyProfileAllowUpdateStatusV3Builder
            : OperationBuilder<PublicGetMyProfileAllowUpdateStatusV3Builder>
        {





            internal PublicGetMyProfileAllowUpdateStatusV3Builder() { }

            internal PublicGetMyProfileAllowUpdateStatusV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetMyProfileAllowUpdateStatusV3 Build(
            )
            {
                PublicGetMyProfileAllowUpdateStatusV3 op = new PublicGetMyProfileAllowUpdateStatusV3(this
                );

                op.SetBaseFields<PublicGetMyProfileAllowUpdateStatusV3Builder>(this);
                return op;
            }

            public PublicGetMyProfileAllowUpdateStatusV3.Response Execute(
            )
            {
                PublicGetMyProfileAllowUpdateStatusV3 op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<PublicGetMyProfileAllowUpdateStatusV3.Response> ExecuteAsync(
            )
            {
                PublicGetMyProfileAllowUpdateStatusV3 op = Build(
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

        private PublicGetMyProfileAllowUpdateStatusV3(PublicGetMyProfileAllowUpdateStatusV3Builder builder
        )
        {
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelUserProfileUpdateAllowStatus>
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::Users::PublicGetMyProfileAllowUpdateStatusV3";
        }

        #endregion

        public PublicGetMyProfileAllowUpdateStatusV3(
        )
        {
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/users/me/profileStatus";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicGetMyProfileAllowUpdateStatusV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicGetMyProfileAllowUpdateStatusV3.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelUserProfileUpdateAllowStatus>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}